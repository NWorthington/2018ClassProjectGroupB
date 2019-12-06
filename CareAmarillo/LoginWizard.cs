using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CareAmarillo
{
    class LoginWizard
    {
        public string AuthenticateUser(string ID, string Password)
        {
            /* This method is designed to pull the ID and the Password from the end user, and check it against the database.
             * If the ID and Password match, then the user is given the correct level of authentication.
             */
            // This is the variable to be returned.
            var AuthenticationLevel = "";

            // There also isn't a database to pull from so I will use a few files.
            var IDReader = new StreamReader("C:\\Users\\programmer\\Desktop\\ID.txt");
            var PassReader = new StreamReader("C:\\Users\\programmer\\Desktop\\Password.txt");
            var AccessReader = new StreamReader("C:\\Users\\programmer\\Desktop\\AccessLevel.txt");

            if(ID.Equals(IDReader.ReadLine()) || Password.Equals(PassReader.ReadLine()))
            {
                AuthenticationLevel = AccessReader.ReadLine();
            }
            else
            {
                AuthenticationLevel = "Invalid ID or Password";
            }

            return AuthenticationLevel;
        }
    }
}
