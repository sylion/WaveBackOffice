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
    public partial class frmAppMarketing : DockContent
    {
        DB db = DB.Instace();
        string Query;
        public frmAppMarketing()
        {
            InitializeComponent();
            dgvValues.DoubleBuffered(true);
        }

        private void btnValueRFM_Click(object sender, EventArgs e)
        {
            Query = "SELECT `directory_account_cards`.`account_id` AS `Номер счета`, " +
            "max(FROM_UNIXTIME(`check_headers`.`time_check`,  '%d.%m.%Y')) AS `Дата последней покупки`, " +
            "count(`check_headers`.`total`) AS `Количество чеков`, " +
            "sum(`check_headers`.`total`) AS `Сумма` " +
            "FROM `check_headers`, `directory_account`, `directory_account_cards` " +
            "where `check_headers`.`time_check` > " + UnixTime.ToUnixTimestamp(DateTime.Parse(date1.Value.ToUniversalTime().ToShortDateString() + " 00:00:00")) +
            " and `check_headers`.`time_check` < " + UnixTime.ToUnixTimestamp(DateTime.Parse(date2.Value.ToUniversalTime().ToShortDateString() + " 23:59:59")) +
            " and `check_headers`.`discard_code` = `directory_account_cards`.`card_id` " +
            "and `directory_account_cards`.`account_id` = `directory_account`.`account_id` " +
            "group by `directory_account_cards`.`account_id` ORDER BY `Сумма`";
            DataTable DT = db.getDT(Query);
            if (DT == null)
            {
                MessageBox.Show(db.GetLastError());
                this.Close();
                return;
            }
            DT.Columns.Add("Perc");
            DT.Columns.Add("R");
            DT.Columns.Add("F");
            DT.Columns.Add("M");
            int days = (date2.Value - date1.Value).Days;
            double summ = 0, tmpperc = 0, minsum = 0;

            foreach (DataRow row in DT.Rows)
                summ += double.Parse(row.ItemArray[3].ToString());

            foreach (DataRow row in DT.Rows)
                row[4] = ((double.Parse(row.ItemArray[3].ToString()) * 100) / summ).ToString();

            foreach (DataRow row in DT.Rows)
            {
                tmpperc += double.Parse(row.ItemArray[4].ToString());
                if (tmpperc >= 20)
                {
                    minsum = double.Parse(row.ItemArray[3].ToString());
                    break;
                }
            }

            DT.Columns.Remove("Perc");

            foreach (DataRow row in DT.Rows)
            {
                //R
                if ((date2.Value - DateTime.Parse(row.ItemArray[1].ToString())).Days <= 3)
                    row["R"] = "5";
                else if ((date2.Value - DateTime.Parse(row.ItemArray[1].ToString())).Days <= 7)
                    row["R"] = "4";
                else if ((date2.Value - DateTime.Parse(row.ItemArray[1].ToString())).Days <= 14)
                    row["R"] = "3";
                else
                    row["R"] = "2";
                //F
                if ((double.Parse(row.ItemArray[2].ToString()) / days) >= 1)
                    row["F"] = "6";
                else if ((double.Parse(row.ItemArray[2].ToString()) / days) >= 0.5)
                    row["F"] = "5";
                else if ((double.Parse(row.ItemArray[2].ToString()) / days) >= 0.25)
                    row["F"] = "4";
                else if ((double.Parse(row.ItemArray[2].ToString()) / days) >= 0.125)
                    row["F"] = "3";
                else
                    row["F"] = "2";
                //M
                if (double.Parse(row.ItemArray[3].ToString()) >= (minsum * 7))
                    row["M"] = "6";
                else if (double.Parse(row.ItemArray[3].ToString()) >= (minsum * 3.5))
                    row["M"] = "5";
                else if (double.Parse(row.ItemArray[3].ToString()) >= (minsum * 2))
                    row["M"] = "4";
                else if (double.Parse(row.ItemArray[3].ToString()) >= minsum)
                    row["M"] = "3";
                else
                    row["M"] = "2";
            }
            dgvValues.DataSource = DT;
            ApplyStyle();
        }
        public void ApplyStyle()
        {
            for (int i = 0; i < dgvValues.Rows.Count; i++)
            {
                switch (int.Parse(dgvValues.Rows[i].Cells["M"].Value.ToString()))
                {
                    case 6:
                        dgvValues.Rows[i].Cells["M"].Style.BackColor = System.Drawing.Color.Red;
                        break;
                    case 5:
                        dgvValues.Rows[i].Cells["M"].Style.BackColor = System.Drawing.Color.LightBlue;
                        break;
                    case 4:
                        dgvValues.Rows[i].Cells["M"].Style.BackColor = System.Drawing.Color.LightYellow;
                        break;
                    case 3:
                        dgvValues.Rows[i].Cells["M"].Style.BackColor = System.Drawing.Color.LightGray;
                        break;
                }
                switch (int.Parse(dgvValues.Rows[i].Cells["F"].Value.ToString()))
                {
                    case 6:
                        dgvValues.Rows[i].Cells["F"].Style.BackColor = System.Drawing.Color.Red;
                        break;
                    case 5:
                        dgvValues.Rows[i].Cells["F"].Style.BackColor = System.Drawing.Color.LightBlue;
                        break;
                    case 4:
                        dgvValues.Rows[i].Cells["F"].Style.BackColor = System.Drawing.Color.LightYellow;
                        break;
                    case 3:
                        dgvValues.Rows[i].Cells["F"].Style.BackColor = System.Drawing.Color.LightGray;
                        break;
                }
                switch (int.Parse(dgvValues.Rows[i].Cells["R"].Value.ToString()))
                {
                    case 6:
                        dgvValues.Rows[i].Cells["R"].Style.BackColor = System.Drawing.Color.Red;
                        break;
                    case 5:
                        dgvValues.Rows[i].Cells["R"].Style.BackColor = System.Drawing.Color.LightBlue;
                        break;
                    case 4:
                        dgvValues.Rows[i].Cells["R"].Style.BackColor = System.Drawing.Color.LightYellow;
                        break;
                    case 3:
                        dgvValues.Rows[i].Cells["R"].Style.BackColor = System.Drawing.Color.LightGray;
                        break;
                }
            }
        }

        private void dgvValues_Sorted(object sender, EventArgs e)
        {
            ApplyStyle();
        }
    }
}
