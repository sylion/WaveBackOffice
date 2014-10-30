namespace WaveBackOffice
{
    partial class frmAppMarketing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppMarketing));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbValues = new System.Windows.Forms.GroupBox();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.btnValue2 = new System.Windows.Forms.Button();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.btnValue1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValueRFM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.dgvValues = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tslblSavedValues = new System.Windows.Forms.ToolStripLabel();
            this.btnSavedLoad = new System.Windows.Forms.ToolStripButton();
            this.btnSavedDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSavedCompare = new System.Windows.Forms.ToolStripButton();
            this.btnSavedExport = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.gbValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValues)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.gbValues);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(744, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 585);
            this.panel1.TabIndex = 0;
            // 
            // gbValues
            // 
            this.gbValues.Controls.Add(this.date1);
            this.gbValues.Controls.Add(this.btnValue2);
            this.gbValues.Controls.Add(this.date2);
            this.gbValues.Controls.Add(this.btnValue1);
            this.gbValues.Controls.Add(this.label3);
            this.gbValues.Controls.Add(this.btnValueRFM);
            this.gbValues.Controls.Add(this.label2);
            this.gbValues.Location = new System.Drawing.Point(22, 6);
            this.gbValues.Name = "gbValues";
            this.gbValues.Size = new System.Drawing.Size(200, 222);
            this.gbValues.TabIndex = 11;
            this.gbValues.TabStop = false;
            this.gbValues.Text = "Отчеты";
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(15, 36);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(170, 20);
            this.date1.TabIndex = 5;
            // 
            // btnValue2
            // 
            this.btnValue2.Enabled = false;
            this.btnValue2.Location = new System.Drawing.Point(15, 188);
            this.btnValue2.Name = "btnValue2";
            this.btnValue2.Size = new System.Drawing.Size(170, 23);
            this.btnValue2.TabIndex = 10;
            this.btnValue2.Text = "Еще отчет";
            this.btnValue2.UseVisualStyleBackColor = true;
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(15, 82);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(170, 20);
            this.date2.TabIndex = 6;
            // 
            // btnValue1
            // 
            this.btnValue1.Enabled = false;
            this.btnValue1.Location = new System.Drawing.Point(15, 159);
            this.btnValue1.Name = "btnValue1";
            this.btnValue1.Size = new System.Drawing.Size(170, 23);
            this.btnValue1.TabIndex = 2;
            this.btnValue1.Text = "Еще отчет";
            this.btnValue1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Период с:";
            // 
            // btnValueRFM
            // 
            this.btnValueRFM.Location = new System.Drawing.Point(15, 130);
            this.btnValueRFM.Name = "btnValueRFM";
            this.btnValueRFM.Size = new System.Drawing.Size(170, 23);
            this.btnValueRFM.TabIndex = 9;
            this.btnValueRFM.Text = "RFM Отчет";
            this.btnValueRFM.UseVisualStyleBackColor = true;
            this.btnValueRFM.Click += new System.EventHandler(this.btnValueRFM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "По:";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 610);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(994, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // dgvValues
            // 
            this.dgvValues.AllowUserToAddRows = false;
            this.dgvValues.AllowUserToDeleteRows = false;
            this.dgvValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvValues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvValues.Location = new System.Drawing.Point(0, 25);
            this.dgvValues.Name = "dgvValues";
            this.dgvValues.Size = new System.Drawing.Size(744, 585);
            this.dgvValues.TabIndex = 3;
            this.dgvValues.Sorted += new System.EventHandler(this.dgvValues_Sorted);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblSavedValues,
            this.btnSavedLoad,
            this.btnSavedDelete,
            this.btnSavedCompare,
            this.btnSavedExport});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(994, 25);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tslblSavedValues
            // 
            this.tslblSavedValues.Name = "tslblSavedValues";
            this.tslblSavedValues.Size = new System.Drawing.Size(127, 22);
            this.tslblSavedValues.Text = "Сохраненные отчеты:";
            // 
            // btnSavedLoad
            // 
            this.btnSavedLoad.Enabled = false;
            this.btnSavedLoad.Image = global::WaveBackOffice.Properties.Resources.image_loading;
            this.btnSavedLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavedLoad.Name = "btnSavedLoad";
            this.btnSavedLoad.Size = new System.Drawing.Size(81, 22);
            this.btnSavedLoad.Text = "Загрузить";
            // 
            // btnSavedDelete
            // 
            this.btnSavedDelete.Enabled = false;
            this.btnSavedDelete.Image = global::WaveBackOffice.Properties.Resources.gtk_delete;
            this.btnSavedDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavedDelete.Name = "btnSavedDelete";
            this.btnSavedDelete.Size = new System.Drawing.Size(71, 22);
            this.btnSavedDelete.Text = "Удалить";
            // 
            // btnSavedCompare
            // 
            this.btnSavedCompare.Enabled = false;
            this.btnSavedCompare.Image = global::WaveBackOffice.Properties.Resources.gtk_copy;
            this.btnSavedCompare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavedCompare.Name = "btnSavedCompare";
            this.btnSavedCompare.Size = new System.Drawing.Size(79, 22);
            this.btnSavedCompare.Text = "Сравнить";
            // 
            // btnSavedExport
            // 
            this.btnSavedExport.Enabled = false;
            this.btnSavedExport.Image = global::WaveBackOffice.Properties.Resources.export;
            this.btnSavedExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavedExport.Name = "btnSavedExport";
            this.btnSavedExport.Size = new System.Drawing.Size(72, 22);
            this.btnSavedExport.Text = "Экспорт";
            // 
            // frmAppMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 632);
            this.Controls.Add(this.dgvValues);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAppMarketing";
            this.Text = "Маркетинг";
            this.panel1.ResumeLayout(false);
            this.gbValues.ResumeLayout(false);
            this.gbValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValues)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button btnValueRFM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button btnValue2;
        private System.Windows.Forms.Button btnValue1;
        private System.Windows.Forms.GroupBox gbValues;
        private System.Windows.Forms.DataGridView dgvValues;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel tslblSavedValues;
        private System.Windows.Forms.ToolStripButton btnSavedDelete;
        private System.Windows.Forms.ToolStripButton btnSavedCompare;
        private System.Windows.Forms.ToolStripButton btnSavedLoad;
        private System.Windows.Forms.ToolStripButton btnSavedExport;
    }
}