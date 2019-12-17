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
    public partial class formCareAmarillo : Form
    {
        public formCareAmarillo()
        {
            InitializeComponent();
        }

        private void PbxLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new FormCareLogin();
            form1.Show();
        }
    }
}
