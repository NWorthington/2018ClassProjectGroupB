﻿namespace CareAmarillo
{
    partial class FormAu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAu));
            this.plTop = new System.Windows.Forms.Panel();
            this.pbxCareAmarillo = new System.Windows.Forms.PictureBox();
            this.pbxMenuBar = new System.Windows.Forms.PictureBox();
            this.plRight = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.plSidebar = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.plSidebarTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.plMiddle = new System.Windows.Forms.Panel();
            this.userControlAccountsAu1 = new CareAmarillo.AuControl.UserControlAccountsAu();
            this.userControlResetPassword1 = new CareAmarillo.AuControl.UserControlResetPassword();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCareAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuBar)).BeginInit();
            this.plRight.SuspendLayout();
            this.plSidebar.SuspendLayout();
            this.plSidebarTop.SuspendLayout();
            this.plMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.White;
            this.plTop.Controls.Add(this.pbxCareAmarillo);
            this.plTop.Controls.Add(this.pbxMenuBar);
            this.plTop.Controls.Add(this.plRight);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(1832, 148);
            this.plTop.TabIndex = 1;
            // 
            // pbxCareAmarillo
            // 
            this.pbxCareAmarillo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxCareAmarillo.Image = ((System.Drawing.Image)(resources.GetObject("pbxCareAmarillo.Image")));
            this.pbxCareAmarillo.Location = new System.Drawing.Point(815, 29);
            this.pbxCareAmarillo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pbxCareAmarillo.Name = "pbxCareAmarillo";
            this.pbxCareAmarillo.Size = new System.Drawing.Size(149, 119);
            this.pbxCareAmarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCareAmarillo.TabIndex = 3;
            this.pbxCareAmarillo.TabStop = false;
            // 
            // pbxMenuBar
            // 
            this.pbxMenuBar.Image = ((System.Drawing.Image)(resources.GetObject("pbxMenuBar.Image")));
            this.pbxMenuBar.Location = new System.Drawing.Point(21, 12);
            this.pbxMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxMenuBar.Name = "pbxMenuBar";
            this.pbxMenuBar.Size = new System.Drawing.Size(136, 117);
            this.pbxMenuBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMenuBar.TabIndex = 2;
            this.pbxMenuBar.TabStop = false;
            this.pbxMenuBar.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // plRight
            // 
            this.plRight.Controls.Add(this.lblLogout);
            this.plRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.plRight.Location = new System.Drawing.Point(1584, 0);
            this.plRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plRight.Name = "plRight";
            this.plRight.Size = new System.Drawing.Size(248, 148);
            this.plRight.TabIndex = 1;
            this.plRight.MouseHover += new System.EventHandler(this.PlRight_MouseHover);
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.AutoSize = true;
            this.lblLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Gray;
            this.lblLogout.Location = new System.Drawing.Point(40, 48);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(161, 46);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "Log out";
            // 
            // plSidebar
            // 
            this.plSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plSidebar.Controls.Add(this.btnAccount);
            this.plSidebar.Controls.Add(this.btnReset);
            this.plSidebar.Controls.Add(this.button3);
            this.plSidebar.Controls.Add(this.button1);
            this.plSidebar.Controls.Add(this.button2);
            this.plSidebar.Controls.Add(this.plSidebarTop);
            this.plSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.plSidebar.Location = new System.Drawing.Point(0, 148);
            this.plSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plSidebar.Name = "plSidebar";
            this.plSidebar.Size = new System.Drawing.Size(464, 1073);
            this.plSidebar.TabIndex = 2;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.LightGray;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(0, 644);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(464, 141);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Accounts";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightGray;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(0, 503);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(464, 141);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset passwords";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 362);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(464, 141);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(464, 141);
            this.button1.TabIndex = 0;
            this.button1.Text = "button2";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 76);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(464, 145);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // plSidebarTop
            // 
            this.plSidebarTop.Controls.Add(this.label1);
            this.plSidebarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plSidebarTop.Location = new System.Drawing.Point(0, 0);
            this.plSidebarTop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.plSidebarTop.Name = "plSidebarTop";
            this.plSidebarTop.Size = new System.Drawing.Size(464, 76);
            this.plSidebarTop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator";
            // 
            // plMiddle
            // 
            this.plMiddle.Controls.Add(this.userControlAccountsAu1);
            this.plMiddle.Controls.Add(this.userControlResetPassword1);
            this.plMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMiddle.Location = new System.Drawing.Point(464, 148);
            this.plMiddle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plMiddle.Name = "plMiddle";
            this.plMiddle.Size = new System.Drawing.Size(1368, 1073);
            this.plMiddle.TabIndex = 3;
            // 
            // userControlAccountsAu1
            // 
            this.userControlAccountsAu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAccountsAu1.Location = new System.Drawing.Point(0, 0);
            this.userControlAccountsAu1.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.userControlAccountsAu1.Name = "userControlAccountsAu1";
            this.userControlAccountsAu1.Size = new System.Drawing.Size(1368, 1073);
            this.userControlAccountsAu1.TabIndex = 1;
            // 
            // userControlResetPassword1
            // 
            this.userControlResetPassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlResetPassword1.Location = new System.Drawing.Point(0, 0);
            this.userControlResetPassword1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlResetPassword1.Name = "userControlResetPassword1";
            this.userControlResetPassword1.Size = new System.Drawing.Size(1368, 1073);
            this.userControlResetPassword1.TabIndex = 0;
            // 
            // FormAu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 1221);
            this.Controls.Add(this.plMiddle);
            this.Controls.Add(this.plSidebar);
            this.Controls.Add(this.plTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAu";
            this.Text = "CareAmarillo";
            this.plTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCareAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuBar)).EndInit();
            this.plRight.ResumeLayout(false);
            this.plRight.PerformLayout();
            this.plSidebar.ResumeLayout(false);
            this.plSidebarTop.ResumeLayout(false);
            this.plSidebarTop.PerformLayout();
            this.plMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Panel plSidebar;
        private System.Windows.Forms.Panel plMiddle;
        private System.Windows.Forms.Panel plRight;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.PictureBox pbxMenuBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel plSidebarTop;
        private System.Windows.Forms.PictureBox pbxCareAmarillo;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private AuControl.UserControlAccountsAu userControlAccountsAu1;
        private AuControl.UserControlResetPassword userControlResetPassword1;
    }
}