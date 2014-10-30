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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            tbDBAddress.Text = WaveBackOffice.Properties.Settings.Default.DBAddress;
            tbDBPort.Text = WaveBackOffice.Properties.Settings.Default.DBPort;
            tbDBLogin.Text = WaveBackOffice.Properties.Settings.Default.DBLogin;
            tbDBPwd.Text = WaveBackOffice.Properties.Settings.Default.DBPwd;
            tbDBName.Text = WaveBackOffice.Properties.Settings.Default.DBName;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            WaveBackOffice.Properties.Settings.Default.DBAddress = tbDBAddress.Text;
            WaveBackOffice.Properties.Settings.Default.DBPort = tbDBPort.Text;
            WaveBackOffice.Properties.Settings.Default.DBLogin = tbDBLogin.Text;
            WaveBackOffice.Properties.Settings.Default.DBPwd = tbDBPwd.Text;
            WaveBackOffice.Properties.Settings.Default.DBName = tbDBName.Text;
            WaveBackOffice.Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            WaveBackOffice.Properties.Settings.Default.DBAddress = tbDBAddress.Text;
            WaveBackOffice.Properties.Settings.Default.DBPort = tbDBPort.Text;
            WaveBackOffice.Properties.Settings.Default.DBLogin = tbDBLogin.Text;
            WaveBackOffice.Properties.Settings.Default.DBPwd = tbDBPwd.Text;
            WaveBackOffice.Properties.Settings.Default.DBName = tbDBName.Text;
            WaveBackOffice.Properties.Settings.Default.Save();
            DB db = DB.Instace();
            if (!db.testConnection())
                MessageBox.Show("Не удалось установить подключение!", "Проверка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Соединение успешно!", "Проверка соединения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            if (tbDBAddress.Text != "" && tbDBLogin.Text != "" && tbDBName.Text != "" && tbDBPort.Text != "" && tbDBPwd.Text != "" && !tbDBName.Text.Contains(" "))
            {
                MessageBox.Show("На данный момент приложение, как и база данных, находиться в стадии активной разработки. Взможны ошибки при работе с созданной БД т.к. ее версия может отличаться от текущей рабочей...", "Создание базы данных", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string msg = DB.CreateNewDB(tbDBAddress.Text, tbDBLogin.Text, tbDBPwd.Text, tbDBPort.Text, tbDBName.Text);
                if (msg == "")
                {
                    MessageBox.Show("База данных ''" + tbDBName.Text + "'' успешно создана!\n\nДля первого входа и настройки приложения используйте\n логин: ''admin'' и пароль: ''0000''", "Создание базы данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WaveBackOffice.Properties.Settings.Default.DBAddress = tbDBAddress.Text;
                    WaveBackOffice.Properties.Settings.Default.DBPort = tbDBPort.Text;
                    WaveBackOffice.Properties.Settings.Default.DBLogin = tbDBLogin.Text;
                    WaveBackOffice.Properties.Settings.Default.DBPwd = tbDBPwd.Text;
                    WaveBackOffice.Properties.Settings.Default.DBName = tbDBName.Text;
                    WaveBackOffice.Properties.Settings.Default.Save();
                }
                else
                    MessageBox.Show("Не удалось создать бузу данных ''" + tbDBName.Text + "''. \nПроверьте настройки соединения!", "Ошибка создание базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Введите параметры соединения и новой базы данных!\n\nВ параметрах не должно быть знаков пробела и некоторых спецсимволов запрещенных в MySQL.\nПодробнее читайте в документации к MySQL Server", "Создание базы данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
