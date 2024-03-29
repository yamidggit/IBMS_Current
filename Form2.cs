﻿using DevExpress.XtraEditors;
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
        private string Spare1 = String.Empty;
        private string Spare2 = String.Empty;
        private string Spare3 = String.Empty;
        private string Spare4 = String.Empty;
        private string Spare5 = String.Empty;
        private string Spare6 = String.Empty;
        private string Spare7 = String.Empty;
        private string Spare8 = String.Empty;
        private string DataStatus = String.Empty;

        // faults flags
        private bool OV_Flag = false;
        private bool UV_Flag = false;
        private bool OCD_Flag = false;


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

        private int DataLengthwithSpares = 52;
        int seconds = 0;


        public Form2()
        {
            InitializeComponent();
            _context = SynchronizationContext.Current;

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
            this.checkEditOCD2.ReadOnly = true;
            this.checkEditOCD1_SC.ReadOnly = true;

            this.checkEditUV.ForeColor = Color.Black;
            this.checkEditOV.ForeColor = Color.Black;
            this.checkEditUTB.ForeColor = Color.Black;
            this.checkEditOTB.ForeColor = Color.Black;
            this.checkEditOTF.ForeColor = Color.Black;
            this.checkEditOTP.ForeColor = Color.Black;
            this.checkEditOCD2.ForeColor = Color.Black;
            this.checkEditOCD1_SC.ForeColor = Color.Black;

            this.checkEditUV.Checked = false;
            this.checkEditOV.Checked = false;
            this.checkEditUTB.Checked = false;
            this.checkEditOTB.Checked = false;
            this.checkEditOTF.Checked = false;
            this.checkEditOTP.Checked = false;
            this.checkEditOCD2.Checked = false;
            this.checkEditOCD1_SC.Checked = false;

            
        }

        private void ClearFaults()
        {

            this.checkEditUV.Checked = false;
            this.checkEditOV.Checked = false;
            this.checkEditUTB.Checked = false;
            this.checkEditOTB.Checked = false;
            this.checkEditOTF.Checked = false;
            this.checkEditOTP.Checked = false;
            this.checkEditOCD2.Checked = false;
            this.checkEditOCD1_SC.Checked = false;

            this.checkEditUV.ForeColor = Color.Black;
            this.checkEditOV.ForeColor = Color.Black;
            this.checkEditUTB.ForeColor = Color.Black;
            this.checkEditOTB.ForeColor = Color.Black;
            this.checkEditOTF.ForeColor = Color.Black;
            this.checkEditOTP.ForeColor = Color.Black;
            this.checkEditOCD2.ForeColor = Color.Black;
            this.checkEditOCD1_SC.ForeColor = Color.Black;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.serialPort1.IsOpen)
                {
                    this.serialPort1.PortName = this.comboBox1.Text;
                    this.serialPort1.DataReceived += SerialPort1_DataReceived;
                    this.serialPort1.Open();
                }
                
                DataRXLightIndicator();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
         {
            var data = new List<int>();                                         // to use array need to know the lenght. For variable length use a list

            //var counter = 0;
            int headerIndex = 0;
            var bufferLength = 0;


            while (serialPort1.BytesToRead > 0)                                   // waits here if there are bytes to read
            {
                data.Add(this.serialPort1.ReadByte());

                //Debug.WriteLine(data[counter]+ " Fecha:" + DateTime.Now.ToString());
                //counter++;
            }
                                                                        // buffer= 0x55,0x55, dataLength,...data...,0xff,0xff  
            if (data.Contains(0x55))                                    // checks if the list contains the first 0x55 byte of the header
            {
                headerIndex = data.IndexOf(0x55);                       // finds the index of the first byte of the header

                if (headerIndex != -1 && data.Count > headerIndex + 2 && data[headerIndex + 1] == 0x55 )
                {
                   bufferLength = data[headerIndex + 2];                //gets the length of the buffer from the firmware. Variable length is allow for spare data
                }
            }
            if (bufferLength != 0)
            {
                //checks for the header and terminator
                if (data[headerIndex] == 0x55 && data[headerIndex + 1] == 0x55 && data[bufferLength - 1] == 0xff && data[bufferLength - 2] == 0xff)
                {
                    if (DataLengthwithSpares - bufferLength > 0)
                    {
                        for (int i = bufferLength - 2; i < DataLengthwithSpares; i++)
                        {
                            data.Insert(i, 0);
                        }
                        int[] dataCompletedWithSpare = new int[DataLengthwithSpares];
                        Array.ConstrainedCopy(data.ToArray(), headerIndex, dataCompletedWithSpare, 0, DataLengthwithSpares);
                        GetBatteryData(dataCompletedWithSpare);
                    }
                    else
                    {
                        int[] dataCompleted = new int[bufferLength];
                        Array.ConstrainedCopy(data.ToArray(), headerIndex, dataCompleted, 0, bufferLength);
                        GetBatteryData(dataCompleted);
                    }

                    DataStatus = "Data Received";

                }
                else 
                {
                    DataStatus = "Package Error";
                }
            }

             setBMSFaults(UARTFault);
             _context.Post(UpdateBatteryStatus(), null);
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
            ChgCurrent = ConvertBytesDataRxToFloat(DataRX[19], DataRX[18], 1).ToString();

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

            

            Spare1 = ConvertBytesDataRxToInt(DataRX[37], DataRX[36]).ToString();
            Spare2 = ConvertBytesDataRxToInt(DataRX[39], DataRX[38]).ToString();
            Spare3 = ConvertBytesDataRxToInt(DataRX[41], DataRX[40]).ToString();
            Spare4 = ConvertBytesDataRxToInt(DataRX[43], DataRX[42]).ToString();
            Spare5 = ConvertBytesDataRxToInt(DataRX[45], DataRX[44]).ToString();
            Spare6 = ConvertBytesDataRxToInt(DataRX[47], DataRX[46]).ToString();
            Spare7 = ConvertBytesDataRxToInt(DataRX[49], DataRX[48]).ToString();
            Spare8 = ConvertBytesDataRxToInt(DataRX[51], DataRX[50]).ToString();
            
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
                this.FVersion.Text = "NLX NOCO V" + FirmwareVersion;
                this.labelSpare1.Text = Spare1;
                this.labelSpare2.Text = Spare2;
                this.labelSpare3.Text = Spare3;
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

            if (fault > 0 && fault < 6)
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
                case "OCD2":
                    this.checkEditOCD2.Checked = true;
                    this.checkEditOCD2.ForeColor = Color.Red;
                    break;
                case "OCD_SC":
                    this.checkEditOCD1_SC.Checked = true;
                    this.checkEditOCD1_SC.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.serialPort1.IsOpen)
            {
                this.serialPort1.Close();
                ClearForm();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
