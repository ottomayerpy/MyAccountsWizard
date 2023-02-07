namespace MyAccountsWizard
{
    partial class Form3_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonExceptionLog = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboBoxLoadSortDirection = new System.Windows.Forms.ComboBox();
            this.ComboBoxLoadSortTable = new System.Windows.Forms.ComboBox();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.GroupBoxTextProtection = new System.Windows.Forms.GroupBox();
            this.CheckBoxProtPass = new System.Windows.Forms.CheckBox();
            this.CheckBoxProtDesc = new System.Windows.Forms.CheckBox();
            this.CheckBoxProtLogin = new System.Windows.Forms.CheckBox();
            this.CheckBoxProtSite = new System.Windows.Forms.CheckBox();
            this.GroupBoxChangePassword = new System.Windows.Forms.GroupBox();
            this.ButtonChangePassword = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CheckBoxProtPassword = new System.Windows.Forms.CheckBox();
            this.TxtPathAutoLoad = new System.Windows.Forms.TextBox();
            this.ButtonSetPath = new System.Windows.Forms.Button();
            this.GroupBoxAutoLoad = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.GroupBoxTextProtection.SuspendLayout();
            this.GroupBoxChangePassword.SuspendLayout();
            this.GroupBoxAutoLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonExceptionLog
            // 
            this.ButtonExceptionLog.Location = new System.Drawing.Point(167, 252);
            this.ButtonExceptionLog.Name = "ButtonExceptionLog";
            this.ButtonExceptionLog.Size = new System.Drawing.Size(94, 23);
            this.ButtonExceptionLog.TabIndex = 105;
            this.ButtonExceptionLog.Text = "Exception log";
            this.ButtonExceptionLog.UseVisualStyleBackColor = true;
            this.ButtonExceptionLog.Click += new System.EventHandler(this.ButtonExceptionLog_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComboBoxLoadSortDirection);
            this.groupBox3.Controls.Add(this.ComboBoxLoadSortTable);
            this.groupBox3.Location = new System.Drawing.Point(3, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 65);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сортировка";
            // 
            // ComboBoxLoadSortDirection
            // 
            this.ComboBoxLoadSortDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLoadSortDirection.FormattingEnabled = true;
            this.ComboBoxLoadSortDirection.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.ComboBoxLoadSortDirection.Location = new System.Drawing.Point(6, 37);
            this.ComboBoxLoadSortDirection.Name = "ComboBoxLoadSortDirection";
            this.ComboBoxLoadSortDirection.Size = new System.Drawing.Size(255, 21);
            this.ComboBoxLoadSortDirection.TabIndex = 13;
            this.ComboBoxLoadSortDirection.Tag = "Этот параметр сортирует таблицу по возрастанию или убыванию.";
            this.ComboBoxLoadSortDirection.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSortDirection_SelectedIndexChanged);
            // 
            // ComboBoxLoadSortTable
            // 
            this.ComboBoxLoadSortTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLoadSortTable.FormattingEnabled = true;
            this.ComboBoxLoadSortTable.Items.AddRange(new object[] {
            "Сайт",
            "Описание",
            "Логин",
            "Пароль",
            "Не выбрано"});
            this.ComboBoxLoadSortTable.Location = new System.Drawing.Point(6, 14);
            this.ComboBoxLoadSortTable.Name = "ComboBoxLoadSortTable";
            this.ComboBoxLoadSortTable.Size = new System.Drawing.Size(255, 21);
            this.ComboBoxLoadSortTable.TabIndex = 12;
            this.ComboBoxLoadSortTable.Tag = "Этот параметр сортирует таблицу по одному из выбранных вариантов.";
            this.ComboBoxLoadSortTable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSortTable_SelectedIndexChanged);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Location = new System.Drawing.Point(167, 223);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(94, 23);
            this.ButtonHelp.TabIndex = 104;
            this.ButtonHelp.Text = "Справка";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // GroupBoxTextProtection
            // 
            this.GroupBoxTextProtection.Controls.Add(this.CheckBoxProtPass);
            this.GroupBoxTextProtection.Controls.Add(this.CheckBoxProtDesc);
            this.GroupBoxTextProtection.Controls.Add(this.CheckBoxProtLogin);
            this.GroupBoxTextProtection.Controls.Add(this.CheckBoxProtSite);
            this.GroupBoxTextProtection.Location = new System.Drawing.Point(3, 217);
            this.GroupBoxTextProtection.Name = "GroupBoxTextProtection";
            this.GroupBoxTextProtection.Size = new System.Drawing.Size(158, 61);
            this.GroupBoxTextProtection.TabIndex = 101;
            this.GroupBoxTextProtection.TabStop = false;
            this.GroupBoxTextProtection.Text = "Защита текста";
            // 
            // CheckBoxProtPass
            // 
            this.CheckBoxProtPass.AutoSize = true;
            this.CheckBoxProtPass.Location = new System.Drawing.Point(90, 41);
            this.CheckBoxProtPass.Name = "CheckBoxProtPass";
            this.CheckBoxProtPass.Size = new System.Drawing.Size(64, 17);
            this.CheckBoxProtPass.TabIndex = 3;
            this.CheckBoxProtPass.Text = "Пароль";
            this.CheckBoxProtPass.UseVisualStyleBackColor = true;
            this.CheckBoxProtPass.CheckedChanged += new System.EventHandler(this.CheckBoxProtPass_CheckedChanged);
            // 
            // CheckBoxProtDesc
            // 
            this.CheckBoxProtDesc.AutoSize = true;
            this.CheckBoxProtDesc.Location = new System.Drawing.Point(8, 41);
            this.CheckBoxProtDesc.Name = "CheckBoxProtDesc";
            this.CheckBoxProtDesc.Size = new System.Drawing.Size(76, 17);
            this.CheckBoxProtDesc.TabIndex = 2;
            this.CheckBoxProtDesc.Text = "Описание";
            this.CheckBoxProtDesc.UseVisualStyleBackColor = true;
            this.CheckBoxProtDesc.CheckedChanged += new System.EventHandler(this.CheckBoxProtDesc_CheckedChanged);
            // 
            // CheckBoxProtLogin
            // 
            this.CheckBoxProtLogin.AutoSize = true;
            this.CheckBoxProtLogin.Location = new System.Drawing.Point(90, 19);
            this.CheckBoxProtLogin.Name = "CheckBoxProtLogin";
            this.CheckBoxProtLogin.Size = new System.Drawing.Size(57, 17);
            this.CheckBoxProtLogin.TabIndex = 1;
            this.CheckBoxProtLogin.Text = "Логин";
            this.CheckBoxProtLogin.UseVisualStyleBackColor = true;
            this.CheckBoxProtLogin.CheckedChanged += new System.EventHandler(this.CheckBoxProtLogin_CheckedChanged);
            // 
            // CheckBoxProtSite
            // 
            this.CheckBoxProtSite.AutoSize = true;
            this.CheckBoxProtSite.Location = new System.Drawing.Point(8, 19);
            this.CheckBoxProtSite.Name = "CheckBoxProtSite";
            this.CheckBoxProtSite.Size = new System.Drawing.Size(50, 17);
            this.CheckBoxProtSite.TabIndex = 0;
            this.CheckBoxProtSite.Text = "Сайт";
            this.CheckBoxProtSite.UseVisualStyleBackColor = true;
            this.CheckBoxProtSite.CheckedChanged += new System.EventHandler(this.CheckBoxProtSite_CheckedChanged);
            // 
            // GroupBoxChangePassword
            // 
            this.GroupBoxChangePassword.Controls.Add(this.ButtonChangePassword);
            this.GroupBoxChangePassword.Controls.Add(this.ButtonReset);
            this.GroupBoxChangePassword.Controls.Add(this.TxtPassword);
            this.GroupBoxChangePassword.Controls.Add(this.CheckBoxProtPassword);
            this.GroupBoxChangePassword.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxChangePassword.Name = "GroupBoxChangePassword";
            this.GroupBoxChangePassword.Size = new System.Drawing.Size(267, 79);
            this.GroupBoxChangePassword.TabIndex = 102;
            this.GroupBoxChangePassword.TabStop = false;
            this.GroupBoxChangePassword.Text = "Шифрование файла. Создание пароля.";
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.Location = new System.Drawing.Point(69, 45);
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.Size = new System.Drawing.Size(192, 28);
            this.ButtonChangePassword.TabIndex = 2;
            this.ButtonChangePassword.Tag = "";
            this.ButtonChangePassword.Text = "Создать/Изменить";
            this.ButtonChangePassword.UseVisualStyleBackColor = true;
            this.ButtonChangePassword.Click += new System.EventHandler(this.ButtonChangePass_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(3, 48);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(60, 23);
            this.ButtonReset.TabIndex = 8;
            this.ButtonReset.Text = "Сброс";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(9, 19);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(252, 20);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.Tag = "";
            // 
            // CheckBoxProtPassword
            // 
            this.CheckBoxProtPassword.AutoSize = true;
            this.CheckBoxProtPassword.Location = new System.Drawing.Point(210, 0);
            this.CheckBoxProtPassword.Name = "CheckBoxProtPassword";
            this.CheckBoxProtPassword.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxProtPassword.TabIndex = 6;
            this.CheckBoxProtPassword.Tag = "";
            this.CheckBoxProtPassword.UseVisualStyleBackColor = true;
            this.CheckBoxProtPassword.CheckedChanged += new System.EventHandler(this.CheckBoxNewPass_CheckedChanged);
            // 
            // TxtPathAutoLoad
            // 
            this.TxtPathAutoLoad.Location = new System.Drawing.Point(6, 23);
            this.TxtPathAutoLoad.Name = "TxtPathAutoLoad";
            this.TxtPathAutoLoad.Size = new System.Drawing.Size(226, 20);
            this.TxtPathAutoLoad.TabIndex = 106;
            // 
            // ButtonSetPath
            // 
            this.ButtonSetPath.Location = new System.Drawing.Point(238, 21);
            this.ButtonSetPath.Name = "ButtonSetPath";
            this.ButtonSetPath.Size = new System.Drawing.Size(27, 23);
            this.ButtonSetPath.TabIndex = 107;
            this.ButtonSetPath.UseVisualStyleBackColor = true;
            this.ButtonSetPath.Click += new System.EventHandler(this.ButtonSetPath_Click);
            // 
            // GroupBoxAutoLoad
            // 
            this.GroupBoxAutoLoad.Controls.Add(this.TxtPathAutoLoad);
            this.GroupBoxAutoLoad.Controls.Add(this.ButtonSetPath);
            this.GroupBoxAutoLoad.Location = new System.Drawing.Point(3, 159);
            this.GroupBoxAutoLoad.Name = "GroupBoxAutoLoad";
            this.GroupBoxAutoLoad.Size = new System.Drawing.Size(267, 52);
            this.GroupBoxAutoLoad.TabIndex = 108;
            this.GroupBoxAutoLoad.TabStop = false;
            this.GroupBoxAutoLoad.Text = "Автозагрузка таблицы";
            // 
            // Form3_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(273, 281);
            this.Controls.Add(this.GroupBoxAutoLoad);
            this.Controls.Add(this.ButtonExceptionLog);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.GroupBoxTextProtection);
            this.Controls.Add(this.GroupBoxChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_Settings_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.GroupBoxTextProtection.ResumeLayout(false);
            this.GroupBoxTextProtection.PerformLayout();
            this.GroupBoxChangePassword.ResumeLayout(false);
            this.GroupBoxChangePassword.PerformLayout();
            this.GroupBoxAutoLoad.ResumeLayout(false);
            this.GroupBoxAutoLoad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonExceptionLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ComboBoxLoadSortDirection;
        private System.Windows.Forms.ComboBox ComboBoxLoadSortTable;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.GroupBox GroupBoxTextProtection;
        private System.Windows.Forms.CheckBox CheckBoxProtPass;
        private System.Windows.Forms.CheckBox CheckBoxProtDesc;
        private System.Windows.Forms.CheckBox CheckBoxProtLogin;
        private System.Windows.Forms.CheckBox CheckBoxProtSite;
        private System.Windows.Forms.GroupBox GroupBoxChangePassword;
        private System.Windows.Forms.Button ButtonChangePassword;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.CheckBox CheckBoxProtPassword;
        private System.Windows.Forms.TextBox TxtPathAutoLoad;
        private System.Windows.Forms.Button ButtonSetPath;
        private System.Windows.Forms.GroupBox GroupBoxAutoLoad;
    }
}