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
    public partial class frmProtokolPalitra : Form
    {
        DB db = DB.Instace();
        string Query = "SELECT protokol_operations.id AS `ID`, protokol_operations.`name` AS `Операция`, protokol_operations_colors.color AS `Цвет`, protokol_operations_colors.text_color AS `Цвет текста` " +
        "FROM protokol_operations, protokol_operations_colors " +
        "WHERE protokol_operations.id = protokol_operations_colors.op_id";
        public frmProtokolPalitra()
        {
            InitializeComponent();
        }

        private void frmProtokolPalitra_Shown(object sender, EventArgs e)
        {
            dgvColors.DoubleBuffered(true);
            LoadData();
        }

        public void LoadData()
        {
            DataTable DTColors = db.getDT(Query);
            dgvColors.DataSource = DTColors;
            foreach (DataGridViewColumn column in dgvColors.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            ApplyStyle();
        }

        public void ApplyStyle()
        {
            DataTable DTColors = new DataTable();
            DTColors = db.getDT(Query);
            foreach (DataGridViewRow row in dgvColors.Rows)
            {
                foreach (DataRow r in DTColors.Rows)
                {
                    if (r.ItemArray[1].ToString() == row.Cells["Операция"].Value.ToString())
                    {

                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(r.ItemArray[2].ToString());
                        row.DefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(r.ItemArray[3].ToString());
                    }
                }
            }
        }

        private void dgwColors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string q = "";
            if (e.RowIndex == -1 || e.ColumnIndex < 2)
                return;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                switch (e.ColumnIndex)
                {
                    case 2:
                        q = "UPDATE protokol_operations_colors SET `color` = '" + System.Drawing.ColorTranslator.ToHtml(colorDlg.Color) + "' WHERE `op_id` = " +
                            dgvColors.Rows[e.RowIndex].Cells[0].Value.ToString();
                        break;
                    case 3:
                        q = "UPDATE protokol_operations_colors SET `text_color` = '" + System.Drawing.ColorTranslator.ToHtml(colorDlg.Color) + "' WHERE `op_id` = " +
                            dgvColors.Rows[e.RowIndex].Cells[0].Value.ToString();
                        break;
                }
                db.Execute(q);
                LoadData();
            }
        }
    }
}
