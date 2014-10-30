using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using WeifenLuo.WinFormsUI.Docking;

namespace WaveBackOffice
{
    public partial class frmDirectoryOperators : DockContent
    {
        DB db = DB.Instace();
        string Query = "", Filter = "";
        DataTable DTUsers;
        int Deleted = 0;
        frmDirectoryOperatorsDetails Details;
        TreeNode currNode = null;
        public frmDirectoryOperators()
        {
            InitializeComponent();
            Deleted = 0;
        }

        private void frmDirectoryOperators_Load(object sender, EventArgs e)
        {
            dgvUsers.DoubleBuffered(true);
            dgvUsers.DefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, (float)9.5);
        }

        private void frmDirectoryOperators_Shown(object sender, EventArgs e)
        {
            LoadTree();
        }

        private void LoadTree()
        {
            treeViewPOS.Nodes.Clear();
            treeViewPOS.Nodes.Add("ХВИЛЯ");
            string Query = "SELECT * FROM directory_pos_groups";
            DataTable DTGroups;
            DataTable DTObjects;
            DataTable DTPos;
            DTGroups = db.getDT(Query);
            if (DTGroups == null)
            {
                MessageBox.Show(db.GetLastError());
                return;
            }
            foreach (DataRow drg in DTGroups.Rows)
            {
                TreeNode node = new TreeNode(drg.ItemArray[1].ToString());
                Query = "SELECT directory_pos_objects.id, directory_pos_objects.`name` FROM directory_pos_objects, directory_pos_groups WHERE directory_pos_objects.group_id = directory_pos_groups.id AND directory_pos_groups.name = '" +
                    drg.ItemArray[1].ToString() + "';";
                DTObjects = db.getDT(Query);
                foreach (DataRow dro in DTObjects.Rows)
                {
                    TreeNode node1 = new TreeNode(dro.ItemArray[1].ToString());
                    Query = Query = "SELECT directory_pos.id, directory_pos.`name` FROM directory_pos_objects, directory_pos WHERE directory_pos_objects.id = directory_pos.object_id AND directory_pos_objects.name = '" +
                        dro.ItemArray[1].ToString() + "';";
                    DTPos = db.getDT(Query);
                    foreach (DataRow drp in DTPos.Rows)
                    {
                        node1.Nodes.Add(new TreeNode { Text = drp.ItemArray[1].ToString(), ImageIndex = 1, SelectedImageIndex = 1 });
                    }
                    node.Nodes.Add(node1);

                }
                treeViewPOS.Nodes[0].Nodes.Add(node);
            }

            treeViewPOS.Nodes[0].Expand();
            foreach (TreeNode n in treeViewPOS.Nodes[0].Nodes)
                n.Expand();
            if (currNode != null)
                switch (currNode.Level)
                {
                    case 0:
                        try { treeViewPOS.SelectedNode = treeViewPOS.Nodes[0]; }
                        catch { }
                        break;
                    case 1:
                        try { treeViewPOS.SelectedNode = treeViewPOS.Nodes[0].Nodes[currNode.Index]; }
                        catch { treeViewPOS.SelectedNode = treeViewPOS.Nodes[0]; }
                        break;
                    case 2:
                        try { treeViewPOS.SelectedNode = treeViewPOS.Nodes[0].Nodes[currNode.Parent.Index].Nodes[currNode.Index]; }
                        catch { treeViewPOS.SelectedNode = treeViewPOS.Nodes[0]; }
                        break;
                    case 3:
                        try { treeViewPOS.SelectedNode = treeViewPOS.Nodes[0].Nodes[currNode.Parent.Index].Nodes[currNode.Parent.Index].Nodes[currNode.Index]; }
                        catch { treeViewPOS.SelectedNode = treeViewPOS.Nodes[0]; }
                        break;
                }
            else
                try { treeViewPOS.SelectedNode = treeViewPOS.Nodes[0]; }
                catch { }
        }

        private void LoadUsers()
        {
            Query = "SELECT `s`.`ID`, `p`.`name` AS `POS`, `o`.`name` AS `Объект`, " +
                    "`g`.`name` AS `Группа`, `s`.`Номер кассира`, `s`.`Имя`, `s`.`Пароль`, " +
                    "`s`.`Пароль кассы`, `s`.`Код магнитной карты`, `s`.`Права доступа`, " +
                    "CASE WHEN `s`.`Не активен` = 0 THEN 'Нет' ELSE 'Да' END AS `Не активен` " +
                    "FROM ( SELECT " +
                    "`id` AS `ID`, `pos_id`, `operator_code` AS `Номер кассира`, `name` AS `Имя`, " +
                    "`password` AS `Пароль`, `cash_password` AS `Пароль кассы`, " +
                    "`magnetcard_code` AS `Код магнитной карты`, `rightmask` AS `Права доступа`, " +
                    "`not_active` AS `Не активен`, `is_deleted` " +
                    "FROM `directory_operator`) AS `s` " +
                    "LEFT JOIN `directory_pos` AS `p` ON `s`.`pos_id` = `p`.`id` " +
                    "LEFT JOIN `directory_pos_objects` AS `o` ON `p`.`object_id` = `o`.`id` " +
                    "LEFT JOIN `directory_pos_groups` AS `g` ON `o`.`group_id` = `g`.`id` " +
                    "WHERE ((`s`.`pos_id` = `p`.`id` AND `p`.`object_id` = `o`.`id`" + Filter + ") OR `s`.`pos_id` = 0) AND `s`.`is_deleted` = " + Deleted + " " +
                    " ORDER BY `s`.`ID`;";
            Thread getdata = new Thread(() => { DTUsers = db.getDT(Query); });
            getdata.Start();
            getdata.Join();
            if (DTUsers == null)
            {
                MessageBox.Show(db.GetLastError());
                return;
            }
            dgvUsers.DataSource = DTUsers;
            ApplyStyle();
        }

        private void ApplyStyle()
        {
            for (int i = 1; i < dgvUsers.Rows.Count; i += 2)
            {
                dgvUsers.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            }
            for (int i = 0; i < dgvUsers.Rows.Count; i++)
            {
                if (dgvUsers.Rows[i].Cells["ID"].Value.ToString() == "0")
                {
                    dgvUsers.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
                    break;
                }
            }
        }

        private void ChangeFilter()
        {
            switch (treeViewPOS.SelectedNode.Level)
            {
                case 0:
                    Filter = "";
                    break;
                case 1:
                    Filter = " AND `g`.`name` = '" + treeViewPOS.SelectedNode.Text + "' ";
                    break;
                case 2:
                    Filter = " AND `o`.`name` = '" + treeViewPOS.SelectedNode.Text + "' ";
                    break;
                case 3:
                    Filter = " AND `p`.`name` = '" + treeViewPOS.SelectedNode.Text + "' ";
                    break;
            }
            try
            {
                System.Threading.Thread th = new System.Threading.Thread(() => { new frmWaiter(-1).ShowDialog(); });
                th.Start();
                LoadUsers();
                th.Abort();
            }
            catch { LoadUsers(); }
        }

        private void treeViewPOS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            currNode = treeViewPOS.SelectedNode;
            ChangeFilter();
        }

        private void dgvUsers_Sorted(object sender, EventArgs e)
        {
            ApplyStyle();
        }

        private void btnDirPOS_Click(object sender, EventArgs e)
        {
            frmDirectoryPOS DirectoryPOS = new frmDirectoryPOS();
            DirectoryPOS.ShowDialog();
            LoadTree();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Details = new frmDirectoryOperatorsDetails(true, "-1");
            DialogResult dlg = Details.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.Yes)
                LoadTree();
        }

        private void cbShowDeleted_CheckedChanged(object sender, EventArgs e)
        {
            Deleted = Convert.ToInt16(cbShowDeleted.Checked);
            ChangeFilter();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadTree();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Details = new frmDirectoryOperatorsDetails(false, dgvUsers.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult dlg = Details.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.Yes)
                LoadTree();
        }
    }
}
