using System;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Hvylya_Worker
{
    public static class FPS
    {
        public static bool checkServer()
        {
            Settings set = SettingsControl.Load();
            TcpClient TClient = new TcpClient();
            Socket client = TClient.Client;
            try
            {
                TClient.Connect(set.fpserver.ServerAddress, 4500);
                byte[] rcvBuffer = new byte[1000];
                string tmpBuffer = "";
                client.Send(Encoding.Default.GetBytes(Environment.MachineName));
                client.SendTimeout = 3000;
                frmMain.FPServerRun = true;
                while (client.Connected)
                {
                    rcvBuffer = new byte[1000];
                    client.Receive(rcvBuffer);
                    tmpBuffer = Encoding.Default.GetString(rcvBuffer);
                    if (tmpBuffer.Length > 0 && tmpBuffer.Trim(tmpBuffer[0]) == "")                     
                        break;
                    if (set.fpserver.ServerAddress != "127.0.0.1" && set.fpserver.ServerAddress != "localhost"
                        && set.fpserver.ServerAddress != Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString())
                    {
                        frmMain.FPSerror = tmpBuffer;
                        frmMain.FPSerrorUP = true;
                    }
                    System.Threading.Thread.Sleep(3000);
                }
                TClient.Close();
                client.Close();
                frmMain.FPSerror = "";
                frmMain.FPSerrorUP = true;
                frmMain.FPServerRun = false;
                return false;
            }
            catch
            {
                TClient.Close();
                client.Close();
                frmMain.FPSerror = "";
                frmMain.FPSerrorUP = true;
                frmMain.FPServerRun = false;
                return false;
            }
        }
    }
}
