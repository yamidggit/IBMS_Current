
using System;

namespace IBMS_GUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.toggleSwitchDSG = new DevExpress.XtraEditors.ToggleSwitch();
            this.label25 = new System.Windows.Forms.Label();
            this.toggleSwitchCHG = new DevExpress.XtraEditors.ToggleSwitch();
            this.panel4 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label27 = new System.Windows.Forms.Label();
            this.labelBMSfault = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkEditOTP = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditOCD1_SC = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditUTB = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditOTF = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditOTB = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditOV = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditUV = new DevExpress.XtraEditors.CheckEdit();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.toggleSwitchBal = new DevExpress.XtraEditors.ToggleSwitch();
            this.label30 = new System.Windows.Forms.Label();
            this.labelDataStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label31 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCell4V = new System.Windows.Forms.Label();
            this.labelCell3V = new System.Windows.Forms.Label();
            this.labelCell2V = new System.Windows.Forms.Label();
            this.labelCell1V = new System.Windows.Forms.Label();
            this.labelBattV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.labelbattT = new System.Windows.Forms.Label();
            this.labelFETT = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.labelMCUT = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.labelCHGCurrent = new System.Windows.Forms.Label();
            this.labelDSGCurrent = new System.Windows.Forms.Label();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.labelSpare1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelSpare6 = new System.Windows.Forms.Label();
            this.labelSpare5 = new System.Windows.Forms.Label();
            this.labelSpare4 = new System.Windows.Forms.Label();
            this.labelSpare3 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.labelSpare7 = new System.Windows.Forms.Label();
            this.labelSpare8 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.labelSpare2 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.labelBattID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toggleSwitchRecord = new DevExpress.XtraEditors.ToggleSwitch();
            this.label12 = new System.Windows.Forms.Label();
            this.labelFVersion = new System.Windows.Forms.Label();
            this.buttonDebug = new System.Windows.Forms.Button();
            this.buttonProduction = new System.Windows.Forms.Button();
            this.buttonCalibration = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkEditCalibration = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchDSG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchCHG.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOTP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOCD1_SC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditUTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOTF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditUV.Properties)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchBal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchRecord.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCalibration.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ports:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.SystemColors.Control;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonConnect.Location = new System.Drawing.Point(350, 31);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(154, 38);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonDisconnect.Location = new System.Drawing.Point(514, 29);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(86, 39);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Stop";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "BMS Gate Status";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(11, 80);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(137, 24);
            this.label26.TabIndex = 2;
            this.label26.Text = "Discharge FET";
            // 
            // toggleSwitchDSG
            // 
            this.toggleSwitchDSG.EditValue = null;
            this.toggleSwitchDSG.Location = new System.Drawing.Point(181, 73);
            this.toggleSwitchDSG.Margin = new System.Windows.Forms.Padding(4);
            this.toggleSwitchDSG.Name = "toggleSwitchDSG";
            this.toggleSwitchDSG.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitchDSG.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchDSG.Properties.AppearanceDisabled.Options.UseImage = true;
            this.toggleSwitchDSG.Properties.AutoHeight = false;
            this.toggleSwitchDSG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.toggleSwitchDSG.Properties.OffText = "OFF";
            this.toggleSwitchDSG.Properties.OnText = "ON";
            this.toggleSwitchDSG.Size = new System.Drawing.Size(144, 41);
            this.toggleSwitchDSG.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(12, 43);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(114, 24);
            this.label25.TabIndex = 1;
            this.label25.Text = "Charge FET";
            // 
            // toggleSwitchCHG
            // 
            this.toggleSwitchCHG.Location = new System.Drawing.Point(180, 36);
            this.toggleSwitchCHG.Margin = new System.Windows.Forms.Padding(4);
            this.toggleSwitchCHG.Name = "toggleSwitchCHG";
            this.toggleSwitchCHG.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitchCHG.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchCHG.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.toggleSwitchCHG.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.toggleSwitchCHG.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.toggleSwitchCHG.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.toggleSwitchCHG.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.toggleSwitchCHG.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.toggleSwitchCHG.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.toggleSwitchCHG.Properties.AutoHeight = false;
            this.toggleSwitchCHG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.toggleSwitchCHG.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.toggleSwitchCHG.Properties.OffText = "OFF";
            this.toggleSwitchCHG.Properties.OnText = "ON";
            this.toggleSwitchCHG.Size = new System.Drawing.Size(144, 38);
            this.toggleSwitchCHG.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.toggleSwitchDSG);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.toggleSwitchCHG);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(534, 117);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 1, 6, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 122);
            this.panel4.TabIndex = 17;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label27.Location = new System.Drawing.Point(10, 7);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(155, 25);
            this.label27.TabIndex = 21;
            this.label27.Text = "BMS Fault State";
            // 
            // labelBMSfault
            // 
            this.labelBMSfault.AutoSize = true;
            this.labelBMSfault.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMSfault.Location = new System.Drawing.Point(238, 6);
            this.labelBMSfault.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBMSfault.Name = "labelBMSfault";
            this.labelBMSfault.Size = new System.Drawing.Size(66, 24);
            this.labelBMSfault.TabIndex = 22;
            this.labelBMSfault.Text = "NONE";
            this.labelBMSfault.TextChanged += new System.EventHandler(this.BMSfault_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.checkEditOTP);
            this.panel5.Controls.Add(this.checkEditOCD1_SC);
            this.panel5.Controls.Add(this.checkEditUTB);
            this.panel5.Controls.Add(this.checkEditOTF);
            this.panel5.Controls.Add(this.checkEditOTB);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.checkEditOV);
            this.panel5.Controls.Add(this.labelBMSfault);
            this.panel5.Controls.Add(this.checkEditUV);
            this.panel5.Location = new System.Drawing.Point(534, 253);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(348, 146);
            this.panel5.TabIndex = 18;
            // 
            // checkEditOTP
            // 
            this.checkEditOTP.Location = new System.Drawing.Point(14, 72);
            this.checkEditOTP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkEditOTP.Name = "checkEditOTP";
            this.checkEditOTP.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditOTP.Properties.Appearance.Options.UseFont = true;
            this.checkEditOTP.Properties.Caption = "OTP";
            this.checkEditOTP.Size = new System.Drawing.Size(78, 28);
            this.checkEditOTP.TabIndex = 30;
            // 
            // checkEditOCD1_SC
            // 
            this.checkEditOCD1_SC.Location = new System.Drawing.Point(14, 102);
            this.checkEditOCD1_SC.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkEditOCD1_SC.Name = "checkEditOCD1_SC";
            this.checkEditOCD1_SC.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditOCD1_SC.Properties.Appearance.Options.UseFont = true;
            this.checkEditOCD1_SC.Properties.Caption = "OCD1/SC";
            this.checkEditOCD1_SC.Size = new System.Drawing.Size(118, 28);
            this.checkEditOCD1_SC.TabIndex = 29;
            // 
            // checkEditUTB
            // 
            this.checkEditUTB.Location = new System.Drawing.Point(242, 42);
            this.checkEditUTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkEditUTB.Name = "checkEditUTB";
            this.checkEditUTB.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditUTB.Properties.Appearance.Options.UseFont = true;
            this.checkEditUTB.Properties.Caption = "UTB";
            this.checkEditUTB.Size = new System.Drawing.Size(78, 28);
            this.checkEditUTB.TabIndex = 27;
            // 
            // checkEditOTF
            // 
            this.checkEditOTF.Location = new System.Drawing.Point(242, 72);
            this.checkEditOTF.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkEditOTF.Name = "checkEditOTF";
            this.checkEditOTF.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditOTF.Properties.Appearance.Options.UseFont = true;
            this.checkEditOTF.Properties.Caption = "OTF";
            this.checkEditOTF.Size = new System.Drawing.Size(78, 28);
            this.checkEditOTF.TabIndex = 26;
            // 
            // checkEditOTB
            // 
            this.checkEditOTB.Location = new System.Drawing.Point(142, 72);
            this.checkEditOTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkEditOTB.Name = "checkEditOTB";
            this.checkEditOTB.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditOTB.Properties.Appearance.Options.UseFont = true;
            this.checkEditOTB.Properties.Caption = "OTB";
            this.checkEditOTB.Size = new System.Drawing.Size(78, 28);
            this.checkEditOTB.TabIndex = 25;
            // 
            // checkEditOV
            // 
            this.checkEditOV.Location = new System.Drawing.Point(142, 42);
            this.checkEditOV.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkEditOV.Name = "checkEditOV";
            this.checkEditOV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditOV.Properties.Appearance.Options.UseFont = true;
            this.checkEditOV.Properties.Caption = "OV";
            this.checkEditOV.Size = new System.Drawing.Size(70, 28);
            this.checkEditOV.TabIndex = 24;
            // 
            // checkEditUV
            // 
            this.checkEditUV.Location = new System.Drawing.Point(14, 42);
            this.checkEditUV.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkEditUV.Name = "checkEditUV";
            this.checkEditUV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditUV.Properties.Appearance.Options.UseFont = true;
            this.checkEditUV.Properties.Caption = "UV";
            this.checkEditUV.Size = new System.Drawing.Size(68, 28);
            this.checkEditUV.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label28);
            this.panel6.Controls.Add(this.toggleSwitchBal);
            this.panel6.Controls.Add(this.label30);
            this.panel6.Location = new System.Drawing.Point(534, 417);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(348, 85);
            this.panel6.TabIndex = 19;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(12, 40);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(139, 24);
            this.label28.TabIndex = 23;
            this.label28.Text = "Battery Balance";
            // 
            // toggleSwitchBal
            // 
            this.toggleSwitchBal.EditValue = null;
            this.toggleSwitchBal.Location = new System.Drawing.Point(180, 42);
            this.toggleSwitchBal.Margin = new System.Windows.Forms.Padding(4);
            this.toggleSwitchBal.Name = "toggleSwitchBal";
            this.toggleSwitchBal.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitchBal.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchBal.Properties.AutoHeight = false;
            this.toggleSwitchBal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.toggleSwitchBal.Properties.OffText = "OFF";
            this.toggleSwitchBal.Properties.OnText = "ON";
            this.toggleSwitchBal.Size = new System.Drawing.Size(144, 32);
            this.toggleSwitchBal.TabIndex = 22;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label30.Location = new System.Drawing.Point(4, 7);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(208, 25);
            this.label30.TabIndex = 0;
            this.label30.Text = "BMS Balancing Status";
            // 
            // labelDataStatus
            // 
            this.labelDataStatus.AutoSize = true;
            this.labelDataStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelDataStatus.Location = new System.Drawing.Point(646, 33);
            this.labelDataStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataStatus.Name = "labelDataStatus";
            this.labelDataStatus.Size = new System.Drawing.Size(132, 25);
            this.labelDataStatus.TabIndex = 21;
            this.labelDataStatus.Text = "Data Updated";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(812, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label31.Location = new System.Drawing.Point(539, 643);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(170, 25);
            this.label31.TabIndex = 22;
            this.label31.Text = "Firmware Version:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.67517F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.26926F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.05557F));
            this.tableLayoutPanel1.Controls.Add(this.labelCell4V, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelCell3V, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCell2V, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCell1V, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelBattV, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 312);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // labelCell4V
            // 
            this.labelCell4V.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCell4V.AutoSize = true;
            this.labelCell4V.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCell4V.Location = new System.Drawing.Point(240, 271);
            this.labelCell4V.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCell4V.Name = "labelCell4V";
            this.labelCell4V.Size = new System.Drawing.Size(64, 25);
            this.labelCell4V.TabIndex = 53;
            this.labelCell4V.Text = "label6";
            // 
            // labelCell3V
            // 
            this.labelCell3V.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCell3V.AutoSize = true;
            this.labelCell3V.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCell3V.Location = new System.Drawing.Point(240, 217);
            this.labelCell3V.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCell3V.Name = "labelCell3V";
            this.labelCell3V.Size = new System.Drawing.Size(64, 25);
            this.labelCell3V.TabIndex = 52;
            this.labelCell3V.Text = "label5";
            // 
            // labelCell2V
            // 
            this.labelCell2V.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCell2V.AutoSize = true;
            this.labelCell2V.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCell2V.Location = new System.Drawing.Point(240, 166);
            this.labelCell2V.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCell2V.Name = "labelCell2V";
            this.labelCell2V.Size = new System.Drawing.Size(64, 25);
            this.labelCell2V.TabIndex = 52;
            this.labelCell2V.Text = "label4";
            // 
            // labelCell1V
            // 
            this.labelCell1V.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCell1V.AutoSize = true;
            this.labelCell1V.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCell1V.Location = new System.Drawing.Point(240, 115);
            this.labelCell1V.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCell1V.Name = "labelCell1V";
            this.labelCell1V.Size = new System.Drawing.Size(64, 25);
            this.labelCell1V.TabIndex = 51;
            this.labelCell1V.Text = "label3";
            // 
            // labelBattV
            // 
            this.labelBattV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBattV.AutoSize = true;
            this.labelBattV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBattV.Location = new System.Drawing.Point(240, 64);
            this.labelBattV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBattV.Name = "labelBattV";
            this.labelBattV.Size = new System.Drawing.Size(64, 25);
            this.labelBattV.TabIndex = 51;
            this.labelBattV.Text = "label2";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Units";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Value";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Battery Voltage";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cell 1 Voltage";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cell 2 Voltage";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cell 3 Voltage";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 271);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cell 4 Voltage";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(342, 65);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 24);
            this.label15.TabIndex = 24;
            this.label15.Text = "Volts";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(342, 116);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 24);
            this.label17.TabIndex = 26;
            this.label17.Text = "Volts";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(342, 167);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 24);
            this.label18.TabIndex = 27;
            this.label18.Text = "Volts";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(342, 218);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 24);
            this.label19.TabIndex = 28;
            this.label19.Text = "Volts";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(342, 271);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 24);
            this.label20.TabIndex = 29;
            this.label20.Text = "Volts";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parameter";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(0, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Battery ID";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.Header.BorderColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControl1.AppearancePage.Header.ForeColor = System.Drawing.Color.MidnightBlue;
            this.xtraTabControl1.AppearancePage.Header.Options.UseBorderColor = true;
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.Header.Options.UseForeColor = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(33, 186);
            this.xtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(473, 433);
            this.xtraTabControl1.TabIndex = 44;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Options.UseImage = true;
            this.xtraTabPage1.Appearance.HeaderActive.Options.UseBackColor = true;
            this.xtraTabPage1.Appearance.HeaderDisabled.Options.UseBackColor = true;
            this.xtraTabPage1.Appearance.HeaderHotTracked.Options.UseBackColor = true;
            this.xtraTabPage1.Controls.Add(this.tableLayoutPanel1);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(471, 394);
            this.xtraTabPage1.Text = "Voltage";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.tableLayoutPanel2);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(471, 394);
            this.xtraTabPage2.Text = "Temperature";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.67517F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.26926F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.05557F));
            this.tableLayoutPanel2.Controls.Add(this.label40, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label41, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label42, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label48, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label49, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label55, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label56, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelbattT, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelFETT, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label62, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelMCUT, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label64, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(24, 35);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 191);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(29, 154);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(166, 24);
            this.label40.TabIndex = 43;
            this.label40.Text = "MCU Temperature";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(347, 11);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(61, 25);
            this.label41.TabIndex = 14;
            this.label41.Text = "Units";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(245, 11);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(68, 25);
            this.label42.TabIndex = 13;
            this.label42.Text = "Value";
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(22, 59);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(180, 24);
            this.label48.TabIndex = 21;
            this.label48.Text = "Battery Temperature";
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(32, 106);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(161, 24);
            this.label49.TabIndex = 22;
            this.label49.Text = "FET Temperature";
            // 
            // label55
            // 
            this.label55.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(366, 59);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(23, 24);
            this.label55.TabIndex = 30;
            this.label55.Text = "C";
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(366, 106);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(23, 24);
            this.label56.TabIndex = 31;
            this.label56.Text = "C";
            // 
            // labelbattT
            // 
            this.labelbattT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelbattT.AutoSize = true;
            this.labelbattT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbattT.Location = new System.Drawing.Point(249, 59);
            this.labelbattT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelbattT.Name = "labelbattT";
            this.labelbattT.Size = new System.Drawing.Size(60, 24);
            this.labelbattT.TabIndex = 39;
            this.labelbattT.Text = "label7";
            // 
            // labelFETT
            // 
            this.labelFETT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFETT.AutoSize = true;
            this.labelFETT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFETT.Location = new System.Drawing.Point(249, 106);
            this.labelFETT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFETT.Name = "labelFETT";
            this.labelFETT.Size = new System.Drawing.Size(60, 24);
            this.labelFETT.TabIndex = 40;
            this.labelFETT.Text = "label8";
            // 
            // label62
            // 
            this.label62.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(366, 154);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(23, 24);
            this.label62.TabIndex = 44;
            this.label62.Text = "C";
            // 
            // labelMCUT
            // 
            this.labelMCUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMCUT.AutoSize = true;
            this.labelMCUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMCUT.Location = new System.Drawing.Point(249, 154);
            this.labelMCUT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMCUT.Name = "labelMCUT";
            this.labelMCUT.Size = new System.Drawing.Size(60, 24);
            this.labelMCUT.TabIndex = 45;
            this.labelMCUT.Text = "label9";
            // 
            // label64
            // 
            this.label64.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(57, 11);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(111, 25);
            this.label64.TabIndex = 0;
            this.label64.Text = "Parameter";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.tableLayoutPanel3);
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(471, 394);
            this.xtraTabPage3.Text = "Current";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.67517F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.26926F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.05557F));
            this.tableLayoutPanel3.Controls.Add(this.label75, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label76, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label93, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label94, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label95, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label98, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label99, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelCHGCurrent, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelDSGCurrent, 1, 2);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 39);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(418, 155);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // label75
            // 
            this.label75.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(344, 13);
            this.label75.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(61, 25);
            this.label75.TabIndex = 14;
            this.label75.Text = "Units";
            // 
            // label76
            // 
            this.label76.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(244, 13);
            this.label76.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(68, 25);
            this.label76.TabIndex = 13;
            this.label76.Text = "Value";
            // 
            // label93
            // 
            this.label93.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(345, 116);
            this.label93.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(59, 24);
            this.label93.TabIndex = 33;
            this.label93.Text = "Amps";
            // 
            // label94
            // 
            this.label94.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(42, 65);
            this.label94.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(139, 24);
            this.label94.TabIndex = 23;
            this.label94.Text = "Charge Current";
            // 
            // label95
            // 
            this.label95.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(345, 65);
            this.label95.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(59, 24);
            this.label95.TabIndex = 32;
            this.label95.Text = "Amps";
            // 
            // label98
            // 
            this.label98.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(56, 13);
            this.label98.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(111, 25);
            this.label98.TabIndex = 0;
            this.label98.Text = "Parameter";
            // 
            // label99
            // 
            this.label99.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(31, 116);
            this.label99.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(162, 24);
            this.label99.TabIndex = 25;
            this.label99.Text = "Discharge Current";
            // 
            // labelCHGCurrent
            // 
            this.labelCHGCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCHGCurrent.AutoSize = true;
            this.labelCHGCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCHGCurrent.Location = new System.Drawing.Point(243, 65);
            this.labelCHGCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCHGCurrent.Name = "labelCHGCurrent";
            this.labelCHGCurrent.Size = new System.Drawing.Size(70, 24);
            this.labelCHGCurrent.TabIndex = 54;
            this.labelCHGCurrent.Text = "label10";
            // 
            // labelDSGCurrent
            // 
            this.labelDSGCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDSGCurrent.AutoSize = true;
            this.labelDSGCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSGCurrent.Location = new System.Drawing.Point(243, 116);
            this.labelDSGCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDSGCurrent.Name = "labelDSGCurrent";
            this.labelDSGCurrent.Size = new System.Drawing.Size(70, 24);
            this.labelDSGCurrent.TabIndex = 46;
            this.labelDSGCurrent.Text = "label11";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.tableLayoutPanel4);
            this.xtraTabPage4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(471, 394);
            this.xtraTabPage4.Text = "Other";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.67517F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.26926F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.05557F));
            this.tableLayoutPanel4.Controls.Add(this.label14, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelSpare1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelSpare6, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.labelSpare5, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.labelSpare4, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.labelSpare3, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label110, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label111, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label112, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label113, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label114, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label116, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.labelSpare7, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.labelSpare8, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.label132, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelSpare2, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label115, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label117, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.label16, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label135, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.label109, 2, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(20, 39);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(430, 336);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(356, 81);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 24);
            this.label14.TabIndex = 55;
            this.label14.Text = "Amps";
            // 
            // labelSpare1
            // 
            this.labelSpare1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpare1.AutoSize = true;
            this.labelSpare1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpare1.Location = new System.Drawing.Point(248, 43);
            this.labelSpare1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpare1.Name = "labelSpare1";
            this.labelSpare1.Size = new System.Drawing.Size(75, 25);
            this.labelSpare1.TabIndex = 54;
            this.labelSpare1.Text = "label12";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 24);
            this.label13.TabIndex = 53;
            this.label13.Text = "IDSG Calib. Constant";
            // 
            // labelSpare6
            // 
            this.labelSpare6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpare6.AutoSize = true;
            this.labelSpare6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpare6.Location = new System.Drawing.Point(248, 228);
            this.labelSpare6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpare6.Name = "labelSpare6";
            this.labelSpare6.Size = new System.Drawing.Size(75, 25);
            this.labelSpare6.TabIndex = 53;
            this.labelSpare6.Text = "label17";
            // 
            // labelSpare5
            // 
            this.labelSpare5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpare5.AutoSize = true;
            this.labelSpare5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpare5.Location = new System.Drawing.Point(248, 191);
            this.labelSpare5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpare5.Name = "labelSpare5";
            this.labelSpare5.Size = new System.Drawing.Size(75, 25);
            this.labelSpare5.TabIndex = 52;
            this.labelSpare5.Text = "label16";
            // 
            // labelSpare4
            // 
            this.labelSpare4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpare4.AutoSize = true;
            this.labelSpare4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpare4.Location = new System.Drawing.Point(248, 154);
            this.labelSpare4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpare4.Name = "labelSpare4";
            this.labelSpare4.Size = new System.Drawing.Size(75, 25);
            this.labelSpare4.TabIndex = 52;
            this.labelSpare4.Text = "label15";
            // 
            // labelSpare3
            // 
            this.labelSpare3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpare3.AutoSize = true;
            this.labelSpare3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpare3.Location = new System.Drawing.Point(248, 117);
            this.labelSpare3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpare3.Name = "labelSpare3";
            this.labelSpare3.Size = new System.Drawing.Size(75, 25);
            this.labelSpare3.TabIndex = 51;
            this.labelSpare3.Text = "label14";
            // 
            // label110
            // 
            this.label110.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label110.Location = new System.Drawing.Point(251, 6);
            this.label110.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(68, 25);
            this.label110.TabIndex = 13;
            this.label110.Text = "Value";
            // 
            // label111
            // 
            this.label111.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.Location = new System.Drawing.Point(22, 81);
            this.label111.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(185, 24);
            this.label111.TabIndex = 16;
            this.label111.Text = "ICHG Calib. Constant";
            // 
            // label112
            // 
            this.label112.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label112.Location = new System.Drawing.Point(36, 118);
            this.label112.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(158, 24);
            this.label112.TabIndex = 17;
            this.label112.Text = "Watchdog Resets";
            // 
            // label113
            // 
            this.label113.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.Location = new System.Drawing.Point(77, 155);
            this.label113.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(75, 24);
            this.label113.TabIndex = 18;
            this.label113.Text = "Spare 1";
            // 
            // label114
            // 
            this.label114.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label114.AutoSize = true;
            this.label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label114.Location = new System.Drawing.Point(77, 192);
            this.label114.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(75, 24);
            this.label114.TabIndex = 19;
            this.label114.Text = "Spare 2";
            // 
            // label116
            // 
            this.label116.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label116.AutoSize = true;
            this.label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label116.Location = new System.Drawing.Point(77, 266);
            this.label116.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(75, 24);
            this.label116.TabIndex = 21;
            this.label116.Text = "Spare 4";
            // 
            // labelSpare7
            // 
            this.labelSpare7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpare7.AutoSize = true;
            this.labelSpare7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpare7.Location = new System.Drawing.Point(250, 266);
            this.labelSpare7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpare7.Name = "labelSpare7";
            this.labelSpare7.Size = new System.Drawing.Size(70, 24);
            this.labelSpare7.TabIndex = 39;
            this.labelSpare7.Text = "label18";
            // 
            // labelSpare8
            // 
            this.labelSpare8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpare8.AutoSize = true;
            this.labelSpare8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpare8.Location = new System.Drawing.Point(250, 304);
            this.labelSpare8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpare8.Name = "labelSpare8";
            this.labelSpare8.Size = new System.Drawing.Size(70, 24);
            this.labelSpare8.TabIndex = 40;
            this.labelSpare8.Text = "label19";
            // 
            // label132
            // 
            this.label132.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label132.AutoSize = true;
            this.label132.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label132.Location = new System.Drawing.Point(59, 6);
            this.label132.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(111, 25);
            this.label132.TabIndex = 0;
            this.label132.Text = "Parameter";
            // 
            // labelSpare2
            // 
            this.labelSpare2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpare2.AutoSize = true;
            this.labelSpare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpare2.Location = new System.Drawing.Point(248, 80);
            this.labelSpare2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpare2.Name = "labelSpare2";
            this.labelSpare2.Size = new System.Drawing.Size(75, 25);
            this.labelSpare2.TabIndex = 51;
            this.labelSpare2.Text = "label13";
            // 
            // label115
            // 
            this.label115.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label115.Location = new System.Drawing.Point(77, 229);
            this.label115.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(75, 24);
            this.label115.TabIndex = 20;
            this.label115.Text = "Spare 3";
            // 
            // label117
            // 
            this.label117.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label117.Location = new System.Drawing.Point(77, 304);
            this.label117.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(75, 24);
            this.label117.TabIndex = 22;
            this.label117.Text = "Spare 5";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(356, 44);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 24);
            this.label16.TabIndex = 56;
            this.label16.Text = "Amps";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(344, 112);
            this.label135.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(0, 24);
            this.label135.TabIndex = 44;
            // 
            // label109
            // 
            this.label109.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label109.AutoSize = true;
            this.label109.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label109.Location = new System.Drawing.Point(355, 6);
            this.label109.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(61, 25);
            this.label109.TabIndex = 14;
            this.label109.Text = "Units";
            // 
            // labelBattID
            // 
            this.labelBattID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBattID.AutoSize = true;
            this.labelBattID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBattID.Location = new System.Drawing.Point(150, 1);
            this.labelBattID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBattID.Name = "labelBattID";
            this.labelBattID.Size = new System.Drawing.Size(64, 25);
            this.labelBattID.TabIndex = 50;
            this.labelBattID.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelBattID);
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(34, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 33);
            this.panel1.TabIndex = 51;
            // 
            // toggleSwitchRecord
            // 
            this.toggleSwitchRecord.Location = new System.Drawing.Point(676, 686);
            this.toggleSwitchRecord.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.toggleSwitchRecord.Name = "toggleSwitchRecord";
            this.toggleSwitchRecord.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitchRecord.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchRecord.Properties.OffText = "OFF";
            this.toggleSwitchRecord.Properties.OnText = "ON";
            this.toggleSwitchRecord.Size = new System.Drawing.Size(144, 29);
            this.toggleSwitchRecord.TabIndex = 52;
            this.toggleSwitchRecord.Toggled += new System.EventHandler(this.ToggleSwitchRecord_Toggled);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(540, 686);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 24);
            this.label12.TabIndex = 53;
            this.label12.Text = "Record Data";
            // 
            // labelFVersion
            // 
            this.labelFVersion.AutoSize = true;
            this.labelFVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFVersion.Location = new System.Drawing.Point(743, 649);
            this.labelFVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFVersion.Name = "labelFVersion";
            this.labelFVersion.Size = new System.Drawing.Size(0, 20);
            this.labelFVersion.TabIndex = 57;
            // 
            // buttonDebug
            // 
            this.buttonDebug.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDebug.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonDebug.Location = new System.Drawing.Point(35, 657);
            this.buttonDebug.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(106, 38);
            this.buttonDebug.TabIndex = 58;
            this.buttonDebug.Text = "Debug";
            this.buttonDebug.UseVisualStyleBackColor = false;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // buttonProduction
            // 
            this.buttonProduction.BackColor = System.Drawing.SystemColors.Control;
            this.buttonProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduction.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonProduction.Location = new System.Drawing.Point(173, 657);
            this.buttonProduction.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonProduction.Name = "buttonProduction";
            this.buttonProduction.Size = new System.Drawing.Size(154, 38);
            this.buttonProduction.TabIndex = 59;
            this.buttonProduction.Text = "Production";
            this.buttonProduction.UseVisualStyleBackColor = false;
            this.buttonProduction.Click += new System.EventHandler(this.buttonProduction_Click);
            // 
            // buttonCalibration
            // 
            this.buttonCalibration.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalibration.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonCalibration.Location = new System.Drawing.Point(352, 657);
            this.buttonCalibration.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonCalibration.Name = "buttonCalibration";
            this.buttonCalibration.Size = new System.Drawing.Size(154, 38);
            this.buttonCalibration.TabIndex = 60;
            this.buttonCalibration.Text = "Calibration";
            this.buttonCalibration.UseVisualStyleBackColor = false;
            this.buttonCalibration.Click += new System.EventHandler(this.buttonCalibration_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label21.Location = new System.Drawing.Point(4, 7);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(285, 25);
            this.label21.TabIndex = 0;
            this.label21.Text = "BMS Current Calibration Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkEditCalibration);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Location = new System.Drawing.Point(534, 518);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 90);
            this.panel2.TabIndex = 61;
            // 
            // checkEditCalibration
            // 
            this.checkEditCalibration.Location = new System.Drawing.Point(14, 45);
            this.checkEditCalibration.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkEditCalibration.Name = "checkEditCalibration";
            this.checkEditCalibration.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditCalibration.Properties.Appearance.Options.UseFont = true;
            this.checkEditCalibration.Properties.Caption = "Current Calibrated";
            this.checkEditCalibration.Size = new System.Drawing.Size(246, 28);
            this.checkEditCalibration.TabIndex = 24;
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(916, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonCalibration);
            this.Controls.Add(this.buttonProduction);
            this.Controls.Add(this.buttonDebug);
            this.Controls.Add(this.labelFVersion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.toggleSwitchRecord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.labelDataStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "NLX NOCO REV 5 FEP ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchDSG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchCHG.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOTP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOCD1_SC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditUTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOTF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditOV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditUV.Properties)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchBal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.xtraTabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.xtraTabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchRecord.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCalibration.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label labelBMSfault;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label30;
        private DevExpress.XtraEditors.CheckEdit checkEditUTB;
        private DevExpress.XtraEditors.CheckEdit checkEditOTF;
        private DevExpress.XtraEditors.CheckEdit checkEditOTB;
        private DevExpress.XtraEditors.CheckEdit checkEditOV;
        private DevExpress.XtraEditors.CheckEdit checkEditUV;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchCHG;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchDSG;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchBal;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label labelDataStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label31;
        private DevExpress.XtraEditors.CheckEdit checkEditOCD1_SC;
        private DevExpress.XtraEditors.CheckEdit checkEditOTP;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Label labelCell4V;
        private System.Windows.Forms.Label labelCell3V;
        private System.Windows.Forms.Label labelCell2V;
        private System.Windows.Forms.Label labelCell1V;
        private System.Windows.Forms.Label labelBattV;
        private System.Windows.Forms.Label labelBattID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label labelbattT;
        private System.Windows.Forms.Label labelFETT;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label labelMCUT;
        private System.Windows.Forms.Label label64;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label labelCHGCurrent;
        private System.Windows.Forms.Label labelDSGCurrent;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelSpare4;
        private System.Windows.Forms.Label labelSpare3;
        private System.Windows.Forms.Label labelSpare2;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label labelSpare6;
        private System.Windows.Forms.Label labelSpare5;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label labelSpare7;
        private System.Windows.Forms.Label labelSpare8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSpare1;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchRecord;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelFVersion;
        private System.Windows.Forms.Button buttonDebug;
        private System.Windows.Forms.Button buttonProduction;
        private System.Windows.Forms.Button buttonCalibration;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.CheckEdit checkEditCalibration;
    }
}