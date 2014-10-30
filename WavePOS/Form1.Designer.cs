namespace WavePOS
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.mbtnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mbtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.panelTool = new System.Windows.Forms.ToolStrip();
            this.toolbtnNullCheck = new System.Windows.Forms.ToolStripButton();
            this.toolbtnInOut = new System.Windows.Forms.ToolStripButton();
            this.toolbtnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.panelMain.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelPrice.SuspendLayout();
            this.panelTool.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelPrice);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(82, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1159, 623);
            this.panelMain.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnFile,
            this.продажиToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1241, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 647);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1241, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // mbtnFile
            // 
            this.mbtnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mbtnExit});
            this.mbtnFile.Name = "mbtnFile";
            this.mbtnFile.Size = new System.Drawing.Size(48, 20);
            this.mbtnFile.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mbtnExit
            // 
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Size = new System.Drawing.Size(152, 22);
            this.mbtnExit.Text = "Выход";
            // 
            // panelPrice
            // 
            this.panelPrice.BackColor = System.Drawing.SystemColors.Control;
            this.panelPrice.Controls.Add(this.maskedTextBox5);
            this.panelPrice.Controls.Add(this.maskedTextBox6);
            this.panelPrice.Controls.Add(this.maskedTextBox3);
            this.panelPrice.Controls.Add(this.maskedTextBox4);
            this.panelPrice.Controls.Add(this.maskedTextBox2);
            this.panelPrice.Controls.Add(this.maskedTextBox1);
            this.panelPrice.Controls.Add(this.label6);
            this.panelPrice.Controls.Add(this.label5);
            this.panelPrice.Controls.Add(this.label4);
            this.panelPrice.Controls.Add(this.label3);
            this.panelPrice.Controls.Add(this.label2);
            this.panelPrice.Controls.Add(this.label1);
            this.panelPrice.Location = new System.Drawing.Point(3, 3);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(485, 199);
            this.panelPrice.TabIndex = 0;
            // 
            // panelTool
            // 
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.panelTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnNullCheck,
            this.toolbtnInOut,
            this.toolbtnClear,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.panelTool.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.panelTool.Location = new System.Drawing.Point(0, 24);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(82, 623);
            this.panelTool.TabIndex = 1;
            this.panelTool.Text = "toolStrip1";
            // 
            // toolbtnNullCheck
            // 
            this.toolbtnNullCheck.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnNullCheck.Image")));
            this.toolbtnNullCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnNullCheck.Name = "toolbtnNullCheck";
            this.toolbtnNullCheck.Size = new System.Drawing.Size(79, 35);
            this.toolbtnNullCheck.Text = "Нулевой чек";
            this.toolbtnNullCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolbtnInOut
            // 
            this.toolbtnInOut.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnInOut.Image")));
            this.toolbtnInOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnInOut.Name = "toolbtnInOut";
            this.toolbtnInOut.Size = new System.Drawing.Size(79, 35);
            this.toolbtnInOut.Text = "Внос\\Вынос";
            this.toolbtnInOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolbtnClear
            // 
            this.toolbtnClear.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnClear.Image")));
            this.toolbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnClear.Name = "toolbtnClear";
            this.toolbtnClear.Size = new System.Drawing.Size(79, 35);
            this.toolbtnClear.Text = "Очистить";
            this.toolbtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(79, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButton1.Checked = true;
            this.toolStripButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(79, 20);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 412);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(748, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 617);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.продажиToolStripMenuItem.Text = "Продажи";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1152, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(410, 617);
            this.dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(337, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сумма:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(148, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Код \\ Штрихкод:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(148, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Стоимость:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(337, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "К оплате:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.maskedTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox1.Location = new System.Drawing.Point(340, 26);
            this.maskedTextBox1.Mask = "0.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(135, 33);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.TabStop = false;
            this.maskedTextBox1.Text = "000";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.maskedTextBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox2.Location = new System.Drawing.Point(340, 84);
            this.maskedTextBox2.Mask = "0.00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(135, 33);
            this.maskedTextBox2.TabIndex = 17;
            this.maskedTextBox2.TabStop = false;
            this.maskedTextBox2.Text = "000";
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.maskedTextBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox3.Location = new System.Drawing.Point(151, 84);
            this.maskedTextBox3.Mask = "0.00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.ReadOnly = true;
            this.maskedTextBox3.Size = new System.Drawing.Size(183, 33);
            this.maskedTextBox3.TabIndex = 19;
            this.maskedTextBox3.TabStop = false;
            this.maskedTextBox3.Text = "000";
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.maskedTextBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox4.Location = new System.Drawing.Point(151, 26);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(183, 33);
            this.maskedTextBox4.TabIndex = 18;
            this.maskedTextBox4.TabStop = false;
            this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.maskedTextBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maskedTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox5.Location = new System.Drawing.Point(10, 84);
            this.maskedTextBox5.Mask = "0.00";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.ReadOnly = true;
            this.maskedTextBox5.Size = new System.Drawing.Size(135, 33);
            this.maskedTextBox5.TabIndex = 21;
            this.maskedTextBox5.TabStop = false;
            this.maskedTextBox5.Text = "000";
            this.maskedTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.maskedTextBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maskedTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox6.ForeColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox6.Location = new System.Drawing.Point(10, 26);
            this.maskedTextBox6.Mask = "0.00";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.ReadOnly = true;
            this.maskedTextBox6.Size = new System.Drawing.Size(135, 33);
            this.maskedTextBox6.TabIndex = 20;
            this.maskedTextBox6.TabStop = false;
            this.maskedTextBox6.Text = "000";
            this.maskedTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 669);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTool);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(955, 655);
            this.Name = "frmMain";
            this.Text = "Wave POS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mbtnFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mbtnExit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panelPrice;
        private System.Windows.Forms.ToolStrip panelTool;
        private System.Windows.Forms.ToolStripButton toolbtnNullCheck;
        private System.Windows.Forms.ToolStripButton toolbtnInOut;
        private System.Windows.Forms.ToolStripButton toolbtnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
    }
}

