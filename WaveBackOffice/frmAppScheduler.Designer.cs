namespace WaveBackOffice
{
    partial class frmAppScheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppScheduler));
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDoneTasks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnRegular = new System.Windows.Forms.RadioButton();
            this.rbtnMarketing = new System.Windows.Forms.RadioButton();
            this.rbtnDirs = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitAll = new System.Windows.Forms.Button();
            this.chkAllTasks = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoneTasks)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 430);
            this.panel3.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTasks);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 430);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ожидают подтверждения";
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTasks.Location = new System.Drawing.Point(3, 16);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(693, 411);
            this.dgvTasks.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 200);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDoneTasks);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подтвержденные задачи";
            // 
            // dgvDoneTasks
            // 
            this.dgvDoneTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoneTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoneTasks.Location = new System.Drawing.Point(3, 16);
            this.dgvDoneTasks.Name = "dgvDoneTasks";
            this.dgvDoneTasks.Size = new System.Drawing.Size(693, 181);
            this.dgvDoneTasks.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.chkAllTasks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(699, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 630);
            this.panel1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnRegular);
            this.groupBox4.Controls.Add(this.rbtnMarketing);
            this.groupBox4.Controls.Add(this.rbtnDirs);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(3, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 93);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тип задачи";
            // 
            // rbtnRegular
            // 
            this.rbtnRegular.AutoSize = true;
            this.rbtnRegular.Checked = true;
            this.rbtnRegular.Location = new System.Drawing.Point(9, 19);
            this.rbtnRegular.Name = "rbtnRegular";
            this.rbtnRegular.Size = new System.Drawing.Size(124, 17);
            this.rbtnRegular.TabIndex = 2;
            this.rbtnRegular.TabStop = true;
            this.rbtnRegular.Text = "Регулярные задачи";
            this.rbtnRegular.UseVisualStyleBackColor = true;
            // 
            // rbtnMarketing
            // 
            this.rbtnMarketing.AutoSize = true;
            this.rbtnMarketing.Location = new System.Drawing.Point(9, 65);
            this.rbtnMarketing.Name = "rbtnMarketing";
            this.rbtnMarketing.Size = new System.Drawing.Size(144, 17);
            this.rbtnMarketing.TabIndex = 1;
            this.rbtnMarketing.Text = "Маркетинговые задачи";
            this.rbtnMarketing.UseVisualStyleBackColor = true;
            // 
            // rbtnDirs
            // 
            this.rbtnDirs.AutoSize = true;
            this.rbtnDirs.Location = new System.Drawing.Point(9, 42);
            this.rbtnDirs.Name = "rbtnDirs";
            this.rbtnDirs.Size = new System.Drawing.Size(112, 17);
            this.rbtnDirs.TabIndex = 0;
            this.rbtnDirs.Text = "Обновление POS";
            this.rbtnDirs.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnCancelAll);
            this.groupBox3.Controls.Add(this.btnSubmit);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnSubmitAll);
            this.groupBox3.Location = new System.Drawing.Point(3, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 111);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Действия";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(132, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.Location = new System.Drawing.Point(132, 76);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(112, 23);
            this.btnCancelAll.TabIndex = 5;
            this.btnCancelAll.Text = "Отменить все";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(9, 47);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Подтвердить";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(9, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmitAll
            // 
            this.btnSubmitAll.Location = new System.Drawing.Point(132, 47);
            this.btnSubmitAll.Name = "btnSubmitAll";
            this.btnSubmitAll.Size = new System.Drawing.Size(112, 23);
            this.btnSubmitAll.TabIndex = 3;
            this.btnSubmitAll.Text = "Подтвердить все";
            this.btnSubmitAll.UseVisualStyleBackColor = true;
            // 
            // chkAllTasks
            // 
            this.chkAllTasks.AutoSize = true;
            this.chkAllTasks.Checked = true;
            this.chkAllTasks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllTasks.Location = new System.Drawing.Point(12, 16);
            this.chkAllTasks.Name = "chkAllTasks";
            this.chkAllTasks.Size = new System.Drawing.Size(124, 17);
            this.chkAllTasks.TabIndex = 1;
            this.chkAllTasks.Text = "Только мои задачи";
            this.chkAllTasks.UseVisualStyleBackColor = true;
            this.chkAllTasks.CheckedChanged += new System.EventHandler(this.chkAllTasks_CheckedChanged);
            // 
            // frmAppScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 630);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAppScheduler";
            this.Text = "Планировщик";
            this.Shown += new System.EventHandler(this.frmAppScheduler_Shown);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoneTasks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDoneTasks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmitAll;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkAllTasks;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnRegular;
        private System.Windows.Forms.RadioButton rbtnMarketing;
        private System.Windows.Forms.RadioButton rbtnDirs;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}