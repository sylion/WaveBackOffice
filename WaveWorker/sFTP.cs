using System;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace Hvylya_Worker
{
    static class sFTP
    {
        public static string checkGC(Settings set)
        {
            frmMain.checkStarted = true;
            try
            {
                bool OK = false;
                FastZip fastZip = new FastZip();
                string fileFilter = null;
                string answer = "", rattr = "";

                //Goods
                rattr = File.GetLastWriteTime(set.baseupdater.goodsDir + "\\GOODS.ZIP").ToString();
                if (File.Exists(set.localdirs.InPath + "\\GOODS.ZIP"))
                {
                    if (rattr != File.GetLastWriteTime(set.localdirs.InPath + "\\GOODS.ZIP").ToString())
                        OK = true;
                }
                else
                    OK = true;

                if (OK)
                {
                    //Download and unpack goods
                    File.Copy(set.baseupdater.goodsDir + "\\GOODS.ZIP", set.localdirs.InPath + "\\GOODS.ZIP", true);
                    File.SetLastWriteTime(set.localdirs.InPath + "\\GOODS.ZIP", DateTime.Parse(rattr));
                    answer += " - Справочник товаров обновлен - " + rattr + "\n";
                    fastZip.ExtractZip(set.localdirs.InPath + "\\GOODS.ZIP", set.localdirs.InPath, fileFilter);
                    using (File.Create(set.localdirs.CommandPath + "\\req1.tmp")) { }
                    File.Move(set.localdirs.CommandPath + "\\req1.tmp", set.localdirs.CommandPath + "\\req1");
                    OK = false;
                }
                //Cards
                rattr = File.GetLastWriteTime(set.baseupdater.cardsDir + "\\CARDS.ZIP").ToString();
                if (File.Exists(set.localdirs.InPath + "\\CARDS.ZIP"))
                {
                    if (rattr != File.GetLastWriteTime(set.localdirs.InPath + "\\CARDS.ZIP").ToString())
                        OK = true;
                }
                else
                    OK = true;

                if (OK)
                {
                    //Download and unpack cards
                    File.Copy(set.baseupdater.cardsDir + "\\CARDS.ZIP", set.localdirs.InPath + "\\CARDS.ZIP", true);
                    File.SetLastWriteTime(set.localdirs.InPath + "\\CARDS.ZIP", DateTime.Parse(rattr));
                    answer += " - Справочник дисконтных карт обновлен - " + rattr + "\n";
                    fastZip.ExtractZip(set.localdirs.InPath + "\\CARDS.ZIP", set.localdirs.InPath, fileFilter);
                    using (File.Create(set.localdirs.CommandPath + "\\req5.tmp")) { }
                    File.Move(set.localdirs.CommandPath + "\\req5.tmp", set.localdirs.CommandPath + "\\req5");
                    OK = false;
                }
                frmMain.checkStarted = false;
                return answer;
            }
            catch (Exception e)
            {
                frmMain.checkStarted = false;
                return e.Message;
            }
        }

        public static string putChecks(Settings set)
        {
            frmMain.sendStarted = true;
            string[] files = Directory.GetFiles(set.localdirs.SalesPath, "*.xml");
            System.Threading.Thread.Sleep(1000);
            if (files.Length > 0)
            {
                try
                {
                    string tmpName = "";
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (!Path.GetFileName(files[i]).StartsWith("F"))
                        {
                            tmpName = set.uploader.SalesDir + "\\" + Path.GetFileName(files[i]).Insert(1, "_" + Environment.MachineName + "_") + ".tmp";
                            File.Copy(files[i], tmpName, true);
                            File.Move(tmpName, tmpName.Replace(".tmp", ""));
                            File.Delete(files[i]);
                        }
                        files[i] = null;
                    }
                    frmMain.sendStarted = false;
                    return "";
                }
                catch (Exception e)
                {
                    frmMain.sendStarted = false;
                    return e.Message;
                }
            }
            frmMain.sendStarted = false;
            return "";
        }

        public static string putLocalChecks(Settings set)
        {
            frmMain.sendLocalStarted = true;
            try
            {
                string[] files = Directory.GetFiles(set.localdirs.SalesPath, "*.xml");
                System.Threading.Thread.Sleep(1000);
                foreach (string y in files)
                {
                    if (Path.GetFileName(y).StartsWith("F"))
                    {
                        File.Copy(y, set.fpserver.SalesPath + "\\" + Path.GetFileName(y), true);
                        File.Delete(y);
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                frmMain.sendLocalStarted = false;
            }
            return "";
        }

    }
}
