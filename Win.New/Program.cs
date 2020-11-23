using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using Helpers;
using Models.Repository;
using Win.Properties;
using Win.Tmplts;
using Models;
using System.Diagnostics;

namespace Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] param)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();

            // var res = Cryptography.Decrypt("LQzNKovDgd5lrVJO1gypjDqxF4cqbri6uKOYkra19ko=");
            MachineTime.SetSystemTimeZone("Taipei Standard Time");
            MachineTime.SetFormat();
            //Application.Run(new Main(param));
            //Application.Run(new frmConfirmationTemplates(new Models.Templates(), Models.MethodType.Add));


            ModelDb db = new ModelDb();
            db.Database.Log = (s) => { Debug.WriteLine(s); };
            var res = db.Obligations.Select(x => new
            {
                TotalAmount = db.ORDetails.Sum(m=>m.Amount)
            });
            Debug.WriteLine(res.Sum(x => x.TotalAmount));
        }

        public static string URL = "https://localhost:44302"; //"http://ofmis.nuevavizcayagov.ml";
    }
}
