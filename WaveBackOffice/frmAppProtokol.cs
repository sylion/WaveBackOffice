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
    public partial class frmAppProtokol : DockContent
    {
        DB db = DB.Instace();
        string Query, Filter;
        DataTable DTFiscal, DTSumm;

        public frmAppProtokol()
        {
            InitializeComponent();
        }

        private void frmAppProtokol_Load(object sender, EventArgs e)
        {
            dgwFiscal.DoubleBuffered(true);
            dgvProtocol.DoubleBuffered(true);
            LoadTree();
            dgwFiscal.DefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 9);
            dgvProtocol.DefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 9);
            dgwTotal.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, (float)9.5);
            dgvProtocol.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 9);
            dgwFiscal.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 9);

        }

        //Just for test
        private void frmAppProtokol_Shown(object sender, EventArgs e)
        {
            //date2.SetDate(DateTime.Parse("24.04.2013"));
        }

        public void LoadTree()
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
            try { treeViewPOS.SelectedNode = treeViewPOS.Nodes[0]; }
            catch { }
        }

        private void btnDirPOS_Click(object sender, EventArgs e)
        {
            frmDirectoryPOS DirectoryPOS = new frmDirectoryPOS();
            DirectoryPOS.ShowDialog();
            LoadTree();
        }

        public void LoadFiscal()
        {
            Query = "SELECT `directory_pos`.`name` AS `POS`, `protokol_fiscal`.`device_number` AS `Заводской номер кассы`, `protokol_fiscal`.`fiscal_number` AS `Фискальный номер кассы`, " +
            "`protokol_fiscal`.`id_z` AS `№ отчета`, FROM_UNIXTIME(`protokol_fiscal`.`time_z`, '%d.%m.%Y %H:%i:%s') AS `Время отчета`, `protokol_fiscal`.`check_count` AS `Количество чеков`, " +
            "`protokol_fiscal`.`sales` AS `Продажи на сумму`, `protokol_fiscal`.`cash` AS `Наличные`, `protokol_fiscal`.`credit` AS `Кредит`, `protokol_fiscal`.`checks` AS `Чек`, " +
            "`protokol_fiscal`.`other` AS `Другое`, `protokol_fiscal`.`refunds` AS `Возвраты`, `protokol_fiscal`.`cash_in` AS `Внос`, `protokol_fiscal`.`cash_out` AS `Вынос`, " +
            "`protokol_fiscal`.`cash_sum` AS `Остаток в кассе` " +
            "FROM `protokol_fiscal`, `directory_pos`, `directory_pos_groups`, `directory_pos_objects` WHERE `directory_pos_groups`.`id` = `directory_pos_objects`.`group_id` " +
            "AND `directory_pos_objects`.`id` = `directory_pos`.`object_id` AND " +
            "`protokol_fiscal`.`device_number` IN (SELECT `directory_pos_fiscals`.`fiscal_number` FROM `directory_pos_fiscals` WHERE `directory_pos_fiscals`.`pos_id` = `directory_pos`.`id`) AND " +
            "(`protokol_fiscal`.`time_z` BETWEEN " +
            UnixTime.ToUnixTimestamp(DateTime.Parse(date1.SelectionRange.Start.ToShortDateString() + " 00:00:00")) + " AND " +
            UnixTime.ToUnixTimestamp(DateTime.Parse(date2.SelectionRange.Start.ToShortDateString() + " 23:59:59")) + ") " + Filter;
            DTFiscal = db.getDT(Query);
            if (DTFiscal == null)
            {
                MessageBox.Show(db.GetLastError());
                return;
            }
            dgwFiscal.DataSource = DTFiscal;
            ApplyStyleFiscal();
            foreach (DataGridViewColumn c in dgwFiscal.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (c.Index != 3)
                    c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dgwFiscal.Columns["Фискальный номер кассы"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkBlue;
            dgwFiscal.Columns["№ отчета"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen;
            dgwFiscal.Columns["Время отчета"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkBlue;
        }

        public void LoadSumm()
        {
            Query = "SELECT " +
            "`directory_pos`.`name` AS `POS`, " +
            "SUM(`protokol_sales_sum`.`check_num`) AS `Количество чеков`, " +
            "SUM(`protokol_sales_sum`.`sale`) AS `Продажи на сумму`, " +
            "SUM(`protokol_sales_sum`.`reject`) AS `Отказы на сумму`, " +
            "SUM(`protokol_sales_sum`.`discount`) AS `Скидки на сумму`, " +
            "SUM(`protokol_sales_sum`.`raise`) AS `Надбавки на сумму`, " +
            "SUM(`protokol_sales_sum`.`cash`) AS `Наличные`, " +
            "SUM(`protokol_sales_sum`.`check`) AS `Чеки`, " +
            "SUM(`protokol_sales_sum`.`credit`) AS `Кредит`, " +
            "SUM(`protokol_sales_sum`.`other`) AS `Другое`, " +
            "SUM(`protokol_sales_sum`.`total`) AS `В сумме`, " +
            "SUM(`protokol_sales_sum`.`refund`) AS `Возвраты`, " +
            "SUM(`protokol_sales_sum`.`in`) AS `Внос`, " +
            "SUM(`protokol_sales_sum`.`out`) AS `Вынос`, " +
            "SUM(`protokol_sales_sum`.`cashsum`) AS `Сумма в кассе` " +
            "FROM `protokol_sales_sum`, `directory_pos`, `directory_pos_groups`, `directory_pos_objects` WHERE " +
            "`directory_pos_groups`.`id` = `directory_pos_objects`.`group_id` AND `directory_pos_objects`.`id` = `directory_pos`.`object_id` " +
            "AND `protokol_sales_sum`.`pos_id` = `directory_pos`.`id` " +
            "AND (`protokol_sales_sum`.`date` BETWEEN UNIX_TIMESTAMP(STR_TO_DATE('" + (date1.SelectionRange.Start.ToShortDateString()) + "', '%d.%m.%Y')) AND " +
            "UNIX_TIMESTAMP(STR_TO_DATE('" + (date2.SelectionRange.Start.ToShortDateString()) + "', '%d.%m.%Y')))" +
                //    UnixTime.ToUnixTimestamp(DateTime.Parse(date1.SelectionRange.Start.ToShortDateString() + " 00:00:00")) + " AND " +
                //    UnixTime.ToUnixTimestamp(DateTime.Parse(date2.SelectionRange.Start.ToShortDateString() + " 23:59:59")) + ") " + 
            Filter + " GROUP BY `POS`";
            DTSumm = db.getDT(Query);

            if (DTSumm == null)
            {
                MessageBox.Show(db.GetLastError());
                return;
            }
            dgvProtocol.DataSource = DTSumm;
            ApplyStyleSumm();
            foreach (DataGridViewColumn c in dgvProtocol.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (c.Index != 0)
                    c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dgvProtocol.Columns["Количество чеков"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen;
            dgvProtocol.Columns["Продажи на сумму"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkBlue;
            dgvProtocol.Columns["Возвраты"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
            dgvProtocol.Columns["Отказы на сумму"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
            LoadTotal();
        }

        public void LoadTotal()
        {
            if (dgvProtocol.Rows.Count == 0)
            {
                dgwTotal.Visible = false;
                return;
            }
            dgwTotal.Visible = true;
            dgwTotal.Columns.Clear();
            dgwTotal.Columns.Add("Итого", "Итого:");
            dgwTotal.Columns.Add("Количество чеков", "0");
            dgwTotal.Columns.Add("Продажи на сумму", "0");
            dgwTotal.Columns.Add("Отказы на сумму", "0");
            dgwTotal.Columns.Add("Скидки на сумму", "0");
            dgwTotal.Columns.Add("Надбавки на сумму", "0");
            dgwTotal.Columns.Add("Наличные", "0");
            dgwTotal.Columns.Add("Чеки", "0");
            dgwTotal.Columns.Add("Кредит", "0");
            dgwTotal.Columns.Add("Другое", "0");
            dgwTotal.Columns.Add("В сумме", "0");
            dgwTotal.Columns.Add("Возвраты", "0");
            dgwTotal.Columns.Add("Внос", "0");
            dgwTotal.Columns.Add("Вынос", "0");
            dgwTotal.Columns.Add("Сумма в кассе", "0");
            foreach (DataGridViewRow r in dgvProtocol.Rows)
            {
                double d1, d2;
                double.TryParse(dgwTotal.Columns["Количество чеков"].HeaderText, out d1);
                double.TryParse(r.Cells["Количество чеков"].Value.ToString(), out d2);
                dgwTotal.Columns["Количество чеков"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Продажи на сумму"].HeaderText, out d1);
                double.TryParse(r.Cells["Продажи на сумму"].Value.ToString(), out d2);
                dgwTotal.Columns["Продажи на сумму"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Отказы на сумму"].HeaderText, out d1);
                double.TryParse(r.Cells["Отказы на сумму"].Value.ToString(), out d2);
                dgwTotal.Columns["Отказы на сумму"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Скидки на сумму"].HeaderText, out d1);
                double.TryParse(r.Cells["Скидки на сумму"].Value.ToString(), out d2);
                dgwTotal.Columns["Скидки на сумму"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Надбавки на сумму"].HeaderText, out d1);
                double.TryParse(r.Cells["Надбавки на сумму"].Value.ToString(), out d2);
                dgwTotal.Columns["Надбавки на сумму"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Наличные"].HeaderText, out d1);
                double.TryParse(r.Cells["Наличные"].Value.ToString(), out d2);
                dgwTotal.Columns["Наличные"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Чеки"].HeaderText, out d1);
                double.TryParse(r.Cells["Чеки"].Value.ToString(), out d2);
                dgwTotal.Columns["Чеки"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Кредит"].HeaderText, out d1);
                double.TryParse(r.Cells["Кредит"].Value.ToString(), out d2);
                dgwTotal.Columns["Кредит"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Другое"].HeaderText, out d1);
                double.TryParse(r.Cells["Другое"].Value.ToString(), out d2);
                dgwTotal.Columns["Другое"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["В сумме"].HeaderText, out d1);
                double.TryParse(r.Cells["В сумме"].Value.ToString(), out d2);
                dgwTotal.Columns["В сумме"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Возвраты"].HeaderText, out d1);
                double.TryParse(r.Cells["Возвраты"].Value.ToString(), out d2);
                dgwTotal.Columns["Возвраты"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Внос"].HeaderText, out d1);
                double.TryParse(r.Cells["Внос"].Value.ToString(), out d2);
                dgwTotal.Columns["Внос"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Вынос"].HeaderText, out d1);
                double.TryParse(r.Cells["Вынос"].Value.ToString(), out d2);
                dgwTotal.Columns["Вынос"].HeaderText = (d1 + d2).ToString();

                double.TryParse(dgwTotal.Columns["Сумма в кассе"].HeaderText, out d1);
                double.TryParse(r.Cells["Сумма в кассе"].Value.ToString(), out d2);
                dgwTotal.Columns["Сумма в кассе"].HeaderText = (d1 + d2).ToString();
            }
            ResizeTotal();
            dgwTotal.ColumnHeadersDefaultCellStyle.BackColor = Color.LightYellow;
            dgwTotal.EnableHeadersVisualStyles = false;
            foreach (DataGridViewColumn c in dgwTotal.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (c.Index != 0)
                    c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        public void ApplyStyleFiscal()
        {
            for (int i = 1; i < dgwFiscal.Rows.Count; i += 2)
            {
                dgwFiscal.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            }
            foreach (DataGridViewRow row in dgwFiscal.Rows)
                foreach (DataGridViewCell c in row.Cells)
                    if (c.Value.ToString() == "0.00" || c.Value.ToString() == "0" || c.Value.ToString() == "0,00")
                        c.Value = DBNull.Value;

        }

        public void ApplyStyleSumm()
        {
            for (int i = 1; i < dgvProtocol.Rows.Count; i += 2)
            {
                dgvProtocol.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            }
            foreach (DataGridViewRow row in dgvProtocol.Rows)
                foreach (DataGridViewCell c in row.Cells)
                    if (c.Value.ToString() == "0.00" || c.Value.ToString() == "0" || c.Value.ToString() == "0,00")
                        c.Value = DBNull.Value;
        }

        private void treeViewPOS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ChangeFilter();
        }

        private void btnProtSales_Click(object sender, EventArgs e)
        {
            frmAppProtokolDetails det = new frmAppProtokolDetails(0,
                date1.SelectionRange.Start.ToShortDateString(),
                date2.SelectionRange.Start.ToShortDateString(),
                //UnixTime.ToUnixTimestamp(DateTime.Parse(date1.SelectionRange.Start.ToShortDateString() + " 00:00:00")),
                //UnixTime.ToUnixTimestamp(DateTime.Parse(date1.SelectionRange.Start.ToShortDateString() + " 23:59:59")),
                treeViewPOS.SelectedNode.Level, treeViewPOS.SelectedNode.Text);
            det.Show(this.DockPanel);
        }

        private void btnProtAction_Click(object sender, EventArgs e)
        {
            frmAppProtokolDetails det = new frmAppProtokolDetails(1,
                date1.SelectionRange.Start.ToShortDateString(),
                date2.SelectionRange.Start.ToShortDateString(),
                //UnixTime.ToUnixTimestamp(DateTime.Parse(date1.SelectionRange.Start.ToShortDateString() + " 00:00:00")),
                //UnixTime.ToUnixTimestamp(DateTime.Parse(date1.SelectionRange.Start.ToShortDateString() + " 23:59:59")),
                treeViewPOS.SelectedNode.Level, treeViewPOS.SelectedNode.Text);
            det.Show(this.DockPanel);
        }

        private void date1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (date1.SelectionRange.Start > date2.SelectionRange.Start)
                date2.SelectionRange = date1.SelectionRange;
            else
                ChangeFilter();
        }
        private void date2_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (date2.SelectionRange.Start < date1.SelectionRange.Start)
                date1.SelectionRange = date2.SelectionRange;
            else
                ChangeFilter();
        }
        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            date2.SelectionRange = date1.SelectionRange;
        }
        private void contextMenu1_Opening(object sender, CancelEventArgs e)
        {
            date1.SelectionRange = date2.SelectionRange;
        }

        public void ChangeFilter()
        {
            switch (treeViewPOS.SelectedNode.Level)
            {
                case 0:
                    Filter = "";
                    break;
                case 1:
                    Filter = "AND `directory_pos_groups`.`name` = '" + treeViewPOS.SelectedNode.Text + "'";
                    break;
                case 2:
                    Filter = "AND `directory_pos_objects`.`name` = '" + treeViewPOS.SelectedNode.Text + "'";
                    break;
                case 3:
                    Filter = "AND `directory_pos`.`name` = '" + treeViewPOS.SelectedNode.Text + "'";
                    break;
            }
            try
            {
                System.Threading.Thread th = new System.Threading.Thread(() => { try { new frmWaiter(-1).ShowDialog(); } catch { } });
                th.Start();
                LoadFiscal();
                LoadSumm();
                th.Abort();
            }
            catch
            {
                LoadFiscal();
                LoadSumm();
            }
        }

        private void btnProtokolPalitra_Click(object sender, EventArgs e)
        {
            frmProtokolPalitra pal = new frmProtokolPalitra();
            pal.ShowDialog();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    ApplyStyleSumm();
                    break;
                case 1:
                    ApplyStyleFiscal();
                    break;
            }
        }

        private void dgwProtocol_Resize(object sender, EventArgs e)
        {
            ResizeTotal();
        }

        private void dgwProtocol_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            ResizeTotal();
        }

        public void ResizeTotal()
        {
            if (dgvProtocol.ColumnCount != 0 && dgwTotal.ColumnCount != 0 && dgvProtocol.RowCount != 0)
            {
                dgwTotal.Columns["Итого"].Width = dgvProtocol.Columns[0].Width;
                dgwTotal.Columns["Количество чеков"].Width = dgvProtocol.Columns["Количество чеков"].Width;
                dgwTotal.Columns["Продажи на сумму"].Width = dgvProtocol.Columns["Продажи на сумму"].Width;
                dgwTotal.Columns["Отказы на сумму"].Width = dgvProtocol.Columns["Отказы на сумму"].Width;
                dgwTotal.Columns["Скидки на сумму"].Width = dgvProtocol.Columns["Скидки на сумму"].Width;
                dgwTotal.Columns["Надбавки на сумму"].Width = dgvProtocol.Columns["Надбавки на сумму"].Width;
                dgwTotal.Columns["Наличные"].Width = dgvProtocol.Columns["Наличные"].Width;
                dgwTotal.Columns["Чеки"].Width = dgvProtocol.Columns["Кредит"].Width;
                dgwTotal.Columns["Кредит"].Width = dgvProtocol.Columns["Кредит"].Width;
                dgwTotal.Columns["Другое"].Width = dgvProtocol.Columns["Другое"].Width;
                dgwTotal.Columns["В сумме"].Width = dgvProtocol.Columns["В сумме"].Width;
                dgwTotal.Columns["Возвраты"].Width = dgvProtocol.Columns["Возвраты"].Width;
                dgwTotal.Columns["Внос"].Width = dgvProtocol.Columns["Внос"].Width;
                dgwTotal.Columns["Вынос"].Width = dgvProtocol.Columns["Вынос"].Width;
                dgwTotal.Columns["Сумма в кассе"].Width = dgvProtocol.Columns["Сумма в кассе"].Width;
            }
        }
    }
}
