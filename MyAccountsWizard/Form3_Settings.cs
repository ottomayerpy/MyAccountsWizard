using System;
using System.IO;
using System.Windows.Forms;
using MyAccountsWizard.Properties;
using DependenciesLibrary;

namespace MyAccountsWizard
{
    public partial class Form3_Settings : Form
    {
        bool[] DataGridRefresh = new bool[4];

        public Form3_Settings()
        {
            InitializeComponent();
            Icon = GetImage.GetI("icon_programm");
            ButtonSetPath.Image = GetImage.Get("Open_Folder");
            CheckBoxProtSite.Checked = Settings.Default.CBProtSite;
            CheckBoxProtDesc.Checked = Settings.Default.CBProtDesc;
            CheckBoxProtLogin.Checked = Settings.Default.CBProtLogin;
            CheckBoxProtPass.Checked = Settings.Default.CBProtPass;
            CheckBoxProtPassword.Checked = Settings.Default.CBNewPass;
            ComboBoxLoadSortTable.Text = Settings.Default.SortTable;
            ComboBoxLoadSortDirection.Text = Settings.Default.SortDirection;
            TxtPathAutoLoad.Text = Settings.Default.LoadPath;

            DataGridRefresh[0] = Settings.Default.CBProtSite;
            DataGridRefresh[1] = Settings.Default.CBProtDesc;
            DataGridRefresh[2] = Settings.Default.CBProtLogin;
            DataGridRefresh[3] = Settings.Default.CBProtPass;

            try
            {
                GroupBoxChangePassword.Enabled = true;

                // Проверка на зашифрованность файла
                bool a = false, b = false, c = false, d = false, e = false;

                foreach (string line in File.ReadLines(Settings.Default.LoadFile))
                {
                    if (line.Contains("<NewDataSet>"))
                        a = true;
                    if (line.Contains("<account>"))
                        b = true;
                    if (line.Contains("<description>"))
                        c = true;
                    if (line.Contains("<login>"))
                        d = true;
                    if (line.Contains("<password>"))
                        e = true;
                }

                if (!a && !b && !c && !d && !e)
                {
                    ButtonChangePassword.Text = "Изменить";
                }
                else
                    ButtonChangePassword.Text = "Создать";
            }
            catch
            {
                GroupBoxChangePassword.Enabled = false;
            }

            if (ButtonChangePassword.Text == "Создать")
                ButtonReset.Enabled = false;
        }

        private void ButtonChangePass_Click(object sender, EventArgs e)
        { // Кнопка - Создать/Изменить пароль
            CheckBoxProtSite.Focus();
            try
            {
                if (TxtPassword.Text != "")
                {
                    if (ButtonChangePassword.Text == "Создать")
                    {
                        string text = Encryption.EncryptStringAES(File.ReadAllText(Settings.Default.LoadFile), TxtPassword.Text);
                        Settings.Default.Password = TxtPassword.Text;
                        File.WriteAllText(Settings.Default.LoadFile, text);
                        ButtonChangePassword.Text = "Изменить";
                        ButtonReset.Enabled = true;
                        TxtPassword.Text = null;
                        CustomMessageBox.Show("Файл зашифрован, пароль установлен", "Выполнено", CustomMessageBox.eDialogButtons.OK, GetImage.Get("Success"), "None");
                    }
                    else
                    {
                        string text1 = Encryption.DecryptStringAES(File.ReadAllText(Settings.Default.LoadFile), Settings.Default.Password);
                        File.WriteAllText(Settings.Default.LoadFile, text1);
                        Settings.Default.Password = TxtPassword.Text;
                        string text = Encryption.EncryptStringAES(File.ReadAllText(Settings.Default.LoadFile), TxtPassword.Text);
                        File.WriteAllText(Settings.Default.LoadFile, text);
                        TxtPassword.Text = null;
                        CustomMessageBox.Show("Пароль изменен", "Выполнено", CustomMessageBox.eDialogButtons.OK, GetImage.Get("Success"), "None");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ButtonChangePassword.Text == "Создать")
                    Settings.Default.ExceptionLog += "     " + DateTime.Now.ToString() + "\n     Неудачная попытка создать пароль: \n" + ex.ToString() + "\n\n\n\n";
                else
                {
                    Settings.Default.ExceptionLog += "     " + DateTime.Now.ToString() + "\n     Неудачная попытка изменить пароль: \n" + ex.ToString() + "\n\n\n\n";
                    CustomMessageBox.Show("Смотрите подробности в ExceptionLog \n\n   Программа будет перезапущена...", "Критическая ошибка", CustomMessageBox.eDialogButtons.OK, GetImage.Get("Restart"), "Error");
                    Application.Restart();
                }
            }
        }

        private void CheckBoxNewPass_CheckedChanged(object sender, EventArgs e)
        { // Вкл/Выкл использования точек вместо символов
            if (CheckBoxProtPassword.Checked)
            {
                TxtPassword.UseSystemPasswordChar = true;
                Settings.Default.CBNewPass = true;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = false;
                Settings.Default.CBNewPass = false;
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        { // Сбросить пароль
            CheckBoxProtSite.Focus();

            try
            {
                TxtPassword.Text = null;
                string text = Encryption.DecryptStringAES(File.ReadAllText(Settings.Default.LoadFile), Settings.Default.Password);
                File.WriteAllText(Settings.Default.LoadFile, text);
                ButtonChangePassword.Text = "Создать";
                ButtonReset.Enabled = false;
                CustomMessageBox.Show("Пароль сброшен", "Выполнено", CustomMessageBox.eDialogButtons.OK, GetImage.Get("Success"), "None");
            }
            catch (Exception ex)
            {
                Settings.Default.ExceptionLog += "     " + DateTime.Now.ToString() + "\n     Неудачная попытка сбросить пароль: \n" + ex.ToString() + "\n\n\n\n";
                CustomMessageBox.Show("Смотрите подробности в ExceptionLog \n\n   Программа будет перезапущена...", "Критическая ошибка", CustomMessageBox.eDialogButtons.OK, GetImage.Get("Restart"), "Error");
                Application.Restart();
            }
        }

        private void ComboBoxSortTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.SortTable = ComboBoxLoadSortTable.Text;

            if (ComboBoxLoadSortTable.Text == "Не выбрано")
            {
                ComboBoxLoadSortDirection.Enabled = false;
                ComboBoxLoadSortDirection.Text = null;
            }
            else
            {
                ComboBoxLoadSortDirection.Enabled = true;
                ComboBoxLoadSortDirection.Text = "По возрастанию";
            }
        }

        private void ComboBoxSortDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.SortDirection = ComboBoxLoadSortDirection.Text;
        }

        private void CheckBoxProtSite_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxProtSite.Checked)
                Settings.Default.CBProtSite = true;
            else
                Settings.Default.CBProtSite = false;
        }

        private void CheckBoxProtDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxProtDesc.Checked)
                Settings.Default.CBProtDesc = true;
            else
                Settings.Default.CBProtDesc = false;
        }

        private void CheckBoxProtLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxProtLogin.Checked)
                Settings.Default.CBProtLogin = true;
            else
                Settings.Default.CBProtLogin = false;
        }

        private void CheckBoxProtPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxProtPass.Checked)
                Settings.Default.CBProtPass = true;
            else
                Settings.Default.CBProtPass = false;
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            CheckBoxProtSite.Focus();
            if (CustomMessageBox.Show("Сейчас будет открыт сайт со справкой\nо программе в вашем браузере по умолчанию", "Справка", CustomMessageBox.eDialogButtons.ContinueCancel, GetImage.Get("dialogInformation"), "None") == DialogResult.OK)
                System.Diagnostics.Process.Start("https://spcs.me/diary/diary/read/user/StalkeRj/Instrukcija_po_ispolzovaniju_MyAccountsWizard-2059673477/");
        }

        private void ButtonExceptionLog_Click(object sender, EventArgs e)
        {
            CheckBoxProtSite.Focus();
            new Form4_ExceptionLog().ShowDialog();
        }

        private void Form3_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool[] DataGridRefresh1 = new bool[4];
            DataGridRefresh1[0] = Settings.Default.CBProtSite;
            DataGridRefresh1[1] = Settings.Default.CBProtDesc;
            DataGridRefresh1[2] = Settings.Default.CBProtLogin;
            DataGridRefresh1[3] = Settings.Default.CBProtPass;

            string a = null;
            string b = null;

            foreach (bool q in DataGridRefresh)
                a += q.ToString();
            foreach (bool w in DataGridRefresh1)
                b += w.ToString();

            if (a != b)
            {
                Form1_Main frm1 = (Form1_Main)Application.OpenForms[0];
                frm1.DataGridRefresh();
            }

            if ((TxtPathAutoLoad.Text == "" || TxtPathAutoLoad.Text == null) && (Settings.Default.LoadPath != null || Settings.Default.LoadPath != ""))
                Settings.Default.LoadPath = null;
        }

        private void ButtonSetPath_Click(object sender, EventArgs e)
        {
            CheckBoxProtSite.Focus();
            OpenFileDialog load = new OpenFileDialog();

            if (load.ShowDialog() == DialogResult.OK)
                TxtPathAutoLoad.Text = load.FileName;
            Settings.Default.LoadPath = TxtPathAutoLoad.Text;
        }
    }
}