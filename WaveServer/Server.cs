using Ini;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Text;

namespace WaveServer
{
    public partial class Server : ServiceBase
    {
        System.Timers.Timer doTimer = new System.Timers.Timer();
        IniFile set = new IniFile("C:\\WaveServer\\settings.ini");
        DB db = DB.Instace();

        bool Update = false;

        public Server()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            doTimer.Elapsed += doTimer_Elapsed;
            try { doTimer.Interval = int.Parse(set.IniReadValue("Set", "TimerTick")); }
            catch { }
            if (doTimer.Interval < 1000 || doTimer.Interval > 60000)
                doTimer.Interval = 30000;
            doTimer.Enabled = true;
            doTimer.Start();
            AddLog("Сервис успешно запущен", 0);
        }

        void doTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DataTable DT = db.getDT("SELECT * FROM `scheduler_tasks` WHERE `operation_id` = 1 AND `doit` = 1;");
            if (DT != null && DT.Rows.Count > 0 && !Update)
            {
                AddLog("Обновляю справочник дисконтных карт", 0);
                UpdateCardsDir();
            }
        }

        private void UpdateCardsDir()
        {
            Update = true;
            string Cards = "";
            string Query = "SELECT `card_id`, `fixperc`, `last_name`, `first_name`, `middle_name`, `status`, `category`, `comment`, `commentmode` FROM `directory_cards_tmp`;";
            DataTable DT = db.getDT(Query);
            foreach (DataRow r in DT.Rows)
            {
                try
                {
                    if (GetCardCode(r["card_id"].ToString()) != "")
                    {
                        Cards += r["card_id"].ToString() + "," + GetCardCode(r["card_id"].ToString()) + "," + r["fixperc"].ToString() + "," + r["last_name"].ToString() +
                            "," + r["first_name"].ToString() + "," + r["middle_name"].ToString() +
                            "," + r["status"].ToString() + "," + r["category"].ToString() + "," + r["comment"].ToString() + "," + r["commentmode"].ToString() + ",0\r\n";
                    }
                }
                catch (Exception e)
                {
                    AddLog("Ошибка: " + e.Message, 1);
                }
            }
            Query = "SELECT `directory_account_cards`.`card_id`, `directory_account`.`fixperc`, `directory_account_details`.`last_name`, `directory_account_details`.`first_name`, " +
                    "`directory_account_details`.`middle_name`, `directory_account_cards`.`status`, `directory_account`.`category`, `directory_account`.`is_bonus` " +
                    "FROM `directory_account_cards`, `directory_account`, `directory_account_details` " +
                    "WHERE `directory_account_cards`.`account_id` = `directory_account`.`account_id` AND `directory_account_details`.`account_id` = `directory_account`.`account_id`";
            DT = db.getDT(Query);
            foreach (DataRow r in DT.Rows)
            {
                try
                {
                    if (GetCardCode(r["card_id"].ToString()) != "")
                    {
                        Cards += r["card_id"].ToString() + "," + GetCardCode(r["card_id"].ToString()) + "," + r["fixperc"].ToString() + "," + r["last_name"].ToString() +
                            "," + r["first_name"].ToString() + "," + r["middle_name"].ToString() +
                            "," + r["status"].ToString() + "," + r["category"].ToString() + ",,0," + Convert.ToInt32(bool.Parse(r["is_bonus"].ToString())) + "\r\n";
                    }
                }
                catch (Exception e)
                {
                    AddLog("Ошибка: " + e.Message, 1);
                }
            }
            File.WriteAllText(set.IniReadValue("Set", "DirToCards") + "\\CARDS.txt", Cards, Encoding.Default);
            Query = "DELETE FROM `scheduler_tasks` WHERE `operation_id` = 1 AND `doit` = 1;";
            Query += "INSERT INTO `scheduler_tasks_done` VALUES (1, UNIX_TIMESTAMP(), 0, 0, 0, 1) ON DUPLICATE KEY UPDATE `update_time` = UNIX_TIMESTAMP();";
            db.Execute(Query);
            AddLog("Справочник дисконтных карт успешно обновлен!!!", 0);
            Update = false;
        }

        private string GetCardCode(string CardID)
        {
            try
            {
                if (int.Parse(CardID) > 999999)
                    return "";
                while (CardID.Length != 6)
                {
                    CardID = "0" + CardID;
                }
                CardID = "990016" + CardID;
                return CardID;
            }
            catch
            {
                return "";
            }
        }

        //0("Code")
        //1("CardID")
        //2("FixedDiscount")
        //3("Name")
        //4("FirstName")
        //5("Patronymic")
        //6("Status")
        //7("Category")
        //8("Comment")
        //9("CommentMode")

        protected override void OnStop()
        {
            doTimer.Enabled = false;
            doTimer.Stop();
            AddLog("Сервис остановлен!", 0);
        }

        public void AddLog(string log, int Type)
        {
            try
            {
                if (!EventLog.SourceExists("WaveServer"))
                {
                    EventLog.CreateEventSource("WaveServer", "WaveServer");
                }
                Log.Source = "WaveServer";
                switch (Type)
                {
                    case 0:
                        Log.WriteEntry(log, EventLogEntryType.Information);
                        break;
                    case 1:
                        Log.WriteEntry(log, EventLogEntryType.Error);
                        break;
                    case 2:
                        Log.WriteEntry(log, EventLogEntryType.Warning);
                        break;
                    default:
                        Log.WriteEntry(log, EventLogEntryType.Information);
                        break;
                }

            }
            catch { }
        }
    }

    #region DB connection class
    class DB
    {
        private DB()
        {
            try
            {
                IniFile set = new IniFile("C:\\WaveServer\\settings.ini");
                MSB.Server = set.IniReadValue("Set", "Server");
                MSB.Database = set.IniReadValue("Set", "Database");
                MSB.UserID = set.IniReadValue("Set", "UserID");
                MSB.Password = set.IniReadValue("Set", "Password");
                MSB.Port = uint.Parse(set.IniReadValue("Set", "Port"));
                MSB.DefaultCommandTimeout = 600;
            }
            catch { }
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

        public bool Execute(string Query)
        {
            using (MySqlConnection con = new MySqlConnection())
            {
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
    }
    #endregion
}
