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
    public partial class Location : Form
    {

        public Location()
        {
            InitializeComponent();

            //set variable then call the method
            var test = DatabaseProcess.ReadHumanServices();
            //dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = test;
            dataGridView1.DataMember = test.Tables[0].ToString();
            //lblLocations.Text = test;

        }


        private void Button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
