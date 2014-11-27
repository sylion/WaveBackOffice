using System.IO;

namespace Hvylya_Worker
{
    public static class Cleaner
    {
        public static void Clean()
        {
            string[] logs;
            //Smarket errors
            if (Directory.Exists("C:\\smarket\\errors"))
            {
                if (Directory.Exists("C:\\smarket\\errors\\old"))
                    Directory.Delete("C:\\smarket\\errors\\old", true);
                logs = Directory.GetFiles("C:\\smarket\\errors\\");
                Directory.CreateDirectory("C:\\smarket\\errors\\old");
                for (int i = 0; i < logs.Length; i++)
                {
                    File.Move(logs[i], "C:\\smarket\\errors\\old\\" + Path.GetFileName(logs[i]));
                }
            }
            //updater logs
            if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Log"))
            {
                if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Log\\old\\"))
                    Directory.Delete(Directory.GetCurrentDirectory() + "\\Log\\old\\", true);
                logs = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Log\\");
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Log\\old\\");
                for (int i = 0; i < logs.Length; i++)
                {
                    File.Move(logs[i], Directory.GetCurrentDirectory() + "\\log\\old\\" + Path.GetFileName(logs[i]));
                }
            }
            //fpserver logs
            if (Directory.Exists("C:\\Smarket\\fpserver\\Log"))
            {
                if (Directory.Exists("C:\\Smarket\\fpserver\\Log\\old\\"))
                    Directory.Delete("C:\\Smarket\\fpserver\\Log\\old\\", true);
                logs = Directory.GetFiles("C:\\Smarket\\fpserver\\Log\\");
                Directory.CreateDirectory("C:\\Smarket\\fpserver\\Log\\old\\");
                for (int i = 0; i < logs.Length; i++)
                {
                    File.Move(logs[i], "C:\\Smarket\\fpserver\\log\\old\\" + Path.GetFileName(logs[i]));
                }
            }
            //fpserver checks
            if (Directory.Exists("C:\\Smarket\\fpserver\\check"))
            {
                if (Directory.Exists("C:\\Smarket\\fpserver\\check\\old\\"))
                    Directory.Delete("C:\\Smarket\\fpserver\\check\\old\\", true);
                logs = Directory.GetFiles("C:\\Smarket\\fpserver\\check\\");
                Directory.CreateDirectory("C:\\Smarket\\fpserver\\check\\old\\");
                for (int i = 0; i < logs.Length; i++)
                {
                    File.Move(logs[i], "C:\\Smarket\\fpserver\\check\\old\\" + Path.GetFileName(logs[i]));
                }
            }
            //Smarket fpio
            if (Directory.Exists("C:\\smarket\\fpio"))
            {
                if (Directory.Exists("C:\\smarket\\fpio\\old"))
                    Directory.Delete("C:\\smarket\\fpio\\old", true);
                logs = Directory.GetFiles("C:\\smarket\\fpio\\");
                Directory.CreateDirectory("C:\\smarket\\fpio\\old");
                for (int i = 0; i < logs.Length; i++)
                {
                    File.Move(logs[i], "C:\\smarket\\fpio\\old\\" + Path.GetFileName(logs[i]));
                }
            }
        }
    }
}
