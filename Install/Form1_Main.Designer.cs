namespace Install
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
            this.СheckBoxDesktopLink = new System.Windows.Forms.CheckBox();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.ButtonInstall = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // СheckBoxDesktopLink
            // 
            this.СheckBoxDesktopLink.AutoSize = true;
            this.СheckBoxDesktopLink.Location = new System.Drawing.Point(145, 103);
            this.СheckBoxDesktopLink.Name = "СheckBoxDesktopLink";
            this.СheckBoxDesktopLink.Size = new System.Drawing.Size(196, 17);
            this.СheckBoxDesktopLink.TabIndex = 20;
            this.СheckBoxDesktopLink.Text = "Создать ярлык на рабочем столе";
            this.СheckBoxDesktopLink.UseVisualStyleBackColor = true;
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Location = new System.Drawing.Point(332, 154);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(27, 23);
            this.ButtonSelect.TabIndex = 19;
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 140);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(168, 13);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Выберите папку для установки:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(11, 9);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(128, 128);
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // TxtBox
            // 
            this.TxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBox.Location = new System.Drawing.Point(10, 156);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.ReadOnly = true;
            this.TxtBox.Size = new System.Drawing.Size(316, 20);
            this.TxtBox.TabIndex = 16;
            // 
            // ButtonInstall
            // 
            this.ButtonInstall.Location = new System.Drawing.Point(284, 125);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.Size = new System.Drawing.Size(75, 23);
            this.ButtonInstall.TabIndex = 15;
            this.ButtonInstall.Text = "Установить";
            this.ButtonInstall.UseVisualStyleBackColor = true;
            this.ButtonInstall.Click += new System.EventHandler(this.ButtonInstall_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(145, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(175, 91);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Вас приветствует установщик\r\nMyAccountsWizard, выполните по\r\nжеланию настройку ус" +
    "тановки\r\nпрограммы и нажмите\r\nкнопку \"Установить\".\r\nПосле завершения операции\r\nи" +
    "нсталлятор закроется.";
            // 
            // Form1_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(369, 186);
            this.Controls.Add(this.СheckBoxDesktopLink);
            this.Controls.Add(this.ButtonSelect);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.ButtonInstall);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox СheckBoxDesktopLink;
        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Button ButtonInstall;
        private System.Windows.Forms.Label Label1;
    }
}