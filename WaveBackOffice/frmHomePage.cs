using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

namespace WaveBackOffice
{
    public partial class frmHomePage : DockContent
    {
        public delegate void LinkClickedEventHandler(int Page);
        public event LinkClickedEventHandler linkClickedEvent;

        public frmHomePage()
        {
            InitializeComponent();
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
        }

        private void frmHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void linkDirClients_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkClickedEvent(1);
        }
        private void btnDirClients_Click(object sender, EventArgs e)
        {
            this.linkClickedEvent(1);
        }

        private void linkAppProtokol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkClickedEvent(2);
        }
        private void btnAppProtokol_Click(object sender, EventArgs e)
        {
            this.linkClickedEvent(2);
        }

        private void linkDirPos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkClickedEvent(3);
        }
        private void btnDirPOS_Click(object sender, EventArgs e)
        {
            this.linkClickedEvent(3);
        }

        private void linkAppMarketing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkClickedEvent(4);
        }
        private void btnAppMarketing_Click(object sender, EventArgs e)
        {
            this.linkClickedEvent(4);
        }

        private void btnDirOperators_Click(object sender, EventArgs e)
        {
            this.linkClickedEvent(5);
        }
        private void linkDirOperators_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkClickedEvent(5);
        }

        private void btnAppScheduler_Click(object sender, EventArgs e)
        {
            this.linkClickedEvent(6);
        }

        private void linkAppScheduler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkClickedEvent(6);
        }

        private void btnDirUsers_Click(object sender, EventArgs e)
        {
            this.linkClickedEvent(7);
        }

        private void linkDirUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkClickedEvent(7);
        }
    }
}
