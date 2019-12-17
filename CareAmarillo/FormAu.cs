﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareAmarillo
{
    public partial class FormAu : Form
    {
        public FormAu()
        {
            InitializeComponent();
        }

        bool show1;
        bool show2;

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (show1)
            {
                plSidebar.Visible = false;
                show1 = false;
            }
            else
            {
                plSidebar.Visible = true;
                show1 = true;
            }
            Application.DoEvents();
        }

        private void PlRight_MouseHover(object sender, EventArgs e)
        {
            this.lblLogout.ForeColor = Color.DimGray;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            
            if (show2)
            {
                plSidebar.Visible = false;
                show2 = false;
            }
            else
            {
                plSidebar.Visible = true;
                show2 = true;
            }
            Application.DoEvents();
        }
    }
}
