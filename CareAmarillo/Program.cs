using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CareAmarillo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 



        [STAThread]
        static void Main()
        {

            //calling methods with string value returned
            //DatabaseProcess.ReadDataBase();
            //DatabaseProcess.ReadHumanServices();
            //DatabaseProcess.ReadEmergencyServices();
            //DatabaseProcess.ReadServicesOffered();

            //calling methods to pass in updated info (ID, count)
            //DatabaseProcess.UpdateBedCount(1, 7);
            //DatabaseProcess.UpdateVolunteers(1, 7);

            //calling method to delete user by (ID)
            //DatabaseProcess.DeleteAUser(3);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCareLogin());
            //FormUniSearch

            // The methods for SQL interaction.


            //DatabaseProcess.AddNewUser("Tom", "Smith", "tommy1998", "Yes", "no", 1, 3);
            //Console.ReadKey();

        }
    }
}
