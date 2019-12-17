using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareAmarillo.AuControl
{
    public partial class UserControlResetPassword : UserControl
    {
        public UserControlResetPassword()
        {
            InitializeComponent();
            var test = DatabaseProcess.AllUserDataSet();

            dataGridView1.DataSource = test;
            dataGridView1.DataMember = test.Tables[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userID = int.Parse(txtID.Text);
            var newPassword = txtNewPassword.Text;
            LoginWizard loginWizard = new LoginWizard();
            loginWizard.AdminChangePassword(userID, newPassword);
            txtID.Clear();
            txtNewPassword.Clear();
        }
    }
}
