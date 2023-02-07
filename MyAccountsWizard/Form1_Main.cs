using System;
using System.IO;
using System.Data;
using System.Drawing;
using DependenciesLibrary;
using System.Windows.Forms;
using System.ComponentModel;
using MyAccountsWizard.Properties;

namespace MyAccountsWizard
{
    public partial class Form1_Main : Form
    {
        bool ToolEdit = false; // Проверка включения панели редактрования
        bool EditTable = false; // Проверка изменений в таблице
        bool FastOpenFile = false; // Быстрое открытие файла не через программу
        bool FastSaveFile = false; // Быстрое сохранение файла
        string globalargs; // Имя открытого файла не через программу
        bool globlargs = false; // Закрыть программу если была закрыта форма авторизации
        
        public Form1_Main(string[] args)
        {
            InitializeComponent();

            Icon = GetImage.GetI("icon_programm");
            ToolItemFile.Image = GetImage.Get("File");
            ToolItemEditing.Image = GetImage.Get("Edit");
            ToolItemSettings.Image = GetImage.Get("Settings");
            ToolItemOpen.Image = GetImage.Get("Open");
            ToolItemСlear.Image = GetImage.Get("Clear");
            ToolItemFastSave.Image = GetImage.Get("Save");
            ToolItemSave.Image = GetImage.Get("SaveAs");
            ButtonAdd.Image = GetImage.Get("Add");
            ButtonEditing.Image = GetImage.Get("PanelEdit");
            ButtonDelete.Image = GetImage.Get("Delete");


            foreach (string a in args)
                globalargs = a;

            if (globalargs == null)
                globalargs = Settings.Default.LoadPath;

            if (globalargs != null && globalargs != "")
            {
                globlargs = true;
                FastOpenFile = true;
                OpenFileVoid();
                FastOpenFile = false;
            }
        }

        private void Form1_Main_Load(object sender, EventArgs e)
        {
            switch (Settings.Default.SortTable)
            {
                case "Сайт":
                    if (Settings.Default.SortDirection == "По возрастанию")
                        DataGridView.Sort(DataGridView.Columns[0], ListSortDirection.Ascending);
                    else
                        DataGridView.Sort(DataGridView.Columns[0], ListSortDirection.Descending);
                    break;
                case "Описание":
                    if (Settings.Default.SortDirection == "По возрастанию")
                        DataGridView.Sort(DataGridView.Columns[1], ListSortDirection.Ascending);
                    else
                        DataGridView.Sort(DataGridView.Columns[1], ListSortDirection.Descending);
                    break;
                case "Логин":
                    if (Settings.Default.SortDirection == "По возрастанию")
                        DataGridView.Sort(DataGridView.Columns[2], ListSortDirection.Ascending);
                    else
                        DataGridView.Sort(DataGridView.Columns[2], ListSortDirection.Descending);
                    break;
                case "Пароль":
                    if (Settings.Default.SortDirection == "По возрастанию")
                        DataGridView.Sort(DataGridView.Columns[3], ListSortDirection.Ascending);
                    else
                        DataGridView.Sort(DataGridView.Columns[3], ListSortDirection.Descending);
                    break;
                default:
                    break;
            }
        }

        public void DataGridRefresh()
        {
            DataGridView.Refresh();
        }

        public string Rand()
        {
            Random rand = new Random();
            char[,] a = new char[10, 10];
            string TempName = null;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[i, j] = (char)rand.Next(0x61, 0x7A);
                    TempName += a[i, j];
                }
            }
            return TempName + ".tabl";
        }

        private byte MessageSave()
        { // 0 - None     1 - Yes     2 - No     3 - Cancel
            if (EditTable)
            {
                switch (CustomMessageBox.Show("Хотите сохранить изменения перед выходом?", "Обнаружены изменения в таблице", CustomMessageBox.eDialogButtons.YesNoCancel, GetImage.Get("dialogQuestion"), "None"))
                {
                    case DialogResult.Yes:
                        if (TxtFile.Text == "")
                            SaveFileVoid();
                        else
                        {
                            FastSaveFile = true;
                            SaveFileVoid();
                            FastSaveFile = false;
                        }
                        return 1;
                    case DialogResult.No:
                        return 2;
                    case DialogResult.Cancel:
                        return 3;
                    default:
                        return 0;
                }
            }
            else
                return 0;
        }

        private void OpenFileVoid()
        {
            try
            {
                string path = null;

                DataSet ds = new DataSet();
                bool CryptFileLoad = false; // true - Зашифрован; false - Не зашифрован

                if (!FastOpenFile)
                {
                    OpenFileDialog load = new OpenFileDialog
                    {
                        Filter = @"TABL (*.tabl)|*.tabl",
                        RestoreDirectory = true
                    };

                    if (load.ShowDialog() == DialogResult.OK)
                        ClearTabelVoid();
                    else
                        return;

                    Settings.Default.LoadFile = load.FileName;
                }
                else
                    Settings.Default.LoadFile = globalargs;

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
                    new Form2_Load().ShowDialog();
                    CryptFileLoad = true;
                }

                if (Settings.Default.EnableLoad)
                {
                    Settings.Default.EnableLoad = false;
                    Settings.Default.LoadFile = null;
                    TxtFile.Text = null;
                    if (globlargs)
                        Environment.Exit(0);
                    return;
                }

                TxtFile.Text = Settings.Default.LoadFile;

                if (CryptFileLoad)
                {
                    path = Path.GetTempPath() + Rand();
                    File.WriteAllText(path, Encryption.DecryptStringAES(File.ReadAllText(Settings.Default.LoadFile), Settings.Default.Password));
                    ds.ReadXml(path);
                }
                else
                    ds.ReadXml(Settings.Default.LoadFile);

                foreach (DataRow item in ds.Tables["account"].Rows)
                {
                    int n = DataGridView.Rows.Add();
                    DataGridView.Rows[n].Cells[0].Value = item["website"];
                    DataGridView.Rows[n].Cells[1].Value = item["description"];
                    DataGridView.Rows[n].Cells[2].Value = item["login"];
                    DataGridView.Rows[n].Cells[3].Value = item["password"];
                }

                if (CryptFileLoad)
                    File.Delete(path);

                EditTable = false;
            }
            catch (Exception ex)
            {
                Settings.Default.EnableLoad = false;
                Settings.Default.LoadFile = null;
                TxtFile.Text = null;

                if (ex.ToString().Contains("System.Xml.XmlException"))
                    CustomMessageBox.Show("Файл поврежден", "Ошибка", CustomMessageBox.eDialogButtons.OK, GetImage.Get("dialogError"), "Error");
                else
                {
                    Settings.Default.ExceptionLog += "     " + DateTime.Now.ToString() + "\n     Неудачная попытка открыть файл: \n" + ex.ToString() + "\n\n\n\n";
                    CustomMessageBox.Show("Смотрите подробности в ExceptionLog", "Критическая ошибка", CustomMessageBox.eDialogButtons.OK, GetImage.Get("dialogError"), "Error");
                }
            }
        }

        private void SaveFileVoid()
        {
            try
            {
                bool CryptFileLoad = false;
                string file = null;

                if (TxtFile.Text != "")
                {
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
                        CryptFileLoad = true;
                }

                DataSet ds = new DataSet();
                DataTable dt = new DataTable { TableName = "account" };
                dt.Columns.Add("website");
                dt.Columns.Add("description");
                dt.Columns.Add("login");
                dt.Columns.Add("password");
                ds.Tables.Add(dt);

                foreach (DataGridViewRow r in DataGridView.Rows)
                {
                    DataRow row = ds.Tables["account"].NewRow();
                    row["website"] = r.Cells[0].Value;
                    row["description"] = r.Cells[1].Value;
                    row["login"] = r.Cells[2].Value;
                    row["password"] = r.Cells[3].Value;
                    ds.Tables["account"].Rows.Add(row);
                }

                if (FastSaveFile)
                {
                    file = Settings.Default.LoadFile;
                    ds.WriteXml(Settings.Default.LoadFile);
                }

                if (!FastSaveFile)
                {
                    CryptFileLoad = false;
                    SaveFileDialog save = new SaveFileDialog
                    {
                        Filter = @"TABL (*.tabl)|*.tabl|XML (*.xml)|*.xml",
                        RestoreDirectory = true
                    };

                    if (save.ShowDialog() != DialogResult.OK)
                        return;

                    file = save.FileName;
                    ds.WriteXml(file);
                }

                if (CryptFileLoad)
                {
                    string text = Encryption.EncryptStringAES(File.ReadAllText(file), Settings.Default.Password);
                    File.WriteAllText(file, text);
                }

                EditTable = false;
                CustomMessageBox.Show("Файл успешно сохранен", "Выполнено", CustomMessageBox.eDialogButtons.OK, GetImage.Get("dialogSuccess"), "None");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Путь не может быть неопределенным") || ex.Message.Contains("Пустое имя пути не допускается"))
                    CustomMessageBox.Show("Путь не может быть пустым!\nИспользуйте функцию \"Сохранить как...\"", "Ошибка", CustomMessageBox.eDialogButtons.OK, GetImage.Get("dialogWarning"), "Info");
                else
                {
                    Settings.Default.ExceptionLog += "     " + DateTime.Now.ToString() + "\n     Неудачная попытка сохранить файл: \n" + ex.ToString() + "\n\n\n\n";
                    CustomMessageBox.Show("Смотрите подробности в ExceptionLog", "Критическая ошибка", CustomMessageBox.eDialogButtons.OK, GetImage.Get("dialogError"), "Error");
                }
            }
        }

        private void ClearTabelVoid()
        {
            if (DataGridView.Rows.Count > 0)
            {
                Settings.Default.LoadFile = null;
                TxtFile.Text = null;
                DataGridView.Rows.Clear();
                EditTable = false;
            }
        }

        private void ToolItemFastSave_Click(object sender, EventArgs e)
        {
            FastSaveFile = true;
            SaveFileVoid();
            FastSaveFile = false;
        }

        private void ToolItemClear_Click(object sender, EventArgs e)
        {
            if (MessageSave() != 3)
                ClearTabelVoid();
        }

        private void ToolItemEditing_Click(object sender, EventArgs e)
        {
            if (ToolEdit)
            {
                panel.Visible = false;
                ToolEdit = false;
            }
            else
            {
                panel.Visible = true;
                ToolEdit = true;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            DataGridView.Focus();

            if (TxtWebsite.ForeColor != Color.Gray && TxtDescription.ForeColor != Color.Gray && TxtLogin.ForeColor != Color.Gray && TxtPassword.ForeColor != Color.Gray)
            {
                int n = DataGridView.Rows.Add();
                DataGridView.Rows[n].Cells[0].Value = TxtWebsite.Text;
                DataGridView.Rows[n].Cells[1].Value = TxtDescription.Text;
                DataGridView.Rows[n].Cells[2].Value = TxtLogin.Text;
                DataGridView.Rows[n].Cells[3].Value = TxtPassword.Text;
                TxtWebsite.Text = TxtDescription.Text = TxtLogin.Text = TxtPassword.Text = null;
                TxtLeave();
                EditTable = true;
            }
            else
                CustomMessageBox.Show("Заполните все поля", "Обратите внимание", CustomMessageBox.eDialogButtons.OK, GetImage.Get("dialogInformation"), "None");
        }

        private void ButtonEditing_Click(object sender, EventArgs e)
        {
            DataGridView.Focus();

            if (DataGridView.SelectedRows.Count > 0)
            {
                int n = DataGridView.SelectedRows[0].Index;

                if (TxtWebsite.ForeColor != Color.Gray)
                    DataGridView.Rows[n].Cells[0].Value = TxtWebsite.Text;

                if (TxtDescription.ForeColor != Color.Gray)
                    DataGridView.Rows[n].Cells[1].Value = TxtDescription.Text;

                if (TxtLogin.ForeColor != Color.Gray)
                    DataGridView.Rows[n].Cells[2].Value = TxtLogin.Text;

                if (TxtPassword.ForeColor != Color.Gray)
                    DataGridView.Rows[n].Cells[3].Value = TxtPassword.Text;

                TxtWebsite.Text = TxtDescription.Text = TxtLogin.Text = TxtPassword.Text = null;
                TxtLeave();
                EditTable = true;
            }
            else
                CustomMessageBox.Show("Выберите строку для редактирования", "Обратите внимание", CustomMessageBox.eDialogButtons.OK, GetImage.Get("dialogInformation"), "None");
        }

        private void Delete()
        {
            DataGridView.Focus();

            if (DataGridView.SelectedRows.Count > 0)
            {
                DataGridView.Rows.RemoveAt(DataGridView.SelectedRows[0].Index);
                EditTable = true;
            }
            else
                CustomMessageBox.Show("Выберите строку для удаления", "Обратите внимание", CustomMessageBox.eDialogButtons.OK, GetImage.Get("dialogInformation"), "None");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ToolItemSettings_Click(object sender, EventArgs e)
        {
            new Form3_Settings().ShowDialog();
        }

        private void Form1_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageSave() == 3)
                e.Cancel = true;
            else
            {
                Settings.Default.LoadFile = null;
                Settings.Default.Password = null;
                Settings.Default.Save();
            }
        }

        private void TxtWebsite_Enter(object sender, EventArgs e)
        {
            TxtWebsite.ForeColor = Color.Black;
            TxtWebsite.Text = "";
            TxtWebsite.Enter -= TxtWebsite_Enter;
        }

        private void TxtDescription_Enter(object sender, EventArgs e)
        {
            TxtDescription.ForeColor = Color.Black;
            TxtDescription.Text = "";
            TxtDescription.Enter -= TxtDescription_Enter;
        }

        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            TxtLogin.ForeColor = Color.Black;
            TxtLogin.Text = "";
            TxtLogin.Enter -= TxtLogin_Enter;
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            TxtPassword.ForeColor = Color.Black;
            TxtPassword.Text = "";
            TxtPassword.Enter -= TxtPassword_Enter;
        }

        private void TxtLeave()
        {
            if (TxtWebsite.Text == "")
            {
                TxtWebsite.ForeColor = Color.Gray;
                TxtWebsite.Text = "Введите сайт";
                TxtWebsite.Enter += TxtWebsite_Enter;
            }

            if (TxtDescription.Text == "")
            {
                TxtDescription.ForeColor = Color.Gray;
                TxtDescription.Text = "Введите описание";
                TxtDescription.Enter += TxtDescription_Enter;
            }

            if (TxtLogin.Text == "")
            {
                TxtLogin.ForeColor = Color.Gray;
                TxtLogin.Text = "Введите логин";
                TxtLogin.Enter += TxtLogin_Enter;
            }

            if (TxtPassword.Text == "")
            {
                TxtPassword.ForeColor = Color.Gray;
                TxtPassword.Text = "Введите пароль";
                TxtPassword.Enter += TxtPassword_Enter;
            }
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Settings.Default.CBProtSite)
            {
                if (e.ColumnIndex == 0 && e.Value != null)
                {
                    DataGridView.Rows[e.RowIndex].Tag = e.Value;
                    e.Value = new string('\u25CF', e.Value.ToString().Length);
                }
            }

            if (Settings.Default.CBProtDesc)
            {
                if (e.ColumnIndex == 1 && e.Value != null)
                {
                    DataGridView.Rows[e.RowIndex].Tag = e.Value;
                    e.Value = new string('\u25CF', e.Value.ToString().Length);
                }
            }

            if (Settings.Default.CBProtLogin)
            {
                if (e.ColumnIndex == 2 && e.Value != null)
                {
                    DataGridView.Rows[e.RowIndex].Tag = e.Value;
                    e.Value = new string('\u25CF', e.Value.ToString().Length);
                }
            }

            if (Settings.Default.CBProtPass)
            {
                if (e.ColumnIndex == 3 && e.Value != null)
                {
                    DataGridView.Rows[e.RowIndex].Tag = e.Value;
                    e.Value = new string('\u25CF', e.Value.ToString().Length);
                }
            }

        }

        private void Form1_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
                DataGridView.CellFormatting -= new DataGridViewCellFormattingEventHandler(DataGridView_CellFormatting);

            if (e.KeyCode == Keys.Delete)
                Delete();
        }

        private void Form1_Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
                DataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(DataGridView_CellFormatting);
        }

        private void TxtLeave(object sender, EventArgs e)
        {
            TxtLeave();
        }

        private void ToolItemOpen_Click(object sender, EventArgs e)
        {
            if (MessageSave() != 3)
                OpenFileVoid();
        }

        private void ToolItemSave_Click(object sender, EventArgs e)
        {
            SaveFileVoid();
        }

        private void ToolItemFile_MouseEnter(object sender, EventArgs e)
        {
            if (TxtFile.Text == "")
            {
                ToolItemСlear.Enabled = false;
                ToolItemFastSave.Enabled = false;
            }
            else
            {
                ToolItemСlear.Enabled = true;
                ToolItemFastSave.Enabled = true;
            }

            if (DataGridView.Rows.Count > 0)
                ToolItemSave.Enabled = true;
            else
                ToolItemSave.Enabled = false;
        }

        private void Form1_Main_SizeChanged(object sender, EventArgs e)
        {
            TxtWebsite.Width = Width - 73;
            TxtDescription.Width = Width - 73;
            TxtLogin.Width = Width - 73;
            TxtPassword.Width = Width - 73;
        }

        private void DataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView.CellFormatting -= new DataGridViewCellFormattingEventHandler(DataGridView_CellFormatting);
            Clipboard.SetDataObject(DataGridView.GetClipboardContent());
            DataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(DataGridView_CellFormatting);
        }
    }
}