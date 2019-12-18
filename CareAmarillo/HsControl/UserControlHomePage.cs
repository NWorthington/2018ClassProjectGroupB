using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareAmarillo.HsControl
{
    public partial class UserControlHomePage : UserControl
    {
        public int ID = 0;
        public UserControlHomePage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            ID = id;
        }
    }
}
