namespace MyAccountsWizard
{
    partial class Form2_Load
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
            this.CheckBoxPass = new System.Windows.Forms.CheckBox();
            this.LabelClose = new System.Windows.Forms.Label();
            this.LabelRollUp = new System.Windows.Forms.Label();
            this.TxtPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // CheckBoxPass
            // 
            this.CheckBoxPass.AutoSize = true;
            this.CheckBoxPass.Location = new System.Drawing.Point(262, 45);
            this.CheckBoxPass.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.CheckBoxPass.Name = "CheckBoxPass";
            this.CheckBoxPass.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxPass.TabIndex = 5;
            this.CheckBoxPass.Tag = "";
            this.CheckBoxPass.UseVisualStyleBackColor = true;
            this.CheckBoxPass.CheckedChanged += new System.EventHandler(this.CheckBoxPass_CheckedChanged);
            // 
            // LabelClose
            // 
            this.LabelClose.AutoSize = true;
            this.LabelClose.Location = new System.Drawing.Point(263, 9);
            this.LabelClose.Name = "LabelClose";
            this.LabelClose.Size = new System.Drawing.Size(14, 13);
            this.LabelClose.TabIndex = 8;
            this.LabelClose.Text = "X";
            // 
            // LabelRollUp
            // 
            this.LabelRollUp.AutoSize = true;
            this.LabelRollUp.Location = new System.Drawing.Point(244, 9);
            this.LabelRollUp.Name = "LabelRollUp";
            this.LabelRollUp.Size = new System.Drawing.Size(13, 13);
            this.LabelRollUp.TabIndex = 9;
            this.LabelRollUp.Text = "—";
            // 
            // TxtPass
            // 
            this.TxtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPass.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPass.HintText = "";
            this.TxtPass.isPassword = false;
            this.TxtPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.TxtPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.TxtPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.TxtPass.LineThickness = 3;
            this.TxtPass.Location = new System.Drawing.Point(13, 26);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(244, 33);
            this.TxtPass.TabIndex = 12;
            this.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPass.OnValueChanged += new System.EventHandler(this.TxtPass_OnValueChanged);
            // 
            // Form2_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(289, 70);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.LabelRollUp);
            this.Controls.Add(this.LabelClose);
            this.Controls.Add(this.CheckBoxPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2_Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_Load_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_Load_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CheckBoxPass;
        private System.Windows.Forms.Label LabelClose;
        private System.Windows.Forms.Label LabelRollUp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPass;
    }
}