using System;
using System.IO;
using System.Windows.Forms;
using MyAccountsWizard.Properties;
using DependenciesLibrary;

namespace MyAccountsWizard
{
    public partial class Form2_Load : Form
    {
        bool EnableLoad = true; // Регулирует изменение Settings.Default.EnableLoad

        public Form2_Load()
        {
            InitializeComponent();
            Icon = GetImage.GetI("icon_programm");
            CheckBoxPass.Checked = Settings.Default.CBPassLoad;
        }

        private void OK()
        {
            try
            {
                Encryption.DecryptStringAES(File.ReadAllText(Settings.Default.LoadFile), TxtPass.Text);
                Settings.Default.Password = TxtPass.Text;
                EnableLoad = false;
                Hide();
            }
            catch
            {
                CustomMessageBox.Show("Введен неверный пароль, повторите попытку", "Ошибка", CustomMessageBox.eDialogButtons.OK, GetImage.Get("dialogWarning"), "Info");
                TxtPass.Text = null;
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            CheckBoxPass.Focus();
            OK();
        }

        private void CheckBoxPass_CheckedChanged(object sender, EventArgs e) // Вкл/Выкл использования точек вместо символов
        {
            if (CheckBoxPass.Checked)
            {
                TxtPass.isPassword = true;
                Settings.Default.CBPassLoad = true;
            }
            else
            {
                TxtPass.isPassword = false;
                Settings.Default.CBPassLoad = false;
            }
        }

        private void Form2_Load_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OK();
        }

        private void Form2_Load_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnableLoad)
                Settings.Default.EnableLoad = true;
        }

        private void TxtPass_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}