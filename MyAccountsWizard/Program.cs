using System;
using System.Windows.Forms;

namespace MyAccountsWizard
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2_Load());
        }
    }
}