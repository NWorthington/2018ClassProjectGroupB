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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Testing test connection DJH
        }
        Location locationSearchResults = new Location();
        public static string GetValue = "";


        private void BtnSearch_Click(object sender, EventArgs e)    //when the user presses the 'search' button, 
                                                                    //the search screen will be presented
        {
            if (txtSearchBar.Text == ("LOCATION"))
            {
                locationSearchResults.Show();
                this.Hide();
            }
            if (txtSearchBar.Text == ("LOCATIONS"))
            {
                locationSearchResults.Show();
                this.Hide();
            }
            if (txtSearchBar.Text == ("ADRESS"))
            {
                locationSearchResults.Show();
                this.Hide();
            }
            if (txtSearchBar.Text == ("ADRESSES"))
            {
                locationSearchResults.Show();
                this.Hide();
            }
            if (txtSearchBar.Text == ("SHELTERS"))
            {
                locationSearchResults.Show();
                this.Hide();
            }
            if (txtSearchBar.Text == ("EMERGENCY SHELTERS"))
            {
                locationSearchResults.Show();
                this.Hide();
            }
        }
    }
}
