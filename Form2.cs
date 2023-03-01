using DevExpress.Spreadsheet;     // this is for using the workbook class
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace IBMS_GUI
{

    public partial class Form2 : Form
    {
        private Workbook _workbook;
        private readonly SynchronizationContext _context;

        // Battery data
        private string BattID = String.Empty;
        private string ChgGate = String.Empty;
        private string DsgGate = String.Empty;
        private string Cell1Volt = String.Empty;
        private string Cell2Volt = String.Empty;
        private string Cell3Volt = String.Empty;
        private string Cell4Volt = String.Empty;
        private string DsgCurrent = String.Empty;
        private string ChgCurrent = String.Empty;
        private string BattVolt = String.Empty;
        private string BatteryTemp = String.Empty;
        private string FETT = String.Empty;
        private string MCUT = String.Empty;
        private string Fault = String.Empty;
        private string BattBalance = String.Empty;
        private string FirmwareVersion = String.Empty;
        private string UARTFault = String.Empty;
        private string IDSGCal = String.Empty;
        private string ICHGCal = String.Empty;
        private string WDResets = String.Empty;
        private string Spare4 = String.Empty;
        private string Spare5 = String.Empty;
        private string Spare6 = String.Empty;
        private string Spare7 = String.Empty;
        private string Spare8 = String.Empty;
        private string DataStatus = String.Empty;
        private string ICalibrationStatus = String.Empty;
        private string ICHGCalError = String.Empty;
        private string IDSGCalError = String.Empty;

        // faults flags
        private bool OV_Flag = false;
        private bool UV_Flag = false;
        private bool OCD_Flag = false;

        //button flags status
        private bool DebugButtonSetected = false;
        private bool ProductionButtonSetected = true;
        private bool CalibrationButtonSetected = false;

        // Over Voltage and Under Voltage threshold
        private float OV_Threshold = 3.9f;
        private float UV_Threshold = 2f;
        private float UV_Hys = 2.4f;
        private float OV_Hys = 3.7f;

        //FET and Battery thermistor Beta
        private float FET_BETA = 3435f;
        private float BATT_BETA = 3950f;

        //BMS Faults states
        private int NORMAL_STATE = 1;
        private int UART_FAULT_STATE = 2;
        private int APP_FAULT_STATE = 3;

        private int CurrentState = 1;
        private int NextState = 1;

        private int DataLengthwithSpares = 54;
        private int CalibrationDataLength = 12;
        private int seconds = 0;
        private int DataCounter = -1;

        private DateTime previousDateTime = DateTime.Now;
        private DateTime currentDateTime = DateTime.Now;



        public Form2()
        {
            InitializeComponent();
            _context = SynchronizationContext.Current;
            this.FormClosing += Form2_FormClosing;
            this.buttonCalibration.Enabled = false;
            this.buttonDebug.Enabled = false;
            this.buttonProduction.Enabled = false;

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Is Recording Data off? Please stop recording to save all data to excel", "NLX NOCO",
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            this.comboBox1.Items.AddRange(ports);
            ClearForm();
        }

        private void ClearForm()
        {
            this.labelBattID.Text = String.Empty;
            this.labelCell1V.Text = String.Empty;
            this.labelCell2V.Text = String.Empty;
            this.labelCell3V.Text = String.Empty;
            this.labelCell4V.Text = String.Empty;
            this.labelCHGCurrent.Text = String.Empty;
            this.labelDSGCurrent.Text = String.Empty;
            this.labelBattV.Text = String.Empty;
            this.labelbattT.Text = String.Empty;
            this.labelFETT.Text = String.Empty;
            this.labelMCUT.Text = String.Empty;
            this.labelBMSfault.Text = String.Empty;
            this.labelSpare1.Text = String.Empty;
            this.labelSpare2.Text = String.Empty;
            this.labelSpare3.Text = String.Empty;
            this.labelSpare4.Text = String.Empty;
            this.labelSpare5.Text = String.Empty;
            this.labelSpare6.Text = String.Empty;
            this.labelSpare7.Text = String.Empty;
            this.labelSpare8.Text = String.Empty;
            this.labelDataStatus.Text = String.Empty;
            this.labelBattV.Text = String.Empty;
            this.labelFVersion.Text = String.Empty;
            

            this.toggleSwitchDSG.IsOn = false;
            this.toggleSwitchCHG.IsOn = false;
            this.toggleSwitchBal.IsOn = false;
            this.toggleSwitchDSG.ReadOnly = true;
            this.toggleSwitchCHG.ReadOnly = true;
            this.toggleSwitchBal.ReadOnly = true;
            this.toggleSwitchDSG.ForeColor = Color.Black;
            this.toggleSwitchCHG.ForeColor = Color.Black;
            this.toggleSwitchBal.ForeColor = Color.Black;

            this.checkEditUV.ReadOnly = true;
            this.checkEditOV.ReadOnly = true;
            this.checkEditUTB.ReadOnly = true;
            this.checkEditOTB.ReadOnly = true;
            this.checkEditOTF.ReadOnly = true;
            this.checkEditOTP.ReadOnly = true;
            this.checkEditOCD1_SC.ReadOnly = true;
            this.checkEditCalibration.ReadOnly = true;

            this.checkEditUV.ForeColor = Color.Black;
            this.checkEditOV.ForeColor = Color.Black;
            this.checkEditUTB.ForeColor = Color.Black;
            this.checkEditOTB.ForeColor = Color.Black;
            this.checkEditOTF.ForeColor = Color.Black;
            this.checkEditOTP.ForeColor = Color.Black;
            this.checkEditOCD1_SC.ForeColor = Color.Black;

            this.checkEditUV.Checked = false;
            this.checkEditOV.Checked = false;
            this.checkEditUTB.Checked = false;
            this.checkEditOTB.Checked = false;
            this.checkEditOTF.Checked = false;
            this.checkEditOTP.Checked = false;
            this.checkEditOCD1_SC.Checked = false;
            this.checkEditCalibration.Checked = false;


        }

        private void ClearFaults()
        {

            this.checkEditUV.Checked = false;
            this.checkEditOV.Checked = false;
            this.checkEditUTB.Checked = false;
            this.checkEditOTB.Checked = false;
            this.checkEditOTF.Checked = false;
            this.checkEditOTP.Checked = false;
            this.checkEditOCD1_SC.Checked = false;

            this.checkEditUV.ForeColor = Color.Black;
            this.checkEditOV.ForeColor = Color.Black;
            this.checkEditUTB.ForeColor = Color.Black;
            this.checkEditOTB.ForeColor = Color.Black;
            this.checkEditOTF.ForeColor = Color.Black;
            this.checkEditOTP.ForeColor = Color.Black;
            this.checkEditOCD1_SC.ForeColor = Color.Black;
        }

        private void ClearCalibrationStatus()
        {
            this.checkEditCalibration.Checked = false;
            this.checkEditCalibration.Text = "Not Calibrated";
        }

        private async void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.serialPort1.IsOpen)
                {
                    this.serialPort1.PortName = this.comboBox1.Text;
                    this.serialPort1.DataReceived += SerialPort1_DataReceived;
                    this.serialPort1.Open();
                    this.buttonConnect.Text = "Connected";

                    this.buttonDebug.Enabled = true;
                    this.buttonProduction.Enabled = true;
                }

                DataRXLightIndicator();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            this.serialPort1.Write("D");
            this.buttonCalibration.Enabled = true;
            this.DebugButtonSetected = true;
            this.ProductionButtonSetected = false;
            this.CalibrationButtonSetected = false;
        }

        private void buttonProduction_Click(object sender, EventArgs e)
        {
            this.serialPort1.Write("P");
            this.buttonCalibration.Enabled = false;
            this.DebugButtonSetected = false;
            this.ProductionButtonSetected = true;
            this.CalibrationButtonSetected = false;
            ClearForm();
        }

        private void buttonCalibration_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("This action is going to calibrate the Battery, please make sure there is not a load or charger connected to the battery. Are you ready?", "NLX NOCO",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.serialPort1.Write("C");
                this.DebugButtonSetected = false;
                this.ProductionButtonSetected = false;
                this.CalibrationButtonSetected = true;
                ClearForm();
            }
            
        }
        
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (this.serialPort1.IsOpen)
            {
                this.serialPort1.Close();
                ClearForm();
                this.buttonConnect.Text = "Connect";
                this.buttonCalibration.Enabled = false;
                this.buttonProduction.Enabled = false;
                this.buttonDebug.Enabled = false;
            }
        }
        
        private int[] ValidateRXData(List<int> data, int DataLength)
        {
            int headerIndex = 0;
            var bufferLength = 0;
            int[] dataCompleted = new int[DataLength];

            if (data.Contains(0x55))                                    // checks if the list contains the first 0x55 byte of the header
            {
                headerIndex = data.IndexOf(0x55);                       // finds the index of the first byte of the header

                if (headerIndex != -1 && data.Count > headerIndex + 2 && data[headerIndex + 1] == 0x55)
                {
                    bufferLength = data[headerIndex + 2];                //gets the length of the buffer from the firmware. Variable length is allow for spare data
                }
            }
            if (bufferLength != 0)
            {
                //checks for the header and terminator
                if (data[headerIndex] == 0x55 && data[headerIndex + 1] == 0x55 && data[bufferLength - 1] == 0xff && data[bufferLength - 2] == 0xff)
                {

                    //private DateTime previousDateTime = DateTime.Now;
                    if (DataLength - bufferLength > 0)
                    {
                        for (int i = bufferLength - 2; i < DataLength; i++)
                        {
                            data.Insert(i, 0);
                        }
                    } 

                    Array.ConstrainedCopy(data.ToArray(), headerIndex, dataCompleted, 0, bufferLength);

                    DataStatus = "Data Received";
                }
                else
                {
                    DataStatus = "Package Error";
                }
            }
            return dataCompleted;
        }
        
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
         {
            var data = new List<int>();                                         // to use array need to know the lenght. For variable length use a list
            var caldata = new List<int>();

            int[] dataCompleted = new int[DataLengthwithSpares];

            if (DebugButtonSetected)
            {
                while (serialPort1.BytesToRead > 0)                                   // waits here if there are bytes to read
                {
                    data.Add(this.serialPort1.ReadByte());

                    //Debug.WriteLine(data[counter]+ " Fecha:" + DateTime.Now.ToString());
                    //counter++;
                }

                dataCompleted = ValidateRXData(data, DataLengthwithSpares);
                if (DataStatus == "Data Received")                                  //need to add another validation for datacompleted 
                {
                    GetBatteryData(dataCompleted);
                }
                setBMSFaults(UARTFault);
                _context.Post(UpdateBatteryStatus(), null);
            }

            if (CalibrationButtonSetected)
            {
                while (serialPort1.BytesToRead > 0)                                   // waits here if there are bytes to read
                {
                    caldata.Add(this.serialPort1.ReadByte());
                }
                dataCompleted = ValidateRXData(caldata, CalibrationDataLength);

                if (DataStatus == "Data Received")                                  //need to add another validation for datacompleted 
                {
                    GetCalibrationData(dataCompleted);
                    
                    if (ICalibrationStatus == "1")
                    {
                        XtraMessageBox.Show("Battery Calibrated");
                    }
                    else if (ICalibrationStatus == "2")
                    {
                        XtraMessageBox.Show("ERROR during calibration. Fail to calibrate the battery with ICharge = "+ ICHGCalError+ "A, and IDischarge = " + IDSGCalError + "A");
                    }

                }
            }    
         }
        private int ConvertBytesDataRxToInt(int dataMSB, int dataLSB)
        {
            var MSB = Convert.ToInt16(dataMSB) << 8;
            var LSB = Convert.ToInt16(dataLSB);

            var number = (Int16)(MSB + LSB);
            if (number == -9999)
            {
                return -9999;                          //invalid value, indicates an error
            }

            return number;                             
        }
        private float ConvertBytesDataRxToFloat(int dataMSB, int dataLSB, double decNumbers)
        {
            var MSB = Convert.ToInt16(dataMSB) << 8;
            var LSB = Convert.ToInt16(dataLSB);

            var number = (Int16)(MSB + LSB);
            if (number == -9999)
            {
                return -9999;                          //invalid value, indicates an error
            }

            return (float)(number * decNumbers);       //need to cast to Int16 for showing the negative numbers;
        }
        private float ConvertNTCVoltageToTemp(float NTCVolt, float NTCBeta)
        {
            var BAT_NTC_PULLUP = 5100f;
            var BAT_NTC_REF_RES = 10000f;
            var VCC = 3.3f;
            var BAT_NTC_REF_TEMP = 298.15f;
            var NTCresistance = (BAT_NTC_PULLUP * NTCVolt) / (VCC - NTCVolt);                                           // Convert thermistor voltage to resistance
            var temperature = 1 / ((Math.Log(NTCresistance / BAT_NTC_REF_RES) * (1 / NTCBeta)) + (1 / BAT_NTC_REF_TEMP));   // Calculate temperature using thermistor equation
            return (float)(temperature - 273.15f);                                                                              // Convert degrees Kelvin to Celcius
        }

        private float ConvertMCU_NTCVoltToTemp(float NTCVolt)
        {
            return (float)((NTCVolt - 0.986f) / 0.00355f);
        }
        private int GetBufferLength(int[] DataRX,int index)
        {
            int lenght = 0;
            
            if (DataRX.Length > index +1)
            {
                lenght = (int)ConvertBytesDataRxToInt(DataRX[index + 1], DataRX[index]);
            }
            return lenght;
        }

        private void GetCalibrationData(int[] DataRX)
        {
            ICalibrationStatus = ConvertBytesDataRxToInt(DataRX[5], DataRX[4]).ToString();
            ICHGCalError = ConvertBytesDataRxToFloat(DataRX[7], DataRX[6], 0.01).ToString();
            IDSGCalError = ConvertBytesDataRxToFloat(DataRX[9], DataRX[8], 0.01).ToString();

        }
        private void GetBatteryData(int[] DataRX)
        {
            float battTemp, FETtemp, MCUtemp = 0;
           

            FirmwareVersion = ConvertBytesDataRxToInt(DataRX[5], DataRX[4]).ToString();

            BattID = GetBatteryID(ConvertBytesDataRxToInt(DataRX[7], DataRX[6]).ToString());
            DsgGate = ConvertBytesDataRxToInt(DataRX[9], DataRX[8]).ToString();
            ChgGate = ConvertBytesDataRxToInt(DataRX[11], DataRX[10]).ToString();
            BattBalance = ConvertBytesDataRxToInt(DataRX[13], DataRX[12]).ToString();
            UARTFault = ConvertBytesDataRxToInt(DataRX[15], DataRX[14]).ToString();

            DsgCurrent = ConvertBytesDataRxToFloat(DataRX[17], DataRX[16], 1).ToString();
            ChgCurrent = ConvertBytesDataRxToFloat(DataRX[19], DataRX[18], 0.1).ToString();

            Cell1Volt = ConvertBytesDataRxToFloat(DataRX[21], DataRX[20], 0.001).ToString();
            Cell2Volt = ConvertBytesDataRxToFloat(DataRX[23], DataRX[22], 0.001).ToString();
            Cell3Volt = ConvertBytesDataRxToFloat(DataRX[25], DataRX[24], 0.001).ToString();
            Cell4Volt = ConvertBytesDataRxToFloat(DataRX[27], DataRX[26], 0.001).ToString();
            BattVolt = ConvertBytesDataRxToFloat(DataRX[29], DataRX[28], 0.01).ToString();

            battTemp = ConvertBytesDataRxToFloat(DataRX[31], DataRX[30], 0.001); 
            if (battTemp != -9999)
                battTemp = ConvertNTCVoltageToTemp(battTemp, BATT_BETA);
            BatteryTemp = Math.Round(battTemp, 1).ToString();

            FETtemp = ConvertBytesDataRxToFloat(DataRX[33], DataRX[32], 0.001);

            if (FETtemp != -9999)
                FETtemp = ConvertNTCVoltageToTemp(FETtemp, FET_BETA);
            FETT = Math.Round(FETtemp, 1).ToString();

            MCUtemp = ConvertBytesDataRxToFloat(DataRX[35], DataRX[34], 0.001);
            if (MCUtemp != -9999)
                MCUtemp = ConvertMCU_NTCVoltToTemp(MCUtemp);
            MCUT = Math.Round(MCUtemp, 1).ToString();



            IDSGCal = ConvertBytesDataRxToFloat(DataRX[37], DataRX[36], 0.01).ToString();
            ICHGCal = ConvertBytesDataRxToFloat(DataRX[39], DataRX[38], 0.01).ToString();

            ICalibrationStatus = ConvertBytesDataRxToInt(DataRX[41], DataRX[40]).ToString();

            WDResets = ConvertBytesDataRxToInt(DataRX[43], DataRX[42]).ToString();
            Spare4 = ConvertBytesDataRxToInt(DataRX[45], DataRX[44]).ToString();
            Spare5 = ConvertBytesDataRxToInt(DataRX[47], DataRX[46]).ToString();
            Spare6 = ConvertBytesDataRxToInt(DataRX[49], DataRX[48]).ToString();
            Spare7 = ConvertBytesDataRxToInt(DataRX[51], DataRX[50]).ToString();
            Spare8 = ConvertBytesDataRxToInt(DataRX[53], DataRX[52]).ToString();

            if (_workbook != null)    
                UpdateExcel();

        }


        private void CreateExcel()
        {
            Worksheet ws;
            if (_workbook == null)                      //if workbook is null create a new workbook and add the format 
            {
                _workbook = new Workbook();

                ws = _workbook.Worksheets[0];           //access to the first worksheet 
                ws.Name = "Battery Info";               //name of worksheet

                //format of worksheet
                ws.Columns["A"].Width = 450;
                ws.Columns["B"].Width = 450;
                ws.Columns["C"].Width = 450;
                ws.Columns["D"].Width = 450;
                ws.Columns["E"].Width = 450;
                ws.Columns["F"].Width = 450;
                ws.Columns["G"].Width = 450;
                ws.Columns["H"].Width = 450;
                ws.Columns["I"].Width = 450;
                ws.Columns["J"].Width = 450;
                ws.Columns["K"].Width = 450;
                ws.Columns["L"].Width = 450;

                
                //name of columns 
                ws["A1"].Value = "Date Received";
                ws["B1"].Value = "Relative Time";
                ws["C1"].Value = "Battery Voltage";
                ws["D1"].Value = "Cell 1 Voltage";
                ws["E1"].Value = "Cell 2 Voltage";
                ws["F1"].Value = "Cell 3 Voltage";
                ws["G1"].Value = "Cell 4 Voltage";
                ws["H1"].Value = "Battery Temperature";
                ws["I1"].Value = "FET Temperature";
                ws["J1"].Value = "MCU Temperature";
                ws["K1"].Value = "Charge Current";
                ws["L1"].Value = "Discharge Current";

            }
        }

        private void UpdateExcel()
        {
            DataCounter++;
            Worksheet ws;
            currentDateTime = DateTime.Now;
            
            // when you apply multiple modifications to a document enclose the code in the BeginUpdate - EndUpdate() to improve performance
            _workbook.BeginUpdate();

            // try…finally statement to ensure that EndUpdate() is always called even if an exception occurs.
            try
            {
                ws = _workbook.Worksheets[0];
                CellRange datarange = ws.GetDataRange();
                int rowindex = datarange.RowCount + 1;

                ws["A" + rowindex].Value = DateTime.Now;
                ws["A" + rowindex].NumberFormat = "m/d/yyyy h:mm:ss";

                // calculates the relative time by getting the difference in seconds between the current DateTime and the previous one, and multiply it by sample counter

                ws["B" + rowindex].Value = (int)currentDateTime.Subtract(previousDateTime).TotalSeconds*DataCounter;
                ws["C" + rowindex].Value = Convert.ToDouble(BattVolt);
                ws["D" + rowindex].Value = Convert.ToDouble(Cell1Volt);
                ws["E" + rowindex].Value = Convert.ToDouble(Cell2Volt);
                ws["F" + rowindex].Value = Convert.ToDouble(Cell3Volt);
                ws["G" + rowindex].Value = Convert.ToDouble(Cell4Volt);
                ws["H" + rowindex].Value = Convert.ToDouble(BatteryTemp);
                ws["I" + rowindex].Value = Convert.ToDouble(FETT);
                ws["J" + rowindex].Value = Convert.ToDouble(MCUT);
                ws["K" + rowindex].Value = Convert.ToDouble(ChgCurrent);
                ws["L" + rowindex].Value = Convert.ToDouble(DsgCurrent);

                previousDateTime = currentDateTime;
            }
            finally
            {
                _workbook.EndUpdate();
            }
        }
        private SendOrPostCallback UpdateBatteryStatus()
        {
            return status =>
            {
                this.labelBattID.Text = BattID;
                this.labelCell1V.Text = Cell1Volt;
                this.labelCell2V.Text = Cell2Volt;
                this.labelCell3V.Text = Cell3Volt;
                this.labelCell4V.Text = Cell4Volt;
                this.labelDSGCurrent.Text = DsgCurrent;
                this.labelCHGCurrent.Text = ChgCurrent;
                this.labelBattV.Text = BattVolt;
                this.labelbattT.Text = BatteryTemp;
                this.labelFETT.Text = FETT;
                this.labelMCUT.Text = MCUT;
                this.labelBMSfault.Text = Fault;
                this.labelFVersion.Text = "NLX NOCO V" + FirmwareVersion;
                this.labelSpare1.Text = IDSGCal;
                this.labelSpare2.Text = ICHGCal;
                this.labelSpare3.Text = WDResets;
                this.labelSpare4.Text = Spare4;
                this.labelSpare5.Text = Spare5;
                this.labelSpare6.Text = Spare6;
                this.labelSpare7.Text = Spare7;
                this.labelSpare8.Text = Spare8;
                

                UpdateGateStatus(this.DsgGate, this.toggleSwitchDSG);
                UpdateGateStatus(this.ChgGate, this.toggleSwitchCHG);
                UpdateBalanceStatus(this.BattBalance, this.toggleSwitchBal);
                UpdateFaultStatus();
                DataRXLightIndicator();
                UpdateCurrentCalibrationStatus();
            };
        }

        private void DataRXLightIndicator()
        {
            timer1.Start();
            this.labelDataStatus.Text = DataStatus;
            
            if (DataStatus == "Data Received")
            {
                pictureBox1.Image = Image.FromFile("green.png");
                this.labelDataStatus.ForeColor = Color.Green;
            }

            else if (DataStatus == "Package Error")
            {
                pictureBox1.Image = Image.FromFile("red.png");
                this.labelDataStatus.ForeColor = Color.Red;
            }
            else if (DataStatus == "Waiting Status")
            {
                pictureBox1.Image = Image.FromFile("yellow.png");
                this.labelDataStatus.ForeColor = Color.Black;
            }

        }
        private string GetBatteryID(string batteryID)
        {
            var ID = "";
            switch (batteryID)
            {
                case "0":
                    ID = "NLX 31";
                    break;
                case "1":
                    ID = "NLX 27";
                    break;
                case "2":
                    ID = "NLX 24";
                    break;
                case "3":
                    ID = "NLX U1";
                    break;

                default:
                    break;
            }
            return ID;
        }

        private bool UART_BMSFaultPresent(string bmsFault)
        {
            
            var fault = !(String.IsNullOrEmpty(bmsFault)) ? Convert.ToInt32(bmsFault) : 0;
            bool faultPresent = false;

            if (fault > 0 && fault < 8)
                faultPresent = true;

            return faultPresent;
        }
        private string UART_BMSFault(string bmsFault)
        {
            string UART_FAULT = "";

            switch (bmsFault)
            {
                case "0":
                    UART_FAULT = "NONE";
                    break;
                case "1":
                    UART_FAULT = "OTB";
                    break;
                case "2":
                    UART_FAULT = "OTF";
                    break;
                case "3":
                    UART_FAULT = "OTP";
                    break;
                case "4":
                    UART_FAULT = "UTB";
                    break;
                case "5":
                    UART_FAULT = "OCD2";
                    break;
                case "6":
                    UART_FAULT = "OCD3";
                    break;
                case "7":
                    UART_FAULT = "OCD4";
                    break;

                default:
                    break;
            }

            return UART_FAULT;
        }
        private bool UV_OV_OCD_BMSFaultPresent()
        {
            bool faultPresent = false;
            if (OV_Flag || UV_Flag || OCD_Flag)
                faultPresent = true;

            return faultPresent;
        }
        private string APP_UV_OV_OCD_BMSFault()
        {
            string APP_Fault = "";

            if (DsgGate == "1" && ChgGate == "0" && Fault != "UTB")
                APP_Fault = OV_Fault();
            else
                OV_Flag = false;

            if (DsgGate == "0" && ChgGate == "1")
                APP_Fault = UV_Fault();
            else
                UV_Flag = false;

            if (ChgGate == "0" && DsgGate == "0" && Fault == "NONE")
                APP_Fault = OCD_SC_Fault();
            else
                OCD_Flag = false;

            return APP_Fault;
        }

        private void setBMSFaults(string UART_fault)
        {
            switch (CurrentState)
            {
                case 1:
                    Fault = "NONE";

                    if (UART_BMSFaultPresent(UART_fault))
                        NextState = UART_FAULT_STATE;

                    else if (!UART_BMSFaultPresent(UART_fault) && (DsgGate == "0" || ChgGate == "0"))
                        NextState = APP_FAULT_STATE;

                    break;

                case 2:

                    Fault = UART_BMSFault(UART_fault);

                    if (!UART_BMSFaultPresent(UART_fault))
                        NextState = NORMAL_STATE;
                    else
                        NextState = UART_FAULT_STATE;
                    break;

                case 3:

                    Fault = APP_UV_OV_OCD_BMSFault();

                    if (!UV_OV_OCD_BMSFaultPresent())
                        NextState = NORMAL_STATE;
                    else
                        NextState = APP_FAULT_STATE;
                    break;
                // Default case -----------------------------------------------------------------------
                default:
                    NextState = NORMAL_STATE;
                    break;
            }
            CurrentState = NextState;           // update the state
        }
        private void UpdateGateStatus(string gate, ToggleSwitch name)
        {
            if (gate == "1")
            {
                name.IsOn = true;
                name.ForeColor = Color.Green;
            }
            if (gate == "0")
            {
                name.IsOn = false;
                name.ForeColor = Color.Red;
            }
        }

        private void UpdateBalanceStatus(string balance, ToggleSwitch name)
        {
            if (balance == "2")
            {
                name.IsOn = true;
                name.ForeColor = Color.Green;
            }
            if (balance == "1")
            {
                name.IsOn = false;
                name.ForeColor = Color.Red;
            }
        }

        private void UpdateCurrentCalibrationStatus()
        {
            if (this.ICalibrationStatus == "1")
            {
                this.checkEditCalibration.Checked = true;
            }
            else
                ClearCalibrationStatus();
        }
        private string OV_Fault()
        {
            var cell1 = Convert.ToDouble(this.Cell1Volt);
            var cell2 = Convert.ToDouble(this.Cell2Volt);
            var cell3 = Convert.ToDouble(this.Cell3Volt);
            var cell4 = Convert.ToDouble(this.Cell4Volt);

            string OV_Fault = "";

            if (cell1 > OV_Threshold || cell2 > OV_Threshold || cell3 > OV_Threshold || cell4 > OV_Threshold)
            {
                OV_Flag = true;
                OV_Fault = "OV";
            }

            if (OV_Flag && (cell1 > OV_Hys || cell2 > OV_Hys || cell3 > OV_Hys || cell4 > OV_Hys))
            {

                OV_Fault = "OV";
            }
            return OV_Fault;
        }

        private string UV_Fault()
        {
            //Debug.WriteLine(UV_Flag + " Fecha:"+ DateTime.Now.ToString());
            var cell1 = Convert.ToDouble(this.Cell1Volt);
            var cell2 = Convert.ToDouble(this.Cell2Volt);
            var cell3 = Convert.ToDouble(this.Cell3Volt);
            var cell4 = Convert.ToDouble(this.Cell4Volt);

            string UV_Fault = "";

            if (cell1 < UV_Threshold || cell2 < UV_Threshold || cell3 < UV_Threshold || cell4 < UV_Threshold)
            {
                UV_Fault = "UV";
                UV_Flag = true;
            }

            if (UV_Flag && (cell1 < UV_Hys || cell2 < UV_Hys || cell3 < UV_Hys || cell4 < UV_Hys))
            {
                UV_Fault = "UV";
            }
            return UV_Fault;
        }

        private string OCD_SC_Fault()
        {

            string OCD_Fault = "OCD_SC";
            OCD_Flag = true;

            return OCD_Fault;
        }

        private void UpdateFaultStatus()
        {
            ClearFaults();
            switch (this.Fault)
            {
                case "UV":
                    this.checkEditUV.Checked = true;
                    this.checkEditUV.ForeColor = Color.Red;
                    break;
                case "OV":
                    this.checkEditOV.Checked = true;
                    this.checkEditOV.ForeColor = Color.Red;
                    break;
                case "UTB":
                    this.checkEditUTB.Checked = true;
                    this.checkEditUTB.ForeColor = Color.Red;
                    break;
                case "OTB":
                    this.checkEditOTB.Checked = true;
                    this.checkEditOTB.ForeColor = Color.Red;
                    break;
                case "OTF":
                    this.checkEditOTF.Checked = true;
                    this.checkEditOTF.ForeColor = Color.Red;
                    break;
                case "OTP":
                    this.checkEditOTP.Checked = true;
                    this.checkEditOTP.ForeColor = Color.Red;
                    break;
                case "OCD_SC":
                    this.checkEditOCD1_SC.Checked = true;
                    this.checkEditOCD1_SC.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        private void BMSfault_TextChanged(object sender, EventArgs e)
        {
            if (this.labelBMSfault.Text == "NONE")
                this.labelBMSfault.ForeColor = Color.Black;
            else
                this.labelBMSfault.ForeColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 3)
            {
                seconds = 0;
                timer1.Stop();
                pictureBox1.Image = Image.FromFile("yellow.png");
                this.labelDataStatus.ForeColor = Color.Black;
                DataStatus = "Waiting for Data";
                this.labelDataStatus.Text = DataStatus;
                
            }
        }
       
        private void ToggleSwitchRecord_Toggled(object sender, EventArgs e)
        {
           if (toggleSwitchRecord.IsOn)
           {
               CreateExcel();
               label12.Text = "Recording";
           }
           else
           {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (_workbook != null)
                        _workbook.SaveDocument(saveFileDialog1.FileName, DocumentFormat.Xlsx);
                }
                
               label12.Text = "Record Data";
           }
        }

        
    }
}
