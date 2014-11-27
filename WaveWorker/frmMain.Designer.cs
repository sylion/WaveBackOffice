namespace Hvylya_Worker
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btn_close = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbtnLog = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cbtnAutostart = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnCheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cbtnOffline = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnSendSC = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnSendF = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnCheckGC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbtnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnPatch = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnVers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cbtn_close = new System.Windows.Forms.ToolStripMenuItem();
            this.log = new System.Windows.Forms.RichTextBox();
            this.SetErrorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnClean = new System.Windows.Forms.Button();
            this.DoWhatYouDo = new System.Windows.Forms.Timer(this.components);
            this.FPErrorTimer = new System.Windows.Forms.Timer(this.components);
            this.uploadTimer = new System.Windows.Forms.Timer(this.components);
            this.bwUpdateGC = new System.ComponentModel.BackgroundWorker();
            this.bwCheckFP = new System.ComponentModel.BackgroundWorker();
            this.checkGCTimer = new System.Windows.Forms.Timer(this.components);
            this.syncTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.saveLog = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uploadLocalTimer = new System.Windows.Forms.Timer(this.components);
            this.cbtnStartSoft = new System.Windows.Forms.ToolStripMenuItem();
            this.trayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(356, 237);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Скрыть";
            this.toolTip1.SetToolTip(this.btn_close, "Скрыть окно в область уведомлений");
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Hvylya Worker";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tryIcon_MouseDoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnLog,
            this.cbtnSettings,
            this.toolStripMenuItem2,
            this.cbtnAutostart,
            this.cbtnCheckUpdates,
            this.cbtnStartSoft,
            this.toolStripMenuItem4,
            this.cbtnOffline,
            this.cbtnSendSC,
            this.cbtnSendF,
            this.cbtnCheckGC,
            this.toolStripMenuItem1,
            this.cbtnAbout,
            this.mbtnPatch,
            this.mbtnVers,
            this.toolStripMenuItem3,
            this.cbtn_close});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(240, 336);
            // 
            // cbtnLog
            // 
            this.cbtnLog.Name = "cbtnLog";
            this.cbtnLog.Size = new System.Drawing.Size(239, 22);
            this.cbtnLog.Text = "Показать log";
            this.cbtnLog.Click += new System.EventHandler(this.cbtnLog_Click);
            // 
            // cbtnSettings
            // 
            this.cbtnSettings.Name = "cbtnSettings";
            this.cbtnSettings.Size = new System.Drawing.Size(239, 22);
            this.cbtnSettings.Text = "Настройки";
            this.cbtnSettings.Click += new System.EventHandler(this.cbtnSettings_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(236, 6);
            // 
            // cbtnAutostart
            // 
            this.cbtnAutostart.Name = "cbtnAutostart";
            this.cbtnAutostart.Size = new System.Drawing.Size(239, 22);
            this.cbtnAutostart.Text = "Стартовать с Windows";
            this.cbtnAutostart.Click += new System.EventHandler(this.cbtnAutostart_Click);
            // 
            // cbtnCheckUpdates
            // 
            this.cbtnCheckUpdates.Name = "cbtnCheckUpdates";
            this.cbtnCheckUpdates.Size = new System.Drawing.Size(239, 22);
            this.cbtnCheckUpdates.Text = "Проверять обновления";
            this.cbtnCheckUpdates.Click += new System.EventHandler(this.cbtnCheckUpdates_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(236, 6);
            // 
            // cbtnOffline
            // 
            this.cbtnOffline.Name = "cbtnOffline";
            this.cbtnOffline.Size = new System.Drawing.Size(239, 22);
            this.cbtnOffline.Text = "Режим Offline";
            this.cbtnOffline.Click += new System.EventHandler(this.cbtnOffline_Click);
            // 
            // cbtnSendSC
            // 
            this.cbtnSendSC.Name = "cbtnSendSC";
            this.cbtnSendSC.Size = new System.Drawing.Size(239, 22);
            this.cbtnSendSC.Text = "Отправлять чеки на сервер";
            this.cbtnSendSC.Click += new System.EventHandler(this.cbtnSendSC_Click);
            // 
            // cbtnSendF
            // 
            this.cbtnSendF.Name = "cbtnSendF";
            this.cbtnSendF.Size = new System.Drawing.Size(239, 22);
            this.cbtnSendF.Text = "Отправлять фискальные чеки";
            this.cbtnSendF.Click += new System.EventHandler(this.cbtnSendF_Click);
            // 
            // cbtnCheckGC
            // 
            this.cbtnCheckGC.Name = "cbtnCheckGC";
            this.cbtnCheckGC.Size = new System.Drawing.Size(239, 22);
            this.cbtnCheckGC.Text = "Обновлять справочники POS";
            this.cbtnCheckGC.Click += new System.EventHandler(this.cbtnCheckGC_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(236, 6);
            // 
            // cbtnAbout
            // 
            this.cbtnAbout.Name = "cbtnAbout";
            this.cbtnAbout.Size = new System.Drawing.Size(239, 22);
            this.cbtnAbout.Text = "О программе...";
            this.cbtnAbout.Click += new System.EventHandler(this.cbtnAbout_Click);
            // 
            // mbtnPatch
            // 
            this.mbtnPatch.Enabled = false;
            this.mbtnPatch.Name = "mbtnPatch";
            this.mbtnPatch.Size = new System.Drawing.Size(239, 22);
            this.mbtnPatch.Text = "patch #";
            // 
            // mbtnVers
            // 
            this.mbtnVers.Enabled = false;
            this.mbtnVers.Name = "mbtnVers";
            this.mbtnVers.Size = new System.Drawing.Size(239, 22);
            this.mbtnVers.Text = "version";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(236, 6);
            // 
            // cbtn_close
            // 
            this.cbtn_close.Name = "cbtn_close";
            this.cbtn_close.Size = new System.Drawing.Size(239, 22);
            this.cbtn_close.Text = "Выход";
            this.cbtn_close.Click += new System.EventHandler(this.cbtn_close_Click);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Location = new System.Drawing.Point(2, 3);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(439, 228);
            this.log.TabIndex = 1;
            this.log.Text = "";
            // 
            // SetErrorTimer
            // 
            this.SetErrorTimer.Interval = 5000;
            this.SetErrorTimer.Tick += new System.EventHandler(this.SetErrorTimer_Tick);
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClean.Location = new System.Drawing.Point(275, 237);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Очистить";
            this.toolTip1.SetToolTip(this.btnClean, "Удалить текущий ЛОГ");
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // DoWhatYouDo
            // 
            this.DoWhatYouDo.Interval = 2000;
            this.DoWhatYouDo.Tick += new System.EventHandler(this.DoWhatYouDo_Tick);
            // 
            // FPErrorTimer
            // 
            this.FPErrorTimer.Interval = 2000;
            this.FPErrorTimer.Tick += new System.EventHandler(this.FPErrorTimer_Tick);
            // 
            // uploadTimer
            // 
            this.uploadTimer.Enabled = true;
            this.uploadTimer.Interval = 10000;
            this.uploadTimer.Tick += new System.EventHandler(this.uploadTimer_Tick);
            // 
            // bwUpdateGC
            // 
            this.bwUpdateGC.WorkerSupportsCancellation = true;
            this.bwUpdateGC.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdateGC_DoWork);
            // 
            // bwCheckFP
            // 
            this.bwCheckFP.WorkerSupportsCancellation = true;
            this.bwCheckFP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCheckFP_DoWork);
            // 
            // checkGCTimer
            // 
            this.checkGCTimer.Enabled = true;
            this.checkGCTimer.Interval = 50000;
            this.checkGCTimer.Tick += new System.EventHandler(this.checkGCTimer_Tick);
            // 
            // syncTimer
            // 
            this.syncTimer.Enabled = true;
            this.syncTimer.Tick += new System.EventHandler(this.syncTimer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "version";
            // 
            // saveLog
            // 
            this.saveLog.Enabled = true;
            this.saveLog.Interval = 1800000;
            this.saveLog.Tick += new System.EventHandler(this.saveLog_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // uploadLocalTimer
            // 
            this.uploadLocalTimer.Enabled = true;
            this.uploadLocalTimer.Interval = 10000;
            this.uploadLocalTimer.Tick += new System.EventHandler(this.uploadLocalTimer_Tick);
            // 
            // cbtnStartSoft
            // 
            this.cbtnStartSoft.Name = "cbtnStartSoft";
            this.cbtnStartSoft.Size = new System.Drawing.Size(239, 22);
            this.cbtnStartSoft.Text = "Запускать ПО";
            this.cbtnStartSoft.Click += new System.EventHandler(this.cbtnStartSoft_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 272);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.log);
            this.Controls.Add(this.btn_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(459, 288);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hvylya Worker Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.trayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem cbtn_close;
        private System.Windows.Forms.ToolStripMenuItem cbtnLog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cbtnOffline;
        private System.Windows.Forms.ToolStripMenuItem cbtnSettings;
        private System.Windows.Forms.ToolStripMenuItem cbtnAutostart;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Timer SetErrorTimer;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Timer DoWhatYouDo;
        private System.Windows.Forms.Timer FPErrorTimer;
        private System.Windows.Forms.Timer uploadTimer;
        private System.Windows.Forms.ToolStripMenuItem cbtnAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.ComponentModel.BackgroundWorker bwUpdateGC;
        private System.ComponentModel.BackgroundWorker bwCheckFP;
        private System.Windows.Forms.Timer checkGCTimer;
        private System.Windows.Forms.Timer syncTimer;
        private System.Windows.Forms.ToolStripMenuItem cbtnCheckUpdates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mbtnPatch;
        private System.Windows.Forms.ToolStripMenuItem mbtnVers;
        private System.Windows.Forms.Timer saveLog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer uploadLocalTimer;
        private System.Windows.Forms.ToolStripMenuItem cbtnSendSC;
        private System.Windows.Forms.ToolStripMenuItem cbtnSendF;
        private System.Windows.Forms.ToolStripMenuItem cbtnCheckGC;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cbtnStartSoft;
    }
}

