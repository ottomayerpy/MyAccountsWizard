using System;
using System.IO;
using Microsoft.Win32;
using Install.Properties;
using System.Windows.Forms;

namespace Install
{
    public partial class Form1_Main : Form
    {
        public Form1_Main()
        {
            InitializeComponent();

            СheckBoxDesktopLink.Checked = true;
            TxtBox.Text = @"C:\Program Files (x86)\MyAccountsWizard";

            Icon = Resources.icon_install;
            pictureBox.Image = Resources.icon_programm;
            ButtonSelect.Image = Resources.Open_Folder;
        }

        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            ButtonInstall.Enabled = false;

            // Создаем папки и копируем файлы
            Directory.CreateDirectory(TxtBox.Text); // Создаем папку для программы
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MyAccountsWizard"); // Создаем папку куда поместим деинсталлятор и иконку для файлов
            File.WriteAllBytes(Environment.ExpandEnvironmentVariables(TxtBox.Text) + @"\MyAccountsWizard.exe", Resources.MyAccountsWizard); // Копируем программу
            File.WriteAllBytes(Environment.ExpandEnvironmentVariables(TxtBox.Text) + @"\DependenciesLibrary.dll", Resources.DependenciesLibrary); // Копируем dll
            File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MyAccountsWizard" + @"\Uninstall.exe", Resources.Uninstall); // Копируем деинсталлятор
            File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MyAccountsWizard" + @"\icone_file.ico", Resources.icone_file); // Копируем иконку для файлов .tabl

            // Создаем ключи в реестре для нового типа файлов .tabl
            RegistryKey classes_key = Registry.CurrentUser.OpenSubKey(@"Software\Classes", true);
            RegistryKey ext_key = classes_key.CreateSubKey(".tabl", RegistryKeyPermissionCheck.ReadWriteSubTree);
            ext_key.SetValue(null, "tabl_file");
            RegistryKey file_key = classes_key.CreateSubKey(ext_key.GetValue(null).ToString(), RegistryKeyPermissionCheck.ReadWriteSubTree);
            file_key.SetValue(null, "Table file MyAccountsWizard");
            RegistryKey icon_key = file_key.CreateSubKey("DefaultIcon", RegistryKeyPermissionCheck.ReadWriteSubTree);
            icon_key.SetValue(null, string.Format("\"{0}\",0", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MyAccountsWizard" + @"\icone_file.ico"));
            RegistryKey run_key = file_key.CreateSubKey(@"Shell\Open\Command", RegistryKeyPermissionCheck.ReadWriteSubTree);
            run_key.SetValue(null, string.Format("{0} %1", Environment.CurrentDirectory + "\\Accounts.exe"));

            // Создаем ключи в реестре для меню "Программы и компоненты" Windows
            RegistryKey IsRegKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\" + "MyAccountsWizard");
            IsRegKey.SetValue("DisplayIcon", TxtBox.Text + @"\MyAccountsWizard.exe");
            IsRegKey.SetValue("DisplayName", "MyAccountsWizard");
            IsRegKey.SetValue("DisplayVersion", "1.0.0.0");
            IsRegKey.SetValue("InstallDate", string.Format("{0:yyyyMMdd}", DateTime.Now));
            IsRegKey.SetValue("InstallLocation", TxtBox.Text);
            IsRegKey.SetValue("Publisher", "Никита Колтман");
            IsRegKey.SetValue("UninstallString", "\"" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MyAccountsWizard\Uninstall.exe" + "\"");

            // Создаем иконку на рабочем столе
            if (СheckBoxDesktopLink.Checked)
                ShortCut.Create(TxtBox.Text + @"\MyAccountsWizard.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MyAccountsWizard.lnk", "", "");

            Close();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            Label1.Focus();

            FolderBrowserDialog load = new FolderBrowserDialog();

            if (load.ShowDialog() == DialogResult.OK)
                TxtBox.Text = load.SelectedPath + @"\MyAccountsWizard";
        }
    }
}