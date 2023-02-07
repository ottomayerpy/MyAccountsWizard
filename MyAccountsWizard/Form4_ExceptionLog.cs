using DependenciesLibrary;
using MyAccountsWizard.Properties;
using System.Windows.Forms;

namespace MyAccountsWizard
{
    public partial class Form4_ExceptionLog : Form
    {
        public Form4_ExceptionLog()
        {
            InitializeComponent();
            Icon = GetImage.GetI("icon_programm");
            richTextBox.Text = Settings.Default.ExceptionLog;
        }

        private void ToolItemClear_Click(object sender, System.EventArgs e)
        {
            richTextBox.Text = Settings.Default.ExceptionLog = null;
        }
    }
}