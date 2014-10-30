namespace WaveBackOffice
{
    partial class frmProtokolPalitra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProtokolPalitra));
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvColors.Location = new System.Drawing.Point(0, 0);
            this.dgvColors.MultiSelect = false;
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColors.Size = new System.Drawing.Size(519, 497);
            this.dgvColors.TabIndex = 0;
            this.dgvColors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwColors_CellDoubleClick);
            // 
            // colorDlg
            // 
            this.colorDlg.FullOpen = true;
            // 
            // frmProtokolPalitra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(519, 497);
            this.Controls.Add(this.dgvColors);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProtokolPalitra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Палитра цветов";
            this.Shown += new System.EventHandler(this.frmProtokolPalitra_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.ColorDialog colorDlg;
    }
}