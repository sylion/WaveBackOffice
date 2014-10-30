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
    public partial class frmDirectoryOperatorsDetails : Form
    {
        DB db = DB.Instace();
        int RightMask = 0;
        string Query = "";
        bool add = false;
        string ID = "";
        bool Deleted = false;
        public frmDirectoryOperatorsDetails(bool Add, string id)
        {
            InitializeComponent();
            if (Add)
            {
                btnSave.Visible = btnDelete.Visible = false;
                btnClose.Text = "Добавить";
            }
            add = Add;
            ID = id;
            if (id == "0")
                c1.Enabled = valMask.Enabled = tbGroup.Enabled = tbObj.Enabled = tbPOS.Enabled = cbNotactive.Enabled = btnDelete.Visible = false;
        }

        private void frmDirectoryOperatorsDetails_Load(object sender, EventArgs e)
        {
            if (ID != "0")
                LoadGroups();
            if (!add)
                LoadUser();
        }

        private void LoadUser()
        {
            Query = "SELECT `s`.`ID`, `p`.`name` AS `POS`, `o`.`name` AS `Объект`, " +
                    "`g`.`name` AS `Группа`, `s`.`Номер кассира`, `s`.`Имя`, `s`.`Пароль`, " +
                    "`s`.`Пароль кассы`, `s`.`Код магнитной карты`, `s`.`Права доступа`, " +
                    "CASE WHEN `s`.`Не активен` = 0 THEN 'False' ELSE 'True' END AS `Не активен`, " +
                    "CASE WHEN `s`.`Удален` = 0 THEN 'False' ELSE 'True' END AS `Удален`, " +
                    "FROM_UNIXTIME(`s`.`time_delete`) AS `deletetime`, `s`.`description` " +
                    "FROM ( SELECT " +
                    "`id` AS `ID`, `pos_id`, `operator_code` AS `Номер кассира`, `name` AS `Имя`, " +
                    "`password` AS `Пароль`, `cash_password` AS `Пароль кассы`, `magnetcard_code` AS `Код магнитной карты`, " +
                    "`rightmask` AS `Права доступа`, `not_active` AS `Не активен`, " +
                    "`is_deleted` AS `Удален`,`time_delete`,`description` " +
                    "FROM `directory_operator`) AS `s` " +
                    "LEFT JOIN `directory_pos` AS `p` ON `s`.`pos_id` = `p`.`id` " +
                    "LEFT JOIN `directory_pos_objects` AS `o` ON `p`.`object_id` = `o`.`id` " +
                    "LEFT JOIN `directory_pos_groups` AS `g` ON `o`.`group_id` = `g`.`id` " +
                    "WHERE ((`s`.`pos_id` = `p`.`id` AND `p`.`object_id` = `o`.`id`) OR `s`.`pos_id` = 0) AND `s`.`ID` = '" + ID + "' " +
                    "ORDER BY `s`.`ID`;";
            DataTable DT = db.getDT(Query);
            if (DT != null && DT.Rows.Count > 0)
            {
                tbName.Text = DT.Rows[0].ItemArray[5].ToString();
                tbNumber.Text = DT.Rows[0].ItemArray[4].ToString();
                tbCashpwd.Text = DT.Rows[0].ItemArray[7].ToString();
                tbPassword.Text = DT.Rows[0].ItemArray[6].ToString();
                tbmagneCardCode.Text = DT.Rows[0].ItemArray[8].ToString();
                tbGroup.SelectedItem = DT.Rows[0].ItemArray[3].ToString();
                tbObj.SelectedItem = DT.Rows[0].ItemArray[2].ToString();
                tbPOS.SelectedItem = DT.Rows[0].ItemArray[1].ToString();
                cbNotactive.Checked = bool.Parse(DT.Rows[0].ItemArray[10].ToString());
                SetRights(int.Parse(DT.Rows[0].ItemArray[9].ToString()));
                RightMask = int.Parse(DT.Rows[0].ItemArray[9].ToString());
                Deleted = bool.Parse(DT.Rows[0].ItemArray[11].ToString());
                valMask.Text = RightMask.ToString();
                if (DT.Rows[0].ItemArray[13].ToString().Trim() != "")
                {
                    label9.Visible = label10.Visible = tbDateDelete.Visible = tbReason.Visible = true;
                    tbDateDelete.Text = DT.Rows[0].ItemArray[12].ToString();
                    tbReason.Text = DT.Rows[0].ItemArray[13].ToString();
                }
                if (Deleted)
                    btnDelete.Text = "Восстановить";
            }
            else
            {
                MessageBox.Show(db.GetLastError(), "Ошибка соединения с БД!");
                this.Close();
                return;
            }
        }

        private void LoadGroups()
        {
            Query = "SELECT `name` FROM `directory_pos_groups`";
            DataTable DT = db.getDT(Query);
            tbGroup.Items.AddRange(DT.AsEnumerable().Select(r => r.Field<string>("name")).ToArray());
            tbGroup.SelectedIndex = 0;
        }
        private void LoadObjects()
        {
            tbObj.Items.Clear();
            if (tbGroup.Items[tbGroup.SelectedIndex].ToString().Trim() == "")
                return;
            Query = "SELECT `directory_pos_objects`.`name` AS `name` FROM `directory_pos_objects`, `directory_pos_groups` " +
            "WHERE `directory_pos_objects`.`group_id` = `directory_pos_groups`.`id` " +
            "AND `directory_pos_groups`.`name` = '" + tbGroup.Items[tbGroup.SelectedIndex].ToString() + "';";
            DataTable DT = db.getDT(Query);
            tbObj.Items.AddRange(DT.AsEnumerable().Select(r => r.Field<string>("name")).ToArray());
            tbObj.SelectedIndex = 0;
        }
        private void LoadPos()
        {
            tbPOS.Items.Clear();
            if (tbObj.Items[tbObj.SelectedIndex].ToString().Trim() == "")
                return;
            Query = "SELECT `directory_pos`.`name` AS `name` FROM `directory_pos_objects`, `directory_pos` " +
            "WHERE `directory_pos_objects`.`id` = `directory_pos`.`object_id` " +
            "AND `directory_pos_objects`.`name` = '" + tbObj.Items[tbObj.SelectedIndex].ToString() + "';";
            DataTable DT = db.getDT(Query);
            tbPOS.Items.AddRange(DT.AsEnumerable().Select(r => r.Field<string>("name")).ToArray());
            tbPOS.Sorted = true;
            tbPOS.SelectedIndex = 0;
        }
        private void tbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadObjects();
        }
        private void tbObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPos();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (add)
            {
                Query = "INSERT INTO `directory_operator` " +
                        "(`pos_id`, `operator_code`, `name`, `password`, " +
                        "`cash_password`, `magnetcard_code`, `rightmask`, `not_active`, `is_security`) " +
                        "VALUES ((SELECT `id` FROM `directory_pos` WHERE `name` = '" + tbPOS.Text + "'), " +
                        "'" + tbNumber.Text + "', '" + tbName.Text.Replace("'", "\\'") + "', '" + tbPassword.Text + "', " +
                        "'" + tbCashpwd.Text + "', '" + tbmagneCardCode.Text + "', " + RightMask + ", " + Convert.ToInt16(cbNotactive.Checked) + "); ";
                Query += db.GetLogQuery(5, 20, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "");
                Clipboard.SetText(Query);
                if (!db.Execute(Query))
                    MessageBox.Show(db.GetLastError(), "Ошибка соединения с БД!");
                else
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else
                this.DialogResult = System.Windows.Forms.DialogResult.No;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Query = "UPDATE `directory_operator` SET";
            if (ID != "0")
                Query += "`pos_id` = (SELECT `id` FROM `directory_pos` WHERE `name` = '" + tbPOS.Text + "'), ";
            Query += "`operator_code` = '" + tbNumber.Text + "', `name` = '" + tbName.Text.Replace("'", "\\'") + "', " +
                     "`password` = '" + tbPassword.Text + "', `cash_password` = '" + tbCashpwd.Text + "', `magnetcard_code` = '" + tbmagneCardCode.Text + "', " +
                     "`rightmask` = " + RightMask + ", `not_active` = " + Convert.ToInt16(cbNotactive.Checked) +
                     " WHERE `directory_operator`.`id` = " + ID + "; ";
            Query += db.GetLogQuery(5, int.Parse(ID), 19, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "");
            if (!db.Execute(Query))
                MessageBox.Show(db.GetLastError(), "Ошибка соединения с БД!");
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string reason = "";
            if (!Deleted)
            {
                using (var form = new frmInputBox())
                {
                    form.ShowDialog();
                    string val = form.ReturnValue;
                    reason = val;
                }
                if (reason != string.Empty)
                {
                    Query = "UPDATE `directory_operator` SET `is_deleted` = 1, `time_delete` = " +
                            UnixTime.ToUnixTimestamp(DateTime.Now.ToUniversalTime()) + ", `description` = '" +
                            reason + "' WHERE `id` = '" + ID + "';";
                    Query += db.GetLogQuery(5, int.Parse(ID), 16, WaveBackOffice.Properties.Settings.Default.CurrentUserID, reason);
                    if (!db.Execute(Query))
                        MessageBox.Show(db.GetLastError(), "Ошибка соединения с БД!");
                    else
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
            }
            else
            {
                Query = "UPDATE `directory_operator` SET `is_deleted` = 0, `time_delete` = NULL, `description` = NULL WHERE `id` = '" + ID + "';";
                Query += db.GetLogQuery(5, int.Parse(ID), 17, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "");
                if (!db.Execute(Query))
                    MessageBox.Show(db.GetLastError(), "Ошибка соединения с БД!");
                else
                {
                    btnDelete.Text = "Удалить";
                    Deleted = false;
                    label9.Visible = label10.Visible = tbDateDelete.Visible = tbReason.Visible = false;
                    MessageBox.Show("Пользователь восстановлен!", "Успех операции!");
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
            }
        }

        private void SetRights(int tmpMask)
        {
            if (tmpMask == 8191)
            {
                c1.Checked = true;
            }
            else
            {
                c1.Checked = false;

                if (tmpMask >= 4096)
                {
                    c13.Checked = true;
                    tmpMask -= 4096;
                }
                else
                {
                    c13.Checked = false;
                }
                if (tmpMask >= 2048)
                {
                    c9.Checked = true;
                    tmpMask -= 2048;
                }
                else
                {
                    c9.Checked = false;
                }
                if (tmpMask >= 1024)
                {
                    c12.Checked = true;
                    tmpMask -= 1024;
                }
                else
                {
                    c12.Checked = false;
                }
                if (tmpMask >= 512)
                {
                    c11.Checked = true;
                    tmpMask -= 512;
                }
                else
                {
                    c11.Checked = false;
                }
                if (tmpMask >= 256)
                {
                    c10.Checked = true;
                    tmpMask -= 256;
                }
                else
                {
                    c10.Checked = false;
                }
                if (tmpMask >= 128)
                {
                    c8.Checked = true;
                    tmpMask -= 128;
                }
                else
                {
                    c8.Checked = false;
                }
                if (tmpMask >= 64)
                {
                    c7.Checked = true;
                    tmpMask -= 64;
                }
                else
                {
                    c7.Checked = false;
                }
                if (tmpMask >= 32)
                {
                    c6.Checked = true;
                    tmpMask -= 32;
                }
                else
                {
                    c6.Checked = false;
                }
                if (tmpMask >= 16)
                {
                    c5.Checked = true;
                    tmpMask -= 16;
                }
                else
                {
                    c5.Checked = false;
                }
                if (tmpMask >= 8)
                {
                    c4.Checked = true;
                    tmpMask -= 8;
                }
                else
                {
                    c4.Checked = false;
                }
                if (tmpMask >= 4)
                {
                    c3.Checked = true;
                    tmpMask -= 4;
                }
                else
                {
                    c3.Checked = false;
                }
                if (tmpMask >= 2)
                {
                    c2.Checked = true;
                    tmpMask -= 2;
                }
                else
                {
                    c2.Checked = false;
                }
            }
        }
        private void c1_CheckedChanged(object sender, EventArgs e)
        {
            c2.Checked = c1.Checked;
            c3.Checked = c1.Checked;
            c4.Checked = c1.Checked;
            c5.Checked = c1.Checked;
            c6.Checked = c1.Checked;
            c7.Checked = c1.Checked;
            c8.Checked = c1.Checked;
            c9.Checked = c1.Checked;
            c10.Checked = c1.Checked;
            c11.Checked = c1.Checked;
            c12.Checked = c1.Checked;
            c13.Checked = c1.Checked;
            if (c1.Checked)
            {
                RightMask = 8191;
                c2.Enabled = false;
                c3.Enabled = false;
                c4.Enabled = false;
                c5.Enabled = false;
                c6.Enabled = false;
                c7.Enabled = false;
                c8.Enabled = false;
                c9.Enabled = false;
                c10.Enabled = false;
                c11.Enabled = false;
                c12.Enabled = false;
                c13.Enabled = false;
            }
            else
            {
                RightMask = 0;
                c2.Enabled = true;
                c3.Enabled = true;
                c4.Enabled = true;
                c5.Enabled = true;
                c6.Enabled = true;
                c7.Enabled = true;
                c8.Enabled = true;
                c9.Enabled = true;
                c10.Enabled = true;
                c11.Enabled = true;
                c12.Enabled = true;
                c13.Enabled = true;
            }
            valMask.Text = RightMask.ToString();
        }
        private void c2_CheckedChanged(object sender, EventArgs e)
        {
            if (c2.Checked)
                RightMask += 2;
            else
                RightMask -= 2;
            valMask.Text = RightMask.ToString();
        }
        private void c3_CheckedChanged(object sender, EventArgs e)
        {
            if (c3.Checked)
                RightMask += 4;
            else
                RightMask -= 4;
            valMask.Text = RightMask.ToString();
        }
        private void c4_CheckedChanged(object sender, EventArgs e)
        {
            if (c4.Checked)
                RightMask += 8;
            else
                RightMask -= 8;
            valMask.Text = RightMask.ToString();
        }
        private void c5_CheckedChanged(object sender, EventArgs e)
        {
            if (c5.Checked)
                RightMask += 16;
            else
                RightMask -= 16;
            valMask.Text = RightMask.ToString();
        }
        private void c6_CheckedChanged(object sender, EventArgs e)
        {
            if (c6.Checked)
                RightMask += 32;
            else
                RightMask -= 32;
            valMask.Text = RightMask.ToString();
        }
        private void c7_CheckedChanged(object sender, EventArgs e)
        {
            if (c7.Checked)
                RightMask += 64;
            else
                RightMask -= 64;
            valMask.Text = RightMask.ToString();
        }
        private void c8_CheckedChanged(object sender, EventArgs e)
        {
            if (c8.Checked)
                RightMask += 128;
            else
                RightMask -= 128;
            valMask.Text = RightMask.ToString();
        }
        private void c9_CheckedChanged(object sender, EventArgs e)
        {
            if (c9.Checked)
                RightMask += 2048;
            else
                RightMask -= 2048;
            valMask.Text = RightMask.ToString();
        }
        private void c10_CheckedChanged(object sender, EventArgs e)
        {
            if (c10.Checked)
                RightMask += 256;
            else
                RightMask -= 256;
            valMask.Text = RightMask.ToString();
        }
        private void c11_CheckedChanged(object sender, EventArgs e)
        {
            if (c11.Checked)
                RightMask += 512;
            else
                RightMask -= 512;
            valMask.Text = RightMask.ToString();
        }
        private void c12_CheckedChanged(object sender, EventArgs e)
        {
            if (c12.Checked)
                RightMask += 1024;
            else
                RightMask -= 1024;
            valMask.Text = RightMask.ToString();
        }
        private void c13_CheckedChanged(object sender, EventArgs e)
        {
            if (c13.Checked)
                RightMask += 4096;
            else
                RightMask -= 4096;
            valMask.Text = RightMask.ToString();
        }
        private void valMask_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SetRights(int.Parse(valMask.Text));
            }
            catch { }
        }
    }
}
