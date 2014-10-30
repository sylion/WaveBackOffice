using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaveBackOffice
{
    public partial class frmDirectoryClientsDetails : Form
    {
        #region Global VAR
        bool edit = false, add = false;
        int id = 0;
        Bitmap bmp = new Bitmap(WaveBackOffice.Properties.Resources.card);
        DataTable DT = new DataTable();
        DataTable DTC = new DataTable();
        DataTable DTLog = new DataTable();
        DB db = DB.Instace();
        string reason = "";
        public void SetReason(string r)
        {
            reason = r;
        }
        bool active_state = false;
        public frmDirectoryClientsDetails()
        {
            InitializeComponent();
            add = true;
        }
        public frmDirectoryClientsDetails(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        #endregion

        frmDirectoryClients frmparent;
        private void frmAccountDetails_Load(object sender, EventArgs e)
        {
            if (!add)
            {
                //load user data
                tbLastName.Enabled = tbFirstName.Enabled = tbMiddleName.Enabled = tbSP.Enabled = tbCardID.Enabled = tbPIN.Enabled = tbTel.Enabled = tbTel2.Enabled =
                tbEmail.Enabled = cbSubscribe.Enabled = cbBonus.Enabled = tbDate.Enabled = tbDate1.Enabled = tbDate2.Enabled = tbDate3.Enabled = tbDate4.Enabled =
                tbCity.Enabled = tbStreet.Enabled = tbBld.Enabled = tbApt.Enabled = tbIndex.Enabled = cbEmployee.Enabled = cbActive.Enabled = tbDescription.Enabled = cbVIP.Enabled = false;
                btnEdit.Enabled = true;
                btnAdd.Text = "Закрыть"; lblCardID.Text = "Лицевой счет:";
                string Query = "SELECT " +
                "directory_account_details.last_name, " +
                "directory_account_details.first_name, " +
                "directory_account_details.middle_name," +
                "directory_account_details.maritalstatus, " +
                "directory_account.pin_code, " +
                "directory_account_details.tel, " +
                "directory_account_details.tel2," +
                "directory_account_details.email, " +
                "directory_account.is_subscribe, " +
                "directory_account.is_bonus, " +
                "directory_account_details.birthday, " +
                "directory_account_details.birthday1," +
                "directory_account_details.birthday2, " +
                "directory_account_details.birthday3, " +
                "directory_account_details.birthday4," +
                "directory_account_details.city, " +
                "directory_account_details.street, " +
                "directory_account_details.bld, " +
                "directory_account_details.apt, " +
                "directory_account_details.index," +
                "directory_account.is_employee, " +
                "directory_account.is_active, " +
                "directory_account.account_bonus, " +
                "directory_account.is_vip, " +
                "directory_account.category, " +
                "directory_account.fixperc, " +
                "FROM_UNIXTIME(directory_account.date_activate) AS `adate`, " +
                "FROM_UNIXTIME(directory_account.date_deactivate) AS `dadate`, " +
                "directory_account.description " +
                "FROM directory_account_details, directory_account WHERE directory_account_details.account_id = directory_account.account_id AND directory_account.account_id = '" + id + "'";

                DT = db.getDT(Query);
                if (DT == null)
                {
                    MessageBox.Show("Ошибка подключения, проверьте настройки соединения с БД!\n" + db.GetLastError(), "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DT == null)
                    return;
                tbLastName.Text = DT.Rows[0]["last_name"].ToString();
                tbFirstName.Text = DT.Rows[0]["first_name"].ToString();
                tbMiddleName.Text = DT.Rows[0]["middle_name"].ToString();
                tbSP.Text = DT.Rows[0]["maritalstatus"].ToString();
                tbCardID.Text = id.ToString();
                tbPIN.Text = DT.Rows[0]["pin_code"].ToString();
                tbTel.Text = DT.Rows[0]["tel"].ToString();
                tbTel2.Text = DT.Rows[0]["tel2"].ToString();
                tbEmail.Text = DT.Rows[0]["email"].ToString();
                if (DT.Rows[0]["is_subscribe"].ToString() == "1" || DT.Rows[0]["is_subscribe"].ToString() == "True")
                    cbSubscribe.Checked = true;
                else
                    cbSubscribe.Checked = false;

                if (DT.Rows[0]["is_bonus"].ToString() == "1" || DT.Rows[0]["is_bonus"].ToString() == "True")
                    cbBonus.Checked = true;
                else
                    cbBonus.Checked = false;

                if (DT.Rows[0]["is_vip"].ToString() == "1" || DT.Rows[0]["is_vip"].ToString() == "True")
                    cbVIP.Checked = true;
                else
                    cbVIP.Checked = false;

                if (DT.Rows[0]["is_employee"].ToString() == "1" || DT.Rows[0]["is_employee"].ToString() == "True")
                    cbEmployee.Checked = true;
                else
                    cbEmployee.Checked = false;

                if (DT.Rows[0]["is_active"].ToString() == "1" || DT.Rows[0]["is_active"].ToString() == "True")
                    cbActive.Checked = true;
                else
                    cbActive.Checked = false;

                if (DT.Rows[0]["birthday"].ToString() != "")
                    tbDate.Text = DateTime.Parse(DT.Rows[0]["birthday"].ToString()).ToShortDateString();
                if (DT.Rows[0]["birthday1"].ToString() != "")
                    tbDate1.Text = DateTime.Parse(DT.Rows[0]["birthday1"].ToString()).ToShortDateString();
                if (DT.Rows[0]["birthday2"].ToString() != "")
                    tbDate2.Text = DateTime.Parse(DT.Rows[0]["birthday2"].ToString()).ToShortDateString();
                if (DT.Rows[0]["birthday3"].ToString() != "")
                    tbDate3.Text = DateTime.Parse(DT.Rows[0]["birthday3"].ToString()).ToShortDateString();
                if (DT.Rows[0]["birthday4"].ToString() != "")
                    tbDate4.Text = DateTime.Parse(DT.Rows[0]["birthday4"].ToString()).ToShortDateString();

                tbCity.Text = DT.Rows[0]["city"].ToString();
                tbStreet.Text = DT.Rows[0]["street"].ToString();
                tbBld.Text = DT.Rows[0]["bld"].ToString();
                tbApt.Text = DT.Rows[0]["apt"].ToString();
                tbIndex.Text = DT.Rows[0]["index"].ToString();

                tbAccountMain.Text = DT.Rows[0]["account_bonus"].ToString();
                tbCategory.Text = DT.Rows[0]["category"].ToString();
                tbFixperc.Text = DT.Rows[0]["fixperc"].ToString();
                tbAdate.Text = DT.Rows[0]["adate"].ToString();
                tbDedate.Text = DT.Rows[0]["dadate"].ToString();
                tbDescription.Text = DT.Rows[0]["description"].ToString();

                LoadCardData();
                active_state = cbActive.Checked;
                LoadUserLog();
            }
            else
            {
                tbCity.Text = WaveBackOffice.Properties.Settings.Default.LastAddedCity;
                frmparent = new frmDirectoryClients();
                this.Owner = frmparent;
                tbLastName.Select();
            }
        }

        private void tabPage_Paint(object sender, PaintEventArgs e)
        {
            bmp.SetResolution(600, 600);
            Point ulCorner = new Point(205, 0);
            e.Graphics.DrawImage(bmp, ulCorner);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!add)
            {
                this.Close();
                return;
            }
            if (!ValidForm())
            {
                MessageBox.Show("Проверьте введнные данные!!!\nПоля: ''Фамилия'' и ''Номер карты'' - обязательны для заполнения!\nДаты вводяться в формате ''dd.mm.yyyy'' например: 21.02.2013", "Ошибка заполнения формы", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string date, date1, date2, date3, date4;
                if (tbPIN.Text == "") tbPIN.Text = "0000";
                if (tbDate.Text == "") date = ""; else date = DateTime.Parse(tbDate.Text).ToShortDateString();
                if (tbDate1.Text == "") date1 = ""; else date1 = DateTime.Parse(tbDate1.Text).ToShortDateString();
                if (tbDate2.Text == "") date2 = ""; else date2 = DateTime.Parse(tbDate2.Text).ToShortDateString();
                if (tbDate3.Text == "") date3 = ""; else date3 = DateTime.Parse(tbDate3.Text).ToShortDateString();
                if (tbDate4.Text == "") date4 = ""; else date4 = DateTime.Parse(tbDate4.Text).ToShortDateString();
                string Query = "SET autocommit = 0; INSERT INTO directory_account (`account_id`, `pin_code`, `is_employee`, `is_subscribe`, `is_bonus`, `is_vip`, `is_active`, `date_activate`, `description`) VALUES (NULL, " +
                    tbPIN.Text + ", " + System.Convert.ToInt32(cbEmployee.Checked) + ", " + System.Convert.ToInt32(cbSubscribe.Checked) + ", " + System.Convert.ToInt32(cbBonus.Checked) + ", " + System.Convert.ToInt32(cbVIP.Checked) + ", " +
                    System.Convert.ToInt32(cbActive.Checked) + ", '" + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()).ToString() + "', '" + tbDescription.Text + "');" +
                "INSERT INTO directory_account_details (`account_id`, `first_name`, `middle_name`, `last_name`, `tel`, `tel2`, `email`, `maritalstatus`, `index`, `city`, `street`, `bld`, `apt`, `birthday`, `birthday1`, `birthday2`, `birthday3`, `birthday4`)" +
                "VALUES (LAST_INSERT_ID(), '" + tbFirstName.Text + "', '" + tbMiddleName.Text + "', '" + tbLastName.Text + "', '" + tbTel.Text + "', '" + tbTel2.Text + "', '" + tbEmail.Text + "', " +
                "'" + tbSP.Text + "', '" + tbIndex.Text + "', '" + tbCity.Text + "', '" + tbStreet.Text + "', '" + tbBld.Text + "', '" + tbApt.Text + "', '" + date + "', '" + date1 + "', '" + date2 + "', '" + date3 + "', '" +
                date4 + "');" + "INSERT INTO directory_account_cards (`account_id`,`card_id`,`status`,`date_activate`) VALUES (LAST_INSERT_ID(), '" + tbCardID.Text + "', 0, '" +
                UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()).ToString() + "');";
                Query += "INSERT INTO `directory_log` (`module_id`, `some_id`, `date`, `operation_id`, `user_id`, `description`)" +
                    "VALUES (1, LAST_INSERT_ID(), " + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()) + ", 1, " + WaveBackOffice.Properties.Settings.Default.CurrentUserID + ", '');";
                Query += "INSERT INTO `scheduler_tasks` (`module_id`, `time`, `is_master`) VALUES ('" + (int)Modules.DirClients +
                    "', '" + UnixTime.ToUnixTimestamp(DateTime.Now) + "', '1') ON DUPLICATE KEY UPDATE `time` = '" + UnixTime.ToUnixTimestamp(DateTime.Now) + "';";
                if (!cbActive.Checked)
                {
                    Query += "UPDATE directory_account SET `date_deactivate` = " + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()).ToString() + " WHERE `account_id` = LAST_INSERT_ID();";
                    Query += "INSERT INTO `directory_log` (`module_id`, `some_id`, `date`, `operation_id`, `user_id`, `description`)" +
                        "VALUES (1, LAST_INSERT_ID(), " + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()) + ", 2, " + WaveBackOffice.Properties.Settings.Default.CurrentUserID + ", '');";
                }
                WaveBackOffice.Properties.Settings.Default.LastAddedCity = tbCity.Text;
                if (db.Execute(Query))
                {
                    this.Close();
                }
                else
                    MessageBox.Show("Ошибка:\n\nПроверьте введенные данные, возможно номер карты который вы пытаетесь добавить уже существует или вы ввели слишком много цифр :) или сервер баз данных не  доступен...\n\n" + db.GetLastError());
            }
        }

        private bool ValidForm()
        {
            if (add) { if (tbCardID.Text.Length < 4) return false; }
            try { if (tbDate.Text != "") DateTime.Parse(tbDate.Text); }
            catch { return false; }
            try { if (tbDate1.Text != "") DateTime.Parse(tbDate1.Text); }
            catch { return false; }
            try { if (tbDate2.Text != "") DateTime.Parse(tbDate2.Text); }
            catch { return false; }
            try { if (tbDate3.Text != "") DateTime.Parse(tbDate3.Text); }
            catch { return false; }
            try { if (tbDate4.Text != "") DateTime.Parse(tbDate4.Text); }
            catch { return false; }
            if (tbCardID.Text == "") return false;
            if (tbLastName.Text == "") return false;
            return true;
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcMain.SelectedIndex)
            {
                case 0:
                    btnEdit.Enabled = true;
                    break;
                case 1:
                    if (add || edit)
                        tcMain.SelectedIndex = 0;
                    else
                        btnEdit.Enabled = false;
                    break;
                case 2:
                    if (add || edit)
                        tcMain.SelectedIndex = 0;
                    else
                        btnEdit.Enabled = false;
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                btnEdit.Text = "Применить";
                edit = true;
                tbLastName.Enabled = tbMiddleName.Enabled = tbFirstName.Enabled = tbPIN.Enabled = tbSP.Enabled = tbTel.Enabled = tbTel2.Enabled = tbEmail.Enabled =
                    cbSubscribe.Enabled = cbBonus.Enabled = tbDate.Enabled = tbDate1.Enabled = tbDate2.Enabled = tbDate3.Enabled = tbDate4.Enabled = tbCity.Enabled = tbIndex.Enabled =
                    tbApt.Enabled = tbBld.Enabled = tbStreet.Enabled = cbEmployee.Enabled = cbActive.Enabled = tbDescription.Enabled = cbVIP.Enabled = true;
            }
            else
            {
                if (ValidForm())
                {
                    string date, date1, date2, date3, date4;
                    if (tbPIN.Text == "") tbPIN.Text = "0000";
                    if (tbDate.Text == "") date = ""; else date = DateTime.Parse(tbDate.Text).ToShortDateString();
                    if (tbDate1.Text == "") date1 = ""; else date1 = DateTime.Parse(tbDate1.Text).ToShortDateString();
                    if (tbDate2.Text == "") date2 = ""; else date2 = DateTime.Parse(tbDate2.Text).ToShortDateString();
                    if (tbDate3.Text == "") date3 = ""; else date3 = DateTime.Parse(tbDate3.Text).ToShortDateString();
                    if (tbDate4.Text == "") date4 = ""; else date4 = DateTime.Parse(tbDate4.Text).ToShortDateString();
                    string Query = "SET autocommit = 0; " +
                    "UPDATE directory_account SET `pin_code` = '" + tbPIN.Text + "', `is_employee` = " + System.Convert.ToInt32(cbEmployee.Checked) +
                    ", `is_subscribe` = " + System.Convert.ToInt32(cbSubscribe.Checked) + ", `is_Bonus` = " + System.Convert.ToInt32(cbBonus.Checked) + ", `is_vip` = " + System.Convert.ToInt32(cbVIP.Checked) + ", `is_active` = " +
                    System.Convert.ToInt32(cbActive.Checked) + ", `description` = '" + tbDescription.Text + "' WHERE `account_id` = " + id + ";" +
                    "UPDATE directory_account_details SET `first_name`='" + tbFirstName.Text + "', `middle_name` = '" + tbMiddleName.Text + "', `last_name` = '" + tbLastName.Text +
                    "', `tel` = '" + tbTel.Text + "', `tel2` = '" + tbTel2.Text + "', `email` = '" + tbEmail.Text + "', `maritalstatus` = '" + tbSP.Text + "', `index` = '" + tbIndex.Text +
                    "', `city` = '" + tbCity.Text + "', `street` = '" + tbStreet.Text + "', `bld` = '" + tbBld.Text + "', `apt` = '" + tbApt.Text +
                    "', `birthday` = '" + date + "', `birthday1` = '" + date1 + "', `birthday2` = '" + date2 + "', `birthday3` = '" + date3 + "', `birthday4` = '" + date4 + "' WHERE `account_id` = " + id + ";";
                    Query += "INSERT INTO `directory_log` (`module_id`, `some_id`, `date`, `operation_id`, `user_id`, `description`)" +
                        "VALUES (1, " + id + ", " + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()) + ", 7, " + WaveBackOffice.Properties.Settings.Default.CurrentUserID + ", '');";
                    Query += "INSERT INTO `scheduler_tasks` (`module_id`, `time`, `is_master`) VALUES ('" + (int)Modules.DirClients +
                    "', '" + UnixTime.ToUnixTimestamp(DateTime.Now) + "', '1') ON DUPLICATE KEY UPDATE `time` = '" + UnixTime.ToUnixTimestamp(DateTime.Now) + "';";
                    //If activation state changed
                    if (cbActive.Checked != active_state && active_state)
                    {
                        //Call InputDialog form to request operation reasons
                        using (var form = new frmInputBox())
                        {
                            form.ShowDialog();
                            string val = form.ReturnValue;
                            reason = val;
                        }
                        if (reason != string.Empty)
                        {
                            Query += "UPDATE directory_account SET `date_deactivate` = " + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()) + " WHERE `account_id` = " + id + ";";
                            //Add record to log
                            Query += "INSERT INTO `directory_log` (`module_id`, `some_id`, `date`, `operation_id`, `user_id`, `description`)" +
                            "VALUES (1, " + id + ", " + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()) + ", 2, " + WaveBackOffice.Properties.Settings.Default.CurrentUserID + ", '" + reason + "');";
                            active_state = cbActive.Checked;
                        }
                    }
                    else if (cbActive.Checked != active_state && !active_state)
                    {
                        //Add record to log and set activation state
                        Query += "INSERT INTO `directory_log` (`module_id`, `some_id`, `date`, `operation_id`, `user_id`, `description`)" +
                        "VALUES (1, " + id + ", " + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()) + ", 3, " + WaveBackOffice.Properties.Settings.Default.CurrentUserID + ", '');" +
                        "UPDATE directory_account SET `date_deactivate` = NULL WHERE `account_id` = " + id + ";";
                        active_state = cbActive.Checked;
                    }
                    if (db.Execute(Query))
                    {
                        tbLastName.Enabled = tbMiddleName.Enabled = tbFirstName.Enabled = tbPIN.Enabled = tbSP.Enabled =
                        tbTel.Enabled = tbTel2.Enabled = tbEmail.Enabled = cbSubscribe.Enabled = cbBonus.Enabled = tbDate.Enabled = tbDate1.Enabled = tbDate2.Enabled = tbDate3.Enabled = tbDate4.Enabled =
                        tbCity.Enabled = tbIndex.Enabled = tbApt.Enabled = tbBld.Enabled = tbStreet.Enabled = cbEmployee.Enabled = cbActive.Enabled = tbDescription.Enabled = cbVIP.Enabled = false;
                        btnEdit.Text = "Изменить";
                        edit = false;
                        LoadUserLog();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка:\n\nПроверьте введенные данные, возможно номер карты который вы пытаетесь добавить уже существует или вы ввели слишком много цифр :) или сервер баз данных не  доступен...\n\n" + db.GetLastError());
                    }
                }
                else
                    MessageBox.Show("Проверьте введнные данные!!!\nПоля: ''Фамилия'' - обязательны для заполнения!\nДаты вводяться в формате ''dd.mm.yyyy'' например: 21.02.2013", "Ошибка заполнения формы", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Enter))
            {
                if (!edit)
                {
                    btnAdd_Click(this, new EventArgs());
                    return true;
                }
                else
                    btnEdit_Click(this, new EventArgs());

            }
            if (keyData == (Keys.Escape))
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LoadCardData()
        {
            dgvCards.Columns.Clear();
            string Query = "SELECT `card_id` AS `ID`, CASE WHEN `use_bonus` = 0 THEN 'Нет' ELSE 'Да' END AS `Бонусная`, `status`, " +
                "FROM_UNIXTIME(`date_activate`) AS `adate`, FROM_UNIXTIME(`date_deactivate`) AS `dedate` FROM directory_account_cards WHERE `account_id` = " + id;
            DTC = db.getDT(Query);
            dgvCards.Columns.Add("ID", "ID");
            dgvCards.Columns.Add("Бонусная", "Бонусная");
            dgvCards.Columns.Add("Статус", "Статус");
            dgvCards.Columns.Add("adate", "Дата активации");
            dgvCards.Columns.Add("dedate", "Дата деактивации");
            foreach (DataRow row in DTC.Rows)
            {
                object[] _items = row.ItemArray;
                dgvCards.Rows.Add(_items);
            }
            dgvCards.Columns["adate"].Visible = false;
            dgvCards.Columns["dedate"].Visible = false;
        }

        private void btnCardAdd_Click(object sender, EventArgs e)
        {
            if (tbNewCardID.Text.Length > 0)
            {
                string Query = "INSERT INTO directory_account_cards (`account_id`,`card_id`, `use_bonus`, `is_active`,`date_activate`) VALUES (" + id + ", '" + tbNewCardID.Text +
                    "', 1, 1, '" + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()).ToString() + "');";
                Query += db.GetLogQuery((int)Modules.DirClients, id, 4, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Карта #" + tbNewCardID.Text);
                if (db.Execute(Query))
                {
                    tbNewCardID.Text = "";
                    LoadCardData();
                }
                else
                {
                    MessageBox.Show("Возможно карта уже существует или нету соединения с сервером баз данных\n\n" + db.GetLastError(), "Ошибка добавления карты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Номер карты не может меньше 4х цифр", "Ошибка ввода");
        }

        //Load user log 
        private void LoadUserLog()
        {
            string Query = "SELECT FROM_UNIXTIME(`directory_log`.`date`) AS `Дата`, `directory_log_operations`.`description` AS `Операция`, " +
            "`directory_users`.`name` AS `Пользователь`, `directory_log`.`description` AS `Примечание` FROM `directory_log`, `directory_log_operations`, `directory_users` " +
            "WHERE `directory_log`.`some_id` = " + id + " AND `directory_log`.`operation_id` = `directory_log_operations`.`operation_id` and `directory_users`.`id` = `directory_log`.`user_id`";
            DTLog = db.getDT(Query);
            dgvLog.DataSource = DTLog;
            dgvLog.Update();
        }

        int CardState = 0;
        private void dgwCards_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCards.CurrentCell.RowIndex >= 0)
            {
                tbCardADate.Text = dgvCards.Rows[dgvCards.CurrentCell.RowIndex].Cells["adate"].Value.ToString();
                tbCardDDate.Text = dgvCards.Rows[dgvCards.CurrentCell.RowIndex].Cells["dedate"].Value.ToString();
                cbCardStatus.SelectedIndex = Convert.ToInt32(dgvCards.Rows[dgvCards.CurrentCell.RowIndex].Cells["Статус"].Value);
                CardState = cbCardStatus.SelectedIndex;
                if (dgvCards.Rows[dgvCards.CurrentCell.RowIndex].Cells["Бонусная"].Value.ToString() == "Да")
                    cbsiCardBonus.Checked = true;
                else
                    cbsiCardBonus.Checked = false;

            }
            else
                btnCardEdit.Enabled = false;

        }

        private void dgwCards_Enter(object sender, EventArgs e)
        {
            if (dgvCards.CurrentCell.RowIndex >= 0)
            {
                btnCardEdit.Enabled = true;
            }
        }

        private void btnCardEdit_Click(object sender, EventArgs e)
        {
            string Query = "UPDATE directory_account_cards SET `use_bonus` = " + System.Convert.ToInt32(cbsiCardBonus.Checked) +
                    ", `status` = " + cbCardStatus.SelectedIndex + " WHERE `card_id` = " + dgvCards.Rows[dgvCards.CurrentCell.RowIndex].Cells["ID"].Value.ToString() + ";";
            Query += db.GetLogQuery((int)Modules.DirClients, id, 8, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Карта №" + dgvCards.Rows[dgvCards.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
            if (CardState != cbCardStatus.SelectedIndex && cbCardStatus.SelectedIndex == 0)
            {
                Query += db.GetLogQuery((int)Modules.DirClients, id, 6, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Карта №" + dgvCards.Rows[dgvCards.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
                Query += "UPDATE directory_account_cards SET `date_deactivate` = NULL WHERE `card_id` = " + dgvCards.Rows[dgvCards.CurrentCell.RowIndex].Cells["ID"].Value.ToString() + ";";
            }
            else if (CardState != cbCardStatus.SelectedIndex && cbCardStatus.SelectedIndex > 0)
            {
                using (var form = new frmInputBox())
                {
                    form.ShowDialog();
                    string val = form.ReturnValue;
                    reason = val;
                }
                if (reason != string.Empty)
                {
                    Query += "UPDATE directory_account_cards SET `date_deactivate` = " + UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()) + " WHERE `card_id` = " + dgvCards.Rows[dgvCards.CurrentCell.RowIndex].Cells["ID"].Value.ToString() + ";";
                    Query += db.GetLogQuery((int)Modules.DirClients, id, 5, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Карта №" + dgvCards.Rows[dgvCards.CurrentCell.RowIndex].Cells["ID"].Value.ToString() + " " + reason);
                }
            }
            if (!db.Execute(Query))
            {
                MessageBox.Show("Возможно нету соединения с сервером баз данных\n\n" + db.GetLastError(), "Ошибка изменения карты", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCardData();
            LoadUserLog();
        }

        private void dgwLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvLog.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                MessageBox.Show(dgvLog.Rows[e.RowIndex].Cells[0].Value.ToString() + "\n" +
                    dgvLog.Rows[e.RowIndex].Cells[1].Value.ToString() + "\n" +
                    "Пользователь: " + dgvLog.Rows[e.RowIndex].Cells[2].Value.ToString() + "\n" +
                    dgvLog.Rows[e.RowIndex].Cells[3].Value.ToString());
        }
    }
}
