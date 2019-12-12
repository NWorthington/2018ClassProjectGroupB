//Chris White
//COSC 1320-001
//12/10/19
//GroupB Project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Data.Common;

namespace CareAmarillo
{
    public class DatabaseProcess
       
    {

        static SqlConnection connection = new SqlConnection();
        static public void ReadDataBase()
        {
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            MessageBox.Show(connection.ServerVersion);
            //Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();

            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                // NOTE: @ProfName is just made up: it's a placeholder for the SQL parameter (See the next few lines)
                readAllDatabaseRecords.CommandText =
                    @"select ID as User_ID, FirstName as F_Name, LastName as L_Name, NewPass as New_User,   
                    UserAccess as Last_Login, HID As Human_Services, EID as Emergency_Services
                    from Users";

                // Consider using parameterized queries when possible. ProfName below is the same @ProfName above in the SQL statement.
                //readAllDatabaseRecords.Parameters.Add(new SqlParameter("id", 2));

                // The using block for handling the IO
                using (SqlDataReader reader = readAllDatabaseRecords.ExecuteReader())
                {
                    string rec = "";

                    // a dictionary to store the ordinal positions of each column in the table.
                    var columnNames = new Dictionary<string, int>();

                    // Actually building the above dictionary. This should be done outside of any data-read loop for 
                    // performance reasons.
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    // Get the data you want from the SQL Select and do whatever you want with it.
                    while (reader.Read())
                    {
                        rec = reader.GetFieldValue<int>(columnNames["User_ID"]).ToString() + " ";
                        rec += reader.GetFieldValue<string>(columnNames["F_Name"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["L_Name"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["New_User"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Last_Login"]) + " ";
                        rec += reader.GetFieldValue<int>(columnNames["Human_Services"]) + " ";
                        rec += reader.GetFieldValue<int>(columnNames["Emergency_Services"]);
                        //Console.WriteLine(rec);
                        
                    }
                    MessageBox.Show(rec);
                }
            }
        }


        public static DataSet ReadHumanServices()
        {

            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            //MessageBox.Show(connection.ServerVersion);
            //Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();


            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                // NOTE: @ProfName is just made up: it's a placeholder for the SQL parameter (See the next few lines)
                readAllDatabaseRecords.CommandText =
                    @"select dbo.HumanServicesProvider.CompanyName, HPhone as Phone, HCity,   
			        HAddress as Address from dbo.HumanServicesProvider";
                readAllDatabaseRecords.CommandType = CommandType.Text;
                // Consider using parameterized queries when possible. ProfName below is the same @ProfName above in the SQL statement.
                //readAllDatabaseRecords.Parameters.Add(new SqlParameter("id", 2));

                // The using block for handling the IO
                //using (SqlDataReader reader = readAllDatabaseRecords.ExecuteReader())
                //{
                    string rec = "";

                    // a dictionary to store the ordinal positions of each column in the table.
                    var columnNames = new Dictionary<string, int>();

                // Actually building the above dictionary. This should be done outside of any data-read loop for 
                // performance reasons.
                //var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                //foreach (var columnName in columns)
                //{
                //    columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                //}

                // Get the data you want from the SQL Select and do whatever you want with it.
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);
                    SqlDataAdapter testAdapter = new SqlDataAdapter();
                    DataSet testSet = new DataSet("HumanServicesProvider");
                    //testAdapter.TableMappings.Add(new DataTableMapping("dbo.HumanServicesProvider", "HumanServicesProvider"));
                    testAdapter.SelectCommand = readAllDatabaseRecords;

                    testAdapter.Fill(testSet);


                for (var i = 0; i < testSet.Tables[0].Rows.Count; i++)
                {
                    //rec += testSet.Tables[0].Rows[i]["CompanyName"];
                   // rec += testSet.Tables[0].Rows[i]["Phone"];
                    //rec += testSet.Tables[0].Rows[i]["Address"].ToString() + "\n";
                }

                                    //pass in table then search item
                var searchSubset = testSet.Tables[0].Select("HCity = 'Dumas'");
                for (var k = 0; k < searchSubset.Length; k++) {
                    rec += searchSubset[k]["Phone"].ToString();
                }

                //while (reader.Read())
                //{
                //rec += reader.GetFieldValue<int>(columnNames["User_ID"]).ToString() + " ";
                //rec += reader.GetFieldValue<string>(columnNames["Company"]) + " ";
                //rec += reader.GetFieldValue<string>(columnNames["Email"]) + " ";
                //rec += reader.GetFieldValue<string>(columnNames["Phone"]) + " ";
                //rec += reader.GetFieldValue<string>(columnNames["City"]) + " ";
                //rec += reader.GetFieldValue<string>(columnNames["State"]) + " ";
                //rec += reader.GetFieldValue<string>(columnNames["Address"]);
                //rec += "\n";
                //Console.WriteLine(rec);

                //}
                //MessageBox.Show(rec);
                //return rec;
                return testSet;

                //}
            }
        }


        public static void ReadEmergencyServices()
        {

            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            MessageBox.Show(connection.ServerVersion);
            //Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();


            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                // NOTE: @ProfName is just made up: it's a placeholder for the SQL parameter (See the next few lines)
                readAllDatabaseRecords.CommandText =
                    @"select ID as User_ID, CompanyName as Company, EEmail as Email, Ephone as Phone,   
	ECity as City, EState As State, EAddress as Address from EmergencyServicesProvider";

                // Consider using parameterized queries when possible. ProfName below is the same @ProfName above in the SQL statement.
                //readAllDatabaseRecords.Parameters.Add(new SqlParameter("id", 2));

                // The using block for handling the IO
                using (SqlDataReader reader = readAllDatabaseRecords.ExecuteReader())
                {
                    string rec = "";

                    // a dictionary to store the ordinal positions of each column in the table.
                    var columnNames = new Dictionary<string, int>();

                    // Actually building the above dictionary. This should be done outside of any data-read loop for 
                    // performance reasons.
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    // Get the data you want from the SQL Select and do whatever you want with it.
                    while (reader.Read())
                    {
                        rec = reader.GetFieldValue<int>(columnNames["User_ID"]).ToString() + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Company"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Email"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Phone"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["City"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["State"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Address"]);
                        //Console.WriteLine(rec);
                    }
                    MessageBox.Show(rec);
                }
            }
        }


        public static void ReadServicesOffered()
        {

            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            MessageBox.Show(connection.ServerVersion);
            //Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();


            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                // NOTE: @ProfName is just made up: it's a placeholder for the SQL parameter (See the next few lines)
                readAllDatabaseRecords.CommandText =
                    @"select ID as User_ID, BedCount as Bed, VolunteerOpportunities as Volunteers, ServiceType as Type,   
	Description as Info, CriteriaForService As Criteria, Location as Address from ServicesOffered";

                // Consider using parameterized queries when possible. ProfName below is the same @ProfName above in the SQL statement.
                //readAllDatabaseRecords.Parameters.Add(new SqlParameter("id", 2));

                // The using block for handling the IO
                using (SqlDataReader reader = readAllDatabaseRecords.ExecuteReader())
                {
                    string rec = "";

                    // a dictionary to store the ordinal positions of each column in the table.
                    var columnNames = new Dictionary<string, int>();

                    // Actually building the above dictionary. This should be done outside of any data-read loop for 
                    // performance reasons.
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    // Get the data you want from the SQL Select and do whatever you want with it.
                    while (reader.Read())
                    {
                        rec = reader.GetFieldValue<int>(columnNames["User_ID"]).ToString() + " ";
                        rec += reader.GetFieldValue<int>(columnNames["Bed"]) + " ";
                        rec += reader.GetFieldValue<int>(columnNames["Volunteers"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Type"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Info"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Criteria"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Address"]);
                        //Console.WriteLine(rec);
                    }
                    MessageBox.Show(rec);
                }
            }
        }


        static public void AddNewUser(string firstName, string lastName, string password, string newpass, string useraccess, int hid, int eid)
        {
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            MessageBox.Show(connection.ServerVersion);
            //Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();

            using (SqlCommand insertNewUser = connection.CreateCommand())
            {
                insertNewUser.CommandText = "insert into Users values (@FirstName, @LastName, " +
                    "@UPassword, @NewPass, @UserAccess, @HID, @EID);";

                insertNewUser.Parameters.Add(new SqlParameter("FirstName", firstName));
                insertNewUser.Parameters.Add(new SqlParameter("LastName", lastName));
                insertNewUser.Parameters.Add(new SqlParameter("UPassword", password));
                insertNewUser.Parameters.Add(new SqlParameter("NewPass", newpass));
                insertNewUser.Parameters.Add(new SqlParameter("UserAccess", useraccess));
                insertNewUser.Parameters.Add(new SqlParameter("HID", hid));
                insertNewUser.Parameters.Add(new SqlParameter("EID", eid));
                insertNewUser.ExecuteNonQuery();
            }
        }

        static public void UpdateBedCount(int id, int count)
        {
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            MessageBox.Show(connection.ServerVersion);
            //Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();

            using (SqlCommand updateBed = connection.CreateCommand())
            {
                updateBed.CommandText = "update ServicesOffered set BedCount = @bedcount where ID = @id;";
                updateBed.Parameters.Add(new SqlParameter("bedcount", count));
                updateBed.Parameters.Add(new SqlParameter("id", id));
                updateBed.ExecuteNonQuery();
            }
        }


        static public void UpdateVolunteers(int id, int count)
        {
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            MessageBox.Show(connection.ServerVersion);
            //Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();

            using (SqlCommand updateVols = connection.CreateCommand())
            {
                updateVols.CommandText = "update ServicesOffered set VolunteerOpportunities = @volunteers where ID = @id;";
                updateVols.Parameters.Add(new SqlParameter("volunteers", count));
                updateVols.Parameters.Add(new SqlParameter("id", id));
                updateVols.ExecuteNonQuery();
            }
        }


        static public void DeleteAUser(int id)
        {
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            MessageBox.Show(connection.ServerVersion);
            //Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();

            using (SqlCommand deleteProf = connection.CreateCommand())
            {
                deleteProf.CommandText = "delete from Users where ID = @userID;";
                deleteProf.Parameters.Add(new SqlParameter("userID", id));
                deleteProf.ExecuteNonQuery();
            }
        }

    }
}
