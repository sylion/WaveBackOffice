using Ini;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Hvylya_Worker
{
    public partial class frmUpdate : Form
    {
        int mypatch = 15; //Текущий патч Worker'a
        public string log = "";
        public delegate void AppendLog(string msg);
        //Сохранение лога из других потоков
        public void AppendLogMethod(string msg)
        {
            frmMain frm = (frmMain)this.Owner;
            frm.logtmp = msg;
        }
        public frmUpdate()
        {
            InitializeComponent();
        }
        //Запуск проверки в отдельном потоке
        private void frmUpdate_Shown(object sender, EventArgs e)
        {
            UpdateWorker.RunWorkerAsync();
        }
        //Проверка и обновление в отдельном потоке
        private void UpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Profile prof;
            Group myGroup = null;
            Settings set = SettingsControl.Load();
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\tmp"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\tmp");
            log += " - - - Проверка обновлений - - -\n";
            log += DateTime.Now.ToLongTimeString() + " - Загрузка профиля\n";
            if (FTP.get(set.softwareupdater, "", "profile.xml", Directory.GetCurrentDirectory() + "\\tmp") == 0)
            {
                prof = ProfileControl.Load(Directory.GetCurrentDirectory() + "\\tmp\\profile.xml");
                log += DateTime.Now.ToLongTimeString() + " - Профиль загружен\n";
                for (int i = 0; i < prof.group.Length; i++)
                {
                    if (prof.group[i].Name == set.softwareupdater.UpdateGoup)
                    {
                        myGroup = prof.group[i];
                        log += DateTime.Now.ToLongTimeString() + " - Группа обновлений: " + myGroup.Name + "\n";
                        set.main.Autorun = prof.group[i].Autorun;
                        log += DateTime.Now.ToLongTimeString() + " - Новые параметры автозапуска загружены\n";
                        SettingsControl.Save(set);
                        break;
                    }
                }
                if (myGroup != null)
                {
                    //Сначала проверка своих патчей
                    log += " - - - \n" + DateTime.Now.ToLongTimeString() + " - Проверяю свои обновления...\n";
                    if (mypatch < prof.soft[0].LastPatchID)
                    {
                        log += DateTime.Now.ToLongTimeString() + " - Текущий патч № " + mypatch + "\n";
                        log += DateTime.Now.ToLongTimeString() + " - Обнаружен патч № " + prof.soft[0].LastPatchID + "\n";
                        log += DateTime.Now.ToLongTimeString() + " - Скачиваю...\n";
                        if (Worker.InstallSelfPatch(mypatch + 1))
                        {
                            log += DateTime.Now.ToLongTimeString() + " - Патч скачан, готовлю скрипт для установки...\n";
                            string command = "ping -n 5 127.0.0.1 <nul;copy /Y \"" + Directory.GetCurrentDirectory() + "\\tmp\\worker\\worker\\\" C:\\Worker\\;start \"Worker\" \"" + Application.ExecutablePath + "\" -p;exit";
                            using (File.Create(Directory.GetCurrentDirectory() + "\\tmp\\update.bat")) { }
                            File.WriteAllLines(Directory.GetCurrentDirectory() + "\\tmp\\update.bat", command.Split(new Char[] { ';' }));
                            System.Diagnostics.Process proc = new System.Diagnostics.Process();
                            proc.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\tmp\\update.bat";
                            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            log += DateTime.Now.ToLongTimeString() + " - Скрипт готов, перезагружаюсь для установки патча №" + (mypatch + 1) + "...\n";
                            proc.Start();
                            frmMain frm = (frmMain)this.Owner;
                            frm.logtmp = log;
                            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                            UpdateWorker.CancelAsync();
                        }
                        else
                            log += DateTime.Now.ToLongTimeString() + " - Не удалось установить патч :(\n";
                    }
                    else
                        log += DateTime.Now.ToLongTimeString() + " - Обновлений нету\n";
                    //Проверка и установка патчей
                    if (!File.Exists(Directory.GetCurrentDirectory() + "\\patches.ini"))
                        using (File.Create(Directory.GetCurrentDirectory() + "\\patches.ini")) { }
                    IniFile ini = new IniFile(Directory.GetCurrentDirectory() + "\\patches.ini");
                    Soft tmp;
                    for (int i = 0; i < myGroup.Soft.Length; i++)
                    {
                        tmp = ProfileControl.GetPatch(myGroup.Soft[i], prof);
                        int CurrentPatch;
                        try { CurrentPatch = int.Parse(ini.IniReadValue("Patch", tmp.Name)); }
                        catch { CurrentPatch = 0; }
                        log += " - - - \n" + DateTime.Now.ToLongTimeString() + " - Проверяю обновления для " + tmp.Name + "\n";
                        if (tmp != null && CurrentPatch < tmp.LastPatchID && tmp.LastPatchID != 0)
                        {
                            bool tmpPatch = false;
                            for (int x = CurrentPatch; x < tmp.LastPatchID; x++)
                            {
                                tmpPatch = Worker.Installpatch(x, tmp);
                                if (!tmpPatch)
                                {
                                    log += DateTime.Now.ToLongTimeString() + " - Ошибка обновления " + tmp.Name + ". Не удалось загрузить патч №" + (x + 1) + "\n - - - \n";
                                    break;
                                }
                                else
                                {
                                    log += DateTime.Now.ToLongTimeString() + " - Для " + tmp.Name + " установлен патч №" + (x + 1) + "\n - - - \n";
                                    ini.IniWriteValue("Patch", tmp.Name, (x + 1).ToString());
                                }
                            }
                        }
                        else
                            log += DateTime.Now.ToLongTimeString() + " - Нету обновлений для " + tmp.Name + "\n - - - \n"; ;

                    }
                }
                else
                {
                    log += DateTime.Now.ToLongTimeString() + " - Ошибка обновления. Группа не найдена в профиле!!!\n";
                }
                try
                {
                    this.BeginInvoke(new AppendLog(AppendLogMethod), log);
                }
                catch { }
            }
            else
            {
                log += DateTime.Now.ToLongTimeString() + " - Ошибка обновления. Профиль не загружен!!!\n";
                this.BeginInvoke(new AppendLog(AppendLogMethod), log);
            }
        }
        //Закрыть форму по завершению обновления
        private void UpdateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.Abort)
            {
                this.Close();
            }
            else
            {
                Directory.Delete(Directory.GetCurrentDirectory() + "\\tmp", true);
                this.Close();
            }
        }
    }
}
