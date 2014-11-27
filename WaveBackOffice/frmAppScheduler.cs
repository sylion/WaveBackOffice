using System;
using System.Data;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WaveBackOffice
{
    public partial class frmAppScheduler : DockContent
    {
        string Query;
        DB db = DB.Instace();
        DataTable DT = null;
        DataTable DT1 = null;
        public frmAppScheduler()
        {
            InitializeComponent();
        }

        public void LoadTasks()
        {
            Query = "SELECT " +
                "`s`.`operation_id` AS `ID`, " +
                "`op`.`name` AS `Операция`, " +
                "`s`.`Время`, " +
                "`p`.`name` AS `POS`, " +
                "`o`.`name` AS `Объект`, " +
                "`g`.`name` AS `Группа`, " +
                "`s`.`Для всех`, " +
                "`u`.`name` AS `Пользователь` " +
                "FROM (SELECT " +
                "`operation_id`, " +
                "from_unixtime(`time`, '%d.%m.%Y %H:%i:%s') AS `Время`, " +
                "`pos_id`, " +
                "`obj_id`, " +
                "`group_id`, " +
                "`user_id`, " +
                "CASE WHEN `scheduler_tasks`.`is_master` = 0 THEN 'Нет' ELSE 'Да' END AS `Для всех` " +
                "FROM `scheduler_tasks` WHERE `doit` = 0 ?alltasks ) AS `s` " +
                "LEFT JOIN `directory_pos_groups` AS `g` ON `s`.`group_id` = `g`.`id` " +
                "LEFT JOIN `directory_pos_objects` AS `o` ON `s`.`obj_id` = `o`.`id` " +
                "LEFT JOIN `scheduler_operations` AS `op` ON `s`.`operation_id` = `op`.`id` " +
                "LEFT JOIN `directory_users` AS `u` ON `s`.`user_id` = `u`.`id` " +
                "LEFT JOIN `directory_pos` AS `p` ON `s`.`pos_id` = `p`.`id`;";
            if (chkAllTasks.Checked)
                Query = Query.Replace("?alltasks", "AND `scheduler_tasks`.`user_id` = " + Properties.Settings.Default.CurrentUserID);
            else
                Query = Query.Replace("?alltasks", "");
            DT = db.getDT(Query);
            if (DT == null) { MessageBox.Show(db.GetLastError(), "Ошибка"); this.Dispose(); return; }
            dgvTasks.DataSource = DT;
            Query = "SELECT " +
                "`s`.`operation_id` AS `ID`, " +
                "`op`.`name` AS `Операция`, " +
                "`s`.`Время`, " +
                "`p`.`name` AS `POS`, " +
                "`o`.`name` AS `Объект`, " +
                "`g`.`name` AS `Группа`, " +
                "`s`.`Для всех`, " +
                "`u`.`name` AS `Пользователь` " +
                "FROM (SELECT " +
                "`operation_id`, " +
                "from_unixtime(`time`, '%d.%m.%Y %H:%i:%s') AS `Время`, " +
                "`pos_id`, " +
                "`obj_id`, " +
                "`group_id`, " +
                "`user_id`, " +
                "CASE WHEN `scheduler_tasks`.`is_master` = 0 THEN 'Нет' ELSE 'Да' END AS `Для всех` " +
                "FROM `scheduler_tasks` WHERE `doit` = 1 ?alltasks ) AS `s` " +
                "LEFT JOIN `directory_pos_groups` AS `g` ON `s`.`group_id` = `g`.`id` " +
                "LEFT JOIN `directory_pos_objects` AS `o` ON `s`.`obj_id` = `o`.`id` " +
                "LEFT JOIN `scheduler_operations` AS `op` ON `s`.`operation_id` = `op`.`id` " +
                "LEFT JOIN `directory_users` AS `u` ON `s`.`user_id` = `u`.`id` " +
                "LEFT JOIN `directory_pos` AS `p` ON `s`.`pos_id` = `p`.`id`;";
            if (chkAllTasks.Checked)
                Query = Query.Replace("?alltasks", "AND `scheduler_tasks`.`user_id` = " + Properties.Settings.Default.CurrentUserID);
            else
                Query = Query.Replace("?alltasks", "");
            DT1 = db.getDT(Query);
            if (DT1 == null) { MessageBox.Show(db.GetLastError(), "Ошибка"); this.Dispose(); return; }
            dgvDoneTasks.DataSource = DT1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void chkAllTasks_CheckedChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void frmAppScheduler_Shown(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows[0].Index > -1 && dgvTasks.Rows.Count > 0)
            {
                Query = "UPDATE `scheduler_tasks` SET `doit` = 1 WHERE `operation_id` = " + dgvTasks.SelectedRows[0].Cells[0].Value.ToString();
                if (!db.Execute(Query))
                    MessageBox.Show(db.GetLastError(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadTasks();
            }
        }
    }
}
