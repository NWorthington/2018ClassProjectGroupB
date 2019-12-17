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
    public partial class UserControlAccountsAu : UserControl
    {
        public UserControlAccountsAu()
        {
            InitializeComponent();

            var test = DatabaseProcess.AllUserDataSet();

            dataGridView1.DataSource = test;
            dataGridView1.DataMember = test.Tables[0].ToString();

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            var userID = int.Parse(txtID.Text);
            DatabaseProcess database = new DatabaseProcess();
            
         
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var userID = int.Parse(txtID.Text);
        
            
        }
    }
}
