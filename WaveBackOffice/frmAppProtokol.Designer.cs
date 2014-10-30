namespace WaveBackOffice
{
    partial class frmAppProtokol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppProtokol));
            this.panelToolbox = new System.Windows.Forms.Panel();
            this.date2 = new System.Windows.Forms.MonthCalendar();
            this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.date1 = new System.Windows.Forms.MonthCalendar();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDirPOS = new System.Windows.Forms.Button();
            this.treeViewPOS = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.dgvProtocol = new System.Windows.Forms.DataGridView();
            this.dgwTotal = new System.Windows.Forms.DataGridView();
            this.tabFiscals = new System.Windows.Forms.TabPage();
            this.dgwFiscal = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProtokolPalitra = new System.Windows.Forms.Button();
            this.btnProtAction = new System.Windows.Forms.Button();
            this.btnProtSales = new System.Windows.Forms.Button();
            this.panelToolbox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTotal)).BeginInit();
            this.tabFiscals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiscal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolbox
            // 
            this.panelToolbox.AutoScroll = true;
            this.panelToolbox.Controls.Add(this.date2);
            this.panelToolbox.Controls.Add(this.date1);
            this.panelToolbox.Controls.Add(this.btnDirPOS);
            this.panelToolbox.Controls.Add(this.treeViewPOS);
            this.panelToolbox.Controls.Add(this.label2);
            this.panelToolbox.Controls.Add(this.label1);
            this.panelToolbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelToolbox.Location = new System.Drawing.Point(0, 0);
            this.panelToolbox.Name = "panelToolbox";
            this.panelToolbox.Size = new System.Drawing.Size(200, 615);
            this.panelToolbox.TabIndex = 4;
            // 
            // date2
            // 
            this.date2.ContextMenuStrip = this.contextMenu1;
            this.date2.Location = new System.Drawing.Point(15, 211);
            this.date2.MaxSelectionCount = 1;
            this.date2.Name = "date2";
            this.date2.TabIndex = 7;
            this.date2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.date2_DateChanged);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu";
            this.contextMenu1.Size = new System.Drawing.Size(61, 4);
            this.contextMenu1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu1_Opening);
            // 
            // date1
            // 
            this.date1.ContextMenuStrip = this.contextMenu;
            this.date1.Location = new System.Drawing.Point(15, 24);
            this.date1.MaxSelectionCount = 1;
            this.date1.Name = "date1";
            this.date1.TabIndex = 6;
            this.date1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.date1_DateChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(61, 4);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // btnDirPOS
            // 
            this.btnDirPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDirPOS.ForeColor = System.Drawing.Color.Black;
            this.btnDirPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirPOS.Location = new System.Drawing.Point(2, 376);
            this.btnDirPOS.Name = "btnDirPOS";
            this.btnDirPOS.Size = new System.Drawing.Size(197, 23);
            this.btnDirPOS.TabIndex = 5;
            this.btnDirPOS.Text = "Справочник POS";
            this.btnDirPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDirPOS.UseVisualStyleBackColor = true;
            this.btnDirPOS.Click += new System.EventHandler(this.btnDirPOS_Click);
            // 
            // treeViewPOS
            // 
            this.treeViewPOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewPOS.ImageIndex = 0;
            this.treeViewPOS.ImageList = this.imageList;
            this.treeViewPOS.Location = new System.Drawing.Point(2, 398);
            this.treeViewPOS.Name = "treeViewPOS";
            this.treeViewPOS.SelectedImageIndex = 0;
            this.treeViewPOS.Size = new System.Drawing.Size(197, 215);
            this.treeViewPOS.TabIndex = 0;
            this.treeViewPOS.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPOS_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder.png");
            this.imageList.Images.SetKeyName(1, "gtk-file.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "По:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Период с:";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabSales);
            this.tabControl.Controls.Add(this.tabFiscals);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(200, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(960, 576);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.dgvProtocol);
            this.tabSales.Controls.Add(this.dgwTotal);
            this.tabSales.Location = new System.Drawing.Point(4, 24);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(952, 548);
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "Продажи";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // dgvProtocol
            // 
            this.dgvProtocol.AllowUserToAddRows = false;
            this.dgvProtocol.AllowUserToDeleteRows = false;
            this.dgvProtocol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProtocol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProtocol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProtocol.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProtocol.Location = new System.Drawing.Point(3, 3);
            this.dgvProtocol.MultiSelect = false;
            this.dgvProtocol.Name = "dgvProtocol";
            this.dgvProtocol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProtocol.Size = new System.Drawing.Size(946, 520);
            this.dgvProtocol.StandardTab = true;
            this.dgvProtocol.TabIndex = 0;
            this.dgvProtocol.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgwProtocol_ColumnWidthChanged);
            this.dgvProtocol.Resize += new System.EventHandler(this.dgwProtocol_Resize);
            // 
            // dgwTotal
            // 
            this.dgwTotal.AllowUserToAddRows = false;
            this.dgwTotal.AllowUserToDeleteRows = false;
            this.dgwTotal.AllowUserToResizeColumns = false;
            this.dgwTotal.AllowUserToResizeRows = false;
            this.dgwTotal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgwTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwTotal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwTotal.Location = new System.Drawing.Point(3, 523);
            this.dgwTotal.Name = "dgwTotal";
            this.dgwTotal.Size = new System.Drawing.Size(946, 22);
            this.dgwTotal.TabIndex = 1;
            // 
            // tabFiscals
            // 
            this.tabFiscals.Controls.Add(this.dgwFiscal);
            this.tabFiscals.Location = new System.Drawing.Point(4, 24);
            this.tabFiscals.Name = "tabFiscals";
            this.tabFiscals.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiscals.Size = new System.Drawing.Size(952, 548);
            this.tabFiscals.TabIndex = 1;
            this.tabFiscals.Text = "Фискальные отчеты";
            this.tabFiscals.UseVisualStyleBackColor = true;
            // 
            // dgwFiscal
            // 
            this.dgwFiscal.AllowUserToAddRows = false;
            this.dgwFiscal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFiscal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwFiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFiscal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwFiscal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwFiscal.Location = new System.Drawing.Point(3, 3);
            this.dgwFiscal.Name = "dgwFiscal";
            this.dgwFiscal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFiscal.Size = new System.Drawing.Size(946, 542);
            this.dgwFiscal.StandardTab = true;
            this.dgwFiscal.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProtokolPalitra);
            this.panel1.Controls.Add(this.btnProtAction);
            this.panel1.Controls.Add(this.btnProtSales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(200, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 42);
            this.panel1.TabIndex = 6;
            // 
            // btnProtokolPalitra
            // 
            this.btnProtokolPalitra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProtokolPalitra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProtokolPalitra.Location = new System.Drawing.Point(776, 9);
            this.btnProtokolPalitra.Name = "btnProtokolPalitra";
            this.btnProtokolPalitra.Size = new System.Drawing.Size(180, 23);
            this.btnProtokolPalitra.TabIndex = 2;
            this.btnProtokolPalitra.Text = "Настройка палитры";
            this.btnProtokolPalitra.UseVisualStyleBackColor = true;
            this.btnProtokolPalitra.Click += new System.EventHandler(this.btnProtokolPalitra_Click);
            // 
            // btnProtAction
            // 
            this.btnProtAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProtAction.Location = new System.Drawing.Point(193, 9);
            this.btnProtAction.Name = "btnProtAction";
            this.btnProtAction.Size = new System.Drawing.Size(180, 23);
            this.btnProtAction.TabIndex = 1;
            this.btnProtAction.Text = "Протокол действий";
            this.btnProtAction.UseVisualStyleBackColor = true;
            this.btnProtAction.Click += new System.EventHandler(this.btnProtAction_Click);
            // 
            // btnProtSales
            // 
            this.btnProtSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProtSales.Location = new System.Drawing.Point(7, 9);
            this.btnProtSales.Name = "btnProtSales";
            this.btnProtSales.Size = new System.Drawing.Size(180, 23);
            this.btnProtSales.TabIndex = 0;
            this.btnProtSales.Text = "Протокол продаж";
            this.btnProtSales.UseVisualStyleBackColor = true;
            this.btnProtSales.Click += new System.EventHandler(this.btnProtSales_Click);
            // 
            // frmAppProtokol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelToolbox);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAppProtokol";
            this.Text = "Протоколы";
            this.Load += new System.EventHandler(this.frmAppProtokol_Load);
            this.Shown += new System.EventHandler(this.frmAppProtokol_Shown);
            this.panelToolbox.ResumeLayout(false);
            this.panelToolbox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTotal)).EndInit();
            this.tabFiscals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiscal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolbox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TabPage tabFiscals;
        private System.Windows.Forms.DataGridView dgvProtocol;
        private System.Windows.Forms.DataGridView dgwFiscal;
        private System.Windows.Forms.TreeView treeViewPOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDirPOS;
        private System.Windows.Forms.Button btnProtAction;
        private System.Windows.Forms.Button btnProtSales;
        private System.Windows.Forms.Button btnProtokolPalitra;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.DataGridView dgwTotal;
        private System.Windows.Forms.MonthCalendar date2;
        private System.Windows.Forms.MonthCalendar date1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenu1;


    }
}