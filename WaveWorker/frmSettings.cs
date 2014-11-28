using System;
using System.Windows.Forms;

namespace Hvylya_Worker
{
    public partial class frmSettings : Form
    {
        Settings set = new Settings();
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.Owner;
            set = frm.set;
            //Main
            cbAutorun.Checked = set.main.Autostart;
            cbOffline.Checked = set.main.Offline;
            cbCheckUpdates.Checked = set.main.checkUpdates;
            cbUpload.Checked = set.main.sendSC;
            cbTxtUpload.Checked = set.main.sendTxt;
            cbUploadF.Checked = set.main.sendF;
            cbCheckGC.Checked = set.main.checkGC;
            cbStartSoft.Checked = set.main.startSoft;
            numFPS.Value = set.main.CheckTimer;
            numSync.Value = set.main.syncTimer;
            numGC.Value = set.main.GCTimer;
            numChecks.Value = set.main.uploadTimer;
            tbTimeServer.Text = set.main.TimeServer;
            chkFullLogs.Checked = set.main.fullLogs;
            //LocalDirs
            tbIn.Text = set.localdirs.InPath;
            tbOut.Text = set.localdirs.OutPath;
            tbCommand.Text = set.localdirs.CommandPath;
            tbSales.Text = set.localdirs.SalesPath;
            //FPServer
            tbFPSAddr.Text = set.fpserver.ServerAddress;
            tbFPSSales.Text = set.fpserver.SalesPath;
            //Updater
            tbUpServer.Text = set.softwareupdater.FTPServer;
            tbUpLogin.Text = set.softwareupdater.FTPLogin;
            tbUpPwd.Text = set.softwareupdater.FTPPassword;
            tbUpGroup.Text = set.softwareupdater.UpdateGoup;
            //BaseUpdater
            tbSMgoods.Text = set.baseupdater.goodsDir;
            tbSMcards.Text = set.baseupdater.cardsDir;
            //Uploader
            tbChSales.Text = set.uploader.SalesDir;
            tbChTxtSales.Text = set.uploader.TxtSalesDir;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (numFPS.Value == 0 || numChecks.Value == 0 || numGC.Value == 0 || numSync.Value == 0)
            {
                MessageBox.Show("Таймер проверок не может быть 0 мс.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmMain frm = (frmMain)this.Owner;
            //Main
            set.main.Autostart = cbAutorun.Checked;
            set.main.Offline = cbOffline.Checked;
            set.main.sendSC = cbUpload.Checked;
            set.main.sendTxt = cbTxtUpload.Checked;
            set.main.sendF = cbUploadF.Checked;
            set.main.checkUpdates = cbCheckUpdates.Checked;
            set.main.startSoft = cbStartSoft.Checked;
            set.main.checkGC = cbCheckGC.Checked;
            set.main.CheckTimer = (uint)numFPS.Value;
            set.main.GCTimer = (uint)numGC.Value;
            set.main.syncTimer = (uint)numSync.Value;
            set.main.uploadTimer = (uint)numChecks.Value;
            set.main.TimeServer = tbTimeServer.Text;
            set.main.fullLogs = chkFullLogs.Checked;
            //LocalDirs
            set.localdirs.InPath = tbIn.Text;
            set.localdirs.OutPath = tbOut.Text;
            set.localdirs.CommandPath = tbCommand.Text;
            set.localdirs.SalesPath = tbSales.Text;
            //FPServer
            set.fpserver.ServerAddress = tbFPSAddr.Text;
            set.fpserver.SalesPath = tbFPSSales.Text;
            //Updater
            set.softwareupdater.FTPServer = tbUpServer.Text;
            set.softwareupdater.FTPLogin = tbUpLogin.Text;
            set.softwareupdater.FTPPassword = tbUpPwd.Text;
            set.softwareupdater.UpdateGoup = tbUpGroup.Text;
            //BaseUpdater
            set.baseupdater.goodsDir = tbSMgoods.Text;
            set.baseupdater.cardsDir = tbSMcards.Text;
            //Uploader
            set.uploader.SalesDir = tbChSales.Text;
            set.uploader.TxtSalesDir = tbChTxtSales.Text;
            frm.set = set;
            DialogResult res = new DialogResult();
            res = System.Windows.Forms.DialogResult.OK;
            this.DialogResult = res;
        }

        private void cbOffline_CheckedChanged(object sender, EventArgs e)
        {
            cbCheckGC.Enabled = cbUpload.Enabled = cbUploadF.Enabled = cbTxtUpload.Enabled = !cbOffline.Checked;
        }
    }
}
