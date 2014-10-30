using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WaveBackOffice
{
    public partial class frmWaiter : Form
    {
        public int Mod = 0;
        public frmWaiter(int module)
        {
            InitializeComponent();
            Mod = module;
            switch (module)
            {
                case -1:
                    button1.Enabled = false;
                    break;
                case -2:
                    this.Text = "Сохранение";
                    label1.Text = "Выполняется сохранение файла ...";
                    break;
                default:
                    break;
            }
        }

        public frmWaiter(int module, int MaxProgress)
        {
            InitializeComponent();
            Mod = module;
            switch (module)
            {
                case -2:
                    button1.Enabled = false;
                    progressBar1.Style = ProgressBarStyle.Blocks;
                    if (MaxProgress == 0)
                        progressBar1.Maximum = MaxProgress + 1;
                    else
                        progressBar1.Maximum = MaxProgress;
                    progressBar1.Value = 0;
                    this.Text = "Сохранение";
                    label1.Text = "Выполняется сохранение файла ...";
                    break;
                default:
                    break;
            }
        }

        public delegate void WaiterStopEventHandler(int Module);
        public event WaiterStopEventHandler WaiterStopEvent;

        public void ChangeProgress(int Progress)
        {
            try
            {
                this.Invoke(new ThreadStart(delegate { this.ProgressHandler(Progress); }));
            }
            catch { }
        }

        public void ProgressHandler(int p)
        {
            if (p < progressBar1.Maximum)
                progressBar1.Value = p;
            else
                progressBar1.Value = progressBar1.Maximum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WaiterStopEvent(Mod);
            this.Close();
        }
    }
}
