namespace WaveBackOffice
{
    partial class frmAppProtokolDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppProtokolDetails));
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties2 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties3 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties4 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties5 = new PresentationControls.CheckBoxProperties();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.фильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnFilterFrom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnFilterTo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnFilterFromLong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnFilterToLong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnActions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnFilterClear = new System.Windows.Forms.ToolStripMenuItem();
            this.Pinner = new System.Windows.Forms.CheckBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panelFilter = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HS = new PresentationControls.CheckBoxComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFilterGoods = new System.Windows.Forms.TextBox();
            this.cbFilterGoodsID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbFilterOperator = new PresentationControls.CheckBoxComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbFilterCardID = new PresentationControls.CheckBoxComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFilterPOS = new PresentationControls.CheckBoxComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFilterOperation = new PresentationControls.CheckBoxComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.time2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportExcell = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblCountRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblSumm = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuColumns = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ContextMenuStrip = this.contextMenu;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(788, 622);
            this.dgvData.TabIndex = 0;
            this.dgvData.VirtualMode = true;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwData_CellClick);
            this.dgvData.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgwData_CellContextMenuStripNeeded);
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwData_CellDoubleClick);
            this.dgvData.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgwData_CellValueNeeded);
            this.dgvData.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgwData_Scroll);
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgwData_SelectionChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фильтрToolStripMenuItem,
            this.toolStripSep1,
            this.tsbtnFilterFrom,
            this.tsbtnFilterTo,
            this.tsbtnFilterFromLong,
            this.tsbtnFilterToLong,
            this.toolStripMenuItem2,
            this.tsbtnSales,
            this.tsbtnActions,
            this.toolStripMenuItem3,
            this.tsbtnFilterClear});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(207, 198);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // фильтрToolStripMenuItem
            // 
            this.фильтрToolStripMenuItem.Enabled = false;
            this.фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            this.фильтрToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.фильтрToolStripMenuItem.Text = "Фильтры и действия";
            // 
            // toolStripSep1
            // 
            this.toolStripSep1.Name = "toolStripSep1";
            this.toolStripSep1.Size = new System.Drawing.Size(203, 6);
            // 
            // tsbtnFilterFrom
            // 
            this.tsbtnFilterFrom.Name = "tsbtnFilterFrom";
            this.tsbtnFilterFrom.Size = new System.Drawing.Size(206, 22);
            this.tsbtnFilterFrom.Text = "С";
            this.tsbtnFilterFrom.Visible = false;
            this.tsbtnFilterFrom.Click += new System.EventHandler(this.tsbtnFilterFrom_Click);
            // 
            // tsbtnFilterTo
            // 
            this.tsbtnFilterTo.Name = "tsbtnFilterTo";
            this.tsbtnFilterTo.Size = new System.Drawing.Size(206, 22);
            this.tsbtnFilterTo.Text = "ДО";
            this.tsbtnFilterTo.Visible = false;
            this.tsbtnFilterTo.Click += new System.EventHandler(this.tsbtnFilterTo_Click);
            // 
            // tsbtnFilterFromLong
            // 
            this.tsbtnFilterFromLong.Name = "tsbtnFilterFromLong";
            this.tsbtnFilterFromLong.Size = new System.Drawing.Size(206, 22);
            this.tsbtnFilterFromLong.Text = "С";
            this.tsbtnFilterFromLong.Click += new System.EventHandler(this.tsbtnFilterFromLong_Click);
            // 
            // tsbtnFilterToLong
            // 
            this.tsbtnFilterToLong.Name = "tsbtnFilterToLong";
            this.tsbtnFilterToLong.Size = new System.Drawing.Size(206, 22);
            this.tsbtnFilterToLong.Text = "ДО";
            this.tsbtnFilterToLong.Click += new System.EventHandler(this.tsbtnFilterToLong_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 6);
            // 
            // tsbtnSales
            // 
            this.tsbtnSales.Name = "tsbtnSales";
            this.tsbtnSales.Size = new System.Drawing.Size(206, 22);
            this.tsbtnSales.Text = "Продажи по этому чеку";
            this.tsbtnSales.Click += new System.EventHandler(this.tsbtnSales_Click);
            // 
            // tsbtnActions
            // 
            this.tsbtnActions.Name = "tsbtnActions";
            this.tsbtnActions.Size = new System.Drawing.Size(206, 22);
            this.tsbtnActions.Text = "Действия по этому чеку";
            this.tsbtnActions.Click += new System.EventHandler(this.tsbtnActions_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 6);
            // 
            // tsbtnFilterClear
            // 
            this.tsbtnFilterClear.Name = "tsbtnFilterClear";
            this.tsbtnFilterClear.Size = new System.Drawing.Size(206, 22);
            this.tsbtnFilterClear.Text = "Очистить все фильтры";
            this.tsbtnFilterClear.Click += new System.EventHandler(this.tsbtnFilterClear_Click);
            // 
            // Pinner
            // 
            this.Pinner.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pinner.Checked = true;
            this.Pinner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Pinner.ImageIndex = 0;
            this.Pinner.ImageList = this.imageList;
            this.Pinner.Location = new System.Drawing.Point(3, 3);
            this.Pinner.Name = "Pinner";
            this.Pinner.Size = new System.Drawing.Size(25, 25);
            this.Pinner.TabIndex = 14;
            this.Pinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pinner.UseVisualStyleBackColor = true;
            this.Pinner.CheckedChanged += new System.EventHandler(this.Pinner_CheckedChanged);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "pin.png");
            this.imageList.Images.SetKeyName(1, "unpin.png");
            // 
            // panelFilter
            // 
            this.panelFilter.AutoScroll = true;
            this.panelFilter.Controls.Add(this.groupBox3);
            this.panelFilter.Controls.Add(this.btnApply);
            this.panelFilter.Controls.Add(this.btnReject);
            this.panelFilter.Controls.Add(this.groupBox2);
            this.panelFilter.Controls.Add(this.groupBox1);
            this.panelFilter.Controls.Add(this.btnExportExcell);
            this.panelFilter.Controls.Add(this.Pinner);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFilter.Location = new System.Drawing.Point(788, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(263, 644);
            this.panelFilter.TabIndex = 14;
            this.panelFilter.Leave += new System.EventHandler(this.panel1_Leave);
            this.panelFilter.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HS);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(39, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 78);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Скрытые колонки";
            // 
            // HS
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HS.CheckBoxProperties = checkBoxProperties1;
            this.HS.DisplayMemberSingleItem = "";
            this.HS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HS.FormattingEnabled = true;
            this.HS.Location = new System.Drawing.Point(9, 19);
            this.HS.Name = "HS";
            this.HS.Size = new System.Drawing.Size(179, 21);
            this.HS.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Скрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHideColumns);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.Location = new System.Drawing.Point(155, 593);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 35;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnReject
            // 
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReject.Location = new System.Drawing.Point(48, 593);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 34;
            this.btnReject.Text = "Сброс";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFilterGoods);
            this.groupBox2.Controls.Add(this.cbFilterGoodsID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbFilterOperator);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbFilterCardID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbFilterPOS);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbFilterOperation);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(39, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 318);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключевые поля";
            // 
            // cbFilterGoods
            // 
            this.cbFilterGoods.Location = new System.Drawing.Point(9, 123);
            this.cbFilterGoods.Name = "cbFilterGoods";
            this.cbFilterGoods.Size = new System.Drawing.Size(182, 21);
            this.cbFilterGoods.TabIndex = 34;
            // 
            // cbFilterGoodsID
            // 
            this.cbFilterGoodsID.Location = new System.Drawing.Point(9, 80);
            this.cbFilterGoodsID.Name = "cbFilterGoodsID";
            this.cbFilterGoodsID.Size = new System.Drawing.Size(182, 21);
            this.cbFilterGoodsID.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Товар:";
            // 
            // cbFilterOperator
            // 
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbFilterOperator.CheckBoxProperties = checkBoxProperties2;
            this.cbFilterOperator.DisplayMemberSingleItem = "";
            this.cbFilterOperator.FormattingEnabled = true;
            this.cbFilterOperator.Location = new System.Drawing.Point(9, 261);
            this.cbFilterOperator.Name = "cbFilterOperator";
            this.cbFilterOperator.Size = new System.Drawing.Size(182, 23);
            this.cbFilterOperator.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Оператор:";
            // 
            // cbFilterCardID
            // 
            checkBoxProperties3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbFilterCardID.CheckBoxProperties = checkBoxProperties3;
            this.cbFilterCardID.DisplayMemberSingleItem = "";
            this.cbFilterCardID.FormattingEnabled = true;
            this.cbFilterCardID.Location = new System.Drawing.Point(9, 215);
            this.cbFilterCardID.Name = "cbFilterCardID";
            this.cbFilterCardID.Size = new System.Drawing.Size(182, 23);
            this.cbFilterCardID.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Номер кары:";
            // 
            // cbFilterPOS
            // 
            checkBoxProperties4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbFilterPOS.CheckBoxProperties = checkBoxProperties4;
            this.cbFilterPOS.DisplayMemberSingleItem = "";
            this.cbFilterPOS.FormattingEnabled = true;
            this.cbFilterPOS.Location = new System.Drawing.Point(9, 32);
            this.cbFilterPOS.Name = "cbFilterPOS";
            this.cbFilterPOS.Size = new System.Drawing.Size(182, 23);
            this.cbFilterPOS.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Имя POS:";
            // 
            // cbFilterOperation
            // 
            checkBoxProperties5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbFilterOperation.CheckBoxProperties = checkBoxProperties5;
            this.cbFilterOperation.DisplayMemberSingleItem = "";
            this.cbFilterOperation.FormattingEnabled = true;
            this.cbFilterOperation.Location = new System.Drawing.Point(9, 167);
            this.cbFilterOperation.Name = "cbFilterOperation";
            this.cbFilterOperation.Size = new System.Drawing.Size(182, 23);
            this.cbFilterOperation.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Операция:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Код товара:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date2);
            this.groupBox1.Controls.Add(this.date1);
            this.groupBox1.Controls.Add(this.time2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.time1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(39, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 180);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Период времени";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Время";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "по:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "с:";
            // 
            // date2
            // 
            this.date2.Checked = false;
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(77, 67);
            this.date2.Name = "date2";
            this.date2.ShowCheckBox = true;
            this.date2.Size = new System.Drawing.Size(107, 21);
            this.date2.TabIndex = 26;
            this.date2.ValueChanged += new System.EventHandler(this.date2_ValueChanged);
            // 
            // date1
            // 
            this.date1.Checked = false;
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(77, 41);
            this.date1.Name = "date1";
            this.date1.ShowCheckBox = true;
            this.date1.Size = new System.Drawing.Size(107, 21);
            this.date1.TabIndex = 25;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            // 
            // time2
            // 
            this.time2.Checked = false;
            this.time2.CustomFormat = "HH:mm:ss";
            this.time2.Enabled = false;
            this.time2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time2.Location = new System.Drawing.Point(77, 151);
            this.time2.Name = "time2";
            this.time2.ShowCheckBox = true;
            this.time2.ShowUpDown = true;
            this.time2.Size = new System.Drawing.Size(107, 21);
            this.time2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "по:";
            // 
            // time1
            // 
            this.time1.Checked = false;
            this.time1.CustomFormat = "HH:mm:ss";
            this.time1.Enabled = false;
            this.time1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time1.Location = new System.Drawing.Point(77, 125);
            this.time1.Name = "time1";
            this.time1.ShowCheckBox = true;
            this.time1.ShowUpDown = true;
            this.time1.Size = new System.Drawing.Size(107, 21);
            this.time1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "с:";
            // 
            // btnExportExcell
            // 
            this.btnExportExcell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportExcell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcell.Location = new System.Drawing.Point(39, 5);
            this.btnExportExcell.Name = "btnExportExcell";
            this.btnExportExcell.Size = new System.Drawing.Size(197, 23);
            this.btnExportExcell.TabIndex = 15;
            this.btnExportExcell.Text = "Экспорт";
            this.btnExportExcell.UseVisualStyleBackColor = true;
            this.btnExportExcell.Click += new System.EventHandler(this.btnExportExcell_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblCountRows,
            this.toolStripStatusLabel1,
            this.slblPosition,
            this.toolStripStatusLabel2,
            this.slblSumm,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 622);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip";
            // 
            // slblCountRows
            // 
            this.slblCountRows.Name = "slblCountRows";
            this.slblCountRows.Size = new System.Drawing.Size(150, 17);
            this.slblCountRows.Text = "Загружено: 0 из 0 записей";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel1.Text = "||";
            // 
            // slblPosition
            // 
            this.slblPosition.Name = "slblPosition";
            this.slblPosition.Size = new System.Drawing.Size(123, 17);
            this.slblPosition.Text = "Строка: 0, Столбец: 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel2.Text = "||";
            // 
            // slblSumm
            // 
            this.slblSumm.Name = "slblSumm";
            this.slblSumm.Size = new System.Drawing.Size(147, 17);
            this.slblSumm.Text = "Сумма: нельзя посчитать";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel4.Text = "||";
            // 
            // contextMenuColumns
            // 
            this.contextMenuColumns.Name = "contextMenuColumns";
            this.contextMenuColumns.Size = new System.Drawing.Size(61, 4);
            // 
            // frmAppProtokolDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 644);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelFilter);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAppProtokolDetails";
            this.Text = "Протокол";
            this.Load += new System.EventHandler(this.frmAppProtokolDetails_Load);
            this.Shown += new System.EventHandler(this.frmAppProtokolDetails_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.CheckBox Pinner;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnExportExcell;
        private System.Windows.Forms.DateTimePicker time1;
        private System.Windows.Forms.DateTimePicker time2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReject;
        private PresentationControls.CheckBoxComboBox cbFilterOperator;
        private System.Windows.Forms.Label label11;
        private PresentationControls.CheckBoxComboBox cbFilterCardID;
        private System.Windows.Forms.Label label10;
        private PresentationControls.CheckBoxComboBox cbFilterPOS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblCountRows;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel slblPosition;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel slblSumm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSep1;
        private System.Windows.Forms.ToolStripMenuItem tsbtnFilterFrom;
        private System.Windows.Forms.ToolStripMenuItem tsbtnFilterTo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsbtnFilterClear;
        private System.Windows.Forms.ToolStripMenuItem tsbtnFilterFromLong;
        private System.Windows.Forms.ToolStripMenuItem tsbtnFilterToLong;
        private System.Windows.Forms.TextBox cbFilterGoods;
        private System.Windows.Forms.TextBox cbFilterGoodsID;
        private PresentationControls.CheckBoxComboBox cbFilterOperation;
        private System.Windows.Forms.ToolStripMenuItem tsbtnSales;
        private System.Windows.Forms.ToolStripMenuItem tsbtnActions;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuColumns;
        private PresentationControls.CheckBoxComboBox HS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}