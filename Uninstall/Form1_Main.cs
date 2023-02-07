using System;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Diagnostics;

namespace Uninstall
{
    public partial class Form1_Main : Form
    {
        RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\MyAccountsWizard");

        public Form1_Main()
        {
            InitializeComponent();

            if (key == null)
                ButtonYes.Enabled = false;
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            ButtonYes.Enabled = false;
            bool repit = true;

            while (repit)
            {
                repit = false; // Обработать все файлы
                foreach (string fileName in Directory.GetFiles((string)key.GetValue("InstallLocation") + "\\"))
                {
                    try
                    {
                        using (FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
                        {
                            fs.Close();
                        }
                    }
                    catch (FileNotFoundException) { }
                    catch (IOException)
                    {
                        repit = true;
                        if (MessageBox.Show("Закройте все программы которые могут использовать MyAccountsWizard и его компоненты, за тем нажмите \"ОК\".", "Ошибка доступа", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            ButtonYes.Enabled = true;
                            return;
                        }
                    }
                    catch (Exception) { }
                }
            }

            if (File.Exists((string)key.GetValue("InstallLocation") + "\\MyAccountsWizard.exe"))
                File.Delete((string)key.GetValue("InstallLocation") + "\\MyAccountsWizard.exe");

            if (File.Exists((string)key.GetValue("InstallLocation") + "\\DependenciesLibrary.dll"))
                File.Delete((string)key.GetValue("InstallLocation") + "\\DependenciesLibrary.dll");

            if (Directory.Exists((string)key.GetValue("InstallLocation")))
                Directory.Delete((string)key.GetValue("InstallLocation"));

            if (Registry.ClassesRoot.OpenSubKey(".tabl") != null)
                Registry.ClassesRoot.DeleteSubKeyTree(".tabl");

            if (Registry.ClassesRoot.OpenSubKey("tabl_file") != null)
                Registry.ClassesRoot.DeleteSubKeyTree("tabl_file");

            if (Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\MyAccountsWizard") != null)
                Registry.LocalMachine.DeleteSubKeyTree(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\MyAccountsWizard");

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MyAccountsWizard.lnk"))
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MyAccountsWizard.lnk");

            Close();
        }

        private void Form1_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                Arguments = "/C rd /s /q \"" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MyAccountsWizard\" + "\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe"
            });
        }
    }
}