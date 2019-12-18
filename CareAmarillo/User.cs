using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CareAmarillo
{
    public class User
    {
        static SqlConnection connection = new SqlConnection();

        public List<string> SearchDataset( string wordSearched)
        {
            List<string> rowList = new List<string>();

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
                var testForEmergencyServices = DatabaseProcess.DataSetEmergencyServices();
                var subset1 = testForEmergencyServices.Tables[0].Select("Company >= '" + wordSearched +
                                                                        "' or Email >= '" + wordSearched +
                                                                        "' or Phone >= '" + wordSearched +
                                                                        "' or City >= '" + wordSearched +
                                                                        "' or State >= '" + wordSearched +
                                                                        "' or Address >= '" + wordSearched + "'");

                // Print column 0 of each returned row.
                for (int i = 0; i < subset1.Length; i++)
                {
                    rowList.Add(subset1[i].ToString());
                }

                var testForHumanServices = DatabaseProcess.DataSetHumanServices();
                var subset2 = testForHumanServices.Tables[0].Select("Company >= '" + wordSearched +
                                                                        "' or Email >= '" + wordSearched +
                                                                        "' or Phone >= '" + wordSearched +
                                                                        "' or City >= '" + wordSearched +
                                                                        "' or State >= '" + wordSearched +
                                                                        "' or Address >= '" + wordSearched + "'");
                // Print column 0 of each returned row.
                for (int i = 0; i < subset2.Length; i++)
                {
                    rowList.Add(subset2[i].ToString());
                }

            }
            return rowList;

        }
    }
}
