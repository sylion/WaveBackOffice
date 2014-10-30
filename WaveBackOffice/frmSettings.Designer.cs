namespace WaveBackOffice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDBAddress = new System.Windows.Forms.TextBox();
            this.tbDBPort = new System.Windows.Forms.TextBox();
            this.tbDBLogin = new System.Windows.Forms.TextBox();
            this.tbDBPwd = new System.Windows.Forms.TextBox();
            this.tbDBName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес базы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Порт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя базы:";
            // 
            // tbDBAddress
            // 
            this.tbDBAddress.Location = new System.Drawing.Point(154, 6);
            this.tbDBAddress.Name = "tbDBAddress";
            this.tbDBAddress.Size = new System.Drawing.Size(193, 20);
            this.tbDBAddress.TabIndex = 5;
            // 
            // tbDBPort
            // 
            this.tbDBPort.Location = new System.Drawing.Point(154, 34);
            this.tbDBPort.Name = "tbDBPort";
            this.tbDBPort.Size = new System.Drawing.Size(193, 20);
            this.tbDBPort.TabIndex = 6;
            // 
            // tbDBLogin
            // 
            this.tbDBLogin.Location = new System.Drawing.Point(154, 60);
            this.tbDBLogin.Name = "tbDBLogin";
            this.tbDBLogin.Size = new System.Drawing.Size(193, 20);
            this.tbDBLogin.TabIndex = 7;
            // 
            // tbDBPwd
            // 
            this.tbDBPwd.Location = new System.Drawing.Point(154, 89);
            this.tbDBPwd.Name = "tbDBPwd";
            this.tbDBPwd.PasswordChar = '*';
            this.tbDBPwd.Size = new System.Drawing.Size(193, 20);
            this.tbDBPwd.TabIndex = 8;
            // 
            // tbDBName
            // 
            this.tbDBName.Location = new System.Drawing.Point(154, 115);
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(193, 20);
            this.tbDBName.TabIndex = 9;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(272, 146);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(180, 146);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(75, 23);
            this.btnTestConnection.TabIndex = 11;
            this.btnTestConnection.Text = "Проверить";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(12, 146);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(85, 23);
            this.btnCreateDB.TabIndex = 12;
            this.btnCreateDB.Text = "Создать базу";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 176);
            this.Controls.Add(this.btnCreateDB);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbDBName);
            this.Controls.Add(this.tbDBPwd);
            this.Controls.Add(this.tbDBLogin);
            this.Controls.Add(this.tbDBPort);
            this.Controls.Add(this.tbDBAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(376, 215);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки соединения";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDBAddress;
        private System.Windows.Forms.TextBox tbDBPort;
        private System.Windows.Forms.TextBox tbDBLogin;
        private System.Windows.Forms.TextBox tbDBPwd;
        private System.Windows.Forms.TextBox tbDBName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnCreateDB;
    }
}