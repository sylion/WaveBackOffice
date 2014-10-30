using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WaveBackOffice
{
    public partial class frmAppScheduler : DockContent
    {
        string Query;
        DB db = DB.Instace();
        DataTable DT = null;
        public frmAppScheduler()
        {
            InitializeComponent();
        }

        public void LoadTasks()
        {
            Query = "SELECT `m`.`name` AS `Модуль`, " +
                "`op`.`name` AS `Операция`, " +
                "`s`.`Время`, " +
                "`p`.`name` AS `POS`, " +
                "`o`.`name` AS `Объект`, " +
                "`g`.`name` AS `Группа`, " +
                "`s`.`Для всех`, " +
                "`u`.`name` AS `Пользователь` " +
                "FROM (SELECT " +
                "`module_id`, " +
                "`operation_id`, " +
                "from_unixtime(`time`, '%d.%m.%Y %H:%i:%s') AS `Время`, " +
                "`pos_id`, " +
                "`obj_id`, " +
                "`group_id`, " +
                "`user_id`, " +
                "CASE WHEN `scheduler_tasks`.`is_master` = 0 THEN 'Нет' ELSE 'Да' END AS `Для всех` " +
                "FROM `scheduler_tasks` ?alltasks ) AS `s` " +
                "LEFT JOIN `modules` AS `m` ON `m`.`id` = `s`.`module_id` " +
                "LEFT JOIN `directory_pos_groups` AS `g` ON `s`.`group_id` = `g`.`id` " +
                "LEFT JOIN `directory_pos_objects` AS `o` ON `s`.`obj_id` = `o`.`id` " +
                "LEFT JOIN `scheduler_operations` AS `op` ON `s`.`operation_id` = `op`.`id` " +
                "LEFT JOIN `directory_users` AS `u` ON `s`.`user_id` = `u`.`id` " +
                "LEFT JOIN `directory_pos` AS `p` ON `s`.`pos_id` = `p`.`id`;";
            if (chkAllTasks.Checked)
                Query = Query.Replace("?alltasks", "WHERE `scheduler_tasks`.`user_id` = " + Properties.Settings.Default.CurrentUserID);
            else
                Query = Query.Replace("?alltasks", "");
            DT = db.getDT(Query);
            if (DT == null) { MessageBox.Show(db.GetLastError(), "Ошибка"); this.Dispose(); return; }
            dgvTasks.DataSource = DT;
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
    }
}
