using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CareAmarillo
{
    class Provider
    {
        static SqlConnection connection = new SqlConnection();
        

        static public void UpdateEmail(Char serviceType, int ID, string newEmail)
        {
            if (serviceType == 'E')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update EmergencyServicesProvider set EEmail = @Email where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("Email", newEmail));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else if (serviceType == 'H')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update HumanServicesProvider set HEmail = @Email where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("Email", newEmail));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else
            {

            }
        }

        static public void UpdatePhone(Char serviceType, int ID, String newNumber)
        {
            if (serviceType == 'E')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update EmergencyServicesProvider set EPhone = @Phone where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("Phone", newNumber));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else if (serviceType == 'H')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update HumanServicesProvider set HPhone = @Phone where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("Phone", newNumber));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else
            {

            }
        }

        static public void UpdateCity(Char serviceType, String newCity, int ID)
        {
            if (serviceType == 'E')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update EmergencyServicesProvider set ECity = @City where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("City", newCity));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else if (serviceType == 'H')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update HumanServicesProvider set HCity = @City where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("City", newCity));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else
            {

            }
        }

        static public void UpdateState(Char serviceType, String newState, int ID)
        {
            if (serviceType == 'E')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update EmergencyServicesProvider set EState = @State where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("State", newState));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else if (serviceType == 'H')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update HumanServicesProvider set HState = @State where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("State", newState));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else
            {

            }
        }

        static public void UpdateAddress(Char serviceType, String newAddress, int ID)
        {
            if (serviceType == 'E')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update EmergencyServicesProvider set EAddress = @Address where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("Address", newAddress));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else if (serviceType == 'H')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update HumanServicesProvider set HAddress = @Address where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("Address", newAddress));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else
            {

            }
        }

        static public void UpdateCompanyName(Char serviceType,  String newCompanyName, int ID)
        {
            if (serviceType == 'E')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update EmergencyServicesProvider set CompanyName = @CompanyName where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("CompanyName", newCompanyName));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else if (serviceType == 'H')
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
                connection.Open();
                using (SqlCommand update = connection.CreateCommand())
                {
                    update.CommandText = "update HumanServicesProvider set CompanyName = @CompanyName where ID = @ID;";
                    update.Parameters.Add(new SqlParameter("CompanyName", newCompanyName));
                    update.Parameters.Add(new SqlParameter("ID", ID));
                    update.ExecuteNonQuery();
                }
            }
            else
            {

            }
        }

        static public void UpdateVolunteerPositions(String newVolunteerPositions, int ID)
        {
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            using (SqlCommand update = connection.CreateCommand())
            {
                update.CommandText = "update ServicesOffered set  = @Opportunities where ID = @ID;";
                update.Parameters.Add(new SqlParameter("Opportunities", newVolunteerPositions));
                update.Parameters.Add(new SqlParameter("ID", ID));
                update.ExecuteNonQuery();
            }
        }

        static public void UpdateRequirements(String newRequirements, int ID)
        {
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            using (SqlCommand update = connection.CreateCommand())
            {
                update.CommandText = "update ServicesOffered set CriteriaForService = @Criteria where ID = @ID;";
                update.Parameters.Add(new SqlParameter("Criteria", newRequirements));
                update.Parameters.Add(new SqlParameter("ID", ID));
                update.ExecuteNonQuery();
            }
        }

        static public void UpdateServiceType(String newServiceType, int ID)
        {
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            using (SqlCommand update = connection.CreateCommand())
            {
                update.CommandText = "update ServicesOffered set ServiceType = @ServiceType where ID = @ID;";
                update.Parameters.Add(new SqlParameter("ServiceType", newServiceType));
                update.Parameters.Add(new SqlParameter("ID", ID));
                update.ExecuteNonQuery();
            }
        }

        static public void UpdateDescription(String newDescription, int ID)
        {
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            connection.Open();
            using (SqlCommand update = connection.CreateCommand())
            {
                update.CommandText = "update ServicesOffered set Description = @Description where ID = @ID;";
                update.Parameters.Add(new SqlParameter("Description", newDescription));
                update.Parameters.Add(new SqlParameter("ID", ID));
                update.ExecuteNonQuery();
            }
        }

    }
}
