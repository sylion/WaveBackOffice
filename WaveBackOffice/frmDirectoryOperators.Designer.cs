namespace WaveBackOffice
{
    partial class frmDirectoryOperators
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirectoryOperators));
            this.panelToolbox = new System.Windows.Forms.Panel();
            this.treeViewPOS = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnDirPOS = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbShowDeleted = new System.Windows.Forms.CheckBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panelToolbox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolbox
            // 
            this.panelToolbox.AutoScroll = true;
            this.panelToolbox.Controls.Add(this.treeViewPOS);
            this.panelToolbox.Controls.Add(this.btnDirPOS);
            this.panelToolbox.Controls.Add(this.panel1);
            this.panelToolbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelToolbox.Location = new System.Drawing.Point(0, 0);
            this.panelToolbox.Name = "panelToolbox";
            this.panelToolbox.Size = new System.Drawing.Size(200, 635);
            this.panelToolbox.TabIndex = 5;
            // 
            // treeViewPOS
            // 
            this.treeViewPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewPOS.ImageIndex = 0;
            this.treeViewPOS.ImageList = this.imageList;
            this.treeViewPOS.Location = new System.Drawing.Point(0, 90);
            this.treeViewPOS.Name = "treeViewPOS";
            this.treeViewPOS.SelectedImageIndex = 0;
            this.treeViewPOS.Size = new System.Drawing.Size(200, 545);
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
            // btnDirPOS
            // 
            this.btnDirPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDirPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDirPOS.ForeColor = System.Drawing.Color.Black;
            this.btnDirPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirPOS.Location = new System.Drawing.Point(0, 67);
            this.btnDirPOS.Name = "btnDirPOS";
            this.btnDirPOS.Size = new System.Drawing.Size(200, 23);
            this.btnDirPOS.TabIndex = 5;
            this.btnDirPOS.Text = "Справочник POS";
            this.btnDirPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDirPOS.UseVisualStyleBackColor = true;
            this.btnDirPOS.Click += new System.EventHandler(this.btnDirPOS_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cbShowDeleted);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 67);
            this.panel1.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(109, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Создать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbShowDeleted
            // 
            this.cbShowDeleted.AutoSize = true;
            this.cbShowDeleted.Location = new System.Drawing.Point(12, 41);
            this.cbShowDeleted.Name = "cbShowDeleted";
            this.cbShowDeleted.Size = new System.Drawing.Size(132, 17);
            this.cbShowDeleted.TabIndex = 0;
            this.cbShowDeleted.Text = "Показать удаленных";
            this.cbShowDeleted.UseVisualStyleBackColor = true;
            this.cbShowDeleted.CheckedChanged += new System.EventHandler(this.cbShowDeleted_CheckedChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsers.Location = new System.Drawing.Point(200, 0);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(647, 635);
            this.dgvUsers.TabIndex = 6;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            this.dgvUsers.Sorted += new System.EventHandler(this.dgvUsers_Sorted);
            // 
            // frmDirectoryOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 635);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panelToolbox);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDirectoryOperators";
            this.Text = "Справочник операторов";
            this.Load += new System.EventHandler(this.frmDirectoryOperators_Load);
            this.Shown += new System.EventHandler(this.frmDirectoryOperators_Shown);
            this.panelToolbox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolbox;
        private System.Windows.Forms.Button btnDirPOS;
        private System.Windows.Forms.TreeView treeViewPOS;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbShowDeleted;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}