using System.Xml.Serialization;
using System.IO;

namespace Hvylya_Worker
{
    static class SettingsControl
    {
        public static void Save(Settings set)
        {
            XmlSerializer mySerializer = new
            XmlSerializer(typeof(Settings));
            StreamWriter myWriter = new StreamWriter(Directory.GetCurrentDirectory() + "\\settings.xml");
            mySerializer.Serialize(myWriter, set);
            myWriter.Close();
        }

        public static Settings Load()
        {
            Settings set = new Settings();
            if (File.Exists(Directory.GetCurrentDirectory() + "\\settings.xml"))
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(Settings));
                FileStream myFileStream = new FileStream(Directory.GetCurrentDirectory() + "\\settings.xml", FileMode.Open);
                set = (Settings)mySerializer.Deserialize(myFileStream);
                myFileStream.Close();
                return set;
            }
            else
            {
                return null;
            }
        }

        public static bool CheckSet(Settings Set)
        {
            if (Set.baseupdater.cardsDir == "cardsDir" || Set.baseupdater.goodsDir == "goodsDir" ||
                Set.fpserver.ServerAddress == "ServerAddress" ||
                Set.fpserver.SalesPath == "SalesPath" || Set.localdirs.InPath == "InPath" || Set.localdirs.OutPath == "OutPath" ||
                Set.localdirs.SalesPath == "SalesPath" || Set.localdirs.CommandPath == "CommandPath" ||
                Set.softwareupdater.UpdateGoup == "UpdateGoup" || Set.softwareupdater.FTPServer == "FTPServer" ||
                Set.softwareupdater.FTPPassword == "FTPPassword" || Set.uploader.SalesDir == "SalesDir" || 
                Set.softwareupdater.FTPLogin == "FTPLogin")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class Settings
    {
        public Settings()
        {
        }   
        public Main main = new Main();
        public FPServer fpserver = new FPServer();
        public LocalDirs localdirs = new LocalDirs();
        public SoftwareUpdater softwareupdater = new SoftwareUpdater();
        public BaseUpdater baseupdater = new BaseUpdater();
        public Uploader uploader = new Uploader();
    }

    public class Main
    {
        public Main()
        {
            Offline = true;
            sendF = true;
            sendSC = true;
            checkGC = true;
            checkUpdates = true;
            Autostart = true;
            startSoft = true;
            CheckTimer = 5000;
            GCTimer = 60000;
            syncTimer = 180000;
            uploadTimer = 5000;
            Autorun = new string[1] {"Autorun String"};
            TimeServer = "10.0.1.142";
            fullLogs = true;
            
        }
        public bool Offline { get; set; }
        public bool sendF { get; set; }
        public bool sendSC { get; set; }
        public bool checkGC { get; set; }
        public bool checkUpdates { get; set; }
        public bool Autostart { get; set; }
        public bool startSoft { get; set; }
        public uint CheckTimer { get; set; }
        public uint GCTimer { get; set; }
        public uint syncTimer { get; set; }
        public uint uploadTimer { get; set; }
        public string[] Autorun { get; set; }
        public string TimeServer { get; set; }
        public bool fullLogs { get; set; }
    }

    public class FPServer
    {
        public FPServer()
        {
            SalesPath = "SalesPath";
            ServerAddress = "ServerAddress";
        }
        public string SalesPath { get; set; }
        public string ServerAddress { get; set; }
        //uint ServerPort { get; set; }
    }

    public class LocalDirs
    {
        public LocalDirs()
        {
            InPath = "InPath";
            OutPath = "OutPath";
            CommandPath = "CommandPath";
            SalesPath = "SalesPath";
        }
        public string InPath { get; set; }
        public string OutPath { get; set; }
        public string CommandPath { get; set; }
        public string SalesPath { get; set; }
    }

    public class SoftwareUpdater
    {
        public SoftwareUpdater()
        {
            FTPServer = "FTPServer";
            FTPLogin = "FTPLogin";
            FTPPassword = "FTPPassword";
            UpdateGoup = "UpdateGoup";

        }
        public string FTPServer { get; set; }
        public string FTPLogin { get; set; }
        public string FTPPassword { get; set; }
        public string UpdateGoup { get; set; }
    }

    public class BaseUpdater
    {
        public BaseUpdater()
        {
            goodsDir = "goodsDir";
            cardsDir = "cardsDir";
        }
        public string goodsDir { get; set; }
        public string cardsDir { get; set; }
    }

    public class Uploader
    {
        public Uploader()
        {
            SalesDir = "SalesDir";
        }
        public string SalesDir { get; set; }
    }
}