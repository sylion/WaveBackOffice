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
    public partial class frmDirectoryPOS : DockContent
    {
        DB db = DB.Instace();
        frmDirectoryPOSEdit frmedit;
        DataTable DTDetails;
        public frmDirectoryPOS()
        {
            InitializeComponent();
        }

        public void LoadTree()
        {
            treeViewPOS.Nodes.Clear();
            treeViewPOS.Nodes.Add("ХВИЛЯ");
            string Query = "SELECT * FROM `directory_pos_groups`";
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
                Query = "SELECT `directory_pos_objects`.`id`, `directory_pos_objects`.`name` FROM `directory_pos_objects`, `directory_pos_groups` " +
                    "WHERE directory_pos_objects.group_id = directory_pos_groups.id AND directory_pos_groups.name = '" + drg.ItemArray[1].ToString() + "' ORDER BY `directory_pos_objects`.`name`;";
                DTObjects = db.getDT(Query);
                foreach (DataRow dro in DTObjects.Rows)
                {
                    TreeNode node1 = new TreeNode(dro.ItemArray[1].ToString());
                    Query = "SELECT `directory_pos`.`id`, `directory_pos`.`name` FROM `directory_pos_objects`, `directory_pos` " +
                        "WHERE `directory_pos_objects`.`id` = `directory_pos`.`object_id` AND `directory_pos_objects`.`name` = '" + dro.ItemArray[1].ToString() + "' ORDER BY `directory_pos`.`name`;";
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
            try { treeViewPOS.SelectedNode = treeViewPOS.Nodes[0]; }
            catch { }
        }

        private void frmDirectoryPOS_Load(object sender, EventArgs e)
        {
            LoadTree();
            dgvDetails.DoubleBuffered(true);
            dgvDetails.DefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 9);
            dgvDetails.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 9);
        }

        private void treeViewPOS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string Query;
            dgvDetails.MultiSelect = false;
            dgvDetails.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetails.AllowUserToAddRows = false;
            switch (e.Node.Level)
            {
                case 0:
                    Query = "SELECT directory_pos_groups.id AS `ID`, directory_pos_groups.name AS `Имя` FROM directory_pos_groups;";
                    DTDetails = db.getDT(Query);
                    dgvDetails.DataSource = DTDetails;
                    dgvDetails.Update();
                    break;
                case 1:
                    Query = "SELECT directory_pos_objects.id AS `ID`, directory_pos_objects.name AS `Имя` FROM directory_pos_objects, directory_pos_groups " +
                        "WHERE directory_pos_objects.group_id = directory_pos_groups.id AND directory_pos_groups.name = '" + e.Node.Text + "';";
                    DTDetails = db.getDT(Query);
                    dgvDetails.DataSource = DTDetails;
                    dgvDetails.Update();
                    break;
                case 2:
                    Query = "SELECT directory_pos.id AS `ID`, directory_pos.name AS `Имя`," +
                        " directory_pos.description AS `Примечание` FROM directory_pos_objects, directory_pos " +
                        "WHERE directory_pos_objects.id = directory_pos.object_id AND directory_pos_objects.name = '" + e.Node.Text + "';";
                    DTDetails = db.getDT(Query);
                    dgvDetails.DataSource = DTDetails;
                    dgvDetails.Update();
                    break;
                case 3:
                    Query = "SELECT `directory_pos_fiscals`.`fiscal_number` AS `Фискальный номер` FROM `directory_pos_fiscals`, `directory_pos` " +
                        "WHERE `directory_pos_fiscals`.`pos_id` = `directory_pos`.`id` AND `directory_pos`.`name` = '" + e.Node.Text + "';";
                    DTDetails = db.getDT(Query);
                    dgvDetails.DataSource = DTDetails;
                    dgvDetails.Update();
                    break;
                default:
                    break;
            }
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            frmedit = new frmDirectoryPOSEdit(EditMode.Group);
            frmedit.ShowDialog();
            LoadTree();
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            frmedit = new frmDirectoryPOSEdit(EditMode.Object);
            frmedit.ShowDialog();
            LoadTree();
        }

        private void btnCreatePOS_Click(object sender, EventArgs e)
        {
            frmedit = new frmDirectoryPOSEdit(EditMode.POS);
            frmedit.ShowDialog();
            LoadTree();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                switch (treeViewPOS.SelectedNode.Level)
                {
                    case 1:
                        frmedit = new frmDirectoryPOSEdit(treeViewPOS.SelectedNode.Text, EditMode.Group);
                        frmedit.ShowDialog();
                        LoadTree();
                        break;
                    case 2:
                        frmedit = new frmDirectoryPOSEdit(treeViewPOS.SelectedNode.Text, EditMode.Object);
                        frmedit.ShowDialog();
                        LoadTree();
                        break;
                    case 3:
                        frmedit = new frmDirectoryPOSEdit(treeViewPOS.SelectedNode.Text, EditMode.POS);
                        frmedit.ShowDialog();
                        LoadTree();
                        break;
                    default:
                        break;
                }
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Query;
            if (treeViewPOS.Focused)
            {
                if (treeViewPOS.SelectedNode.Level == 0)
                    return;
                DialogResult dlg = MessageBox.Show("Уверены то хотите удалить элемент " + treeViewPOS.SelectedNode.Text, "Удаление элемента", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                switch (treeViewPOS.SelectedNode.Level)
                {
                    case 1:
                        if (dlg == DialogResult.OK)
                        {
                            Query = "DELETE FROM `directory_pos_groups` WHERE `directory_pos_groups`.`name` = '" + treeViewPOS.SelectedNode.Text + "'; ";
                            Query += db.GetLogQuery(3, 0, 13, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Удаление группы: " + treeViewPOS.SelectedNode.Text);
                            if (!db.Execute(Query))
                                MessageBox.Show(db.GetLastError());
                        }
                        break;
                    case 2:
                        if (dlg == DialogResult.OK)
                        {
                            Query = "DELETE FROM `directory_pos_objects` WHERE `directory_pos_objects`.`name` = '" + treeViewPOS.SelectedNode.Text + "'; ";
                            Query += db.GetLogQuery(3, 0, 13, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Удаление объекта: " + treeViewPOS.SelectedNode.Text);
                            if (!db.Execute(Query))
                                MessageBox.Show(db.GetLastError());
                        }
                        break;
                }
                LoadTree();
            }
            if (dgvDetails.Focused && treeViewPOS.SelectedNode.Level == 2)
            {
                DialogResult dlg = MessageBox.Show("Уверены то хотите удалить элемент " + dgvDetails.SelectedRows[0].Cells["Имя"].Value, "Удаление элемента", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlg == DialogResult.OK)
                {
                    Query = "DELETE FROM `directory_pos` WHERE `directory_pos`.`name` = '" + dgvDetails.SelectedRows[0].Cells["Имя"].Value + "'; ";
                    Query += db.GetLogQuery(3, 0, 13, WaveBackOffice.Properties.Settings.Default.CurrentUserID, "Удаление POS: " + dgvDetails.SelectedRows[0].Cells["Имя"].Value);
                    if (!db.Execute(Query))
                        MessageBox.Show(db.GetLastError());
                }
                LoadTree();
            }
        }
    }
}
