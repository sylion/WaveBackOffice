namespace WaveBackOffice
{
    partial class frmDirectoryOperatorsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirectoryOperatorsDetails));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.valMask = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.c13 = new System.Windows.Forms.CheckBox();
            this.c12 = new System.Windows.Forms.CheckBox();
            this.c11 = new System.Windows.Forms.CheckBox();
            this.c10 = new System.Windows.Forms.CheckBox();
            this.c9 = new System.Windows.Forms.CheckBox();
            this.c8 = new System.Windows.Forms.CheckBox();
            this.c7 = new System.Windows.Forms.CheckBox();
            this.c6 = new System.Windows.Forms.CheckBox();
            this.c5 = new System.Windows.Forms.CheckBox();
            this.c4 = new System.Windows.Forms.CheckBox();
            this.c3 = new System.Windows.Forms.CheckBox();
            this.c2 = new System.Windows.Forms.CheckBox();
            this.c1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.tbDateDelete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbmagneCardCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPOS = new System.Windows.Forms.ComboBox();
            this.tbObj = new System.Windows.Forms.ComboBox();
            this.tbGroup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbNotactive = new System.Windows.Forms.CheckBox();
            this.tbCashpwd = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.valMask);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.c13);
            this.groupBox2.Controls.Add(this.c12);
            this.groupBox2.Controls.Add(this.c11);
            this.groupBox2.Controls.Add(this.c10);
            this.groupBox2.Controls.Add(this.c9);
            this.groupBox2.Controls.Add(this.c8);
            this.groupBox2.Controls.Add(this.c7);
            this.groupBox2.Controls.Add(this.c6);
            this.groupBox2.Controls.Add(this.c5);
            this.groupBox2.Controls.Add(this.c4);
            this.groupBox2.Controls.Add(this.c3);
            this.groupBox2.Controls.Add(this.c2);
            this.groupBox2.Controls.Add(this.c1);
            this.groupBox2.Location = new System.Drawing.Point(7, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 236);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Права доступа";
            // 
            // valMask
            // 
            this.valMask.Location = new System.Drawing.Point(125, 93);
            this.valMask.Mask = "0000";
            this.valMask.Name = "valMask";
            this.valMask.Size = new System.Drawing.Size(49, 20);
            this.valMask.TabIndex = 27;
            this.valMask.KeyUp += new System.Windows.Forms.KeyEventHandler(this.valMask_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Маска прав:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(550, 115);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // c13
            // 
            this.c13.AutoSize = true;
            this.c13.Location = new System.Drawing.Point(408, 75);
            this.c13.Name = "c13";
            this.c13.Size = new System.Drawing.Size(130, 17);
            this.c13.TabIndex = 24;
            this.c13.Text = "Аннулирование чека";
            this.c13.UseVisualStyleBackColor = true;
            this.c13.CheckStateChanged += new System.EventHandler(this.c13_CheckedChanged);
            // 
            // c12
            // 
            this.c12.AutoSize = true;
            this.c12.Location = new System.Drawing.Point(408, 57);
            this.c12.Name = "c12";
            this.c12.Size = new System.Drawing.Size(149, 17);
            this.c12.TabIndex = 23;
            this.c12.Text = "Аннулирование позиций";
            this.c12.UseVisualStyleBackColor = true;
            this.c12.CheckStateChanged += new System.EventHandler(this.c12_CheckedChanged);
            // 
            // c11
            // 
            this.c11.AutoSize = true;
            this.c11.Location = new System.Drawing.Point(408, 38);
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(68, 17);
            this.c11.TabIndex = 22;
            this.c11.Text = "Возврат";
            this.c11.UseVisualStyleBackColor = true;
            this.c11.CheckStateChanged += new System.EventHandler(this.c11_CheckedChanged);
            // 
            // c10
            // 
            this.c10.AutoSize = true;
            this.c10.Location = new System.Drawing.Point(408, 19);
            this.c10.Name = "c10";
            this.c10.Size = new System.Drawing.Size(124, 17);
            this.c10.TabIndex = 21;
            this.c10.Text = "Просмотр всех цен";
            this.c10.UseVisualStyleBackColor = true;
            this.c10.CheckStateChanged += new System.EventHandler(this.c10_CheckedChanged);
            // 
            // c9
            // 
            this.c9.AutoSize = true;
            this.c9.Location = new System.Drawing.Point(191, 92);
            this.c9.Name = "c9";
            this.c9.Size = new System.Drawing.Size(143, 17);
            this.c9.TabIndex = 20;
            this.c9.Text = "Изменение уровня цен";
            this.c9.UseVisualStyleBackColor = true;
            this.c9.CheckStateChanged += new System.EventHandler(this.c9_CheckedChanged);
            // 
            // c8
            // 
            this.c8.AutoSize = true;
            this.c8.Location = new System.Drawing.Point(191, 75);
            this.c8.Name = "c8";
            this.c8.Size = new System.Drawing.Size(182, 17);
            this.c8.TabIndex = 19;
            this.c8.Text = "Просмотр количества товаров";
            this.c8.UseVisualStyleBackColor = true;
            this.c8.CheckStateChanged += new System.EventHandler(this.c8_CheckedChanged);
            // 
            // c7
            // 
            this.c7.AutoSize = true;
            this.c7.Location = new System.Drawing.Point(191, 57);
            this.c7.Name = "c7";
            this.c7.Size = new System.Drawing.Size(208, 17);
            this.c7.TabIndex = 18;
            this.c7.Text = "Конец смены и фискальные отчеты";
            this.c7.UseVisualStyleBackColor = true;
            this.c7.CheckStateChanged += new System.EventHandler(this.c7_CheckedChanged);
            // 
            // c6
            // 
            this.c6.AutoSize = true;
            this.c6.Location = new System.Drawing.Point(191, 38);
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(203, 17);
            this.c6.TabIndex = 17;
            this.c6.Text = "Предоставление скидок/надбавок";
            this.c6.UseVisualStyleBackColor = true;
            this.c6.CheckStateChanged += new System.EventHandler(this.c6_CheckedChanged);
            // 
            // c5
            // 
            this.c5.AutoSize = true;
            this.c5.Location = new System.Drawing.Point(191, 19);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(190, 17);
            this.c5.TabIndex = 16;
            this.c5.Text = "Просмотр протоколов и отчетов";
            this.c5.UseVisualStyleBackColor = true;
            this.c5.CheckedChanged += new System.EventHandler(this.c5_CheckedChanged);
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Location = new System.Drawing.Point(9, 76);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(123, 17);
            this.c4.TabIndex = 15;
            this.c4.Text = "Конфигурирование";
            this.c4.UseVisualStyleBackColor = true;
            this.c4.CheckedChanged += new System.EventHandler(this.c4_CheckedChanged);
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Location = new System.Drawing.Point(9, 58);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(181, 17);
            this.c3.TabIndex = 14;
            this.c3.Text = "Прием любых видов платежей";
            this.c3.UseVisualStyleBackColor = true;
            this.c3.CheckedChanged += new System.EventHandler(this.c3_CheckedChanged);
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Location = new System.Drawing.Point(9, 39);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(165, 17);
            this.c2.TabIndex = 13;
            this.c2.Text = "Выдача наличных из кассы";
            this.c2.UseVisualStyleBackColor = true;
            this.c2.CheckedChanged += new System.EventHandler(this.c2_CheckedChanged);
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Location = new System.Drawing.Point(9, 20);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(130, 17);
            this.c1.TabIndex = 12;
            this.c1.Text = "Администрирование";
            this.c1.UseVisualStyleBackColor = true;
            this.c1.CheckedChanged += new System.EventHandler(this.c1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbReason);
            this.groupBox1.Controls.Add(this.tbDateDelete);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbmagneCardCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPOS);
            this.groupBox1.Controls.Add(this.tbObj);
            this.groupBox1.Controls.Add(this.tbGroup);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.cbNotactive);
            this.groupBox1.Controls.Add(this.tbCashpwd);
            this.groupBox1.Controls.Add(this.tbNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 156);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оператор";
            // 
            // tbReason
            // 
            this.tbReason.Enabled = false;
            this.tbReason.Location = new System.Drawing.Point(307, 129);
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(231, 20);
            this.tbReason.TabIndex = 11;
            this.tbReason.Visible = false;
            // 
            // tbDateDelete
            // 
            this.tbDateDelete.Enabled = false;
            this.tbDateDelete.Location = new System.Drawing.Point(98, 129);
            this.tbDateDelete.Name = "tbDateDelete";
            this.tbDateDelete.Size = new System.Drawing.Size(129, 20);
            this.tbDateDelete.TabIndex = 10;
            this.tbDateDelete.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "По причине:";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Дата удаления:";
            this.label9.Visible = false;
            // 
            // tbmagneCardCode
            // 
            this.tbmagneCardCode.Location = new System.Drawing.Point(359, 103);
            this.tbmagneCardCode.Name = "tbmagneCardCode";
            this.tbmagneCardCode.Size = new System.Drawing.Size(179, 20);
            this.tbmagneCardCode.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Код магнитной карты:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(98, 103);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Пароль:";
            // 
            // tbPOS
            // 
            this.tbPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbPOS.FormattingEnabled = true;
            this.tbPOS.Location = new System.Drawing.Point(289, 76);
            this.tbPOS.Name = "tbPOS";
            this.tbPOS.Size = new System.Drawing.Size(121, 21);
            this.tbPOS.TabIndex = 5;
            // 
            // tbObj
            // 
            this.tbObj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbObj.FormattingEnabled = true;
            this.tbObj.Location = new System.Drawing.Point(289, 49);
            this.tbObj.Name = "tbObj";
            this.tbObj.Size = new System.Drawing.Size(121, 21);
            this.tbObj.TabIndex = 4;
            this.tbObj.SelectedIndexChanged += new System.EventHandler(this.tbObj_SelectedIndexChanged);
            // 
            // tbGroup
            // 
            this.tbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbGroup.FormattingEnabled = true;
            this.tbGroup.Location = new System.Drawing.Point(289, 23);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(121, 21);
            this.tbGroup.TabIndex = 3;
            this.tbGroup.SelectedIndexChanged += new System.EventHandler(this.tbGroup_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Объект:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Группа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "POS:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(98, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // cbNotactive
            // 
            this.cbNotactive.AutoSize = true;
            this.cbNotactive.Location = new System.Drawing.Point(431, 25);
            this.cbNotactive.Name = "cbNotactive";
            this.cbNotactive.Size = new System.Drawing.Size(84, 17);
            this.cbNotactive.TabIndex = 6;
            this.cbNotactive.Text = "Не активен";
            this.cbNotactive.UseVisualStyleBackColor = true;
            // 
            // tbCashpwd
            // 
            this.tbCashpwd.Location = new System.Drawing.Point(98, 75);
            this.tbCashpwd.Name = "tbCashpwd";
            this.tbCashpwd.Size = new System.Drawing.Size(100, 20);
            this.tbCashpwd.TabIndex = 2;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(98, 49);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль кассы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер кассира:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(485, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(397, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(285, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDirectoryOperatorsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 425);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(587, 464);
            this.MinimumSize = new System.Drawing.Size(587, 464);
            this.Name = "frmDirectoryOperatorsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Детали оператора";
            this.Load += new System.EventHandler(this.frmDirectoryOperatorsDetails_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox c13;
        private System.Windows.Forms.CheckBox c12;
        private System.Windows.Forms.CheckBox c11;
        private System.Windows.Forms.CheckBox c10;
        private System.Windows.Forms.CheckBox c9;
        private System.Windows.Forms.CheckBox c8;
        private System.Windows.Forms.CheckBox c7;
        private System.Windows.Forms.CheckBox c6;
        private System.Windows.Forms.CheckBox c5;
        private System.Windows.Forms.CheckBox c4;
        private System.Windows.Forms.CheckBox c3;
        private System.Windows.Forms.CheckBox c2;
        private System.Windows.Forms.CheckBox c1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbNotactive;
        private System.Windows.Forms.TextBox tbCashpwd;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tbPOS;
        private System.Windows.Forms.ComboBox tbObj;
        private System.Windows.Forms.ComboBox tbGroup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbmagneCardCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.TextBox tbDateDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox valMask;
        private System.Windows.Forms.Button btnDelete;
    }
}