namespace Hvylya_Worker
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.cbStartSoft = new System.Windows.Forms.CheckBox();
            this.cbCheckGC = new System.Windows.Forms.CheckBox();
            this.cbUploadF = new System.Windows.Forms.CheckBox();
            this.cbUpload = new System.Windows.Forms.CheckBox();
            this.cbCheckUpdates = new System.Windows.Forms.CheckBox();
            this.cbOffline = new System.Windows.Forms.CheckBox();
            this.cbAutorun = new System.Windows.Forms.CheckBox();
            this.tbTimeServer = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSales = new System.Windows.Forms.TextBox();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.tbIn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFPSSales = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFPSAddr = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUpServer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUpLogin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUpPwd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbUpGroup = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbSMgoods = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSMcards = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbChTxtSales = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbChSales = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.numSync = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.numGC = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.numChecks = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numFPS = new System.Windows.Forms.NumericUpDown();
            this.chkFullLogs = new System.Windows.Forms.CheckBox();
            this.cbTxtUpload = new System.Windows.Forms.CheckBox();
            this.gbMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSync)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChecks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFPS)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.cbTxtUpload);
            this.gbMain.Controls.Add(this.cbStartSoft);
            this.gbMain.Controls.Add(this.cbCheckGC);
            this.gbMain.Controls.Add(this.cbUploadF);
            this.gbMain.Controls.Add(this.cbUpload);
            this.gbMain.Controls.Add(this.cbCheckUpdates);
            this.gbMain.Controls.Add(this.cbOffline);
            this.gbMain.Controls.Add(this.cbAutorun);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(257, 135);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Основные";
            // 
            // cbStartSoft
            // 
            this.cbStartSoft.AutoSize = true;
            this.cbStartSoft.Location = new System.Drawing.Point(151, 39);
            this.cbStartSoft.Name = "cbStartSoft";
            this.cbStartSoft.Size = new System.Drawing.Size(98, 17);
            this.cbStartSoft.TabIndex = 6;
            this.cbStartSoft.Text = "Запускать ПО";
            this.cbStartSoft.UseVisualStyleBackColor = true;
            // 
            // cbCheckGC
            // 
            this.cbCheckGC.AutoSize = true;
            this.cbCheckGC.Location = new System.Drawing.Point(7, 117);
            this.cbCheckGC.Name = "cbCheckGC";
            this.cbCheckGC.Size = new System.Drawing.Size(174, 17);
            this.cbCheckGC.TabIndex = 5;
            this.cbCheckGC.Text = "Обновлять справочники POS";
            this.cbCheckGC.UseVisualStyleBackColor = true;
            // 
            // cbUploadF
            // 
            this.cbUploadF.AutoSize = true;
            this.cbUploadF.Location = new System.Drawing.Point(7, 99);
            this.cbUploadF.Name = "cbUploadF";
            this.cbUploadF.Size = new System.Drawing.Size(179, 17);
            this.cbUploadF.TabIndex = 4;
            this.cbUploadF.Text = "Отправлять фискальные чеки";
            this.cbUploadF.UseVisualStyleBackColor = true;
            // 
            // cbUpload
            // 
            this.cbUpload.AutoSize = true;
            this.cbUpload.Location = new System.Drawing.Point(7, 80);
            this.cbUpload.Name = "cbUpload";
            this.cbUpload.Size = new System.Drawing.Size(166, 17);
            this.cbUpload.TabIndex = 3;
            this.cbUpload.Text = "Отправлять чеки на сервер";
            this.cbUpload.UseVisualStyleBackColor = true;
            // 
            // cbCheckUpdates
            // 
            this.cbCheckUpdates.AutoSize = true;
            this.cbCheckUpdates.Location = new System.Drawing.Point(7, 39);
            this.cbCheckUpdates.Name = "cbCheckUpdates";
            this.cbCheckUpdates.Size = new System.Drawing.Size(144, 17);
            this.cbCheckUpdates.TabIndex = 2;
            this.cbCheckUpdates.Text = "Проверять обновления";
            this.cbCheckUpdates.UseVisualStyleBackColor = true;
            // 
            // cbOffline
            // 
            this.cbOffline.AutoSize = true;
            this.cbOffline.Location = new System.Drawing.Point(151, 20);
            this.cbOffline.Name = "cbOffline";
            this.cbOffline.Size = new System.Drawing.Size(94, 17);
            this.cbOffline.TabIndex = 1;
            this.cbOffline.Text = "Режим Offline";
            this.cbOffline.UseVisualStyleBackColor = true;
            this.cbOffline.CheckedChanged += new System.EventHandler(this.cbOffline_CheckedChanged);
            // 
            // cbAutorun
            // 
            this.cbAutorun.AutoSize = true;
            this.cbAutorun.Location = new System.Drawing.Point(7, 20);
            this.cbAutorun.Name = "cbAutorun";
            this.cbAutorun.Size = new System.Drawing.Size(140, 17);
            this.cbAutorun.TabIndex = 0;
            this.cbAutorun.Text = "Стартовать с Windows";
            this.cbAutorun.UseVisualStyleBackColor = true;
            // 
            // tbTimeServer
            // 
            this.tbTimeServer.Location = new System.Drawing.Point(381, 359);
            this.tbTimeServer.Name = "tbTimeServer";
            this.tbTimeServer.Size = new System.Drawing.Size(139, 20);
            this.tbTimeServer.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(281, 362);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Сервер времени:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSales);
            this.groupBox1.Controls.Add(this.tbCommand);
            this.groupBox1.Controls.Add(this.tbOut);
            this.groupBox1.Controls.Add(this.tbIn);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Локальные Директории";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Command:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Out:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "In:";
            // 
            // tbSales
            // 
            this.tbSales.Location = new System.Drawing.Point(69, 72);
            this.tbSales.Name = "tbSales";
            this.tbSales.Size = new System.Drawing.Size(176, 20);
            this.tbSales.TabIndex = 3;
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(69, 98);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(176, 20);
            this.tbCommand.TabIndex = 2;
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(69, 45);
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(176, 20);
            this.tbOut.TabIndex = 1;
            // 
            // tbIn
            // 
            this.tbIn.Location = new System.Drawing.Point(69, 20);
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(176, 20);
            this.tbIn.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbFPSSales);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbFPSAddr);
            this.groupBox2.Location = new System.Drawing.Point(275, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сервер FP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sales:";
            // 
            // tbFPSSales
            // 
            this.tbFPSSales.Location = new System.Drawing.Point(69, 43);
            this.tbFPSSales.Name = "tbFPSSales";
            this.tbFPSSales.Size = new System.Drawing.Size(176, 20);
            this.tbFPSSales.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Адрес:";
            // 
            // tbFPSAddr
            // 
            this.tbFPSAddr.Location = new System.Drawing.Point(69, 18);
            this.tbFPSAddr.Name = "tbFPSAddr";
            this.tbFPSAddr.Size = new System.Drawing.Size(176, 20);
            this.tbFPSAddr.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbUpServer);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbUpLogin);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbUpPwd);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbUpGroup);
            this.groupBox3.Location = new System.Drawing.Point(12, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 122);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Модуль обновлений ПО";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Группа:";
            // 
            // tbUpServer
            // 
            this.tbUpServer.Location = new System.Drawing.Point(72, 17);
            this.tbUpServer.Name = "tbUpServer";
            this.tbUpServer.Size = new System.Drawing.Size(176, 20);
            this.tbUpServer.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Пароль:";
            // 
            // tbUpLogin
            // 
            this.tbUpLogin.Location = new System.Drawing.Point(72, 42);
            this.tbUpLogin.Name = "tbUpLogin";
            this.tbUpLogin.Size = new System.Drawing.Size(176, 20);
            this.tbUpLogin.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Логин:";
            // 
            // tbUpPwd
            // 
            this.tbUpPwd.Location = new System.Drawing.Point(72, 69);
            this.tbUpPwd.Name = "tbUpPwd";
            this.tbUpPwd.PasswordChar = '*';
            this.tbUpPwd.Size = new System.Drawing.Size(176, 20);
            this.tbUpPwd.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Сервер:";
            // 
            // tbUpGroup
            // 
            this.tbUpGroup.Location = new System.Drawing.Point(72, 95);
            this.tbUpGroup.Name = "tbUpGroup";
            this.tbUpGroup.Size = new System.Drawing.Size(176, 20);
            this.tbUpGroup.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbSMgoods);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.tbSMcards);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(275, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 68);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Модуль обновлений SMarket";
            // 
            // tbSMgoods
            // 
            this.tbSMgoods.Location = new System.Drawing.Point(69, 15);
            this.tbSMgoods.Name = "tbSMgoods";
            this.tbSMgoods.Size = new System.Drawing.Size(176, 20);
            this.tbSMgoods.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Путь cards:";
            // 
            // tbSMcards
            // 
            this.tbSMcards.Location = new System.Drawing.Point(69, 41);
            this.tbSMcards.Name = "tbSMcards";
            this.tbSMcards.Size = new System.Drawing.Size(176, 20);
            this.tbSMcards.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Путь goods:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.tbChTxtSales);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.tbChSales);
            this.groupBox5.Location = new System.Drawing.Point(275, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 69);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Модуль отправки чеков";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "TXT Sales:";
            // 
            // tbChTxtSales
            // 
            this.tbChTxtSales.Location = new System.Drawing.Point(69, 43);
            this.tbChTxtSales.Name = "tbChTxtSales";
            this.tbChTxtSales.Size = new System.Drawing.Size(176, 20);
            this.tbChTxtSales.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Путь Sales:";
            // 
            // tbChSales
            // 
            this.tbChSales.Location = new System.Drawing.Point(69, 19);
            this.tbChSales.Name = "tbChSales";
            this.tbChSales.Size = new System.Drawing.Size(176, 20);
            this.tbChSales.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(457, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.numSync);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.numGC);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.numChecks);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.numFPS);
            this.groupBox6.Location = new System.Drawing.Point(275, 235);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(257, 118);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Таймеры (мс)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(127, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "Таймер проверки FPS";
            // 
            // numSync
            // 
            this.numSync.Location = new System.Drawing.Point(9, 88);
            this.numSync.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSync.Name = "numSync";
            this.numSync.Size = new System.Drawing.Size(112, 20);
            this.numSync.TabIndex = 10;
            this.numSync.ThousandsSeparator = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(127, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(128, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Таймер синхр. времени";
            // 
            // numGC
            // 
            this.numGC.Location = new System.Drawing.Point(9, 64);
            this.numGC.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numGC.Name = "numGC";
            this.numGC.Size = new System.Drawing.Size(112, 20);
            this.numGC.TabIndex = 8;
            this.numGC.ThousandsSeparator = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(127, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(127, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Таймер загрузки goods";
            // 
            // numChecks
            // 
            this.numChecks.Location = new System.Drawing.Point(9, 40);
            this.numChecks.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numChecks.Name = "numChecks";
            this.numChecks.Size = new System.Drawing.Size(112, 20);
            this.numChecks.TabIndex = 6;
            this.numChecks.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Таймер отправки чеков";
            // 
            // numFPS
            // 
            this.numFPS.Location = new System.Drawing.Point(9, 16);
            this.numFPS.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFPS.Name = "numFPS";
            this.numFPS.Size = new System.Drawing.Size(112, 20);
            this.numFPS.TabIndex = 4;
            this.numFPS.ThousandsSeparator = true;
            // 
            // chkFullLogs
            // 
            this.chkFullLogs.AutoSize = true;
            this.chkFullLogs.Location = new System.Drawing.Point(19, 409);
            this.chkFullLogs.Name = "chkFullLogs";
            this.chkFullLogs.Size = new System.Drawing.Size(163, 17);
            this.chkFullLogs.TabIndex = 18;
            this.chkFullLogs.Text = "Расширенное логирование";
            this.chkFullLogs.UseVisualStyleBackColor = true;
            // 
            // cbTxtUpload
            // 
            this.cbTxtUpload.AutoSize = true;
            this.cbTxtUpload.Location = new System.Drawing.Point(7, 59);
            this.cbTxtUpload.Name = "cbTxtUpload";
            this.cbTxtUpload.Size = new System.Drawing.Size(190, 17);
            this.cbTxtUpload.TabIndex = 7;
            this.cbTxtUpload.Text = "Отправлять TXT чеки на сервер";
            this.cbTxtUpload.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 433);
            this.Controls.Add(this.chkFullLogs);
            this.Controls.Add(this.tbTimeServer);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(562, 442);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSync)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChecks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.CheckBox cbOffline;
        private System.Windows.Forms.CheckBox cbAutorun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSales;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.TextBox tbIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFPSSales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFPSAddr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUpServer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUpLogin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbUpPwd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUpGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSMgoods;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbSMcards;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbChSales;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbTimeServer;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown numSync;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown numGC;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown numChecks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numFPS;
        private System.Windows.Forms.CheckBox cbCheckUpdates;
        private System.Windows.Forms.CheckBox chkFullLogs;
        private System.Windows.Forms.CheckBox cbUploadF;
        private System.Windows.Forms.CheckBox cbUpload;
        private System.Windows.Forms.CheckBox cbCheckGC;
        private System.Windows.Forms.CheckBox cbStartSoft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbChTxtSales;
        private System.Windows.Forms.CheckBox cbTxtUpload;
    }
}