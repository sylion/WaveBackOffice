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
    public partial class frmMain : Form
    {
        frmHomePage HomePage;
        frmDirectoryClients DirectoryClients;
        frmDirectoryOperators DirectoryOperators;
        frmAppProtokol AppProtokol;
        frmDirectoryPOS DirectoryPOS;
        frmAppMarketing appMarketing;
        frmAppScheduler appScheduler;
        frmDirectoryUsers DirectoryUsers;
        public frmMain()
        {
            InitializeComponent();
            //для отображение кнопок управления открепленных окон
            dockPanelMain.Extender.FloatWindowFactory = new CustomFloatWindowFactory();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HomePage = new frmHomePage();
            HomePage.Show(dockPanelMain);
            HomePage.linkClickedEvent += HomePage_linkClickedEvent;
        }

        void HomePage_linkClickedEvent(int Page)
        {
            switch (Page)
            {
                case 1:
                    mbtnDirectoryClients_Click(this, new EventArgs());
                    break;
                case 2:
                    mbtnAppProtokol_Click(this, new EventArgs());
                    break;
                case 3:
                    mbtnDirectoryPOS_Click(this, new EventArgs());
                    break;
                case 4:
                    mbtnAppMarketing_Click(this, new EventArgs());
                    break;
                case 5:
                    mbtnDirectoryOperators_Click(this, new EventArgs());
                    break;
                case 6:
                    mbtnAppScheduler_Click(this, new EventArgs());
                    break;
                case 7:
                    mbtnDirectoryUsers_Click(this, new EventArgs());
                    break;
                default:
                    break;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //to Add navigation hotkeys later
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            WaveBackOffice.Properties.Settings.Default.LastAddedCity = "";
            WaveBackOffice.Properties.Settings.Default.Save();
            HomePage.Dispose();
            Application.Exit();
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            HomePage.Dispose();
            Application.Exit();
        }

        private void mbtnSettings_Click(object sender, EventArgs e)
        {
            new frmSettings().ShowDialog();
            //TODO: добавить событие обновления настроек и заставить все открытые формы обновить настройки БД
        }

        private void mbtnDirectoryClients_Click(object sender, EventArgs e)
        {
            if (!dockPanelMain.Documents.Contains(DirectoryClients))
            {
                DirectoryClients = new frmDirectoryClients();
                DirectoryClients.Show(dockPanelMain);
            }
            else
                DirectoryClients.Focus();
        }

        private void mbtnAppProtokol_Click(object sender, EventArgs e)
        {
            if (!dockPanelMain.Documents.Contains(AppProtokol))
            {
                AppProtokol = new frmAppProtokol();
                AppProtokol.Show(dockPanelMain);
            }
            else
                AppProtokol.Focus();
        }

        private void mbtnDirectoryPOS_Click(object sender, EventArgs e)
        {
            if (!dockPanelMain.Documents.Contains(DirectoryPOS))
            {
                DirectoryPOS = new frmDirectoryPOS();
                DirectoryPOS.Show(dockPanelMain);
            }
            else
                DirectoryPOS.Focus();
        }

        private void mbtnAppMarketing_Click(object sender, EventArgs e)
        {
            if (!dockPanelMain.Documents.Contains(appMarketing))
            {
                appMarketing = new frmAppMarketing();
                appMarketing.Show(dockPanelMain);
            }
            else
                appMarketing.Focus();
        }

        private void mbtnDirectoryOperators_Click(object sender, EventArgs e)
        {
            if (!dockPanelMain.Documents.Contains(DirectoryOperators))
            {
                DirectoryOperators = new frmDirectoryOperators();
                DirectoryOperators.Show(dockPanelMain);
            }
            else
                DirectoryOperators.Focus();
        }

        private void mbtnAppScheduler_Click(object sender, EventArgs e)
        {
            if (!dockPanelMain.Documents.Contains(appScheduler))
            {
                appScheduler = new frmAppScheduler();
                appScheduler.Show(dockPanelMain);
            }
            else
                appScheduler.Focus();
        }

        private void mbtnDirectoryUsers_Click(object sender, EventArgs e)
        {

            if (!dockPanelMain.Documents.Contains(DirectoryUsers))
            {
                DirectoryUsers = new frmDirectoryUsers();
                DirectoryUsers.Show(dockPanelMain);
            }
            else
                DirectoryUsers.Focus();
        }
    }
    #region Классы для отображение кнопок управления открепленных окон
    public class CustomFloatWindow : FloatWindow
    {
        public CustomFloatWindow(DockPanel dockPanel, DockPane pane)
            : base(dockPanel, pane)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            ShowInTaskbar = true;
            Owner = null;
            DoubleClickTitleBarToDock = false;
            Width = 800;
            Height = 600;
        }

        public CustomFloatWindow(DockPanel dockPanel, DockPane pane, Rectangle bounds)
            : base(dockPanel, pane, bounds)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            ShowInTaskbar = true;
            Owner = null;
            DoubleClickTitleBarToDock = false;
            Width = 800;
            Height = 600;
        }
    }
    public class CustomFloatWindowFactory : DockPanelExtender.IFloatWindowFactory
    {
        public FloatWindow CreateFloatWindow(DockPanel dockPanel, DockPane pane, Rectangle bounds)
        {
            return new CustomFloatWindow(dockPanel, pane, bounds);
        }

        public FloatWindow CreateFloatWindow(DockPanel dockPanel, DockPane pane)
        {
            return new CustomFloatWindow(dockPanel, pane);
        }
    }
    #endregion
}
