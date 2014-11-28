using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using CustomUIControls;
using System.Drawing;

namespace Hvylya_Worker
{
    public partial class frmMain : Form
    {
        //
        int mypatch = 15;
        string patchv = "20141127 0238";
        //Создание фонового потока с возможностью прерывания работы
        AbortableBackgroundWorker bwUploadChecks = new AbortableBackgroundWorker();
        AbortableBackgroundWorker bwUploadTxtChecks = new AbortableBackgroundWorker();
        AbortableBackgroundWorker bwUploadLocalChecks = new AbortableBackgroundWorker();
        //
        TaskbarNotifier taskbarNotifier = new TaskbarNotifier();
        public Settings set;
        int clock = 0;
        public string logtmp;
        public static string FPSerror = "";
        public static bool FPSerrorUP = false;
        //========Блокировка повторных запусков потоков============================
        public static bool checkStarted = false; //Статус запуска потока
        public static bool sendStarted = false; //Статус запуска потока
        public static bool sendTxtStarted = false; //Статус запуска потока
        public static bool sendLocalStarted = false; //Статус запуска потока
        public static bool FPServerRun = false; //Статус запуска потока
        //=========================================================================
        public delegate void AppendLog(string msg);
        public frmMain()
        {
            InitializeComponent();
        }
        //загрузка настроек и проверка обновлений
        private void frmMain_Shown(object sender, EventArgs e)
        {
            taskbarNotifier.SetBackgroundBitmap(Properties.Resources.skin as Bitmap, Color.FromArgb(255, 0, 255));
            taskbarNotifier.SetCloseBitmap(Properties.Resources.close as Bitmap, Color.FromArgb(255, 0, 255), new Point(280, 8));
            taskbarNotifier.TitleRectangle = new Rectangle(40, 9, 300, 25);
            taskbarNotifier.ContentRectangle = new Rectangle(8, 41, 300, 160);
            taskbarNotifier.TopMost = true;
            label1.Text = "Текущая версия: " + patchv + ", Патч № " + mypatch;
            this.Hide();

            //Запуск проверки обновлений
            if (set.main.checkUpdates)
            {
                Form frm = new frmUpdate();
                frm.Owner = this;
                frm.ShowDialog();
                log.AppendText(logtmp);
                if (frm.DialogResult == System.Windows.Forms.DialogResult.Abort)
                {
                    if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\log"))
                        Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\log");
                    using (File.Create(Directory.GetCurrentDirectory() + "\\log\\" + DateTime.Now.ToShortDateString() + "(up).log")) { }
                    File.WriteAllLines(Directory.GetCurrentDirectory() + "\\log\\" + DateTime.Now.ToShortDateString() + "(up).log", log.Lines);
                    Application.Exit();
                    return;
                }
            }
            if (set.main.startSoft)
            {
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Выполняю запуск ПО...\n\n");
                Worker.AutoStart(set.main);
            }
            uploadLocalTimer.Enabled = true;
            uploadLocalTimer.Start();
            uploadTimer.Enabled = true;
            uploadTimer.Start();
            uploadTxtTimer.Enabled = true;
            uploadTxtTimer.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //
            bwUploadChecks.WorkerSupportsCancellation = true;
            bwUploadChecks.DoWork += bwUploadChecks_DoWork;
            bwUploadLocalChecks.WorkerSupportsCancellation = true;
            bwUploadLocalChecks.DoWork += bwUploadLocalChecks_DoWork;
            bwUploadTxtChecks.WorkerSupportsCancellation = true;
            bwUploadTxtChecks.DoWork += bwUploadTxtChecks_DoWork;
            //
            mbtnPatch.Text += " " + mypatch.ToString();
            mbtnVers.Text += " " + patchv.ToString();
            try
            {
                if (Directory.Exists(Directory.GetCurrentDirectory() + "\\tmp"))
                    Directory.Delete(Directory.GetCurrentDirectory() + "\\tmp", true);
            }
            catch { }
            log.AppendText("=======" + Environment.MachineName + "=======\n");
            log.AppendText(DateTime.Today.ToShortDateString() + "\n");
            log.AppendText(" - - -\n");
            log.AppendText(DateTime.Now.ToLongTimeString() + " - Загружаю настройки...\n");
            set = SettingsControl.Load();
            if (set.uploader.SalesDir.StartsWith("/"))
                set.uploader.SalesDir = @"\\10.0.1.142\protokolpos\SALES";
            if (set.baseupdater.cardsDir.StartsWith("/"))
                set.baseupdater.cardsDir = @"\\10.0.1.141\POS1\";
            if (set.baseupdater.goodsDir.StartsWith("/"))
            {
                string[] s = set.baseupdater.goodsDir.Split('/');
                set.baseupdater.goodsDir = @"\\10.0.1.141\" + s[2] + "\\" + s[3] + "\\";
            }
            log.AppendText(DateTime.Now.ToLongTimeString() + " - Настройки загружены.\n");
            ApplySet();
            //Ежемесячная очистка логов
            if (DateTime.Now.Day == 3)
            {
                log.AppendText(" - - - Сегодня субботник :)\n");
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Начинаю очистку логов...\n");
                Cleaner.Clean();
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Очистка выполнена!\n");
                log.AppendText(" - - -\n");
            }
        }
        //Применение настроек, установка значения кнопок, параметров автозапуска и т.д. 
        void ApplySet()
        {
            log.AppendText(" - - -\n");
            log.AppendText(DateTime.Now.ToLongTimeString() + " - Применяю новые настройки...\n");
            //Проверка настроек
            if (set != null && SettingsControl.CheckSet(set))
            {
                DoWhatYouDo.Interval = (int)set.main.CheckTimer;
                syncTimer.Interval = (int)set.main.syncTimer;
                checkGCTimer.Interval = (int)set.main.GCTimer;
                uploadTimer.Interval = (int)set.main.uploadTimer;
                uploadTxtTimer.Interval = (int)set.main.uploadTimer;
                uploadLocalTimer.Interval = (int)set.main.uploadTimer;
                //
                cbtnAutostart.Checked = set.main.Autostart;
                if (set.main.Autostart)
                {
                    Worker.SetAutostart(true);
                    log.AppendText(DateTime.Now.ToLongTimeString() + " - Автозапуск включен!\n");
                }
                else
                {
                    Worker.SetAutostart(false);
                    log.AppendText(DateTime.Now.ToLongTimeString() + " - Автозапуск выключен!\n");
                }
                //
                cbtnCheckUpdates.Checked = set.main.checkUpdates;
                if (set.main.checkUpdates)
                    log.AppendText(DateTime.Now.ToLongTimeString() + " - Проверка обновлений при запуске включена!\n");
                else
                    log.AppendText(DateTime.Now.ToLongTimeString() + " - Проверка обновлений при запуске выключена!\n");
                SetErrorTimer.Stop();
            }
            else
            {
                //Если настройки неверные то...
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Настройки загружены с ошибкой!\n");
                if (set == null)
                {
                    set = new Settings();
                }
                set.main.Offline = true;
                SetErrorTimer.Start();
            }
            cbtnSendTxt.Checked = set.main.sendTxt;
            if (set.main.sendTxt)
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Отправка TXT чеков на сервер включена!\n");
            else
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Отправка TXT чеков на сервер выключена!\n");
            cbtnSendSC.Checked = set.main.sendSC;
            if (set.main.sendSC)
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Отправка чеков на сервер включена!\n");
            else
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Отправка чеков на сервер выключена!\n");
            cbtnSendF.Checked = set.main.sendF;
            if (set.main.sendF)
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Отправка фискальных чеков включена!\n");
            else
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Отправка фискальных чеков выключена!\n");
            cbtnCheckGC.Checked = set.main.checkGC;
            if (set.main.sendF)
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Обновление справочников POS включено!\n");
            else
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Обновление справочников POS выключено!\n");
            cbtnStartSoft.Checked = set.main.startSoft;
            //Режим оффлайн усатнавливаеться при любых настройках
            cbtnOffline.Checked = set.main.Offline;
            if (set.main.Offline)
            {
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Режим offline включен!\n");
                cbtnCheckGC.Enabled = cbtnSendF.Enabled = cbtnSendSC.Enabled = cbtnSendTxt.Enabled = false;
                DoWhatYouDo.Stop();
                FPErrorTimer.Stop();
            }
            else
            {
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Режим offline выключен!\n");
                cbtnCheckGC.Enabled = cbtnSendF.Enabled = cbtnSendSC.Enabled = cbtnSendTxt.Enabled = true;
                DoWhatYouDo.Start();
                FPErrorTimer.Start();
            }
            log.AppendText(" - - -\n");
            //Сохранение настроек при изменении
            SettingsControl.Save(set);
        }
        //=========================================================================
        //открытие/скрытие окна лога
        private void tryIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }
        private void cbtnLog_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //Очистка окна лога
        private void btnClean_Click(object sender, EventArgs e)
        {
            log.Clear();
        }
        //Установка автозапуска
        private void cbtnAutostart_Click(object sender, EventArgs e)
        {
            set.main.Autostart = !set.main.Autostart;
            ApplySet();
        }
        //Установка Offline режима
        private void cbtnOffline_Click(object sender, EventArgs e)
        {
            set.main.Offline = !set.main.Offline;
            ApplySet();
        }
        //
        private void cbtnCheckUpdates_Click(object sender, EventArgs e)
        {
            set.main.checkUpdates = !set.main.checkUpdates;
            ApplySet();
        }
        private void cbtnSendTxt_Click(object sender, EventArgs e)
        {
            set.main.sendTxt = !set.main.sendTxt;
            ApplySet();
        }
        private void cbtnSendSC_Click(object sender, EventArgs e)
        {
            set.main.sendSC = !set.main.sendSC;
            ApplySet();
        }
        private void cbtnSendF_Click(object sender, EventArgs e)
        {
            set.main.sendF = !set.main.sendF;
            ApplySet();
        }
        private void cbtnCheckGC_Click(object sender, EventArgs e)
        {
            set.main.checkGC = !set.main.checkGC;
            ApplySet();
        }
        private void cbtnStartSoft_Click(object sender, EventArgs e)
        {
            set.main.startSoft = !set.main.startSoft;
            ApplySet();
        }
        //выход
        private void cbtn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //=========================================================================
        //Сохранение лога перед выходом из приложения
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\log"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\log");
            log.AppendText(DateTime.Now.ToLongTimeString() + " - Завершение работы, сохраняю log... :) \n");
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\log\\" + DateTime.Now.ToShortDateString() + ".log"))
                using (File.Create(Directory.GetCurrentDirectory() + "\\log\\" + DateTime.Now.ToShortDateString() + ".log")) { }
            File.WriteAllLines(Directory.GetCurrentDirectory() + "\\log\\" + DateTime.Now.ToShortDateString() + ".log", log.Lines);
            bwCheckFP.CancelAsync();
            bwCheckFP.Dispose();
            bwUpdateGC.CancelAsync();
            bwUpdateGC.Dispose();
            if (bwUploadChecks.IsBusy)
            {
                bwUploadChecks.CancelAsync();
                bwUploadChecks.Abort();
            }
            bwUploadChecks.Dispose();
        }
        //Открытие окна настроек и разрешение ему получать доступ к этой форме и ее элементам (настройкам)
        private void cbtnSettings_Click(object sender, EventArgs e)
        {
            Form frmSet = new frmSettings();
            frmSet.Owner = this;
            frmSet.ShowDialog();
            if (frmSet.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                ApplySet();
            }
        }
        //==============================Таймеры====================================
        //Settings Error timer
        private void SetErrorTimer_Tick(object sender, EventArgs e)
        {
            taskbarNotifier.Show("Ошибка загрузки настроек", "Ошибка загрузки настроек.\nПереход в режим Offline.\nУстановите настройки вручную!!!", 500, 3000, 500);
        }
        //Сообщение ошибки ФП сервера
        private void FPErrorTimer_Tick(object sender, EventArgs e)
        {
            if (FPSerror == "" && FPSerror.Trim() == "")
            {
                if (!FPServerRun && set.fpserver.ServerAddress.Trim() != "" && set.fpserver.ServerAddress != null)
                {
                    taskbarNotifier.Show("Ошибка", "Фискальный регистратор не доступен.\nВозможно программа не запущена\n или неверно введен адрес: " + set.fpserver.ServerAddress, 500, 3000, 500);
                }
            }
            else
            {
                if (FPSerrorUP)
                {
                    taskbarNotifier.Show("FP3530T", FPSerror, 500, 3000, 500);
                    FPSerrorUP = false;
                }
            }
        }
        //Мониторинг ФП сервера
        private void DoWhatYouDo_Tick(object sender, EventArgs e)
        {
            if (set.fpserver.ServerAddress.Trim() != "" && set.fpserver.ServerAddress != null)
            {
                if (!FPServerRun && !bwCheckFP.IsBusy)
                {
                    try
                    {
                        bwCheckFP.RunWorkerAsync();
                        FPErrorTimer.Enabled = true;
                        FPErrorTimer.Start();
                    }
                    catch { }
                }
            }
        }
        //отправкa чеков
        private void uploadTimer_Tick(object sender, EventArgs e)
        {
            if (!set.main.Offline && set.main.sendSC)
            {
                //Запустить если еще не запущен
                if (!sendStarted && !bwUploadChecks.IsBusy)
                {
                    if (set.main.fullLogs)
                        log.AppendText(DateTime.Now.ToLongTimeString() + " - Отправка чеков\n");
                    try
                    {
                        bwUploadChecks.RunWorkerAsync();
                        clock = 0;
                    }
                    catch { }
                }
                else
                {
                    clock += 1;
                }
                //Защита от застопорившегося бекграунд процесса
                if (clock > 20)
                {
                    log.AppendText(DateTime.Now.ToLongTimeString() + " - Перегрузка счетчика отправки чеков, пытаюсь принудительно закрыть соединение с сервером и открыть новое... \n");
                    bwUploadChecks.Abort();
                    bwUploadChecks.CancelAsync();
                    bwUploadChecks.Dispose();
                    clock = 0;
                    try
                    {
                        bwUploadChecks.RunWorkerAsync();
                    }
                    catch
                    {
                        log.AppendText(DateTime.Now.ToLongTimeString() + " - Ошибка, не удалось завершить старый поток отправки чеков... \n");
                    }
                }
            }
        }
        private void UploadTxtTimer_Tick(object sender, EventArgs e)
        {
            if (!set.main.Offline && set.main.sendTxt)
            {
                //Запустить если еще не запущен
                if (!sendTxtStarted && !bwUploadTxtChecks.IsBusy)
                {
                    if (set.main.fullLogs)
                        log.AppendText(DateTime.Now.ToLongTimeString() + " - Отправка TXT чеков\n");
                    try
                    {
                        bwUploadTxtChecks.RunWorkerAsync();
                        clock = 0;
                    }
                    catch { }
                }
                else
                {
                    clock += 1;
                }
                //Защита от застопорившегося бекграунд процесса
                if (clock > 20)
                {
                    log.AppendText(DateTime.Now.ToLongTimeString() + " - Перегрузка счетчика отправки чеков, пытаюсь принудительно закрыть соединение с сервером и открыть новое... \n");
                    bwUploadTxtChecks.Abort();
                    bwUploadTxtChecks.CancelAsync();
                    bwUploadTxtChecks.Dispose();
                    clock = 0;
                    try
                    {
                        bwUploadTxtChecks.RunWorkerAsync();
                    }
                    catch
                    {
                        log.AppendText(DateTime.Now.ToLongTimeString() + " - Ошибка, не удалось завершить старый поток отправки чеков... \n");
                    }
                }
            }
        }
        private void uploadLocalTimer_Tick(object sender, EventArgs e)
        {
            if (!set.main.Offline && set.main.sendF)
            {
                //Запустить если еще не запущен
                if (!sendLocalStarted && !bwUploadLocalChecks.IsBusy)
                {
                    if (set.main.fullLogs)
                        log.AppendText(DateTime.Now.ToLongTimeString() + " - Отправка фискальных чеков\n");
                    try
                    {
                        bwUploadLocalChecks.RunWorkerAsync();
                    }
                    catch { }
                }
            }
        }
        //Проверка и загрузка Goods/Cards
        private void checkGCTimer_Tick(object sender, EventArgs e)
        {
            if (!set.main.Offline && set.main.checkGC)
            {
                if (!checkStarted && !bwUpdateGC.IsBusy)
                {
                    if (set.main.fullLogs)
                        log.AppendText(DateTime.Now.ToLongTimeString() + " - Проверка базы товаров и дисконта\n");
                    try
                    {
                        bwUpdateGC.RunWorkerAsync();
                    }
                    catch { }
                }
            }
        }
        //Sync time
        private void syncTimer_Tick(object sender, EventArgs e)
        {
            if (set.main.fullLogs)
                log.AppendText(DateTime.Now.ToLongTimeString() + " - Синхронизация времени\n");
            Worker.syncTime(set.main);
        }
        //==============================Потоки====================================
        //Проверка FP сервера
        private void bwCheckFP_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!FPS.checkServer())
            {
                this.BeginInvoke(new AppendLog(log.AppendText), DateTime.Now.ToLongTimeString() + " - Не удалось установить соединение с FP сервером\n");
            }
        }
        //Отправка txt чеков на сервер
        void bwUploadTxtChecks_DoWork(object sender, DoWorkEventArgs e)
        {
            string tmpError;
            tmpError = Put.putTxtChecks(set);
            if (tmpError != "")
            {
                try
                {
                    this.BeginInvoke(new AppendLog(log.AppendText), DateTime.Now.ToLongTimeString() + " - ошибка при отправке чеков на сервер:\n");
                    this.BeginInvoke(new AppendLog(log.AppendText), " - - -\n");
                    this.BeginInvoke(new AppendLog(log.AppendText), tmpError + "\n");
                    this.BeginInvoke(new AppendLog(log.AppendText), " - - -\n");
                }
                catch { }
            }
        }
        //Отправка чеков
        private void bwUploadChecks_DoWork(object sender, DoWorkEventArgs e)
        {
            string tmpError;
            tmpError = Put.putChecks(set);
            if (tmpError != "")
            {
                try
                {
                    this.BeginInvoke(new AppendLog(log.AppendText), DateTime.Now.ToLongTimeString() + " - ошибка при отправке чеков на сервер:\n");
                    this.BeginInvoke(new AppendLog(log.AppendText), " - - -\n");
                    this.BeginInvoke(new AppendLog(log.AppendText), tmpError + "\n");
                    this.BeginInvoke(new AppendLog(log.AppendText), " - - -\n");
                }
                catch { }
            }
        }
        private void bwUploadLocalChecks_DoWork(object sender, DoWorkEventArgs e)
        {
            string tmpError;
            tmpError = Put.putLocalChecks(set);
            if (tmpError != "")
            {
                try
                {
                    this.BeginInvoke(new AppendLog(log.AppendText), DateTime.Now.ToLongTimeString() + " - ошибка при отправке фискальных чеков:\n");
                    this.BeginInvoke(new AppendLog(log.AppendText), " - - -\n");
                    this.BeginInvoke(new AppendLog(log.AppendText), tmpError + "\n");
                    this.BeginInvoke(new AppendLog(log.AppendText), " - - -\n");
                }
                catch { }
            }
        }
        //Проверка goods cards
        private void bwUpdateGC_DoWork(object sender, DoWorkEventArgs e)
        {
            string tmpError;
            tmpError = Put.checkGC(set);
            if (tmpError != "")
            {
                if (tmpError.StartsWith(" - Справочник"))
                {
                    this.BeginInvoke(new AppendLog(log.AppendText), DateTime.Now.ToLongTimeString() + " " + tmpError);
                }
                else
                {
                    try
                    {
                        this.BeginInvoke(new AppendLog(log.AppendText), DateTime.Now.ToLongTimeString() + " - ошибка при обновлении карточек и базы товаров:\n");
                        this.BeginInvoke(new AppendLog(log.AppendText), " - - -\n");
                        this.BeginInvoke(new AppendLog(log.AppendText), tmpError + "\n");
                        this.BeginInvoke(new AppendLog(log.AppendText), " - - -\n");
                    }
                    catch { }
                }
            }
        }
        //=========================================================================
        //Окно о программе...
        private void cbtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("     Hvylya Worker\n\n          patch #" + mypatch + "\n\nVersion " + patchv + "\n\n           SYL 2013 - 2014", "О программе...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Сохранения лога каждые 30 минут
        private void saveLog_Tick(object sender, EventArgs e)
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\log"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\log");
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\log\\" + DateTime.Now.ToShortDateString() + ".log"))
                using (File.Create(Directory.GetCurrentDirectory() + "\\log\\" + DateTime.Now.ToShortDateString() + ".log")) { }
            File.WriteAllLines(Directory.GetCurrentDirectory() + "\\log\\" + DateTime.Now.ToShortDateString() + ".log", log.Lines);
            if (set.main.fullLogs)
                log.AppendText(DateTime.Now.ToLongTimeString() + " - log работы сохранен! \n");
        }
        //=========================================================================
    }
}
