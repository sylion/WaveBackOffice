namespace WaveBackOffice
{
    partial class frmDirectoryPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirectoryPOS));
            this.treeViewPOS = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnCreate = new System.Windows.Forms.ToolStripSplitButton();
            this.btnCreateGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateObject = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreatePOS = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewPOS
            // 
            this.treeViewPOS.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewPOS.ImageIndex = 0;
            this.treeViewPOS.ImageList = this.imageList;
            this.treeViewPOS.Location = new System.Drawing.Point(0, 25);
            this.treeViewPOS.Name = "treeViewPOS";
            this.treeViewPOS.SelectedImageIndex = 0;
            this.treeViewPOS.Size = new System.Drawing.Size(234, 369);
            this.treeViewPOS.TabIndex = 1;
            this.treeViewPOS.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPOS_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder.png");
            this.imageList.Images.SetKeyName(1, "gtk-file.png");
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(234, 25);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.Size = new System.Drawing.Size(481, 369);
            this.dgvDetails.TabIndex = 2;
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnEdit,
            this.btnDelete});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(715, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip";
            // 
            // btnCreate
            // 
            this.btnCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateGroup,
            this.btnCreateObject,
            this.btnCreatePOS});
            this.btnCreate.Image = global::WaveBackOffice.Properties.Resources.gtk_new;
            this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(82, 22);
            this.btnCreate.Text = "Создать";
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(114, 22);
            this.btnCreateGroup.Text = "Группу";
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(114, 22);
            this.btnCreateObject.Text = "Объект";
            this.btnCreateObject.Click += new System.EventHandler(this.btnCreateObject_Click);
            // 
            // btnCreatePOS
            // 
            this.btnCreatePOS.Name = "btnCreatePOS";
            this.btnCreatePOS.Size = new System.Drawing.Size(114, 22);
            this.btnCreatePOS.Text = "POS";
            this.btnCreatePOS.Click += new System.EventHandler(this.btnCreatePOS_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::WaveBackOffice.Properties.Resources.gtk_edit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 22);
            this.btnEdit.Text = "Изменить";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::WaveBackOffice.Properties.Resources.gtk_delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 22);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDirectoryPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 394);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.treeViewPOS);
            this.Controls.Add(this.toolStrip);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDirectoryPOS";
            this.Text = "Справочник POS";
            this.Load += new System.EventHandler(this.frmDirectoryPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewPOS;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton btnCreate;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnCreateGroup;
        private System.Windows.Forms.ToolStripMenuItem btnCreateObject;
        private System.Windows.Forms.ToolStripMenuItem btnCreatePOS;
        private System.Windows.Forms.ImageList imageList;
    }
}