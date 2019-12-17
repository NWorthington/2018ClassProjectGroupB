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
        public static DataSet DataSetUsers()
        {

            //setting up connection to server/open connection
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                //checking connection by checking server versino
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting string variable for database query
                readAllDatabaseRecords.CommandText =
                                @"select FirstName as FName, LastName as LName ,UPassword as Password, NewPass as NewUser,   
						UserAccess as LastLogIn, HID as HumanServicesID, EID as EmergencyServicesID from dbo.Users";

                readAllDatabaseRecords.CommandType = CommandType.Text;

                // a dictionary to store the ordinal positions of each column in the table.
                var columnNames = new Dictionary<string, int>();

                //setting adapter for table and fill dataset
                SqlDataAdapter testAdapter = new SqlDataAdapter();
                DataSet testSet = new DataSet("Users");
                //testAdapter.TableMappings.Add(new DataTableMapping("dbo.HumanServicesProvider", "HumanServicesProvider"));
                testAdapter.SelectCommand = readAllDatabaseRecords;
                testAdapter.Fill(testSet);
                
                //close connection
                connection.Close();

                //return dataset 
                return testSet;

            }
        }

        
        static public String ReadDataBase()
        {
            //setting up sql string for query
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting up sql string for query
                readAllDatabaseRecords.CommandText =
                    @"select ID as User_ID, FirstName as F_Name, LastName as L_Name, NewPass as New_User,   
                    UserAccess as Last_Login, HID As Human_Services, EID as Emergency_Services
                    from Users";

                // The using block for handling the IO
                using (SqlDataReader reader = readAllDatabaseRecords.ExecuteReader())
                {
                    string rec = "";

                    // a dictionary to store the ordinal positions of each column in the table.
                    var columnNames = new Dictionary<string, int>();

                    //building the above dictionary
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    //getting the data from query above
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
                    //close connection
                    connection.Close();
                    //return string value for query above
                    return rec;
                }
            }
        }



        public static DataSet DataSetHumanServices()
        {

            //setting up connection to server/open connection
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
 


            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting string variable for database query
                readAllDatabaseRecords.CommandText =
                                @"select dbo.HumanServicesProvider.CompanyName as Company, HEmail as Email ,HPhone as Phone, HCity as City,   HState as State, 
								HAddress as Address from dbo.HumanServicesProvider";

                readAllDatabaseRecords.CommandType = CommandType.Text;

                // a dictionary to store the ordinal positions of each column in the table.
                var columnNames = new Dictionary<string, int>();

                //setting adapter for table and fill dataset
                SqlDataAdapter testAdapter = new SqlDataAdapter();
                DataSet testSet = new DataSet("HumanServicesProvider");
                //testAdapter.TableMappings.Add(new DataTableMapping("dbo.HumanServicesProvider", "HumanServicesProvider"));
                testAdapter.SelectCommand = readAllDatabaseRecords;
                testAdapter.Fill(testSet);

                //close connection
                connection.Close();

                //return dataset 
                return testSet;

            }
        }

        public static String ReadHumanServices()
        {

            //setting up connection string to server
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {

                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting up sql string for query
                readAllDatabaseRecords.CommandText =
                    @"select ID as User_ID, CompanyName as Company, HEmail as Email, Hphone as Phone,   
		        	HCity as City, HState As State, HAddress as Address from HumanServicesProvider";

                // The using block for handling the IO
                using (SqlDataReader reader = readAllDatabaseRecords.ExecuteReader())
                {
                    string rec = "";

                    // a dictionary to store the ordinal positions of each column in the table.
                    var columnNames = new Dictionary<string, int>();

                    //building the above dictionary
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    //getting the data from query above
                    while (reader.Read())
                    {
                        rec = reader.GetFieldValue<int>(columnNames["User_ID"]).ToString() + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Company"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Email"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Phone"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["City"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["State"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Address"]);
                        Console.WriteLine(rec);
                    }
                    //close connection
                    connection.Close();
                    //return string value for query above
                    return rec;
                }
                
            }
        }

        public static DataSet DataSetEmergencyServices()
        {

            //setting up connection to server/open connection
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting string variable for database query
                readAllDatabaseRecords.CommandText =
                                @"select dbo.EmergencyServicesProvider.CompanyName as Company, EEmail as Email ,EPhone as Phone, ECity as City,   EState as State, 
						        EAddress as Address from dbo.EmergencyServicesProvider";

                readAllDatabaseRecords.CommandType = CommandType.Text;

                // a dictionary to store the ordinal positions of each column in the table.
                var columnNames = new Dictionary<string, int>();

                //setting adapter for table and fill dataset
                SqlDataAdapter testAdapter = new SqlDataAdapter();
                DataSet testSet = new DataSet("EmergencyServicesProvider");
                //testAdapter.TableMappings.Add(new DataTableMapping("dbo.HumanServicesProvider", "HumanServicesProvider"));
                testAdapter.SelectCommand = readAllDatabaseRecords;
                testAdapter.Fill(testSet);

                //close connection
                connection.Close();

                //return dataset
                return testSet;

            }
        }

        public static String ReadEmergencyServices()
        {

            //setting up connection string to server
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting up sql string for query
                readAllDatabaseRecords.CommandText =
                    @"select ID as User_ID, CompanyName as Company, EEmail as Email, Ephone as Phone,   
	                ECity as City, EState As State, EAddress as Address from EmergencyServicesProvider";

                // The using block for handling the IO
                using (SqlDataReader reader = readAllDatabaseRecords.ExecuteReader())
                {
                    string rec = "";

                    // a dictionary to store the ordinal positions of each column in the table.
                    var columnNames = new Dictionary<string, int>();

                    //building the above dictionary
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    //getting the data from query above
                    while (reader.Read())
                    {
                        rec = reader.GetFieldValue<int>(columnNames["User_ID"]).ToString() + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Company"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Email"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Phone"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["City"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["State"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Address"]);
                        
                    }
                    //close connection
                    connection.Close();
                    //return string value for query above
                    return rec;
                }
            }
        }

        public static DataSet DataSetServicesOffered()
        {
            //setting up connection to server/open connection
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting string variable for database query
                readAllDatabaseRecords.CommandText =
                        @"select IDHS as HumanServicesProvider, IDES as EmergencyServicesProvider ,BedCount as Beds, VolunteerOpportunities as Volunteers,   
						ServiceType as Services, Description as Info, CriteriaForService as Requirements, Location as Address from dbo.ServicesOffered";

                readAllDatabaseRecords.CommandType = CommandType.Text;

                //setting adapter for table and fill dataset
                SqlDataAdapter testAdapter = new SqlDataAdapter();
                DataSet testSet = new DataSet("ServicesOffered");
                //testAdapter.TableMappings.Add(new DataTableMapping("dbo.HumanServicesProvider", "HumanServicesProvider"));
                testAdapter.SelectCommand = readAllDatabaseRecords;
                testAdapter.Fill(testSet);

                //close connection
                connection.Close();

                //return dataset
                return testSet;

            }
        }

        public static String ReadServicesOffered()
        {
            //setting up connection string to server
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting up sql string for query
                readAllDatabaseRecords.CommandText =
                    @"select ID as User_ID, BedCount as Bed, VolunteerOpportunities as Volunteers, ServiceType as Type,   
                	Description as Info, CriteriaForService As Criteria, Location as Address from ServicesOffered";


                // The using block for handling the IO
                using (SqlDataReader reader = readAllDatabaseRecords.ExecuteReader())
                {
                    string rec = "";

                    // a dictionary to store the ordinal positions of each column in the table.
                    var columnNames = new Dictionary<string, int>();

                    //building the above dictionary
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    //getting the data from query above
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
                    //close connection
                    connection.Close();
                    //return string value for query above
                    return rec;
                }
            }
        }


        static public void AddNewUser(string firstName, string lastName, string password, string newpass, string useraccess, int hid, int eid)
        {
            //setting up connection string to server
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand insertNewUser = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting up sql string for query insert
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
            //setting up connection string to server
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand updateBed = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting up sql string for query update
                updateBed.CommandText = "update ServicesOffered set BedCount = @bedcount where ID = @id;";
                updateBed.Parameters.Add(new SqlParameter("bedcount", count));
                updateBed.Parameters.Add(new SqlParameter("id", id));
                updateBed.ExecuteNonQuery();
            }
        }


        static public void UpdateVolunteers(int id, int count)
        {
            //setting up connection string to server
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand updateVols = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting up sql string for query update
                updateVols.CommandText = "update ServicesOffered set VolunteerOpportunities = @volunteers where ID = @id;";
                updateVols.Parameters.Add(new SqlParameter("volunteers", count));
                updateVols.Parameters.Add(new SqlParameter("id", id));
                updateVols.ExecuteNonQuery();
            }
        }


        static public void DeleteAUser(int id)
        {
            //setting up connection string to server
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand deleteProf = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting up sql string for query delete
                deleteProf.CommandText = "delete from Users where ID = @userID;";
                deleteProf.Parameters.Add(new SqlParameter("userID", id));
                deleteProf.ExecuteNonQuery();
            }
        }

        public static DataSet TwoTableDataSetHumanOffered()
        {

            //setting up connection to server/open connection
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();

            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting string variable for database query
                readAllDatabaseRecords.CommandText =
                                @"select CompanyName as Name, HPhone as Phone, BedCount as Beds, VolunteerOpportunities as NeededVolunteers,
						        ServiceType as Services, Description as Info, CriteriaForService as Requirements, Location
						        from dbo.HumanServicesProvider
						        inner join dbo.ServicesOffered
						        on dbo.HumanServicesProvider.ID = dbo.ServicesOffered.IDHS";

                readAllDatabaseRecords.CommandType = CommandType.Text;

                //setting adapter for table and fill dataset
                SqlDataAdapter testAdapter = new SqlDataAdapter();
                DataSet testSet = new DataSet("HumanServicesProvider");
                //testAdapter.TableMappings.Add(new DataTableMapping("dbo.HumanServicesProvider", "HumanServicesProvider"));
                testAdapter.SelectCommand = readAllDatabaseRecords;
                testAdapter.Fill(testSet);

                //close connection
                connection.Close();

                //return dataset
                return testSet;

            }
        }

        public static DataSet TwoTableDataSetEmergencyOffered()
        {

            //setting up connection to server/open connection
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();


            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting string variable for database query
                readAllDatabaseRecords.CommandText =
                        @"select CompanyName as Name, EPhone as Phone, BedCount as Beds, VolunteerOpportunities as NeededVolunteers,
						ServiceType as Services, Description as Info, CriteriaForService as Requirements, Location
						from dbo.EmergencyServicesProvider
						inner join dbo.ServicesOffered
						on dbo.EmergencyServicesProvider.ID = dbo.ServicesOffered.IDHS";

                readAllDatabaseRecords.CommandType = CommandType.Text;

                //setting adapter for table and fill dataset
                SqlDataAdapter testAdapter = new SqlDataAdapter();
                DataSet testSet = new DataSet("EmergencyServicesProvider");
                testAdapter.SelectCommand = readAllDatabaseRecords;
                testAdapter.Fill(testSet);

                //close connection
                connection.Close();

                //return dataset
                return testSet;

            }
        }

        public static DataSet AllUserDataSet()
        {

            //setting up connection to server/open connection
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();


            using (SqlCommand readAllDatabaseRecords = connection.CreateCommand())
            {
                //checking connection by checking server version
                System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //setting string variable for database query
                readAllDatabaseRecords.CommandText =
                                @"select FirstName, LastName, UserAccess, NewPass
								from dbo.HumanServicesProvider
								inner join	dbo.Users
								on dbo.HumanServicesProvider.ID = dbo.Users.HID
								inner join dbo.EmergencyServicesProvider
								on dbo.Users.EID = dbo.EmergencyServicesProvider.ID
								order by UserAccess asc";

                readAllDatabaseRecords.CommandType = CommandType.Text;

                //setting adapter for table and fill dataset
                SqlDataAdapter testAdapter = new SqlDataAdapter();
                DataSet testSet = new DataSet("Users");
                testAdapter.SelectCommand = readAllDatabaseRecords;
                testAdapter.Fill(testSet);

                //close connection
                connection.Close();

                //return dataset 
                return testSet;

            }
        }












        //********************These are the notes from after class on datasets********************
        //********************This code to be removed before final submission*********************
        /*  
        public static DataSet ReadHumanServices()
        {

            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=DESKTOP-ADO4RHU\\CHRIS;Database=Project2;Trusted_Connection = True;";
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
                for (var k = 0; k < searchSubset.Length; k++)
                {
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
        }*/
        
    }
}
