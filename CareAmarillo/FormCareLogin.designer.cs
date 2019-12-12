namespace CareAmarillo
{
    partial class FormCareLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCareLogin));
            this.plTop = new System.Windows.Forms.Panel();
            this.pbxCareText = new System.Windows.Forms.PictureBox();
            this.pbxCareLogo = new System.Windows.Forms.PictureBox();
            this.plUnderline2 = new System.Windows.Forms.Panel();
            this.plUnderline = new System.Windows.Forms.Panel();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblForgot = new System.Windows.Forms.Label();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCareText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCareLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.White;
            this.plTop.Controls.Add(this.pbxCareText);
            this.plTop.Controls.Add(this.pbxCareLogo);
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(645, 266);
            this.plTop.TabIndex = 0;
            // 
            // pbxCareText
            // 
            this.pbxCareText.Image = ((System.Drawing.Image)(resources.GetObject("pbxCareText.Image")));
            this.pbxCareText.Location = new System.Drawing.Point(17, 154);
            this.pbxCareText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pbxCareText.Name = "pbxCareText";
            this.pbxCareText.Size = new System.Drawing.Size(573, 87);
            this.pbxCareText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCareText.TabIndex = 1;
            this.pbxCareText.TabStop = false;
            // 
            // pbxCareLogo
            // 
            this.pbxCareLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxCareLogo.Image")));
            this.pbxCareLogo.Location = new System.Drawing.Point(217, 29);
            this.pbxCareLogo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pbxCareLogo.Name = "pbxCareLogo";
            this.pbxCareLogo.Size = new System.Drawing.Size(213, 132);
            this.pbxCareLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCareLogo.TabIndex = 0;
            this.pbxCareLogo.TabStop = false;
            // 
            // plUnderline2
            // 
            this.plUnderline2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plUnderline2.Location = new System.Drawing.Point(72, 426);
            this.plUnderline2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.plUnderline2.Name = "plUnderline2";
            this.plUnderline2.Size = new System.Drawing.Size(500, 2);
            this.plUnderline2.TabIndex = 1;
            // 
            // plUnderline
            // 
            this.plUnderline.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plUnderline.Location = new System.Drawing.Point(72, 615);
            this.plUnderline.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.plUnderline.Name = "plUnderline";
            this.plUnderline.Size = new System.Drawing.Size(500, 2);
            this.plUnderline.TabIndex = 2;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUsername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(72, 362);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(573, 58);
            this.tbxUsername.TabIndex = 3;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(72, 550);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(573, 58);
            this.tbxPassword.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsername.Location = new System.Drawing.Point(72, 317);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(145, 32);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPassword.Location = new System.Drawing.Point(72, 505);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(139, 32);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Location = new System.Drawing.Point(80, 715);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(245, 79);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblForgot.Location = new System.Drawing.Point(337, 644);
            this.lblForgot.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(244, 32);
            this.lblForgot.TabIndex = 9;
            this.lblForgot.Text = "Forgot Password?";
            // 
            // FormCareLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(642, 856);
            this.Controls.Add(this.lblForgot);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.plUnderline);
            this.Controls.Add(this.plUnderline2);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormCareLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCareLogin";
            this.plTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCareText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCareLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Panel plUnderline2;
        private System.Windows.Forms.Panel plUnderline;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbxCareText;
        private System.Windows.Forms.PictureBox pbxCareLogo;
        private System.Windows.Forms.Label lblForgot;
    }
}