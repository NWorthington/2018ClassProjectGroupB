namespace CareAmarillo
{
    partial class FormHS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHS));
            this.plTop = new System.Windows.Forms.Panel();
            this.pbxCareAmarillo = new System.Windows.Forms.PictureBox();
            this.pbxMenuBar = new System.Windows.Forms.PictureBox();
            this.plRight = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.plSidebar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.plSidebarTop = new System.Windows.Forms.Panel();
            this.plMiddle = new System.Windows.Forms.Panel();
            this.userControlHomePage1 = new CareAmarillo.HsControl.UserControlHomePage();
            this.userControlHome1 = new CareAmarillo.HsControl.UserControlHome();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCareAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuBar)).BeginInit();
            this.plRight.SuspendLayout();
            this.plSidebar.SuspendLayout();
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
            this.plTop.Size = new System.Drawing.Size(1541, 148);
            this.plTop.TabIndex = 1;
            // 
            // pbxCareAmarillo
            // 
            this.pbxCareAmarillo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxCareAmarillo.Image = ((System.Drawing.Image)(resources.GetObject("pbxCareAmarillo.Image")));
            this.pbxCareAmarillo.Location = new System.Drawing.Point(669, 29);
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
            this.plRight.Location = new System.Drawing.Point(1293, 0);
            this.plRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plRight.Name = "plRight";
            this.plRight.Size = new System.Drawing.Size(248, 148);
            this.plRight.TabIndex = 1;
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Gray;
            this.lblLogout.Location = new System.Drawing.Point(40, 48);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(161, 46);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "Log out";
            this.lblLogout.Click += new System.EventHandler(this.LblLogout_Click);
            this.lblLogout.MouseHover += new System.EventHandler(this.LblLogout_MouseHover);
            // 
            // plSidebar
            // 
            this.plSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plSidebar.Controls.Add(this.button1);
            this.plSidebar.Controls.Add(this.button2);
            this.plSidebar.Controls.Add(this.plSidebarTop);
            this.plSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.plSidebar.Location = new System.Drawing.Point(0, 148);
            this.plSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plSidebar.Name = "plSidebar";
            this.plSidebar.Size = new System.Drawing.Size(464, 846);
            this.plSidebar.TabIndex = 2;
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
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // plSidebarTop
            // 
            this.plSidebarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plSidebarTop.Location = new System.Drawing.Point(0, 0);
            this.plSidebarTop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.plSidebarTop.Name = "plSidebarTop";
            this.plSidebarTop.Size = new System.Drawing.Size(464, 76);
            this.plSidebarTop.TabIndex = 3;
            // 
            // plMiddle
            // 
            this.plMiddle.Controls.Add(this.userControlHomePage1);
            this.plMiddle.Controls.Add(this.userControlHome1);
            this.plMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMiddle.Location = new System.Drawing.Point(464, 148);
            this.plMiddle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plMiddle.Name = "plMiddle";
            this.plMiddle.Size = new System.Drawing.Size(1077, 846);
            this.plMiddle.TabIndex = 3;
            // 
            // userControlHomePage1
            // 
            this.userControlHomePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlHomePage1.Location = new System.Drawing.Point(0, 0);
            this.userControlHomePage1.Name = "userControlHomePage1";
            this.userControlHomePage1.Size = new System.Drawing.Size(1077, 846);
            this.userControlHomePage1.TabIndex = 1;
            // 
            // userControlHome1
            // 
            this.userControlHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlHome1.Location = new System.Drawing.Point(0, 0);
            this.userControlHome1.Name = "userControlHome1";
            this.userControlHome1.Size = new System.Drawing.Size(1077, 846);
            this.userControlHome1.TabIndex = 0;
            // 
            // FormHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 994);
            this.Controls.Add(this.plMiddle);
            this.Controls.Add(this.plSidebar);
            this.Controls.Add(this.plTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHS";
            this.Text = "CareAmarillo";
            this.plTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCareAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuBar)).EndInit();
            this.plRight.ResumeLayout(false);
            this.plRight.PerformLayout();
            this.plSidebar.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel plSidebarTop;
        private System.Windows.Forms.PictureBox pbxCareAmarillo;
        private HsControl.UserControlHomePage userControlHomePage1;
        private HsControl.UserControlHome userControlHome1;
    }
}