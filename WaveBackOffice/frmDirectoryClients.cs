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
    public partial class frmDirectoryClients : DockContent
    {
        DB db = DB.Instace();
        static frmWaiter frm = new frmWaiter(1);
        bool Stop = false;
        Thread w8 = new Thread(() => { frm.ShowDialog(); });
        DataTable DT;
        BindingSource source;
        public frmDirectoryClients()
        {
            InitializeComponent();
        }

        #region Скрывающаяся боковая панель
        bool hidden = false;
        private void Pinner_CheckedChanged(object sender, EventArgs e)
        {
            if (Pinner.Checked)
            {
                hidden = false;
                Pinner.ImageIndex = 0;
                panel1.AutoScroll = true;
                panel1.SendToBack();
            }
            else
            {
                hidden = true;
                Pinner.ImageIndex = 1;
                panel1.BringToFront();
            }
        }
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if (hidden)
            {
                panel1.Width = 263;
                panel1.BringToFront();
                panel1.AutoScroll = true;
                panel1.Focus();
            }
        }
        private void panel1_Leave(object sender, EventArgs e)
        {
            if (hidden)
            {
                panel1.Width = 30;
                panel1.AutoScroll = false;
            }
            else
                panel1.SendToBack();
        }
        #endregion

        private void frmDirectoryClients_Load(object sender, EventArgs e)
        {
            w8 = new Thread(() => { try { frm.ShowDialog(); } catch { } });
            cbAccountLights.Checked = WaveBackOffice.Properties.Settings.Default.cbAccountLigts;
            btnAccountColorActive.BackColor = WaveBackOffice.Properties.Settings.Default.AccountColorActive;
            btnAccountColorEmployee.BackColor = WaveBackOffice.Properties.Settings.Default.AccountColorEmployee;
            btnAccountColorSubscribe.BackColor = WaveBackOffice.Properties.Settings.Default.AccountColorSubscibe;
            //Создание формы ожидания и подписка на кнопку отмена
            frm.WaiterStopEvent += WaiterStopEventMethod;
            dgvAccounts.DoubleBuffered(true);
            dgvAccounts.DefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, (float)9.5);
            dgvAccounts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, (float)9.5);
            //Установка фильтров в значение по умолчанию
            tbSearchSubscribe.SelectedIndex = 0;
            tbSearchActive.SelectedIndex = 0;
            tbSearchEmployee.SelectedIndex = 0;
            tbSearchVip.SelectedIndex = 0;
        }

        private void frmDirectoryClients_Shown(object sender, EventArgs e)
        {
            //Отрисовка вертикального текста на боковой панели
            VerticalLabel v = new VerticalLabel();
            v.Text = "ФИЛЬТР";
            v.TextDrawMode = DrawMode.TopBottom;
            v.Top = 30;
            v.Left = 0;
            v.Font = new Font("Tahoma", 12.0F);
            v.Enabled = false;
            panel1.Controls.Add(v);
            TabAccountLoad();
        }

        //Hotkeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Insert:
                    btnAccountsAdd_Click(this, new EventArgs());
                    break;
                case (Keys.Control | Keys.F):
                    cbSearchID.Focus();
                    break;
                case Keys.Enter:
                    if (dgvAccounts.Focused)
                        dgwAccounts_CellDoubleClick(this, new DataGridViewCellEventArgs(0, dgvAccounts.SelectedCells[0].RowIndex));
                    else
                        btnAccountSearch_Click(this, new EventArgs());
                    break;
                case Keys.F5:
                    btnAccountUpdate_Click(this, new EventArgs());
                    break;
                case Keys.Escape:
                    dgvAccounts.Focus();
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            TabAccountLoad();
        }

        private void btnAccountsAdd_Click(object sender, EventArgs e)
        {
            using (var form = new frmDirectoryClientsDetails())
                form.ShowDialog();
        }

        public void TabAccountLoad()
        {
            string Query = "SELECT directory_account_details.account_id AS `ID`, ?Card1 directory_account_details.last_name AS `Фамилия`, directory_account_details.first_name AS `Имя`," +
                   "directory_account_details.middle_name AS `Отчество`, directory_account_details.tel AS `Телефон`," +
                       "directory_account_details.tel2 AS `доп. Телефон`, directory_account_details.email AS `e-mail`, CASE WHEN directory_account.is_subscribe = 0 THEN 'Нет' ELSE 'Да' END AS `Подписка`," +
                   "CASE WHEN directory_account.is_active = 0 THEN 'Нет' ELSE 'Да' END AS `Активен`, CASE WHEN directory_account.is_employee = 0 THEN 'Нет' ELSE 'Да' END AS `Сотрудник`, " +
                   "CASE WHEN directory_account.is_bonus = 0 THEN 'Нет' ELSE 'Да' END AS `Бонусный`, " +
                   "CASE WHEN directory_account.is_vip = 0 THEN 'Нет' ELSE 'Да' END AS `VIP`, " +
                   "directory_account_details.city AS `Город`, FROM_UNIXTIME(directory_account.date_activate) AS `Дата создания`, directory_account.description AS `Примечание` " +
                   "FROM directory_account_details, directory_account ?Card2" +
                   "WHERE `directory_account_details`.`account_id` = `directory_account`.`account_id` ?ID ?Card0 ?Name ?Tel ?City ?Subscribe ?Active ?Emp ?VIP ORDER BY `ID`";

            if (tbSearchID.Text.Trim() != "" && cbSearchID.Checked)
                Query = Query.Replace("?ID", " AND `directory_account`.`account_id` LIKE '%" + tbSearchID.Text + "%' ");
            else
                Query = Query.Replace("?ID", "");

            if (tbSearchName.Text.Trim() != "" && cbSearchName.Checked)
                Query = Query.Replace("?Name", " AND (`directory_account_details`.`last_name` LIKE '%" + tbSearchName.Text + "%' OR " +
                    "`directory_account_details`.`first_name` LIKE '%" + tbSearchName.Text + "%' OR `directory_account_details`.`middle_name` LIKE '%" + tbSearchName.Text + "%') ");
            else
                Query = Query.Replace("?Name", "");

            if (tbSearchTel.Text.Trim() != "" && cbSearchTel.Checked)
                Query = Query.Replace("?Tel", " AND (`directory_account_details`.`tel` LIKE '%" + tbSearchTel.Text + "%' OR " +
               "`directory_account_details`.`tel2` LIKE '%" + tbSearchTel.Text + "%') ");
            else
                Query = Query.Replace("?Tel", "");

            if (tbSearchCity.Text.Trim() != "" && cbSearchCity.Checked)
                Query = Query.Replace("?City", " AND `directory_account_details`.`city` LIKE '%" + tbSearchCity.Text + "%' ");
            else
                Query = Query.Replace("?City", "");


            if (cbSearchSubscribe.Checked)
                switch (tbSearchSubscribe.SelectedIndex)
                {
                    case 0:
                        Query = Query.Replace("?Subscribe", " AND `directory_account`.`is_subscribe` = 1 ");
                        break;
                    case 1:
                        Query = Query.Replace("?Subscribe", " AND `directory_account`.`is_subscribe` = 0 ");
                        break;
                    default:
                        Query = Query.Replace("?Subscribe", "");
                        break;
                }
            else
                Query = Query.Replace("?Subscribe", "");

            if (cbSearchActive.Checked)
                switch (tbSearchActive.SelectedIndex)
                {
                    case 0:
                        Query = Query.Replace("?Active", " AND `directory_account`.`is_active` = 1 ");
                        break;
                    case 1:
                        Query = Query.Replace("?Active", " AND `directory_account`.`is_active` = 0 ");
                        break;
                    default:
                        Query = Query.Replace("?Active", "");
                        break;
                }
            else
                Query = Query.Replace("?Active", "");

            if (cbSearchEmployee.Checked)
                switch (tbSearchEmployee.SelectedIndex)
                {
                    case 0:
                        Query = Query.Replace("?Emp", " AND `directory_account`.`is_employee` = 1 ");
                        break;
                    case 1:
                        Query = Query.Replace("?Emp", " AND `directory_account`.`is_employee` = 0 ");
                        break;
                    default:
                        Query = Query.Replace("?Emp", "");
                        break;
                }
            else
                Query = Query.Replace("?Emp", "");

            if (cbSearchVip.Checked)
                switch (tbSearchVip.SelectedIndex)
                {
                    case 0:
                        Query = Query.Replace("?VIP", " AND `directory_account`.`is_vip` = 1 ");
                        break;
                    case 1:
                        Query = Query.Replace("?VIP", " AND `directory_account`.`is_vip` = 0 ");
                        break;
                    default:
                        Query = Query.Replace("?VIP", "");
                        break;
                }
            else
                Query = Query.Replace("?VIP", "");



            if (cbSearchCardID.Checked && tbSearchCardID.Text.Trim() != "")
            {
                Query = Query.Replace("?Card0", " AND (`directory_account_cards`.`account_id` = `directory_account`.`account_id` AND `directory_account_cards`.`card_id` LIKE " +
                    "'%" + tbSearchCardID.Text + "%') ");
                Query = Query.Replace("?Card1", " `directory_account_cards`.`card_id` AS `Карта`,");
                Query = Query.Replace("?Card2", ", `directory_account_cards`");
            }
            else
            {
                Query = Query.Replace("?Card0", "");
                Query = Query.Replace("?Card1", "");
                Query = Query.Replace("?Card2", "");
            }

            DT = null;
            var thread = new Thread(() => { DT = db.getDT(Query); });
            if (w8.ThreadState == ThreadState.Aborted)
                w8 = new Thread(() => { frm.ShowDialog(); });
            if (w8.ThreadState == ThreadState.Unstarted || w8.ThreadState == ThreadState.Stopped)
                w8.Start();
            thread.Start();
            thread.Join();
            if (Stop)
            {
                this.Dispose();
                return;
            }
            if (DT == null)
            {
                MessageBox.Show(db.GetLastError(), "Ошибка");
                return; //no connect
            }
            source = new BindingSource();
            source.DataSource = DT;
            LoadClients();
            TabAccountApplyStyle();
            w8.Abort();
        }

        private void LoadClients()
        {
            dgvAccounts.VirtualMode = true;
            dgvAccounts.Columns.Clear();
            dgvAccounts.Columns.Add("ID", "ID");
            if (cbSearchCardID.Checked && tbSearchCardID.Text.Trim() != "")
                dgvAccounts.Columns.Add("Карта", "Карта");
            dgvAccounts.Columns.Add("Фамилия", "Фамилия");
            dgvAccounts.Columns.Add("Имя", "Имя");
            dgvAccounts.Columns.Add("Отчество", "Отчество");
            dgvAccounts.Columns.Add("Телефон", "Телефон");
            dgvAccounts.Columns.Add("доп. Телефон", "доп. Телефон");
            dgvAccounts.Columns.Add("e-mail", "e-mail");
            dgvAccounts.Columns.Add("Подписка", "Подписка");
            dgvAccounts.Columns.Add("Активен", "Активен");
            dgvAccounts.Columns.Add("Сотрудник", "Сотрудник");
            dgvAccounts.Columns.Add("Бонусный", "Бонусный");
            dgvAccounts.Columns.Add("VIP", "VIP");
            dgvAccounts.Columns.Add("Город", "Город");
            dgvAccounts.Columns.Add("Дата создания", "Дата создания");
            dgvAccounts.Columns.Add("Примечание", "Примечание");
            foreach (DataGridViewColumn column in dgvAccounts.Columns)
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            if (DT.Rows.Count < 1000)
            {
                dgvAccounts.RowCount = DT.Rows.Count;
            }
            else
            {
                dgvAccounts.RowCount = 1000;
            }
        }

        //Событие по кнопке отмена в форме ожидания
        void WaiterStopEventMethod(int Module)
        {
            if (Module == 1)
                Stop = true;
        }

        private void TabAccountApplyStyle()
        {
            foreach (DataGridViewRow row in dgvAccounts.Rows)
            {
                if (Stop)
                {
                    this.Dispose();
                    return;
                }
                if (!cbAccountLights.Checked)
                {
                    if (row.Cells["Активен"].Value.ToString() == "Нет")
                        row.DefaultCellStyle.BackColor = WaveBackOffice.Properties.Settings.Default.AccountColorActive;
                    else if (row.Cells["Сотрудник"].Value.ToString() == "Да")
                        row.DefaultCellStyle.BackColor = WaveBackOffice.Properties.Settings.Default.AccountColorEmployee;
                    else if (row.Cells["Подписка"].Value.ToString() == "Нет")
                        row.DefaultCellStyle.BackColor = WaveBackOffice.Properties.Settings.Default.AccountColorSubscibe;
                }
                else
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btnAccountSearch_Click(object sender, EventArgs e)
        {
            TabAccountLoad();
        }

        private void btnAccountColor_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name.Contains("Active"))
                if (PickColor.ShowDialog() == DialogResult.OK)
                {
                    WaveBackOffice.Properties.Settings.Default.AccountColorActive = PickColor.Color;
                    btnAccountColorActive.BackColor = PickColor.Color;
                }
            if ((sender as Button).Name.Contains("Employee"))
                if (PickColor.ShowDialog() == DialogResult.OK)
                {
                    WaveBackOffice.Properties.Settings.Default.AccountColorEmployee = PickColor.Color;
                    btnAccountColorEmployee.BackColor = PickColor.Color;
                }
            if ((sender as Button).Name.Contains("Subscribe"))
                if (PickColor.ShowDialog() == DialogResult.OK)
                {
                    WaveBackOffice.Properties.Settings.Default.AccountColorSubscibe = PickColor.Color;
                    btnAccountColorSubscribe.BackColor = PickColor.Color;
                }
            TabAccountApplyStyle();
        }

        private void btnAccountColorReset_Click(object sender, EventArgs e)
        {
            WaveBackOffice.Properties.Settings.Default.AccountColorActive = Color.Red;
            WaveBackOffice.Properties.Settings.Default.AccountColorEmployee = Color.Pink;
            WaveBackOffice.Properties.Settings.Default.AccountColorSubscibe = Color.Aqua;
            btnAccountColorActive.BackColor = WaveBackOffice.Properties.Settings.Default.AccountColorActive;
            btnAccountColorEmployee.BackColor = WaveBackOffice.Properties.Settings.Default.AccountColorEmployee;
            btnAccountColorSubscribe.BackColor = WaveBackOffice.Properties.Settings.Default.AccountColorSubscibe;
            TabAccountApplyStyle();
        }

        private void cbAccountLights_CheckedChanged(object sender, EventArgs e)
        {
            WaveBackOffice.Properties.Settings.Default.cbAccountLigts = cbAccountLights.Checked;
            TabAccountApplyStyle();
        }

        private void dgwAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvAccounts.Rows[e.RowIndex].Cells["ID"].Value.ToString() != "")
                new frmDirectoryClientsDetails(int.Parse(dgvAccounts.Rows[e.RowIndex].Cells["ID"].Value.ToString())).ShowDialog();
        }

        private void dgwAccounts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                slblPosition.Text = "Строка: " + (dgvAccounts.SelectedCells[0].RowIndex + 1);
            }
            catch
            {
                slblPosition.Text = "Строка: 0";
            }
        }

        private void AddCells()
        {
            if (dgvAccounts.RowCount > 11)
                if (dgvAccounts.Rows[dgvAccounts.RowCount - 10].Displayed && dgvAccounts.RowCount < DT.Rows.Count && dgvAccounts.DataSource == null)
                {
                    if (dgvAccounts.RowCount < DT.Rows.Count && DT.Rows.Count - dgvAccounts.RowCount < 1000)
                        dgvAccounts.RowCount += DT.Rows.Count - dgvAccounts.RowCount;
                    else
                        dgvAccounts.RowCount += 1000;
                    TabAccountApplyStyle();
                }
        }

        void dgvAccounts_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                if (e.RowIndex > DT.Rows.Count - 1)
                    e.Value = DT.Rows[DT.Rows.Count - 1][e.ColumnIndex].ToString();
                else
                    e.Value = DT.Rows[e.RowIndex][e.ColumnIndex].ToString();
                slblRowCount.Text = "Загружено: " + dgvAccounts.RowCount + " из " + DT.Rows.Count + " записей";
            }
            catch { return; }
        }

        private void dgvAccounts_Scroll(object sender, ScrollEventArgs e)
        {
            AddCells();
        }

        private void cbSearchID_CheckedChanged(object sender, EventArgs e)
        {
            tbSearchID.Enabled = cbSearchID.Checked;
        }

        private void cbSearchName_CheckedChanged(object sender, EventArgs e)
        {
            tbSearchName.Enabled = cbSearchName.Checked;
        }

        private void cbSearchTel_CheckedChanged(object sender, EventArgs e)
        {
            tbSearchTel.Enabled = cbSearchTel.Checked;
        }

        private void cbSearchCardID_CheckedChanged(object sender, EventArgs e)
        {
            tbSearchCardID.Enabled = cbSearchCardID.Checked;
        }

        private void cbSearchCity_CheckedChanged(object sender, EventArgs e)
        {
            tbSearchCity.Enabled = cbSearchCity.Checked;
        }

        private void btnSearchReject_Click(object sender, EventArgs e)
        {
            tbSearchID.Text = "";
            cbSearchID.Checked = false;
            tbSearchName.Text = "";
            cbSearchName.Checked = false;
            tbSearchTel.Text = "";
            cbSearchTel.Checked = false;
            tbSearchCity.Text = "";
            cbSearchCity.Checked = false;
            tbSearchCardID.Text = "";
            cbSearchCardID.Checked = false;
            cbSearchVip.Checked = false;
            cbSearchEmployee.Checked = false;
            cbSearchActive.Checked = false;
            cbSearchSubscribe.Checked = false;

            cbSearchSubscribe.Checked = false;
            cbSearchActive.Checked = false;
            cbSearchEmployee.Checked = false;
            cbSearchVip.Checked = false;
            tbSearchSubscribe.SelectedIndex = 0;
            tbSearchActive.SelectedIndex = 0;
            tbSearchEmployee.SelectedIndex = 0;
            tbSearchVip.SelectedIndex = 0;

            TabAccountLoad();
        }

        private void cbSearchSubscribe_CheckedChanged(object sender, EventArgs e)
        {
            tbSearchSubscribe.Enabled = cbSearchSubscribe.Checked;
        }

        private void cbSearchActive_CheckedChanged(object sender, EventArgs e)
        {
            tbSearchActive.Enabled = cbSearchActive.Checked;
        }

        private void cbSearchEmployee_CheckedChanged(object sender, EventArgs e)
        {
            tbSearchEmployee.Enabled = cbSearchEmployee.Checked;
        }

        private void cbSearchVip_CheckedChanged(object sender, EventArgs e)
        {
            tbSearchVip.Enabled = cbSearchVip.Checked;
        }
    }
}
