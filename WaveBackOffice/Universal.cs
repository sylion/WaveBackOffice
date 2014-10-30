using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace WaveBackOffice
{
    #region Unix Timestamps
    static class UnixTime
    {
        public static DateTime FromUnixTimestamp(ulong timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified);
            return origin.AddSeconds(timestamp);
        }
        public static ulong ToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified);
            TimeSpan diff = date - origin;
            return (ulong)Math.Floor(diff.TotalSeconds);
        }
    }
    #endregion

    #region DB connection class
    class DB
    {
        private DB()
        {
            MSB.Server = WaveBackOffice.Properties.Settings.Default.DBAddress;
            MSB.Database = WaveBackOffice.Properties.Settings.Default.DBName;
            MSB.UserID = WaveBackOffice.Properties.Settings.Default.DBLogin;
            MSB.Password = WaveBackOffice.Properties.Settings.Default.DBPwd;
            MSB.Port = uint.Parse(WaveBackOffice.Properties.Settings.Default.DBPort);
            MSB.DefaultCommandTimeout = 600;
        }

        private void UpdateSettings()
        {
            MSB.Server = WaveBackOffice.Properties.Settings.Default.DBAddress;
            MSB.Database = WaveBackOffice.Properties.Settings.Default.DBName;
            MSB.UserID = WaveBackOffice.Properties.Settings.Default.DBLogin;
            MSB.Password = WaveBackOffice.Properties.Settings.Default.DBPwd;
            MSB.Port = uint.Parse(WaveBackOffice.Properties.Settings.Default.DBPort);
        }

        private static DB instance;

        public static DB Instace()
        {
            if (instance == null)
            {
                instance = new DB();
            }

            return instance;
        }

        MySqlConnectionStringBuilder MSB = new MySqlConnectionStringBuilder();

        string Error = "";

        public string GetLastError()
        {
            return Error;
        }

        public bool testConnection()
        {
            try
            {
                UpdateSettings();
                using (MySqlConnection con = new MySqlConnection())
                {
                    con.ConnectionString = MSB.ConnectionString;
                    con.Open();
                    con.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                Error = e.Message;
                return false;
            }
        }

        public DataTable getDT(string Query)
        {
            using (MySqlConnection con = new MySqlConnection())
            {
                UpdateSettings();
                con.ConnectionString = MSB.ConnectionString;
                MySqlCommand com = new MySqlCommand(/*"set net_write_timeout=99999; set net_read_timeout=99999; " + */Query, con);
                DataTable DT = new DataTable();
                try
                {
                    MySqlDataAdapter adr = new MySqlDataAdapter(Query, con);
                    adr.SelectCommand.CommandType = CommandType.Text;
                    adr.Fill(DT);
                    return DT;
                }
                catch (Exception e)
                {
                    Error = e.Message;
                    return null;
                }
            }
        }

        public string GetLogQuery(int ModuleID, int SomeID, int operationID, int UserID, string Description)
        {
            string Query = "INSERT INTO `directory_log` (`module_id`, `some_id`, `date`, `operation_id`, `user_id`, `description`)" +
                "VALUES (" + ModuleID + ", " + SomeID + ", " + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()) + ", " + operationID + ", " + UserID + ", '" + Description + "');";
            return Query;
        }

        public string GetLogQuery(int ModuleID, int operationID, int UserID, string Description)
        {
            string Query = "INSERT INTO `directory_log` (`module_id`, `some_id`, `date`, `operation_id`, `user_id`, `description`)" +
                "VALUES (" + ModuleID + ", LAST_INSERT_ID(), " + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()) + ", " + operationID + ", " + UserID + ", '" + Description + "');";
            return Query;
        }

        public bool LogAdd(int ModuleID, int SomeID, int operationID, int UserID, string Description)
        {
            using (MySqlConnection con = new MySqlConnection())
            {
                UpdateSettings();
                string Query = "INSERT INTO directory_log (`module_id`, `some_id`, `date`, `operation_id`, `user_id`, `description`)" +
                    "VALUES (" + ModuleID + ", " + SomeID + ", " + UnixTime.ToUnixTimestamp(DateTime.Now) + ", " + operationID + ", " + UserID + ", '" + Description + "')";
                con.ConnectionString = MSB.ConnectionString;
                MySqlCommand com = new MySqlCommand(Query, con);
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception e)
                {
                    Error = e.Message;
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
            return true;
        }

        public bool Execute(string Query)
        {
            using (MySqlConnection con = new MySqlConnection())
            {
                UpdateSettings();
                con.ConnectionString = MSB.ConnectionString;
                MySqlCommand com = new MySqlCommand(Query, con);
                try
                {
                    con.Open();
                    MySqlTransaction trans;
                    trans = con.BeginTransaction();
                    try
                    {
                        com.ExecuteNonQuery();
                        trans.Commit();
                    }
                    catch (Exception e)
                    {
                        trans.Rollback();
                        Error = e.Message;
                        return false;
                    }
                    finally
                    {
                        con.Close();
                    }
                    return true;
                }
                catch (Exception e)
                {
                    Error = e.Message;
                    return false;
                }
            }
        }

        public static string CreateNewDB(string Host, string User, string Password, string Port, string NewDBName)
        {
            MySqlConnection Connection = new MySqlConnection("Data Source=" + Host + ";Port=" + Port + ";User Id=" + User + ";Password=" + Password + ";");
            MySqlCommand Query = new MySqlCommand();
            Query.Connection = Connection;
            try
            {
                Connection.Open();
                Query.CommandText = "CREATE DATABASE `" + NewDBName + "` /*!40100 DEFAULT CHARACTER SET utf8 */;";
                Query.ExecuteNonQuery();
                Query.CommandText = "USE " + NewDBName + ";";
                Query.ExecuteNonQuery();
                Query.CommandText = System.IO.File.ReadAllText(System.IO.Directory.GetCurrentDirectory() + @"\DBschema.sql");
                Query.ExecuteNonQuery();

            }
            catch (MySqlException SSDB_Exception)
            {
                return SSDB_Exception.Message;
            }
            finally
            {
                Connection.Close();
            }
            return "";
        }
    }
    #endregion

    public enum EditMode { POS, Object, Group }
    public enum Modules { DirClients = 1, AppProtokol = 2, DirPOS = 3, AppMarketing = 4, AppScheduler = 5, DirOperators = 6, DirUsers = 7 }
    public enum Right
    {
        DirClients = 2,
        AppProtokol = 4,
        DirPOS = 8,
        AppMarketing = 16,
        ProtokolPalitra = 32,
        EditClients = 64,
        Logs = 128,
        DirOperators = 256,
        AppScheduler = 512,
        DirUsers = 1024
    }

    public static class Rights
    {
        public static bool Get(int Right)
        {
            return true;
        }
    }

    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
