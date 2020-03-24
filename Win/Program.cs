using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using Models.Repository;
using Win.Properties;

namespace Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Models.DataSource.ConnectionString = Settings.Default.ConnectionString;
            Console.Write(new UnitOfWork().ObligationsRepo.Fetch().Count());
            Application.Run(new Main());
        }
    }
}
