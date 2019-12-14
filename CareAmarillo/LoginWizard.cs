/* Nathaniel Worthington
 * COSC 1320 001
 * 12/11/2019
 * Group B Project (CareAmarillo)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProjectTest
{
    class LoginWizard
    {
        static SqlConnection connection = new SqlConnection();
        /* The NewPass variable will be passed out to the form, which will in turn allow users to input their new password,
         * and trigger the ChangePassword method.
         */
        public string AuthenticateUser(string ID, string Password, out bool NewPass)
        {
            /* This method is designed to pull the ID and the Password from the end user, and check it against the database.
             * If the ID and Password match, then the user is given the correct level of authentication.
             */
            // This is the variable to be returned.
            var AuthenticationLevel = "";

            // These variables make the CredentialSearch function work the way I want it to.
            SqlConnection connection = new SqlConnection();
            string DBID = ID;
            string DBPass = Password;
            int HMID = 0;
            int ESID = 0;
            NewPass = false;



            if (CredentialSearch(ref DBID, ref DBPass, out HMID, out ESID, out NewPass))
            {
                if (HMID == 3 && ESID == 3)
                {
                    AuthenticationLevel = "High";
                }
                else
                {
                    AuthenticationLevel = "Medium";
                }
            }
            else
            {
                AuthenticationLevel = "Invalid ID or Password";
            }
            // (NO LONGER NECESSARY)There also isn't a database to pull from so I will use a few files.
            //var IDReader = new StreamReader("C:\\Users\\programmer\\Desktop\\ID.txt");
            //var PassReader = new StreamReader("C:\\Users\\programmer\\Desktop\\Password.txt");
            //var AccessReader = new StreamReader("C:\\Users\\programmer\\Desktop\\AccessLevel.txt");

            /* If the entered ID and password and the ID and Password from the database match,
             * the user will be authenticated based on whether or not they have a Human Resource or Emergency Service ID.
             * If both are null, then they are an admin, if the ID and Password do not match up, they are invalid
             * An "Invalid ID or Password" return does not allow access.
             */
            //if (ID.Equals(DBID) && Password.Equals(DBPass))
            //{

            //}


            return AuthenticationLevel;
        }
        // This is an altered version of the ReadDataBase function in the DatabaseProcess class that searches for specific values.
        public bool CredentialSearch(ref string DBID, ref string DBPass, out int HMID, out int ESID, out bool NewPass)
        {
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            //MessageBox.Show(connection.ServerVersion);
            //Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();
            HMID = 3;
            ESID = 3;
            string DBNewPass = "";
            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                // NOTE: @ProfName is just made up: it's a placeholder for the SQL parameter (See the next few lines)
                readAllDatabaseRecords.CommandText =
                    @"select ID as User_ID, UPassword as Password, HID As Human_Services, EID as Emergency_Services, NewPass as NPass
                    from Users
                    WHERE ID = @ID AND UPassword = @UPassword";

                readAllDatabaseRecords.Parameters.Add(new SqlParameter("ID", DBID));
                readAllDatabaseRecords.Parameters.Add(new SqlParameter("UPassword", DBPass));

                // Consider using parameterized queries when possible. ProfName below is the same @ProfName above in the SQL statement.
                //readAllDatabaseRecords.Parameters.Add(new SqlParameter("id", 2));

                // The using block for handling the IO
                using (SqlDataReader reader = readAllDatabaseRecords.ExecuteReader())
                {

                    // a dictionary to store the ordinal positions of each column in the table.
                    var columnNames = new Dictionary<string, int>();

                    // Actually building the above dictionary. This should be done outside of any data-read loop for 
                    // performance reasons.
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    bool foundUser = false;
                    // Get the data you want from the SQL Select and do whatever you want with it.
                    while (reader.Read())
                    {
                        DBID = reader.GetFieldValue<int>(columnNames["User_ID"]).ToString() + "";
                        DBPass = reader.GetFieldValue<string>(columnNames["Password"]) + "";
                        HMID = reader.GetFieldValue<int>(columnNames["Human_Services"]);
                        ESID = reader.GetFieldValue<int>(columnNames["Emergency_Services"]);
                        DBNewPass = reader.GetFieldValue<string>(columnNames["NPass"]);
                        foundUser = true;
                    }
                    if (DBNewPass.Equals("Yes") || DBNewPass.Equals("yes"))
                    {
                        NewPass = true;
                    }
                    else
                    {
                        NewPass = false;
                    }
                    return foundUser;
                }

            }
        }

        // The ID here needs to be the same as it is in the previous methods, otherwise users can change other people's passwords.
        public void ChangePassword(string ID, string NewPassword)
        {
            using (SqlCommand update = connection.CreateCommand())
            {
                update.CommandText = "update Users set UPassword = @Password where ID = @ID;";
                update.Parameters.Add(new SqlParameter("Password", NewPassword));
                update.Parameters.Add(new SqlParameter("ID", ID));
                update.ExecuteNonQuery();
            }
            using (SqlCommand update = connection.CreateCommand())
            {
                update.CommandText = "update Users set NewPass = 'No' where ID = @ID;";
                update.Parameters.Add(new SqlParameter("ID", ID));
                update.ExecuteNonQuery();
            }
        }
    }
}