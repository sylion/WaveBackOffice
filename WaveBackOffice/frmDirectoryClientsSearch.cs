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
    public partial class frmDirectoryClientsSearch : Form
    {
        DataTable DT = null;
        BindingSource BS;
        public string ReturnData = "";
        public frmDirectoryClientsSearch(DataTable dt)
        {
            InitializeComponent();
            DT = dt;
        }

        public frmDirectoryClientsSearch(BindingSource bs)
        {
            InitializeComponent();
            BS = bs;
        }

        private void frmDirectoryClientsSearch_Shown(object sender, EventArgs e)
        {
            if (DT != null)
                dataGridView1.DataSource = DT;
            else
            {
                dataGridView1.DataSource = BS;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnData = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();
        }
    }
}
