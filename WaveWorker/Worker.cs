using ICSharpCode.SharpZipLib.Zip;
using Microsoft.Win32;
using System.IO;
using System.Windows.Forms;

namespace Hvylya_Worker
{
    public static class Worker
    {
        //Синхронизация времени NET TIME ...
        public static void syncTime(Main mainset)
        {
            System.Diagnostics.Process netTime = new System.Diagnostics.Process();
            netTime.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            netTime.StartInfo.FileName = "NET.exe";
            netTime.StartInfo.Arguments = "TIME \\\\" + mainset.TimeServer + " /SET /Y";
            netTime.Start();
        }
        //Запуск софта
        public static void AutoStart(Main set)
        {
            try
            {
                if (set.Autorun.Length >= 0)
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    if (set.Autorun[0] != "" && set.Autorun != null && set.Autorun.Length > 0)
                    {
                        for (int i = 0; i < set.Autorun.Length; i++)
                        {
                            try
                            {
                                proc.StartInfo.FileName = set.Autorun[i];
                                proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(set.Autorun[i]);
                                proc.Start();
                            }
                            catch { }
                        }
                    }
                }
            }
            catch { }
        }
        //Установка патчей
        public static bool Installpatch(int patchID, Soft soft)
        {
            FastZip fastZip = new FastZip();
            string fileFilter = null;
            if (patchID <= 0)
                patchID = 1;
            else
                patchID++;
            Settings set = SettingsControl.Load();
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\tmp\\" + soft.Name))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\tmp\\" + soft.Name);
            if (FTP.get(set.softwareupdater, soft.Name, patchID + ".zip",
                 Directory.GetCurrentDirectory() + "\\tmp\\" + soft.Name + "\\") == 0)
            {
                fastZip.ExtractZip(Directory.GetCurrentDirectory() + "\\tmp\\" + soft.Name + "\\" + patchID + ".zip",
                    soft.Patches[patchID].PathToInstall + "\\", fileFilter);
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = soft.Patches[patchID].CommandToRun;
                try
                {
                    proc.Start();
                    proc.WaitForExit();
                }
                catch { }
            }
            else
            {
                return false;
            }
            return true;
        }
        //Закачка и распаковка патча в темп директорию
        public static bool InstallSelfPatch(int patchID)
        {
            FastZip fastZip = new FastZip();
            string fileFilter = null;
            Settings set = SettingsControl.Load();
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\tmp\\Worker\\"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\tmp\\worker\\");
            if (FTP.get(set.softwareupdater, "worker", patchID + ".zip",
                 Directory.GetCurrentDirectory() + "\\tmp\\worker\\") == 0)
            {
                fastZip.ExtractZip(Directory.GetCurrentDirectory() + "\\tmp\\worker\\" + patchID + ".zip",
                    Directory.GetCurrentDirectory() + "\\tmp\\worker\\", fileFilter);
                return true;
            }
            else
            {
                return false;
            }
        }
        //Получение профиля с FTP
        public static Profile GetProfile(SoftwareUpdater Set)
        {
            if (FTP.get(Set, "", "profile.xml", Application.UserAppDataPath) == 0)
            {
                return ProfileControl.Load(Application.UserAppDataPath + "\\profile.xml");
            }
            else
            {
                return null;
            }
        }
        //Установка автозапуска
        public static void SetAutostart(bool Autostart)
        {
            if (Autostart)
            {
                RegistryKey Hvylya =
                Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
                Hvylya.SetValue("Hvylya", Application.ExecutablePath.ToString());
            }
            else
            {
                try
                {
                    RegistryKey Hvylya =
                    Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
                    Hvylya.DeleteValue("Hvylya");
                }
                catch { }
            }
        }
    }
}
