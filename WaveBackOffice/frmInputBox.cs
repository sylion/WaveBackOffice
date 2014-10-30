using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaveBackOffice
{
    public partial class frmInputBox : Form
    {
        public string ReturnValue { get; set; }
        public frmInputBox()
        {
            InitializeComponent();
            ReturnValue = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbReason.Text.Length > 0)
            {
                ReturnValue = tbReason.Text.Replace("'", "\\'");
                this.Close();
            }
            else
                MessageBox.Show("Введите причину данной операции!");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnValue = string.Empty;
            this.Close();
        }
    }
}
