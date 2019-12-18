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
    public partial class UserControlHomeES : UserControl
    {
        char serviceType = 'E';
        int ID = 0;
        public UserControlHomeES()
        {
            InitializeComponent();
            var home = new UserControlHomePage();
            ID = home.ID;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string newCompanyName = textBox1.Text;
            var provider = new Provider();
            provider.UpdateCompanyName(serviceType, newCompanyName, ID);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string newEmail = textBox2.Text;
            var provider = new Provider();
            provider.UpdateEmail(serviceType, ID, newEmail);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string newPhone = textBox3.Text;
            var provider = new Provider();
            provider.UpdatePhone(serviceType, ID, newPhone);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            string newCity = textBox4.Text;
            var provider = new Provider();
            provider.UpdateCity(serviceType, newCity, ID);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            string newState = textBox5.Text;
            var provider = new Provider();
            provider.UpdateState(serviceType, newState, ID);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string newAddress = textBox6.Text;
            var provider = new Provider();
            provider.UpdateAddress(serviceType, newAddress, ID);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            string newRequirements = textBox8.Text;
            var provider = new Provider();
            provider.UpdateRequirements(newRequirements, ID);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            string Descriptions = textBox9.Text;
            var provider = new Provider();
            provider.UpdateDescription(Descriptions, ID);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            string newVolunteerPositions = textBox7.Text;
            var provider = new Provider();
            provider.UpdateVolunteerPositions(newVolunteerPositions, ID);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox10.Text);
            var provider = new DatabaseProcess();
            provider.UpdateBedCount(ID, count);
        }
    }
}
