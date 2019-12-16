using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CareAmarillo
{
    class User
    {
        static SqlConnection connection = new SqlConnection();

        public static void SearchDataset( string wordSearched)
        {
            if ( wordSearched != null)
            {
                //connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                //connection.Open();

                //using (SqlCommand search = connection.CreateCommand())
                //{
                //    System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                //    search.CommandText = "select ..."; // haven't figure the SQL code out.


                //    connection.Close();
                //}
                var testForEmergencyServices = DatabaseProcess.DataSetHumanServices();
                var subset1 = testForEmergencyServices.Tables[0].Select("CompanyName >= " + wordSearched + 
                                                                        " or HEmail >= " + wordSearched + 
                                                                        " or HPhone >= " + wordSearched + 
                                                                        " or HCity" + wordSearched + 
                                                                        " or HState" + wordSearched +
                                                                        " or HAddress" + wordSearched);
                // Print column 0 of each returned row.
                for (int i = 0; i < subset1.Length; i++)
                {
                    Console.WriteLine(subset1[i]);
                }

                var testForHumanServices = DatabaseProcess.DataSetHumanServices();
                var subset2 = testForHumanServices.Tables[0].Select("CompanyName >= " + wordSearched +
                                                                        " or HEmail >= " + wordSearched +
                                                                        " or HPhone >= " + wordSearched +
                                                                        " or HCity" + wordSearched +
                                                                        " or HState" + wordSearched +
                                                                        " or HAddress" + wordSearched);
                // Print column 0 of each returned row.
                for (int i = 0; i < subset2.Length; i++)
                {
                    Console.WriteLine(subset2[i]);
                }


            }
        }
    }
}
