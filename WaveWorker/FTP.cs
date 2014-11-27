using System;
using System.IO;
using System.Net;

namespace Hvylya_Worker
{
    static class FTP
    {
        //Загрузка указанного файла с FTP
        static public int get(SoftwareUpdater Settings, string dir, string file, string localpath)
        {
            int z = 0;
        retry:
            try
            {
                string mytmp = Path.GetTempPath() + "\\HW\\";
                if (!Directory.Exists(mytmp))
                    Directory.CreateDirectory(mytmp);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Settings.FTPServer + "/" + dir + "/" + file);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(Settings.FTPLogin, Settings.FTPPassword);
                request.Timeout = 10000;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                //Запись файла
                FileStream writeStream = new FileStream(mytmp + file, FileMode.Create);
                int Length = 2048;
                Byte[] buffer = new Byte[Length];
                int bytesRead = responseStream.Read(buffer, 0, Length);
                while (bytesRead > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                    bytesRead = responseStream.Read(buffer, 0, Length);
                }
                writeStream.Close();
                writeStream.Dispose();
                response.Close();
                File.Move(mytmp + file, localpath + "\\" + file);
                return 0;
            }
            catch
            {
                if (z < 3)
                {
                    z++;
                    goto retry;
                }
                return 1;
            }
        }
    }
}
