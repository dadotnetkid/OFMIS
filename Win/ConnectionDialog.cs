using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.ConnectionUI;
using Win.Properties;

namespace Win
{
    public class ConnectionDialog 
    {


        public static string ShowDialog()
        {
            var cd = new DataConnectionDialog();
            DataSource.AddStandardDataSources(cd);
            cd.SelectedDataSource = DataSource.SqlDataSource;
            cd.ConnectionString = Settings.Default.ConnectionString;
            cd.SelectedDataProvider = DataProvider.SqlDataProvider;
            DataConnectionDialog.Show(cd);
            Settings.Default.ConnectionString = cd.ConnectionString;
            Settings.Default.Save();
     
            return cd.ConnectionString;
        }
    }
}
