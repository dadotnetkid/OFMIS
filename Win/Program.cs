using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using Helpers;
using Models.Repository;
using Win.Properties;
using Win.Tmplts;

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
            const string appName = "Win";
            bool createdNew;

           var mutex = new Mutex(true, appName, out createdNew);
           if (!createdNew)
           {
               //app is already running! Exiting the application  
               return;
           }
            Application.Run(new Main(param));
            //Application.Run(new frmConfirmationTemplates(new Models.Templates(), Models.MethodType.Add));
        }
    }
}
