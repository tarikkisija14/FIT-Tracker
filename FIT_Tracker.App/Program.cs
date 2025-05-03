using FIT_Tracker.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FIT_Tracker.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new FITContext())
            {
                db.Database.Migrate();
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmGlavna());
        }
    }
}