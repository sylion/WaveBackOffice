namespace WaveBackOffice
{
    partial class frmDirectoryClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirectoryClients));
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pinner = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAccountsAdd = new System.Windows.Forms.Button();
            this.gbAccountColors = new System.Windows.Forms.GroupBox();
            this.btnAccountColorReset = new System.Windows.Forms.Button();
            this.btnAccountColorActive = new System.Windows.Forms.Button();
            this.btnAccountColorEmployee = new System.Windows.Forms.Button();
            this.btnAccountColorSubscribe = new System.Windows.Forms.Button();
            this.cbAccountLights = new System.Windows.Forms.CheckBox();
            this.gbAccountSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchReject = new System.Windows.Forms.Button();
            this.cbSearchVip = new System.Windows.Forms.CheckBox();
            this.tbSearchCity = new System.Windows.Forms.TextBox();
            this.tbSearchCardID = new System.Windows.Forms.TextBox();
            this.tbSearchTel = new System.Windows.Forms.TextBox();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.cbSearchCity = new System.Windows.Forms.CheckBox();
            this.cbSearchCardID = new System.Windows.Forms.CheckBox();
            this.cbSearchName = new System.Windows.Forms.CheckBox();
            this.cbSearchTel = new System.Windows.Forms.CheckBox();
            this.cbSearchID = new System.Windows.Forms.CheckBox();
            this.cbSearchEmployee = new System.Windows.Forms.CheckBox();
            this.cbSearchActive = new System.Windows.Forms.CheckBox();
            this.cbSearchSubscribe = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchID = new System.Windows.Forms.TextBox();
            this.btnAccountUpdate = new System.Windows.Forms.Button();
            this.PickColor = new System.Windows.Forms.ColorDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.slblRowCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbSearchVip = new System.Windows.Forms.ComboBox();
            this.tbSearchEmployee = new System.Windows.Forms.ComboBox();
            this.tbSearchActive = new System.Windows.Forms.ComboBox();
            this.tbSearchSubscribe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbAccountColors.SuspendLayout();
            this.gbAccountSearch.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccounts.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccounts.Location = new System.Drawing.Point(0, 0);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.ShowEditingIcon = false;
            this.dgvAccounts.Size = new System.Drawing.Size(905, 707);
            this.dgvAccounts.StandardTab = true;
            this.dgvAccounts.TabIndex = 0;
            this.dgvAccounts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAccounts_CellDoubleClick);
            this.dgvAccounts.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvAccounts_CellValueNeeded);
            this.dgvAccounts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvAccounts_Scroll);
            this.dgvAccounts.SelectionChanged += new System.EventHandler(this.dgwAccounts_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Pinner);
            this.panel1.Controls.Add(this.btnAccountsAdd);
            this.panel1.Controls.Add(this.gbAccountColors);
            this.panel1.Controls.Add(this.cbAccountLights);
            this.panel1.Controls.Add(this.gbAccountSearch);
            this.panel1.Controls.Add(this.btnAccountUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(905, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 729);
            this.panel1.TabIndex = 13;
            this.panel1.Leave += new System.EventHandler(this.panel1_Leave);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // Pinner
            // 
            this.Pinner.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pinner.Checked = true;
            this.Pinner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Pinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pinner.ImageIndex = 0;
            this.Pinner.ImageList = this.imageList1;
            this.Pinner.Location = new System.Drawing.Point(3, 3);
            this.Pinner.Name = "Pinner";
            this.Pinner.Size = new System.Drawing.Size(25, 25);
            this.Pinner.TabIndex = 14;
            this.Pinner.TabStop = false;
            this.Pinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pinner.UseVisualStyleBackColor = true;
            this.Pinner.CheckedChanged += new System.EventHandler(this.Pinner_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pin.png");
            this.imageList1.Images.SetKeyName(1, "unpin.png");
            // 
            // btnAccountsAdd
            // 
            this.btnAccountsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccountsAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccountsAdd.Location = new System.Drawing.Point(30, 3);
            this.btnAccountsAdd.Name = "btnAccountsAdd";
            this.btnAccountsAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAccountsAdd.TabIndex = 1;
            this.btnAccountsAdd.TabStop = false;
            this.btnAccountsAdd.Text = "Добавить";
            this.btnAccountsAdd.UseVisualStyleBackColor = true;
            this.btnAccountsAdd.Click += new System.EventHandler(this.btnAccountsAdd_Click);
            // 
            // gbAccountColors
            // 
            this.gbAccountColors.Controls.Add(this.btnAccountColorReset);
            this.gbAccountColors.Controls.Add(this.btnAccountColorActive);
            this.gbAccountColors.Controls.Add(this.btnAccountColorEmployee);
            this.gbAccountColors.Controls.Add(this.btnAccountColorSubscribe);
            this.gbAccountColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAccountColors.Location = new System.Drawing.Point(30, 571);
            this.gbAccountColors.Name = "gbAccountColors";
            this.gbAccountColors.Size = new System.Drawing.Size(209, 136);
            this.gbAccountColors.TabIndex = 19;
            this.gbAccountColors.TabStop = false;
            this.gbAccountColors.Text = "Карта цветов";
            // 
            // btnAccountColorReset
            // 
            this.btnAccountColorReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccountColorReset.Location = new System.Drawing.Point(102, 106);
            this.btnAccountColorReset.Name = "btnAccountColorReset";
            this.btnAccountColorReset.Size = new System.Drawing.Size(100, 23);
            this.btnAccountColorReset.TabIndex = 24;
            this.btnAccountColorReset.TabStop = false;
            this.btnAccountColorReset.Text = "По умолчанию";
            this.btnAccountColorReset.UseVisualStyleBackColor = true;
            this.btnAccountColorReset.Click += new System.EventHandler(this.btnAccountColorReset_Click);
            // 
            // btnAccountColorActive
            // 
            this.btnAccountColorActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountColorActive.BackColor = System.Drawing.Color.Red;
            this.btnAccountColorActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccountColorActive.Location = new System.Drawing.Point(6, 77);
            this.btnAccountColorActive.Name = "btnAccountColorActive";
            this.btnAccountColorActive.Size = new System.Drawing.Size(196, 23);
            this.btnAccountColorActive.TabIndex = 23;
            this.btnAccountColorActive.TabStop = false;
            this.btnAccountColorActive.Text = "Отключен";
            this.btnAccountColorActive.UseVisualStyleBackColor = false;
            this.btnAccountColorActive.Click += new System.EventHandler(this.btnAccountColor_Click);
            // 
            // btnAccountColorEmployee
            // 
            this.btnAccountColorEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountColorEmployee.BackColor = System.Drawing.Color.Pink;
            this.btnAccountColorEmployee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccountColorEmployee.Location = new System.Drawing.Point(6, 48);
            this.btnAccountColorEmployee.Name = "btnAccountColorEmployee";
            this.btnAccountColorEmployee.Size = new System.Drawing.Size(196, 23);
            this.btnAccountColorEmployee.TabIndex = 22;
            this.btnAccountColorEmployee.TabStop = false;
            this.btnAccountColorEmployee.Text = "Сотрудник";
            this.btnAccountColorEmployee.UseVisualStyleBackColor = false;
            this.btnAccountColorEmployee.Click += new System.EventHandler(this.btnAccountColor_Click);
            // 
            // btnAccountColorSubscribe
            // 
            this.btnAccountColorSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountColorSubscribe.BackColor = System.Drawing.Color.Aqua;
            this.btnAccountColorSubscribe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccountColorSubscribe.Location = new System.Drawing.Point(6, 19);
            this.btnAccountColorSubscribe.Name = "btnAccountColorSubscribe";
            this.btnAccountColorSubscribe.Size = new System.Drawing.Size(196, 23);
            this.btnAccountColorSubscribe.TabIndex = 21;
            this.btnAccountColorSubscribe.TabStop = false;
            this.btnAccountColorSubscribe.Text = "Не подписан на рассылку";
            this.btnAccountColorSubscribe.UseVisualStyleBackColor = false;
            this.btnAccountColorSubscribe.Click += new System.EventHandler(this.btnAccountColor_Click);
            // 
            // cbAccountLights
            // 
            this.cbAccountLights.AutoSize = true;
            this.cbAccountLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAccountLights.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbAccountLights.Location = new System.Drawing.Point(37, 34);
            this.cbAccountLights.Name = "cbAccountLights";
            this.cbAccountLights.Size = new System.Drawing.Size(153, 19);
            this.cbAccountLights.TabIndex = 3;
            this.cbAccountLights.TabStop = false;
            this.cbAccountLights.Text = "Отключить подсветку";
            this.cbAccountLights.UseVisualStyleBackColor = true;
            this.cbAccountLights.CheckedChanged += new System.EventHandler(this.cbAccountLights_CheckedChanged);
            // 
            // gbAccountSearch
            // 
            this.gbAccountSearch.Controls.Add(this.tbSearchSubscribe);
            this.gbAccountSearch.Controls.Add(this.tbSearchActive);
            this.gbAccountSearch.Controls.Add(this.tbSearchEmployee);
            this.gbAccountSearch.Controls.Add(this.tbSearchVip);
            this.gbAccountSearch.Controls.Add(this.btnSearchReject);
            this.gbAccountSearch.Controls.Add(this.cbSearchVip);
            this.gbAccountSearch.Controls.Add(this.tbSearchCity);
            this.gbAccountSearch.Controls.Add(this.tbSearchCardID);
            this.gbAccountSearch.Controls.Add(this.tbSearchTel);
            this.gbAccountSearch.Controls.Add(this.tbSearchName);
            this.gbAccountSearch.Controls.Add(this.cbSearchCity);
            this.gbAccountSearch.Controls.Add(this.cbSearchCardID);
            this.gbAccountSearch.Controls.Add(this.cbSearchName);
            this.gbAccountSearch.Controls.Add(this.cbSearchTel);
            this.gbAccountSearch.Controls.Add(this.cbSearchID);
            this.gbAccountSearch.Controls.Add(this.cbSearchEmployee);
            this.gbAccountSearch.Controls.Add(this.cbSearchActive);
            this.gbAccountSearch.Controls.Add(this.cbSearchSubscribe);
            this.gbAccountSearch.Controls.Add(this.btnSearch);
            this.gbAccountSearch.Controls.Add(this.tbSearchID);
            this.gbAccountSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAccountSearch.Location = new System.Drawing.Point(30, 59);
            this.gbAccountSearch.Name = "gbAccountSearch";
            this.gbAccountSearch.Size = new System.Drawing.Size(209, 506);
            this.gbAccountSearch.TabIndex = 10;
            this.gbAccountSearch.TabStop = false;
            this.gbAccountSearch.Text = "Поиск";
            // 
            // btnSearchReject
            // 
            this.btnSearchReject.Location = new System.Drawing.Point(6, 477);
            this.btnSearchReject.Name = "btnSearchReject";
            this.btnSearchReject.Size = new System.Drawing.Size(75, 23);
            this.btnSearchReject.TabIndex = 20;
            this.btnSearchReject.Text = "Сброс";
            this.btnSearchReject.UseVisualStyleBackColor = true;
            this.btnSearchReject.Click += new System.EventHandler(this.btnSearchReject_Click);
            // 
            // cbSearchVip
            // 
            this.cbSearchVip.AutoSize = true;
            this.cbSearchVip.Location = new System.Drawing.Point(6, 428);
            this.cbSearchVip.Name = "cbSearchVip";
            this.cbSearchVip.Size = new System.Drawing.Size(44, 19);
            this.cbSearchVip.TabIndex = 17;
            this.cbSearchVip.Text = "VIP";
            this.cbSearchVip.UseVisualStyleBackColor = true;
            this.cbSearchVip.CheckedChanged += new System.EventHandler(this.cbSearchVip_CheckedChanged);
            // 
            // tbSearchCity
            // 
            this.tbSearchCity.Enabled = false;
            this.tbSearchCity.Location = new System.Drawing.Point(25, 247);
            this.tbSearchCity.Name = "tbSearchCity";
            this.tbSearchCity.Size = new System.Drawing.Size(177, 21);
            this.tbSearchCity.TabIndex = 10;
            // 
            // tbSearchCardID
            // 
            this.tbSearchCardID.Enabled = false;
            this.tbSearchCardID.Location = new System.Drawing.Point(25, 195);
            this.tbSearchCardID.Name = "tbSearchCardID";
            this.tbSearchCardID.Size = new System.Drawing.Size(177, 21);
            this.tbSearchCardID.TabIndex = 8;
            // 
            // tbSearchTel
            // 
            this.tbSearchTel.Enabled = false;
            this.tbSearchTel.Location = new System.Drawing.Point(25, 143);
            this.tbSearchTel.Name = "tbSearchTel";
            this.tbSearchTel.Size = new System.Drawing.Size(177, 21);
            this.tbSearchTel.TabIndex = 6;
            // 
            // tbSearchName
            // 
            this.tbSearchName.Enabled = false;
            this.tbSearchName.Location = new System.Drawing.Point(25, 91);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(177, 21);
            this.tbSearchName.TabIndex = 4;
            // 
            // cbSearchCity
            // 
            this.cbSearchCity.AutoSize = true;
            this.cbSearchCity.Location = new System.Drawing.Point(6, 226);
            this.cbSearchCity.Name = "cbSearchCity";
            this.cbSearchCity.Size = new System.Drawing.Size(61, 19);
            this.cbSearchCity.TabIndex = 9;
            this.cbSearchCity.Text = "Город";
            this.cbSearchCity.UseVisualStyleBackColor = true;
            this.cbSearchCity.CheckedChanged += new System.EventHandler(this.cbSearchCity_CheckedChanged);
            // 
            // cbSearchCardID
            // 
            this.cbSearchCardID.AutoSize = true;
            this.cbSearchCardID.Location = new System.Drawing.Point(7, 174);
            this.cbSearchCardID.Name = "cbSearchCardID";
            this.cbSearchCardID.Size = new System.Drawing.Size(104, 19);
            this.cbSearchCardID.TabIndex = 7;
            this.cbSearchCardID.Text = "Номер карты";
            this.cbSearchCardID.UseVisualStyleBackColor = true;
            this.cbSearchCardID.CheckedChanged += new System.EventHandler(this.cbSearchCardID_CheckedChanged);
            // 
            // cbSearchName
            // 
            this.cbSearchName.AutoSize = true;
            this.cbSearchName.Location = new System.Drawing.Point(6, 70);
            this.cbSearchName.Name = "cbSearchName";
            this.cbSearchName.Size = new System.Drawing.Size(51, 19);
            this.cbSearchName.TabIndex = 3;
            this.cbSearchName.Text = "Имя";
            this.cbSearchName.UseVisualStyleBackColor = true;
            this.cbSearchName.CheckedChanged += new System.EventHandler(this.cbSearchName_CheckedChanged);
            // 
            // cbSearchTel
            // 
            this.cbSearchTel.AutoSize = true;
            this.cbSearchTel.Location = new System.Drawing.Point(6, 122);
            this.cbSearchTel.Name = "cbSearchTel";
            this.cbSearchTel.Size = new System.Drawing.Size(128, 19);
            this.cbSearchTel.TabIndex = 5;
            this.cbSearchTel.Text = "Номер телефона";
            this.cbSearchTel.UseVisualStyleBackColor = true;
            this.cbSearchTel.CheckedChanged += new System.EventHandler(this.cbSearchTel_CheckedChanged);
            // 
            // cbSearchID
            // 
            this.cbSearchID.AutoSize = true;
            this.cbSearchID.Location = new System.Drawing.Point(6, 18);
            this.cbSearchID.Name = "cbSearchID";
            this.cbSearchID.Size = new System.Drawing.Size(101, 19);
            this.cbSearchID.TabIndex = 1;
            this.cbSearchID.Text = "Номер счета";
            this.cbSearchID.UseVisualStyleBackColor = true;
            this.cbSearchID.CheckedChanged += new System.EventHandler(this.cbSearchID_CheckedChanged);
            // 
            // cbSearchEmployee
            // 
            this.cbSearchEmployee.AutoSize = true;
            this.cbSearchEmployee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSearchEmployee.Location = new System.Drawing.Point(7, 378);
            this.cbSearchEmployee.Name = "cbSearchEmployee";
            this.cbSearchEmployee.Size = new System.Drawing.Size(87, 19);
            this.cbSearchEmployee.TabIndex = 15;
            this.cbSearchEmployee.Text = "Сотрудник";
            this.cbSearchEmployee.UseVisualStyleBackColor = true;
            this.cbSearchEmployee.CheckedChanged += new System.EventHandler(this.cbSearchEmployee_CheckedChanged);
            // 
            // cbSearchActive
            // 
            this.cbSearchActive.AutoSize = true;
            this.cbSearchActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSearchActive.Location = new System.Drawing.Point(6, 327);
            this.cbSearchActive.Name = "cbSearchActive";
            this.cbSearchActive.Size = new System.Drawing.Size(74, 19);
            this.cbSearchActive.TabIndex = 13;
            this.cbSearchActive.Text = "Активен";
            this.cbSearchActive.UseVisualStyleBackColor = true;
            this.cbSearchActive.CheckedChanged += new System.EventHandler(this.cbSearchActive_CheckedChanged);
            // 
            // cbSearchSubscribe
            // 
            this.cbSearchSubscribe.AutoSize = true;
            this.cbSearchSubscribe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSearchSubscribe.Location = new System.Drawing.Point(6, 278);
            this.cbSearchSubscribe.Name = "cbSearchSubscribe";
            this.cbSearchSubscribe.Size = new System.Drawing.Size(82, 19);
            this.cbSearchSubscribe.TabIndex = 11;
            this.cbSearchSubscribe.Text = "Подписка";
            this.cbSearchSubscribe.UseVisualStyleBackColor = true;
            this.cbSearchSubscribe.CheckedChanged += new System.EventHandler(this.cbSearchSubscribe_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(127, 477);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Искать";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnAccountSearch_Click);
            // 
            // tbSearchID
            // 
            this.tbSearchID.Enabled = false;
            this.tbSearchID.Location = new System.Drawing.Point(25, 39);
            this.tbSearchID.Name = "tbSearchID";
            this.tbSearchID.Size = new System.Drawing.Size(177, 21);
            this.tbSearchID.TabIndex = 2;
            // 
            // btnAccountUpdate
            // 
            this.btnAccountUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccountUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccountUpdate.Location = new System.Drawing.Point(162, 3);
            this.btnAccountUpdate.Name = "btnAccountUpdate";
            this.btnAccountUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAccountUpdate.TabIndex = 2;
            this.btnAccountUpdate.TabStop = false;
            this.btnAccountUpdate.Text = "Обновить";
            this.btnAccountUpdate.UseVisualStyleBackColor = true;
            this.btnAccountUpdate.Click += new System.EventHandler(this.btnAccountUpdate_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblRowCount,
            this.toolStripStatusLabel3,
            this.slblPosition,
            this.toolStripStatusLabel4});
            this.statusStrip.Location = new System.Drawing.Point(0, 707);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(905, 22);
            this.statusStrip.TabIndex = 14;
            this.statusStrip.Text = "statusStrip1";
            // 
            // slblRowCount
            // 
            this.slblRowCount.Name = "slblRowCount";
            this.slblRowCount.Size = new System.Drawing.Size(150, 17);
            this.slblRowCount.Text = "Загружено: 0 из 0 записей";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel3.Text = "||";
            // 
            // slblPosition
            // 
            this.slblPosition.Name = "slblPosition";
            this.slblPosition.Size = new System.Drawing.Size(58, 17);
            this.slblPosition.Text = "Строка: 0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel4.Text = "||";
            // 
            // tbSearchVip
            // 
            this.tbSearchVip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbSearchVip.Enabled = false;
            this.tbSearchVip.FormattingEnabled = true;
            this.tbSearchVip.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.tbSearchVip.Location = new System.Drawing.Point(25, 449);
            this.tbSearchVip.Name = "tbSearchVip";
            this.tbSearchVip.Size = new System.Drawing.Size(177, 23);
            this.tbSearchVip.TabIndex = 18;
            // 
            // tbSearchEmployee
            // 
            this.tbSearchEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbSearchEmployee.Enabled = false;
            this.tbSearchEmployee.FormattingEnabled = true;
            this.tbSearchEmployee.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.tbSearchEmployee.Location = new System.Drawing.Point(25, 399);
            this.tbSearchEmployee.Name = "tbSearchEmployee";
            this.tbSearchEmployee.Size = new System.Drawing.Size(177, 23);
            this.tbSearchEmployee.TabIndex = 16;
            // 
            // tbSearchActive
            // 
            this.tbSearchActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbSearchActive.Enabled = false;
            this.tbSearchActive.FormattingEnabled = true;
            this.tbSearchActive.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.tbSearchActive.Location = new System.Drawing.Point(25, 349);
            this.tbSearchActive.Name = "tbSearchActive";
            this.tbSearchActive.Size = new System.Drawing.Size(177, 23);
            this.tbSearchActive.TabIndex = 14;
            // 
            // tbSearchSubscribe
            // 
            this.tbSearchSubscribe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbSearchSubscribe.Enabled = false;
            this.tbSearchSubscribe.FormattingEnabled = true;
            this.tbSearchSubscribe.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.tbSearchSubscribe.Location = new System.Drawing.Point(25, 298);
            this.tbSearchSubscribe.Name = "tbSearchSubscribe";
            this.tbSearchSubscribe.Size = new System.Drawing.Size(177, 23);
            this.tbSearchSubscribe.TabIndex = 12;
            // 
            // frmDirectoryClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 729);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDirectoryClients";
            this.Text = "Справочник клиентов";
            this.Load += new System.EventHandler(this.frmDirectoryClients_Load);
            this.Shown += new System.EventHandler(this.frmDirectoryClients_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAccountColors.ResumeLayout(false);
            this.gbAccountSearch.ResumeLayout(false);
            this.gbAccountSearch.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccountsAdd;
        private System.Windows.Forms.GroupBox gbAccountColors;
        private System.Windows.Forms.Button btnAccountColorReset;
        private System.Windows.Forms.Button btnAccountColorActive;
        private System.Windows.Forms.Button btnAccountColorEmployee;
        private System.Windows.Forms.Button btnAccountColorSubscribe;
        private System.Windows.Forms.CheckBox cbAccountLights;
        private System.Windows.Forms.GroupBox gbAccountSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchID;
        private System.Windows.Forms.Button btnAccountUpdate;
        private System.Windows.Forms.CheckBox Pinner;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColorDialog PickColor;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel slblRowCount;
        private System.Windows.Forms.ToolStripStatusLabel slblPosition;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.CheckBox cbSearchEmployee;
        private System.Windows.Forms.CheckBox cbSearchActive;
        private System.Windows.Forms.CheckBox cbSearchSubscribe;
        private System.Windows.Forms.CheckBox cbSearchCity;
        private System.Windows.Forms.CheckBox cbSearchCardID;
        private System.Windows.Forms.CheckBox cbSearchName;
        private System.Windows.Forms.CheckBox cbSearchTel;
        private System.Windows.Forms.CheckBox cbSearchID;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.TextBox tbSearchTel;
        private System.Windows.Forms.TextBox tbSearchCardID;
        private System.Windows.Forms.TextBox tbSearchCity;
        private System.Windows.Forms.CheckBox cbSearchVip;
        private System.Windows.Forms.Button btnSearchReject;
        private System.Windows.Forms.ComboBox tbSearchVip;
        private System.Windows.Forms.ComboBox tbSearchSubscribe;
        private System.Windows.Forms.ComboBox tbSearchActive;
        private System.Windows.Forms.ComboBox tbSearchEmployee;
    }
}