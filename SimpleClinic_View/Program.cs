using SimpleClinic_View.Appointments;
using SimpleClinic_View.MedicalRecords.ListMedicalRecods;
using SimpleClinic_View.Payments;
using SimpleClinic_View.Users;

namespace SimpleClinic_View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new frmManageUsers());
        }
    }
}