using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace CareAmarillo
{
    public partial class FormCareLogin : Form
    {
        public FormCareLogin()
        {
            InitializeComponent();
            
            // This form uses the LoginWizard class to preform its actions.
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginWizard loginWizard = new LoginWizard();
            string InputID = "";
            string InputPassword = "";
            bool NewPass = false;
            string NewPassword = "";
            string Rank = "";

            // Grabs the username and password from the user, then checks for their credentials.
            InputID = tbxUsername.Text;
            InputPassword = tbxPassword.Text;
            Rank = loginWizard.AuthenticateUser(InputID, InputPassword, out NewPass);
            // [NEVER GOT TO WORK] If this is the first time they've logged in then they are prompted to change their password.
            /*if (NewPass)
            {
                tbxUsername.Text = "";
                tbxPassword.Text = "";
                lblUsername.Visible = false;
                lblPassword.Visible = false;
                lblNewPassword.Visible = true;
                lblConPassword.Visible = true;
                btnChange.Visible = true;
                btnLogin.Visible = false;
                //btnChange_Click(sender, e, NewPassword, NewPass, InputID);
            }
            */
            // The user is now directed to the appropriate form.
            if(Rank.Equals("Admin"))
            {
                //this.FormClosed +=
                new FormAu().Show();
                this.Hide();
            }

            else if (Rank.Equals("Human Resources"))
            {
                new FormHS().Show();
                this.Hide();
            }
            else if(Rank.Equals("Emergency Shelter"))
            {
                new FormES().Show();
                this.Hide();
            }
            else
            {
                lblInvalid.Visible = true;
            }

        }

        /*private void btnChange_Click(object sender, EventArgs e, string NewPassword, bool NewPass, string InputID)
        {
            LoginWizard loginWizard = new LoginWizard();
            NewPassword = tbxUsername.Text;
            loginWizard.ChangePassword(InputID, NewPassword);
            NewPass = false;
            MessageBox.Show("NewPass = " + NewPass.ToString(), "NewPassword = " + NewPassword);
        }
        */
    }
}
