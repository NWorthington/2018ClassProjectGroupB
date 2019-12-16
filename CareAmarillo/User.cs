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
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();

                using (SqlCommand search = connection.CreateCommand())
                {
                    System.Diagnostics.Debug.WriteLine(connection.ServerVersion);

                    search.CommandText = "select ..."; // haven't figure the SQL code out.


                    connection.Close();
                }
            }
        }
    }
}
