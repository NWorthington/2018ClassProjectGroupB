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

            //set variable then call the method for dataset to datagridview1
            //var test = DatabaseProcess.DataSetUsers();
            //var test = DatabaseProcess.DataSetHumanServices();
            //var test = DatabaseProcess.DataSetEmergencyServices();
            //var test = DatabaseProcess.DataSetServicesOffered();

            //join table datasets
            //var test = DatabaseProcess.TwoTableDataSetHumanOffered();
            //var test = DatabaseProcess.TwoTableDataSetEmergencyOffered();
            var test = DatabaseProcess.AllUserDataSet();

            dataGridView1.DataSource = test;
            dataGridView1.DataMember = test.Tables[0].ToString();
 

            //calling methods with return string value to a label named lblLocations
            //lblLocations.Text = DatabaseProcess.ReadDataBase();
            //lblLocations.Text = DatabaseProcess.ReadHumanServices();
            //lblLocations.Text = DatabaseProcess.ReadEmergencyServices();
            //lblLocations.Text = DatabaseProcess.ReadServicesOffered();

        }


        private void Button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void Location_Load(object sender, EventArgs e)
        {

        }
    }
}
