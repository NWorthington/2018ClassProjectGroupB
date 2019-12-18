using System;
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
    public partial class FormHS : Form
    {
        public FormHS()
        {
            InitializeComponent();
            var provider = new Provider();
        }

        bool show1;

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

        private void LblLogout_MouseHover(object sender, EventArgs e)
        {
            this.lblLogout.ForeColor = Color.DimGray;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            userControlHomePage1.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            userControlHome1.BringToFront();
        }

        private void LblLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
