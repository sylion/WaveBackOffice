using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.OleDb;
using WeifenLuo.WinFormsUI.Docking;

namespace WaveBackOffice
{
    public partial class frmAppProtokolDetails : DockContent
    {
        #region Скрывающаяся боковая панель
        bool hidden = false;
        private void Pinner_CheckedChanged(object sender, EventArgs e)
        {
            if (Pinner.Checked)
            {
                hidden = false;
                Pinner.ImageIndex = 0;
                panelFilter.AutoScroll = true;
            }
            else
            {
                hidden = true;
                Pinner.ImageIndex = 1;

            }
        }
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if (hidden)
            {
                panelFilter.Width = 263;
                //panel1.BringToFront();
                panelFilter.AutoScroll = true;
                panelFilter.Focus();
            }
        }
        private void panel1_Leave(object sender, EventArgs e)
        {
            if (hidden)
            {
                panelFilter.Width = 30;
                panelFilter.AutoScroll = false;
            }
            //else
            //    panel1.SendToBack();
        }
        #endregion

        #region Global VAR
        DB db = DB.Instace();
        string Query = "", Filter = "";
        int type = 0;
        bool Stop = false;
        DataTable DT = null;
        BindingSource source;
        static frmWaiter frm = new frmWaiter(2);
        Thread w8 = new Thread(() => { try { frm.ShowDialog(); } catch { } });
        #endregion

        public frmAppProtokolDetails()
        {
            InitializeComponent();
        }

        public frmAppProtokolDetails(int Type, string StartDate, string EndDate, int NodeLevel, string NodeName)
        {
            InitializeComponent();
            int limit = 1000000;
            DataTable DTtmp = null;
            type = Type;
            switch (Type)
            {
                case 0:
                    this.Text = "Протокол продаж ''" + NodeName + "''";
                    switch (NodeLevel)
                    {
                        case 0:
                            break;
                        case 1:
                            DTtmp = db.getDT("SELECT `directory_pos`.`id` FROM `directory_pos`, `directory_pos_objects`,  `directory_pos_groups` WHERE `directory_pos_groups`.`name` = '" + NodeName + "' AND `directory_pos_objects`.`id` = `directory_pos`.`object_id` AND `directory_pos_objects`.`group_id` = `directory_pos_groups`.`id`;");
                            break;
                        case 2:
                            DTtmp = db.getDT("SELECT `directory_pos`.`id` FROM `directory_pos`, `directory_pos_objects` WHERE `directory_pos_objects`.`name` = '" + NodeName + "' AND `directory_pos_objects`.`id` = `directory_pos`.`object_id`;");
                            break;
                        case 3:
                            DTtmp = db.getDT("SELECT `directory_pos`.`id` FROM `directory_pos` WHERE `directory_pos`.`name` = '" + NodeName + "';");
                            break;
                    }
                    if (NodeLevel > 0 && DTtmp != null)
                    {
                        Filter = "AND `protokol_sales`.`pos_id` IN (";
                        bool first = true;
                        foreach (DataRow r in DTtmp.Rows)
                        {
                            if (first)
                            {
                                Filter += r.ItemArray[0].ToString();
                                first = false;
                            }
                            else
                                Filter += ", " + r.ItemArray[0].ToString();
                        }
                        Filter += ")";
                    }
                    Query = "SELECT `s`.`Время чека`, `pos`.`name` AS `POS`, `s`.`ID чека`,  `s`.`Номер смены`, `s`.`Время операции`, `oper`.`name` AS `Операция`, " +
                    "`goods`.`code` AS `Код товара`, `goods`.`name` AS `Товар`, `s`.`Номер карты`, `s`.`Количество`, `s`.`Возврат`, `s`.`Сумма`, `op`.`name` AS `Оператор` " +
                        //s
                    "FROM (SELECT from_unixtime(`protokol_sales`.`time_check`, '%d.%m.%Y %H:%i:%s') AS `Время чека`, " +
                    "`protokol_sales`.`pos_id`, `protokol_sales`.`rec_id`,`protokol_sales`.`check_id` AS `ID чека`, `protokol_sales`.`document_id` AS `Номер смены`, " +
                    "from_unixtime(`protokol_sales`.`time_operation`, '%d.%m.%Y %H:%i:%s') AS `Время операции`, " +
                    "`protokol_sales`.`operation_id`, `protokol_sales`.`goods_id`, " +
                    "`protokol_sales`.`discard_code` AS `Номер карты`, `protokol_sales`.`quantity` AS `Количество`, " +
                    "CASE WHEN `protokol_sales`.`is_refund` = 0 THEN 'Нет' ELSE 'Да' END AS `Возврат`, " +
                    "`protokol_sales`.`operation_sum` AS `Сумма`, `protokol_sales`.`operator_id` " +
                    "FROM  `protokol_sales` " +
                    "WHERE (`protokol_sales`.`time_check` BETWEEN UNIX_TIMESTAMP(STR_TO_DATE('" + (StartDate + " 00:00:00") + "', '%d.%m.%Y %H:%i:%s')) AND " +
                    "UNIX_TIMESTAMP(STR_TO_DATE('" + (EndDate + " 23:59:59") + "', '%d.%m.%Y %H:%i:%s')))" +
                    Filter + " LIMIT 0, " + limit + ") AS `s` " +
                        //!s
                    "LEFT JOIN `directory_goods` AS `goods` ON `s`.`goods_id` = `goods`.`id` " +
                    "LEFT JOIN `directory_operator` AS `op` ON `op`.`id` = `s`.`operator_id` " +
                    "LEFT JOIN `directory_pos` AS `pos` ON `pos`.`id` = `s`.`pos_id` " +
                    "LEFT JOIN `protokol_operations` AS `oper` ON `oper`.`id` = `s`.`operation_id` ORDER BY `s`.`Время чека` DESC, `s`.`rec_id` DESC, `pos`.`name`, `s`.`ID чека`, `s`.`Номер смены`;";
                    break;
                case 1:
                    this.Text = "Протокол действий ''" + NodeName + "''";
                    switch (NodeLevel)
                    {
                        case 0:
                            break;
                        case 1:
                            DTtmp = db.getDT("SELECT `directory_pos`.`id` FROM `directory_pos`, `directory_pos_objects`,  `directory_pos_groups` WHERE `directory_pos_groups`.`name` = '" + NodeName + "' AND `directory_pos_objects`.`id` = `directory_pos`.`object_id` AND `directory_pos_objects`.`group_id` = `directory_pos_groups`.`id`;");
                            break;
                        case 2:
                            DTtmp = db.getDT("SELECT `directory_pos`.`id` FROM `directory_pos`, `directory_pos_objects` WHERE `directory_pos_objects`.`name` = '" + NodeName + "' AND `directory_pos_objects`.`id` = `directory_pos`.`object_id`;");
                            break;
                        case 3:
                            DTtmp = db.getDT("SELECT `directory_pos`.`id` FROM `directory_pos` WHERE `directory_pos`.`name` = '" + NodeName + "';");
                            break;
                    }
                    if (NodeLevel > 0 && DTtmp != null)
                    {
                        Filter = "AND `protokol_actions`.`pos_id` IN (";
                        bool first = true;
                        foreach (DataRow r in DTtmp.Rows)
                        {
                            if (first)
                            {
                                Filter += r.ItemArray[0].ToString();
                                first = false;
                            }
                            else
                                Filter += ", " + r.ItemArray[0].ToString();
                        }
                        Filter += ")";
                    }
                    Query = "SELECT `s`.`Время чека`, `pos`.`name` AS `POS`, `s`.`ID чека`,  `s`.`Номер смены`, `s`.`Время операции`, `oper`.`name` AS `Операция`, " +
                    "`goods`.`code` AS `Код товара`, `goods`.`name` AS `Товар`, `s`.`Номер карты`, `s`.`Количество`, `s`.`Возврат`, `s`.`Сумма`, `op`.`name` AS `Оператор` " +
                        //s
                    "FROM (SELECT from_unixtime(`protokol_actions`.`time_check`, '%d.%m.%Y %H:%i:%s') AS `Время чека`, " +
                    "`protokol_actions`.`pos_id`, `protokol_actions`.`rec_id`,`protokol_actions`.`check_id` AS `ID чека`, `protokol_actions`.`document_id` AS `Номер смены`, " +
                    "from_unixtime(`protokol_actions`.`time_operation`, '%d.%m.%Y %H:%i:%s') AS `Время операции`, " +
                    "`protokol_actions`.`operation_id`, `protokol_actions`.`goods_id`, " +
                    "`protokol_actions`.`discard_code` AS `Номер карты`, `protokol_actions`.`quantity` AS `Количество`, " +
                    "CASE WHEN `protokol_actions`.`is_refund` = 0 THEN 'Нет' ELSE 'Да' END AS `Возврат`, " +
                    "`protokol_actions`.`operation_sum` AS `Сумма`, `protokol_actions`.`operator_id` " +
                    "FROM  `protokol_actions` " +
                    "WHERE (`protokol_actions`.`time_check` BETWEEN UNIX_TIMESTAMP(STR_TO_DATE('" + (StartDate + " 00:00:00") + "', '%d.%m.%Y %H:%i:%s')) AND " +
                    "UNIX_TIMESTAMP(STR_TO_DATE('" + (EndDate + " 23:59:59") + "', '%d.%m.%Y %H:%i:%s')))" +
                    Filter + " LIMIT 0, " + limit + ") AS `s` " +
                        //!s
                    "LEFT JOIN `directory_goods` AS `goods` ON `s`.`goods_id` = `goods`.`id` " +
                    "LEFT JOIN `directory_operator` AS `op` ON `op`.`id` = `s`.`operator_id` " +
                    "LEFT JOIN `directory_pos` AS `pos` ON `pos`.`id` = `s`.`pos_id` " +
                    "LEFT JOIN `protokol_operations` AS `oper` ON `oper`.`id` = `s`.`operation_id`  ORDER BY `s`.`Время чека` DESC, `s`.`rec_id` DESC, `pos`.`name`, `s`.`ID чека`, `s`.`Номер смены`;";
                    break;
            }
        }

        public frmAppProtokolDetails(int Type, string TimeCheck, int POS, int CheckID, int DocID)
        {
            InitializeComponent();
            switch (Type)
            {
                case 0:
                    this.Text = "Детали чека ''Продажи''";
                    Query = "SELECT `s`.`Время чека`, `pos`.`name` AS `POS`, `s`.`ID чека`,  `s`.`Номер смены`, `s`.`Время операции`, `oper`.`name` AS `Операция`, " +
                    "`goods`.`code` AS `Код товара`, `goods`.`name` AS `Товар`, `s`.`Номер карты`, `s`.`Количество`, `s`.`Возврат`, `s`.`Сумма`, `op`.`name` AS `Оператор` " +
                        //s
                    "FROM (SELECT from_unixtime(`protokol_sales`.`time_check`, '%d.%m.%Y %H:%i:%s') AS `Время чека`, " +
                    "`protokol_sales`.`pos_id`, `protokol_sales`.`rec_id`,`protokol_sales`.`check_id` AS `ID чека`, `protokol_sales`.`document_id` AS `Номер смены`, " +
                    "from_unixtime(`protokol_sales`.`time_operation`, '%d.%m.%Y %H:%i:%s') AS `Время операции`, " +
                    "`protokol_sales`.`operation_id`, `protokol_sales`.`goods_id` AS `goods_id`, " +
                    "`protokol_sales`.`discard_code` AS `Номер карты`, `protokol_sales`.`quantity` AS `Количество`, " +
                    "CASE WHEN `protokol_sales`.`is_refund` = 0 THEN 'Нет' ELSE 'Да' END AS `Возврат`, " +
                    "`protokol_sales`.`operation_sum` AS `Сумма`, `protokol_sales`.`operator_id` " +
                    "FROM  `protokol_sales` " +
                    "WHERE `protokol_sales`.`time_check` = UNIX_TIMESTAMP(STR_TO_DATE('" + (TimeCheck + " 00:00:00") + "', '%d.%m.%Y %H:%i:%s')) AND `protokol_sales`.`document_id` = " +
                    DocID + " AND `protokol_sales`.`check_id` = " + CheckID +
                    " AND `protokol_sales`.`pos_id` IN (" + POS + ") LIMIT 0, 1000) AS `s` " +
                        //!s
                    "LEFT JOIN `directory_goods` AS `goods` ON `s`.`goods_id` = `goods`.`id` " +
                    "LEFT JOIN `directory_operator` AS `op` ON `op`.`id` = `s`.`operator_id` " +
                    "LEFT JOIN `directory_pos` AS `pos` ON `pos`.`id` = `s`.`pos_id` " +
                    "LEFT JOIN `protokol_operations` AS `oper` ON `oper`.`id` = `s`.`operation_id` " +
                    "ORDER BY `s`.`Время чека` DESC, `s`.`rec_id` DESC, `pos`.`name`, `s`.`ID чека`, `s`.`Номер смены`;";
                    break;
                case 1:
                    this.Text = "Детали чека ''Действия''";
                    Query = "SELECT `s`.`Время чека`, `pos`.`name` AS `POS`, `s`.`ID чека`,  `s`.`Номер смены`, `s`.`Время операции`, `oper`.`name` AS `Операция`, " +
                    "`goods`.`code` AS `Код товара`, `goods`.`name` AS `Товар`, `s`.`Номер карты`, `s`.`Количество`, `s`.`Возврат`, `s`.`Сумма`, `op`.`name` AS `Оператор` " +
                        //s
                    "FROM (SELECT from_unixtime(`protokol_actions`.`time_check`, '%d.%m.%Y %H:%i:%s') AS `Время чека`, " +
                    "`protokol_actions`.`pos_id`, `protokol_actions`.`rec_id`,`protokol_actions`.`check_id` AS `ID чека`, `protokol_actions`.`document_id` AS `Номер смены`, " +
                    "from_unixtime(`protokol_actions`.`time_operation`, '%d.%m.%Y %H:%i:%s') AS `Время операции`, " +
                    "`protokol_actions`.`operation_id`, `protokol_actions`.`goods_id` AS `goods_id`, " +
                    "`protokol_actions`.`discard_code` AS `Номер карты`, `protokol_actions`.`quantity` AS `Количество`, " +
                    "CASE WHEN `protokol_actions`.`is_refund` = 0 THEN 'Нет' ELSE 'Да' END AS `Возврат`, " +
                    "`protokol_actions`.`operation_sum` AS `Сумма`, `protokol_actions`.`operator_id` " +
                    "FROM  `protokol_actions` " +
                    "WHERE `protokol_actions`.`time_check` = UNIX_TIMESTAMP(STR_TO_DATE('" + (TimeCheck + " 00:00:00") + "', '%d.%m.%Y %H:%i:%s')) AND `protokol_actions`.`document_id` = " +
                    DocID + " AND `protokol_actions`.`check_id` = " + CheckID +
                    " AND `protokol_actions`.`pos_id` IN (" + POS + ") LIMIT 0, 1000) AS `s` " +
                        //!s
                    "LEFT JOIN `directory_goods` AS `goods` ON `s`.`goods_id` = `goods`.`id` " +
                    "LEFT JOIN `directory_operator` AS `op` ON `op`.`id` = `s`.`operator_id` " +
                    "LEFT JOIN `directory_pos` AS `pos` ON `pos`.`id` = `s`.`pos_id` " +
                    "LEFT JOIN `protokol_operations` AS `oper` ON `oper`.`id` = `s`.`operation_id` " +
                    "ORDER BY `s`.`Время чека` DESC, `s`.`rec_id` DESC, `pos`.`name`, `s`.`ID чека`, `s`.`Номер смены`;";
                    Clipboard.SetText(Query);
                    break;
            }
        }

        private void frmAppProtokolDetails_Load(object sender, EventArgs e)
        {
            //Создание формы ожидания и подписка на кнопку отмена
            frm.WaiterStopEvent += WaiterStopEventMethod;
            //Отрисовка вертикального текста на боковой панели
            VerticalLabel v = new VerticalLabel();
            v.Text = "ФИЛЬТР";
            v.TextDrawMode = DrawMode.TopBottom;
            v.Top = 30;
            v.Left = 0;
            v.Font = new Font("Tahoma", 12.0F);
            v.Enabled = false;
            Pinner.Checked = false;
            panel1_Leave(this, new EventArgs());
            panelFilter.Controls.Add(v);

            dgvData.DoubleBuffered(true);
            dgvData.DefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 9);
            dgvData.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 9);
        }

        private void frmAppProtokolDetails_Shown(object sender, EventArgs e)
        {
            Thread getdata = new Thread(() => { DT = db.getDT(Query); });
            if (w8.ThreadState == ThreadState.Unstarted)
                w8.Start();
            else
            {
                Thread.Sleep(2000);
                w8.Start();
            }
            getdata.Start();
            getdata.Join();
            if (DT == null && !Stop)
            {
                w8.Abort();
                MessageBox.Show(db.GetLastError(), "Ошибка");
                this.Close();
                return;
            }
            foreach (DataRow row in DT.Rows)
            {
                if (Stop)
                {
                    this.Dispose();
                    return;
                }
                if (row["Код товара"].ToString() == "0.00" || row["Код товара"].ToString() == "0" || row["Код товара"].ToString() == "0,00")
                    row["Код товара"] = DBNull.Value;
                if (row["Номер карты"].ToString() == "0.00" || row["Номер карты"].ToString() == "0" || row["Номер карты"].ToString() == "0,00")
                    row["Номер карты"] = DBNull.Value;
                if (row["Сумма"].ToString() == "0.00" || row["Сумма"].ToString() == "0" || row["Сумма"].ToString() == "0,00")
                    row["Сумма"] = DBNull.Value;
                if (row["Количество"].ToString() == "0.000" || row["Количество"].ToString() == "0" || row["Количество"].ToString() == "0,000")
                    row["Количество"] = DBNull.Value;
            }

            source = new BindingSource();
            source.DataSource = DT;

            LoadProt();

            ApplyStyle();
            LoadFilters();
            w8.Abort();
        }

        private void LoadProt()
        {
            dgvData.VirtualMode = true;
            dgvData.Columns.Add("Время чека", "Время чека");
            dgvData.Columns.Add("POS", "POS");
            dgvData.Columns.Add("ID чека", "ID чека");
            dgvData.Columns.Add("Номер смены", "Номер смены");
            dgvData.Columns.Add("Время операции", "Время операции");
            dgvData.Columns.Add("Операция", "Операция");
            dgvData.Columns.Add("Код товара", "Код товара");
            dgvData.Columns.Add("Товар", "Товар");
            dgvData.Columns.Add("Номер карты", "Номер карты");
            dgvData.Columns.Add("Количество", "Количество");
            dgvData.Columns.Add("Возврат", "Возврат");
            dgvData.Columns.Add("Сумма", "Сумма");
            dgvData.Columns.Add("Оператор", "Оператор");
            foreach (DataGridViewColumn column in dgvData.Columns)
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            if (DT.Rows.Count < 1000)
            {
                dgvData.RowCount = DT.Rows.Count;
            }
            else
            {
                dgvData.RowCount = 1000;
            }
        }

        void dgwData_Scroll(object sender, ScrollEventArgs e)
        {
            AddCells();
        }

        void dgwData_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                if (e.RowIndex > DT.Rows.Count - 1)
                    e.Value = DT.Rows[DT.Rows.Count - 1][e.ColumnIndex].ToString();
                else
                    e.Value = DT.Rows[e.RowIndex][e.ColumnIndex].ToString();
                slblCountRows.Text = "Загружено: " + dgvData.Rows.Count + " из " + DT.Rows.Count + " записей";
            }
            catch { return; }
        }

        void WaiterStopEventMethod(int Module)
        {
            //Событие по кнопке отмена в форме ожидания
            if (Module == 2 || Module == -2)
                Stop = true;
        }

        public void ApplyStyle()
        {
            DataTable DTColors = new DataTable();
            Query = "SELECT protokol_operations.id, protokol_operations.`name`, protokol_operations_colors.color, protokol_operations_colors.text_color AS `Цвет текста`" +
            "FROM protokol_operations, protokol_operations_colors " +
            "WHERE protokol_operations.id = protokol_operations_colors.op_id;";
            DTColors = db.getDT(Query);
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (Stop)
                {
                    this.Dispose();
                    return;
                }
                foreach (DataRow r in DTColors.Rows)
                {
                    if (r.ItemArray[1].ToString() == row.Cells["Операция"].Value.ToString())
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(r.ItemArray[2].ToString());
                        row.DefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(r.ItemArray[3].ToString());
                    }
                }
            }
            foreach (DataGridViewColumn c in dgvData.Columns)
            {
                if (c.Index != 0 && c.Index != 1 && c.Index != 4 && c.Index != 5 & c.Index != 7 && c.Index != 10 && c.Index != 12)
                    c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void dgwData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Text != "Детали чека" && e.RowIndex != -1)
            {
                DataTable DTtmp = null;
                DTtmp = db.getDT("SELECT `directory_pos`.`id` FROM `directory_pos` WHERE `directory_pos`.`name` = '" + dgvData.Rows[e.RowIndex].Cells["POS"].Value.ToString() + "';");
                if (DTtmp == null)
                {
                    MessageBox.Show(db.GetLastError(), "Ошибка");
                    return;
                }
                frmAppProtokolDetails CheckDetail = new frmAppProtokolDetails(type, dgvData.Rows[e.RowIndex].Cells["Время чека"].Value.ToString(),
                    int.Parse(DTtmp.Rows[0].ItemArray[0].ToString()), int.Parse(dgvData.Rows[e.RowIndex].Cells["ID чека"].Value.ToString()),
                    int.Parse(dgvData.Rows[e.RowIndex].Cells["Номер смены"].Value.ToString()));
                CheckDetail.Show(this.DockPanel);
                CheckDetail.Show();
            }
        }

        private void dgwData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex != -1)
            {
                dgvData.ClearSelection();
                for (int r = 0; r < dgvData.RowCount; r++)
                    dgvData[e.ColumnIndex, r].Selected = true;
            }
        }

        private void dgwData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count == 1)
                slblPosition.Text = "Строка: " + dgvData.SelectedCells[0].RowIndex + ", Столбец: " + dgvData.SelectedCells[0].ColumnIndex;
            else
                slblPosition.Text = "Строка:  , Столбец: ";

            AddCells();
            CalcSelected();
        }

        private void dgwData_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvData.ClearSelection();
                dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                dgvData.ContextMenuStrip = contextMenu;
            }
            else
                dgvData.ContextMenuStrip = null;
        }


        public delegate void ChngeProgressEventHandler(int Progress);
        private void btnExportExcell_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "bin",
                Filter = @"Excel-файл (*.xlsx)|*.xlsx|CSV-файл (*.csv)|*.csv",
                FilterIndex = 0,
                RestoreDirectory = true

            };

            if (save.ShowDialog() != DialogResult.OK) return;

            var f = new frmWaiter(-2, dgvData.Rows.Count);
            ChngeProgressEventHandler CP = new ChngeProgressEventHandler(f.ChangeProgress);
            w8 = new Thread(() => { f.ShowDialog(); });
            w8.Start();
            switch (save.FilterIndex)
            {
                case 1:
                    Microsoft.Office.Interop.Excel.Application ObjExcel;
                    Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
                    try
                    {
                        ObjExcel = new Microsoft.Office.Interop.Excel.Application();
                        ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
                        ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
                        for (int j = 0; j <= this.dgvData.ColumnCount - 1; j++)
                        {
                            ObjExcel.Cells[1, j + 1] = dgvData.Columns[j].HeaderText;
                            ObjExcel.Cells[1, j + 1].Interior.Color = Color.Gray;
                        }
                        for (int i = 0; i < dgvData.Rows.Count; i++)
                        {
                            CP.Invoke(i);
                            DataGridViewRow row = dgvData.Rows[i];
                            for (int j = 0; j < row.Cells.Count; j++)
                            {
                                ObjExcel.Cells[i + 2, j + 1] = row.Cells[j].Value;
                                ObjExcel.Cells[i + 2, j + 1].Font.Color = dgvData.Rows[i].DefaultCellStyle.ForeColor;
                                ObjExcel.Cells[i + 2, j + 1].Interior.Color = dgvData.Rows[i].DefaultCellStyle.BackColor;
                            }
                        }
                        ObjWorkSheet.Columns.AutoFit();
                        ObjWorkBook.SaveAs(save.FileName);
                        ObjWorkBook.Close();
                        ObjExcel.Quit();
                        ObjWorkBook = null;
                        ObjWorkSheet = null;
                        ObjExcel = null;
                        GC.Collect();
                    }
                    catch
                    {
                        w8.Abort();
                        return;
                    }
                    w8.Abort();
                    break;
                case 2:
                    var sw = new StreamWriter(save.FileName, true, Encoding.Default);
                    var first = true;
                    foreach (DataGridViewColumn c in dgvData.Columns)
                    {
                        if (!first) sw.Write(";");
                        sw.Write(c.HeaderText.ToString());
                        first = false;
                    }
                    sw.WriteLine();
                    int x = 0;
                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        x++;
                        CP.Invoke(x);
                        if (!row.IsNewRow)
                        {
                            first = true;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (!first) sw.Write(";");
                                if (cell.Value.ToString().StartsWith("+"))
                                    sw.Write("  " + cell.Value.ToString());
                                else
                                    sw.Write(cell.Value.ToString());
                                first = false;
                            }
                            sw.WriteLine();
                        }
                    }
                    sw.Close();
                    w8.Abort();
                    break;
                default:
                    break;
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvData.DataSource == null)
                return;
            ClearFilters();
            dgvData.DataSource = null;
            dgvData.Columns.Clear();
            LoadProt();
            ApplyStyle();
            btnHideColumns(this, new EventArgs());
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Filter = "";
            bool notfirst = false;

            #region DateTime Filter
            if (date1.Checked)
            {
                notfirst = true;

                if (time1.Checked)
                    if (date1.Value.Hour < 10)
                        Filter += string.Format("{0} > '{1}'", "[Время чека]", date1.Value.ToShortDateString() + " 0" + time1.Value.ToLongTimeString());
                    else
                        Filter += string.Format("{0} > '{1}'", "[Время чека]", date1.Value.ToShortDateString() + " " + time1.Value.ToLongTimeString());
                else
                    Filter += string.Format("{0} > '{1}'", "[Время чека]", date1.Value.ToShortDateString() + " 00:00:00");
            }
            if (date2.Checked)
            {
                if (notfirst)
                    Filter += " AND ";
                else
                    notfirst = true;

                if (time2.Checked)
                    if (date2.Value.Hour < 10)
                        Filter += string.Format("{0} < '{1}'", "[Время чека]", date2.Value.ToShortDateString() + " 0" + time2.Value.ToLongTimeString());
                    else
                        Filter += string.Format("{0} < '{1}'", "[Время чека]", date2.Value.ToShortDateString() + " " + time2.Value.ToLongTimeString());
                else
                    Filter += string.Format("{0} < '{1}'", "[Время чека]", date2.Value.ToShortDateString() + " 23:59:59");
            }
            #endregion

            #region POS Filter
            if (cbFilterPOS.Text != "")
            {
                string[] items = cbFilterPOS.Text.Split(new char[] { ',' });
                bool first = true;
                if (notfirst)
                    Filter += " AND (";
                else
                {
                    Filter += " (";
                    notfirst = true;
                }
                foreach (string s in items)
                {
                    if (first)
                        first = false;
                    else
                        Filter += " OR ";
                    Filter += string.Format("{0} LIKE '%{1}%'", "[POS]", s.TrimStart());
                }
                Filter += ")";
            }
            #endregion

            #region goods id Filter
            if (cbFilterGoodsID.Text != "")
            {
                string[] items = cbFilterGoodsID.Text.Split(new char[] { ',' });
                bool first = true;
                if (notfirst)
                    Filter += " AND (";
                else
                {
                    Filter += " (";
                    notfirst = true;
                }
                foreach (string s in items)
                {
                    if (first)
                        first = false;
                    else
                        Filter += " OR ";
                    Filter += string.Format("{0} = '{1}'", "[Код товара]", s.TrimStart());
                }
                Filter += ")";
            }
            #endregion

            #region goods name Filter
            if (cbFilterGoods.Text != "")
            {
                string[] items = cbFilterGoods.Text.Split(new char[] { ',' });
                bool first = true;
                if (notfirst)
                    Filter += " AND (";
                else
                {
                    Filter += " (";
                    notfirst = true;
                }
                foreach (string s in items)
                {
                    if (first)
                        first = false;
                    else
                        Filter += " OR ";
                    Filter += string.Format("{0} LIKE '%{1}%'", "[Товар]", s.TrimStart());
                }
                Filter += ")";
            }
            #endregion

            #region Operation Filter
            if (cbFilterOperation.Text != "")
            {
                string[] items = cbFilterOperation.Text.Split(new char[] { ',' });
                bool first = true;
                if (notfirst)
                    Filter += " AND (";
                else
                {
                    Filter += " (";
                    notfirst = true;
                }
                foreach (string s in items)
                {
                    if (first)
                        first = false;
                    else
                        Filter += " OR ";
                    Filter += string.Format("{0} LIKE '%{1}%'", "[Операция]", s.TrimStart());
                }
                Filter += ")";
            }
            #endregion

            #region card id Filter
            if (cbFilterCardID.Text != "")
            {
                string[] items = cbFilterCardID.Text.Split(new char[] { ',' });
                bool first = true;
                if (notfirst)
                    Filter += " AND (";
                else
                {
                    Filter += " (";
                    notfirst = true;
                }
                foreach (string s in items)
                {
                    if (first)
                        first = false;
                    else
                        Filter += " OR ";
                    Filter += string.Format("{0} = '{1}'", "[Номер карты]", s.TrimStart());
                }
                Filter += ")";
            }
            #endregion

            #region Operator name Filter
            if (cbFilterOperator.Text != "")
            {
                string[] items = cbFilterOperator.Text.Split(new char[] { ',' });
                bool first = true;
                if (notfirst)
                    Filter += " AND (";
                else
                {
                    Filter += " (";
                    notfirst = true;
                }
                foreach (string s in items)
                {
                    if (first)
                        first = false;
                    else
                        Filter += " OR ";
                    Filter += string.Format("{0} = '{1}'", "[Оператор]", s.TrimStart());
                }
                Filter += ")";
            }
            #endregion

            if (Filter == "")
                return;

            dgvData.DataSource = null;
            dgvData.Columns.Clear();
            source.Filter = Filter;
            dgvData.DataSource = source;
            ApplyStyle();
            slblCountRows.Text = "Загружено: " + dgvData.Rows.Count + " из " + DT.Rows.Count + " записей";
            btnHideColumns(this, new EventArgs());
        }

        private void LoadFilters()
        {
            //Hide columns
            foreach (DataGridViewColumn d in dgvData.Columns)
                HS.Items.Add(d.HeaderText);

            if (WaveBackOffice.Properties.Settings.Default.ProtHidedCols.Trim() != "")
            {
                string[] r = WaveBackOffice.Properties.Settings.Default.ProtHidedCols.Split(',');
                foreach (string s in r)
                    HS.CheckBoxItems[s.TrimEnd().TrimStart()].Checked = true;
                btnHideColumns(this, new EventArgs());
            }

            //Other filters
            if (DT.Rows.Count <= 0 || DT == null)
                return;
            date1.Value = DateTime.Parse(DT.Rows[0].ItemArray[0].ToString());
            date2.Value = DateTime.Parse(DT.Rows[DT.Rows.Count - 1].ItemArray[0].ToString());
            time1.Value = DateTime.Parse(DT.Rows[0].ItemArray[0].ToString());
            time2.Value = DateTime.Parse(DT.Rows[DT.Rows.Count - 1].ItemArray[0].ToString());
            date1.Checked = date2.Checked = time1.Checked = time2.Checked = false;

            foreach (DataRow row in DT.Rows)
            {
                if (Stop)
                {
                    this.Dispose();
                    return;
                }
                if (!cbFilterPOS.Items.Contains(row.ItemArray[1].ToString()))
                    cbFilterPOS.Items.Add(row.ItemArray[1].ToString());
                //if (!cbFilterGoodsID.Items.Contains(row.ItemArray[6].ToString()))
                //    cbFilterGoodsID.Items.Add(row.ItemArray[6].ToString());
                //if (!cbFilterGoods.Items.Contains(row.ItemArray[7].ToString()) && row.ItemArray[7].ToString() != "")
                //    cbFilterGoods.Items.Add(row.ItemArray[7].ToString());
                if (!cbFilterOperation.Items.Contains(row.ItemArray[5].ToString()))
                    cbFilterOperation.Items.Add(row.ItemArray[5].ToString());
                if (!cbFilterCardID.Items.Contains(row.ItemArray[8].ToString()))
                    cbFilterCardID.Items.Add(row.ItemArray[8].ToString());
                if (!cbFilterOperator.Items.Contains(row.ItemArray[12].ToString()))
                    cbFilterOperator.Items.Add(row.ItemArray[12].ToString());
            }

            cbFilterCardID.Sorted = true;
            //cbFilterGoods.Sorted = true;
            //cbFilterGoodsID.Sorted = true;
            cbFilterOperation.Sorted = true;
            cbFilterOperator.Sorted = true;
            cbFilterPOS.Sorted = true;
        }

        private void ClearFilters()
        {
            date1.Checked = date2.Checked = time1.Checked = time1.Enabled = time2.Checked = time2.Enabled = false;

            cbFilterPOS.Text = cbFilterOperator.Text = cbFilterOperation.Text = cbFilterGoodsID.Text
                = cbFilterGoods.Text = cbFilterCardID.Text = "";

            for (int i = 0; i < cbFilterPOS.Items.Count; i++)
                cbFilterPOS.CheckBoxItems[i].Checked = false;

            //for (int i = 0; i < cbFilterGoodsID.Items.Count; i++)
            //    cbFilterGoodsID.CheckBoxItems[i].Checked = false;

            //for (int i = 0; i < cbFilterGoods.Items.Count; i++)
            //    cbFilterGoods.CheckBoxItems[i].Checked = false;

            for (int i = 0; i < cbFilterOperation.Items.Count; i++)
                cbFilterOperation.CheckBoxItems[i].Checked = false;

            for (int i = 0; i < cbFilterCardID.Items.Count; i++)
                cbFilterCardID.CheckBoxItems[i].Checked = false;

            for (int i = 0; i < cbFilterOperator.Items.Count; i++)
                cbFilterOperator.CheckBoxItems[i].Checked = false;
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            time1.Enabled = date1.Checked;
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            time2.Enabled = date2.Checked;
        }

        private void AddCells()
        {
            if (dgvData.RowCount > 11)
                if (dgvData.Rows[dgvData.RowCount - 10].Displayed && dgvData.RowCount < DT.Rows.Count && dgvData.DataSource == null)
                {
                    if (dgvData.RowCount < DT.Rows.Count && DT.Rows.Count - dgvData.RowCount < 1000)
                        dgvData.RowCount += DT.Rows.Count - dgvData.RowCount;
                    else
                        dgvData.RowCount += 1000;
                    ApplyStyle();
                }
        }

        private void CalcSelected()
        {
            double summ = 0;
            double col = 0;
            double tmp = 0;
            foreach (DataGridViewCell c in dgvData.SelectedCells)
            {
                if (c.OwningColumn.Name == "Сумма")
                {
                    double.TryParse(c.Value.ToString(), out tmp);
                    summ += tmp;
                }
                if (c.OwningColumn.Name == "Количество")
                {
                    double.TryParse(c.Value.ToString(), out tmp);
                    col += tmp;
                }
            }
            slblSumm.Text = "SUMM(Количество) = " + col.ToString() + " || SUMM(Сумма) = " + summ.ToString();
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (dgvData.SelectedCells.Count == 1 && dgvData.SelectedCells[0].Value.ToString() != "")
            {
                toolStripSep1.Visible = true;
                switch (dgvData.SelectedCells[0].OwningColumn.Name)
                {
                    case "Время чека":
                        tsbtnFilterFrom.Visible = tsbtnFilterTo.Visible = true;
                        tsbtnFilterFromLong.Visible = tsbtnFilterToLong.Visible = true;
                        tsbtnFilterFrom.Text = "Фильтр 'Период с': " + DateTime.Parse(dgvData.SelectedCells[0].Value.ToString()).ToLongDateString();
                        tsbtnFilterTo.Text = "Фильтр 'Период до': " + DateTime.Parse(dgvData.SelectedCells[0].Value.ToString()).ToLongDateString();
                        tsbtnFilterFromLong.Text = "Фильтр 'Период с': " + DateTime.Parse(dgvData.SelectedCells[0].Value.ToString()).ToLongDateString() +
                            " " + DateTime.Parse(dgvData.SelectedCells[0].Value.ToString()).ToLongTimeString();
                        tsbtnFilterToLong.Text = "Фильтр 'Период до': " + DateTime.Parse(dgvData.SelectedCells[0].Value.ToString()).ToLongDateString() +
                            " " + DateTime.Parse(dgvData.SelectedCells[0].Value.ToString()).ToLongTimeString();
                        break;
                    case "POS":
                        tsbtnFilterFrom.Visible = true;
                        tsbtnFilterTo.Visible = tsbtnFilterFromLong.Visible = tsbtnFilterToLong.Visible = false;
                        tsbtnFilterFrom.Text = "Фильтр 'Имя POS': " + dgvData.SelectedCells[0].Value.ToString();
                        break;
                    case "Код товара":
                        if (dgvData.SelectedCells[0].Value.ToString() == "0")
                        {
                            e.Cancel = true;
                            break;
                        }
                        tsbtnFilterFrom.Visible = true;
                        tsbtnFilterTo.Visible = tsbtnFilterFromLong.Visible = tsbtnFilterToLong.Visible = false;
                        tsbtnFilterFrom.Text = "Фильтр 'Код товара': " + dgvData.SelectedCells[0].Value.ToString();
                        break;
                    case "Товар":
                        tsbtnFilterFrom.Visible = true;
                        tsbtnFilterTo.Visible = tsbtnFilterFromLong.Visible = tsbtnFilterToLong.Visible = false;
                        tsbtnFilterFrom.Text = "Фильтр 'Товар': " + dgvData.SelectedCells[0].Value.ToString();
                        break;
                    case "Операция":
                        tsbtnFilterFrom.Visible = true;
                        tsbtnFilterTo.Visible = tsbtnFilterFromLong.Visible = tsbtnFilterToLong.Visible = false;
                        tsbtnFilterFrom.Text = "Фильтр 'Операция': " + dgvData.SelectedCells[0].Value.ToString();
                        break;
                    case "Номер карты":
                        if (dgvData.SelectedCells[0].Value.ToString() == "0")
                        {
                            e.Cancel = true;
                            break;
                        }
                        tsbtnFilterFrom.Visible = true;
                        tsbtnFilterTo.Visible = tsbtnFilterFromLong.Visible = tsbtnFilterToLong.Visible = false;
                        tsbtnFilterFrom.Text = "Фильтр 'Номер карты': " + dgvData.SelectedCells[0].Value.ToString();
                        break;
                    case "Оператор":
                        tsbtnFilterFrom.Visible = true;
                        tsbtnFilterTo.Visible = tsbtnFilterFromLong.Visible = tsbtnFilterToLong.Visible = false;
                        tsbtnFilterFrom.Text = "Фильтр 'Имя оператора': " + dgvData.SelectedCells[0].Value.ToString();
                        break;
                    default:
                        toolStripSep1.Visible = false;
                        tsbtnFilterFrom.Visible = false;
                        tsbtnFilterFromLong.Visible = false;
                        tsbtnFilterTo.Visible = false;
                        tsbtnFilterToLong.Visible = false;
                        break;
                }
            }
            else
            {
                toolStripSep1.Visible = false;
                tsbtnFilterFrom.Visible = false;
                tsbtnFilterFromLong.Visible = false;
                tsbtnFilterTo.Visible = false;
                tsbtnFilterToLong.Visible = false;
            }
        }

        private void tsbtnFilterFrom_Click(object sender, EventArgs e)
        {
            switch (dgvData.SelectedCells[0].OwningColumn.Name)
            {
                case "Время чека":
                    date1.Checked = true;
                    date1.Value = DateTime.Parse(dgvData.SelectedCells[0].Value.ToString());
                    break;
                case "POS":
                    cbFilterPOS.CheckBoxItems[dgvData.SelectedCells[0].Value.ToString()].Checked = true;
                    break;
                case "Код товара":
                    if (cbFilterGoodsID.Text.Trim() != "")
                        cbFilterGoodsID.Text += ",";
                    cbFilterGoodsID.Text += dgvData.SelectedCells[0].Value.ToString();
                    //cbFilterGoodsID.CheckBoxItems[dgwData.SelectedCells[0].Value.ToString()].Checked = true;
                    break;
                case "Товар":
                    if (cbFilterGoods.Text.Trim() != "")
                        cbFilterGoods.Text += ",";
                    cbFilterGoods.Text += dgvData.SelectedCells[0].Value.ToString();
                    //cbFilterGoods.CheckBoxItems[dgwData.SelectedCells[0].Value.ToString()].Checked = true;
                    break;
                case "Операция":
                    cbFilterOperation.CheckBoxItems[dgvData.SelectedCells[0].Value.ToString()].Checked = true;
                    break;
                case "Номер карты":
                    cbFilterCardID.CheckBoxItems[dgvData.SelectedCells[0].Value.ToString()].Checked = true;
                    break;
                case "Оператор":
                    cbFilterOperator.CheckBoxItems[dgvData.SelectedCells[0].Value.ToString()].Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void tsbtnFilterTo_Click(object sender, EventArgs e)
        {
            switch (dgvData.SelectedCells[0].OwningColumn.Name)
            {
                case "Время чека":
                    date2.Checked = true;
                    date2.Value = DateTime.Parse(dgvData.SelectedCells[0].Value.ToString());
                    break;
            }
        }

        private void tsbtnFilterClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void tsbtnFilterFromLong_Click(object sender, EventArgs e)
        {
            switch (dgvData.SelectedCells[0].OwningColumn.Name)
            {
                case "Время чека":
                    date1.Checked = true;
                    date1.Value = DateTime.Parse(dgvData.SelectedCells[0].Value.ToString());
                    time1.Checked = true;
                    time1.Enabled = true;
                    time1.Value = DateTime.Parse(dgvData.SelectedCells[0].Value.ToString());
                    break;
            }
        }

        private void tsbtnFilterToLong_Click(object sender, EventArgs e)
        {
            switch (dgvData.SelectedCells[0].OwningColumn.Name)
            {
                case "Время чека":
                    date2.Checked = true;
                    date2.Value = DateTime.Parse(dgvData.SelectedCells[0].Value.ToString());
                    time2.Checked = true;
                    time2.Enabled = true;
                    time2.Value = DateTime.Parse(dgvData.SelectedCells[0].Value.ToString());
                    break;
            }
        }

        private void tsbtnSales_Click(object sender, EventArgs e)
        {
            DataTable DTtmp = null;
            DTtmp = db.getDT("SELECT `directory_pos`.`id` FROM `directory_pos` WHERE `directory_pos`.`name` = '" + dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells["POS"].Value.ToString() + "';");
            if (DTtmp == null)
            {
                MessageBox.Show(db.GetLastError(), "Ошибка");
                return;
            }
            frmAppProtokolDetails CheckDetail = new frmAppProtokolDetails(0,
                    dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells["Время чека"].Value.ToString(),
                    int.Parse(DTtmp.Rows[0].ItemArray[0].ToString()), int.Parse(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells["ID чека"].Value.ToString()),
                    int.Parse(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells["Номер смены"].Value.ToString()));
            CheckDetail.Show(this.DockPanel);
            CheckDetail.Show();
        }

        private void tsbtnActions_Click(object sender, EventArgs e)
        {
            DataTable DTtmp = null;
            DTtmp = db.getDT("SELECT `directory_pos`.`id` FROM `directory_pos` WHERE `directory_pos`.`name` = '" + dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells["POS"].Value.ToString() + "';");
            if (DTtmp == null)
            {
                MessageBox.Show(db.GetLastError(), "Ошибка");
                return;
            }
            frmAppProtokolDetails CheckDetail = new frmAppProtokolDetails(1,
                    dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells["Время чека"].Value.ToString(),
                    int.Parse(DTtmp.Rows[0].ItemArray[0].ToString()), int.Parse(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells["ID чека"].Value.ToString()),
                    int.Parse(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells["Номер смены"].Value.ToString()));
            CheckDetail.Show(this.DockPanel);
            CheckDetail.Show();
        }

        private void btnHideColumns(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewColumn d in dgvData.Columns)
                    d.Visible = true;
                string[] r = HS.Text.Split(',');
                if (HS.Text.Trim() != "")
                    foreach (string s in r)
                        dgvData.Columns[s.TrimEnd().TrimStart()].Visible = false;
                Properties.Settings.Default.ProtHidedCols = HS.Text;
                Properties.Settings.Default.Save();
            }
            catch
            {

            }
        }
    }
}
