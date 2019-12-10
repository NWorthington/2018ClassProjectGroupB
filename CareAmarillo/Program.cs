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
            DatabaseProcess.ReadDataBase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            // The methods for SQL interaction.


            //DatabaseProcess.AddNewUser("Tom", "Smith", "tommy1998", "Yes", "no", 1, 3);

            //DatabaseProcess.ReadHumanServices();
            //DatabaseProcess.ReadEmergencyServices();
            //DatabaseProcess.ReadServicesOffered();
            //DatabaseProcess.UpdateBedCount(2, 3);
            //DatabaseProcess.UpdateVolunteers(2, 1);
            //DatabaseProcess.DeleteAUser(3);
            //Console.ReadKey();

        }
    }
}
