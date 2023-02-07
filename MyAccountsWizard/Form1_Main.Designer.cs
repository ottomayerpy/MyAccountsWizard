namespace MyAccountsWizard
{
    partial class Form1_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Main));
            this.Label = new System.Windows.Forms.Label();
            this.TxtFile = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.ButtonEditing = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtWebsite = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolItemСlear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolItemFastSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolItemEditing = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label.Location = new System.Drawing.Point(71, 7);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(120, 13);
            this.Label.TabIndex = 13;
            this.Label.Text = "Редактируемый файл:";
            // 
            // TxtFile
            // 
            this.TxtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtFile.Location = new System.Drawing.Point(197, 4);
            this.TxtFile.Name = "TxtFile";
            this.TxtFile.ReadOnly = true;
            this.TxtFile.Size = new System.Drawing.Size(643, 20);
            this.TxtFile.TabIndex = 12;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel.Controls.Add(this.ButtonEditing);
            this.panel.Controls.Add(this.TxtPassword);
            this.panel.Controls.Add(this.TxtWebsite);
            this.panel.Controls.Add(this.ButtonAdd);
            this.panel.Controls.Add(this.TxtLogin);
            this.panel.Controls.Add(this.ButtonDelete);
            this.panel.Controls.Add(this.TxtDescription);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 367);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(878, 114);
            this.panel.TabIndex = 9;
            this.panel.Visible = false;
            // 
            // ButtonEditing
            // 
            this.ButtonEditing.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEditing.Location = new System.Drawing.Point(828, 39);
            this.ButtonEditing.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonEditing.Name = "ButtonEditing";
            this.ButtonEditing.Size = new System.Drawing.Size(40, 35);
            this.ButtonEditing.TabIndex = 5;
            this.ButtonEditing.UseVisualStyleBackColor = true;
            this.ButtonEditing.Click += new System.EventHandler(this.ButtonEditing_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtPassword.Location = new System.Drawing.Point(3, 87);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(821, 20);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.Text = "Введите пароль";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtLeave);
            // 
            // TxtWebsite
            // 
            this.TxtWebsite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtWebsite.ForeColor = System.Drawing.Color.Gray;
            this.TxtWebsite.Location = new System.Drawing.Point(3, 9);
            this.TxtWebsite.Name = "TxtWebsite";
            this.TxtWebsite.Size = new System.Drawing.Size(821, 20);
            this.TxtWebsite.TabIndex = 2;
            this.TxtWebsite.Text = "Введите сайт";
            this.TxtWebsite.Enter += new System.EventHandler(this.TxtWebsite_Enter);
            this.TxtWebsite.Leave += new System.EventHandler(this.TxtLeave);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.Location = new System.Drawing.Point(828, 1);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(40, 38);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TxtLogin
            // 
            this.TxtLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtLogin.ForeColor = System.Drawing.Color.Gray;
            this.TxtLogin.Location = new System.Drawing.Point(3, 61);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(821, 20);
            this.TxtLogin.TabIndex = 4;
            this.TxtLogin.Text = "Введите логин";
            this.TxtLogin.Enter += new System.EventHandler(this.TxtLogin_Enter);
            this.TxtLogin.Leave += new System.EventHandler(this.TxtLeave);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonDelete.Location = new System.Drawing.Point(828, 74);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(40, 38);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtDescription.ForeColor = System.Drawing.Color.Gray;
            this.TxtDescription.Location = new System.Drawing.Point(3, 35);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(821, 20);
            this.TxtDescription.TabIndex = 1;
            this.TxtDescription.Tag = "";
            this.TxtDescription.Text = "Введите описание";
            this.TxtDescription.Enter += new System.EventHandler(this.TxtDescription_Enter);
            this.TxtDescription.Leave += new System.EventHandler(this.TxtLeave);
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 28);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(878, 453);
            this.DataGridView.TabIndex = 10;
            this.DataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            this.DataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 1000F;
            this.Column1.HeaderText = "Сайт";
            this.Column1.MinimumWidth = 200;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 1000F;
            this.Column2.HeaderText = "Описание";
            this.Column2.MinimumWidth = 200;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 1000F;
            this.Column3.HeaderText = "Логин";
            this.Column3.MinimumWidth = 200;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 1000F;
            this.Column4.HeaderText = "Пароль";
            this.Column4.MinimumWidth = 200;
            this.Column4.Name = "Column4";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolItemFile,
            this.ToolItemEditing,
            this.ToolItemSettings});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(878, 28);
            this.menuStrip.TabIndex = 11;
            // 
            // ToolItemFile
            // 
            this.ToolItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolItemOpen,
            this.ToolItemСlear,
            this.ToolItemFastSave,
            this.ToolItemSave});
            this.ToolItemFile.Image = ((System.Drawing.Image)(resources.GetObject("ToolItemFile.Image")));
            this.ToolItemFile.Name = "ToolItemFile";
            this.ToolItemFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolItemFile.Size = new System.Drawing.Size(32, 24);
            this.ToolItemFile.MouseEnter += new System.EventHandler(this.ToolItemFile_MouseEnter);
            // 
            // ToolItemOpen
            // 
            this.ToolItemOpen.Name = "ToolItemOpen";
            this.ToolItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ToolItemOpen.Size = new System.Drawing.Size(234, 22);
            this.ToolItemOpen.Text = "Открыть...";
            this.ToolItemOpen.Click += new System.EventHandler(this.ToolItemOpen_Click);
            // 
            // ToolItemСlear
            // 
            this.ToolItemСlear.Name = "ToolItemСlear";
            this.ToolItemСlear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.ToolItemСlear.Size = new System.Drawing.Size(234, 22);
            this.ToolItemСlear.Text = "Закрыть";
            this.ToolItemСlear.Click += new System.EventHandler(this.ToolItemClear_Click);
            // 
            // ToolItemFastSave
            // 
            this.ToolItemFastSave.Name = "ToolItemFastSave";
            this.ToolItemFastSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolItemFastSave.Size = new System.Drawing.Size(234, 22);
            this.ToolItemFastSave.Text = "Сохранить";
            this.ToolItemFastSave.Click += new System.EventHandler(this.ToolItemFastSave_Click);
            // 
            // ToolItemSave
            // 
            this.ToolItemSave.Name = "ToolItemSave";
            this.ToolItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ToolItemSave.Size = new System.Drawing.Size(234, 22);
            this.ToolItemSave.Text = "Сохранить как...";
            this.ToolItemSave.Click += new System.EventHandler(this.ToolItemSave_Click);
            // 
            // ToolItemEditing
            // 
            this.ToolItemEditing.Checked = true;
            this.ToolItemEditing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolItemEditing.Name = "ToolItemEditing";
            this.ToolItemEditing.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.ToolItemEditing.Size = new System.Drawing.Size(12, 24);
            this.ToolItemEditing.Click += new System.EventHandler(this.ToolItemEditing_Click);
            // 
            // ToolItemSettings
            // 
            this.ToolItemSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolItemSettings.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolItemSettings.Name = "ToolItemSettings";
            this.ToolItemSettings.Size = new System.Drawing.Size(12, 24);
            this.ToolItemSettings.Click += new System.EventHandler(this.ToolItemSettings_Click);
            // 
            // Form1_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(878, 481);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TxtFile);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(894, 520);
            this.Name = "Form1_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAccountsWizard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Main_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_Main_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_Main_KeyUp);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox TxtFile;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button ButtonEditing;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtWebsite;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolItemOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolItemСlear;
        private System.Windows.Forms.ToolStripMenuItem ToolItemFastSave;
        private System.Windows.Forms.ToolStripMenuItem ToolItemSave;
        private System.Windows.Forms.ToolStripMenuItem ToolItemEditing;
        private System.Windows.Forms.ToolStripMenuItem ToolItemSettings;
    }
}