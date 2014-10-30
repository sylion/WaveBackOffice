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
    public partial class frmDirectoryPOSEdit : Form
    {
        DB db = DB.Instace();
        bool add;
        EditMode Mod;
        public frmDirectoryPOSEdit(string POS, EditMode Mode)
        {
            InitializeComponent();
            Mod = Mode;
            string Query;
            DataTable DT;
            switch (Mod)
            {
                case EditMode.POS:
                    Query = "SELECT `name` FROM `directory_pos_objects`";
                    DT = db.getDT(Query);
                    if (DT == null) { MessageBox.Show(db.GetLastError()); this.Close(); return; }
                    foreach (DataRow r in DT.Rows)
                        tbObj.Items.Add(r.ItemArray[0].ToString());
                    this.Text = "Изменить " + POS;
                    tbPOS.Text = POS;
                    Query = "SELECT `directory_pos`.`id`,  `directory_pos`.`description`, `directory_pos_objects`.`name` " +
                        "FROM `directory_pos_objects`, `directory_pos` WHERE `directory_pos`.`name` = '" + POS + "' AND `directory_pos_objects`.`id` = `directory_pos`.`object_id`";
                    DT = db.getDT(Query);
                    if (DT == null) { MessageBox.Show(db.GetLastError()); this.Close(); return; }
                    tbObj.SelectedItem = DT.Rows[0][2].ToString();
                    tbID.Text = DT.Rows[0][0].ToString();
                    tbComment.Text = DT.Rows[0][1].ToString();
                    Query = "SELECT `fiscal_number` FROM `directory_pos_fiscals` WHERE `pos_id` = '" + tbID.Text + "';";
                    DT = db.getDT(Query);
                    if (DT == null) { MessageBox.Show(db.GetLastError()); this.Close(); return; }
                    foreach (DataRow r in DT.Rows)
                        tbFiscalNumber.Text += r[0].ToString() + ";";
                    break;
                case EditMode.Object:
                    Query = "SELECT `name` FROM `directory_pos_groups`";
                    DT = db.getDT(Query);
                    if (DT == null) { MessageBox.Show(db.GetLastError()); this.Close(); return; }
                    foreach (DataRow r in DT.Rows)
                        tbObj.Items.Add(r.ItemArray[0].ToString());
                    this.Text = "Изменить " + POS;
                    tbPOS.Text = POS;
                    Query = "SELECT `directory_pos_groups`.`name`, `directory_pos_objects`.`id` FROM `directory_pos_groups`, `directory_pos_objects` " +
                        "WHERE `directory_pos_groups`.`id` = `directory_pos_objects`.`group_id` AND `directory_pos_objects`.`name` = '" + POS + "';";
                    DT = db.getDT(Query);
                    if (DT == null) { MessageBox.Show(db.GetLastError()); this.Close(); return; }
                    tbObj.SelectedItem = DT.Rows[0][0].ToString();
                    tbID.Text = DT.Rows[0][1].ToString();
                    tbFiscalNumber.Enabled = false;
                    tbComment.Enabled = false;
                    lblObj.Text = "Группа:";
                    lblPOS.Text = "Имя объекта:";
                    break;
                case EditMode.Group:
                    this.Text = "Изменить " + POS;
                    Query = "SELECT `directory_pos_groups`.`id` FROM `directory_pos_groups` WHERE `directory_pos_groups`.`name` = '" + POS + "';";
                    DT = db.getDT(Query);
                    if (DT == null) { MessageBox.Show(db.GetLastError()); this.Close(); return; }
                    tbID.Text = DT.Rows[0][0].ToString();
                    tbPOS.Text = POS;
                    lblPOS.Text = "Имя группы:";
                    tbObj.Enabled = false;
                    tbFiscalNumber.Enabled = false;
                    tbComment.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        public frmDirectoryPOSEdit(EditMode Mode)
        {
            InitializeComponent();
            add = true; Mod = Mode;
            DataTable DT; string Query;
            switch (Mode)
            {
                case EditMode.POS:
                    this.Text = "Создать POS";
                    Query = "SELECT `name` FROM `directory_pos_objects`";
                    DT = db.getDT(Query);
                    if (DT == null)
                    {
                        MessageBox.Show(db.GetLastError());
                        this.Close();
                        return;
                    }
                    foreach (DataRow r in DT.Rows)
                        tbObj.Items.Add(r.ItemArray[0].ToString());
                    break;
                case EditMode.Object:
                    this.Text = "Создать объект";
                    lblObj.Text = "Группа:";
                    lblPOS.Text = "Имя объекта:";
                    Query = "SELECT `name` FROM `directory_pos_groups`";
                    DT = db.getDT(Query);
                    if (DT == null)
                    {
                        MessageBox.Show(db.GetLastError());
                        this.Close();
                        return;
                    }
                    foreach (DataRow r in DT.Rows)
                        tbObj.Items.Add(r.ItemArray[0].ToString());
                    tbFiscalNumber.Enabled = false;
                    tbComment.Enabled = false;
                    break;
                case EditMode.Group:
                    this.Text = "Создать группу";
                    lblPOS.Text = "Имя группы:";
                    tbObj.Enabled = false;
                    tbFiscalNumber.Enabled = false;
                    tbComment.Enabled = false;
                    break;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string Query;
            if (!add)
            {
                switch (Mod)
                {
                    case EditMode.POS:
                        Query = "UPDATE `directory_pos` SET `name` = '" + tbPOS.Text + "', `description` = '" + tbComment.Text +
                            "', `object_id` = (SELECT `id` FROM `directory_pos_objects` WHERE `name` = '" + tbObj.Text + "') " +
                            "WHERE `id` = " + tbID.Text + "; ";
                        Query += "DELETE FROM `directory_pos_fiscals` WHERE `pos_id` = '" + tbID.Text + "'; ";
                        if (tbFiscalNumber.Text.Trim() != "")
                        {
                            string[] tmp = tbFiscalNumber.Text.Trim().Split(';');
                            foreach (string s in tmp)
                                if (s.Trim() != "")
                                    Query += "INSERT INTO `directory_pos_fiscals` (`fiscal_number`, `pos_id`) VALUES ('" + s + "', '" + tbID.Text + "') " +
                                        "ON DUPLICATE KEY UPDATE `pos_id` = '" + tbID.Text + "'; ";
                        }
                        Query += db.GetLogQuery(3, 0, 13, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Изменение POS: " + tbPOS.Text);
                        if (!db.Execute(Query)) MessageBox.Show(db.GetLastError()); else this.Close();
                        break;
                    case EditMode.Object:
                        Query = "UPDATE `directory_pos_objects` SET `name` = '" + tbPOS.Text + "', `group_id` = (SELECT `id` FROM `directory_pos_groups` WHERE `name` = '" + tbObj.Text + "') " +
                            "WHERE `id` = " + tbID.Text + "; ";
                        Query += db.GetLogQuery(3, 0, 13, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Изменение объекта: " + tbPOS.Text);
                        if (!db.Execute(Query)) MessageBox.Show(db.GetLastError()); else this.Close();
                        break;
                    case EditMode.Group:
                        Query = "UPDATE `directory_pos_groups` SET `name` = '" + tbPOS.Text + "' WHERE `id` = " + tbID.Text + "; ";
                        Query += db.GetLogQuery(3, 0, 13, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Изменение группы: " + tbPOS.Text);
                        if (!db.Execute(Query)) MessageBox.Show(db.GetLastError()); else this.Close();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (Mod)
                {
                    case EditMode.POS:
                        if (tbObj.Text.Trim() == "" || tbPOS.Text.Trim() == "")
                        {
                            MessageBox.Show("Выберите объект и введите имя нового POS терминала", "Введите данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        Query = "INSERT INTO `directory_pos` (`name`, `fiscal_number`, `object_id`, `description`) " +
                        "VALUES ('" + tbPOS.Text + "', '" + tbFiscalNumber.Text + "', " +
                        "(SELECT `id` FROM `directory_pos_objects` WHERE `name` = '" + tbObj.Text + "'), '" + tbComment.Text + "'); ";
                        Query += db.GetLogQuery(3, 0, 14, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Добавление POS: " + tbPOS.Text);
                        if (!db.Execute(Query)) MessageBox.Show(db.GetLastError()); else this.Close();
                        break;
                    case EditMode.Object:
                        Query = "INSERT INTO `directory_pos_objects` (`name`, `group_id`) VALUES ('" + tbPOS.Text + "', " +
                            "(SELECT `id` FROM `directory_pos_groups` WHERE `name` = '" + tbObj.Text + "')); ";
                        Query += db.GetLogQuery(3, 0, 14, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Добавление объекта: " + tbPOS.Text);
                        if (!db.Execute(Query)) MessageBox.Show(db.GetLastError()); else this.Close();
                        break;
                    case EditMode.Group:
                        Query = "INSERT INTO `directory_pos_groups` (`name`) VALUES ('" + tbPOS.Text + "'); ";
                        Query += db.GetLogQuery(3, 0, 14, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Добавление группы: " + tbPOS.Text);
                        if (!db.Execute(Query)) MessageBox.Show(db.GetLastError()); else this.Close();
                        break;
                }
            }
        }
    }
}
