using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Win
{
    public partial class frmUpdateNotification : DevExpress.XtraEditors.XtraForm
    {
        public bool updateNow = false;
        private ApplicationDeployment applicationDeployment;

        public frmUpdateNotification()
        {
            InitializeComponent();

        }

        private void btnLater_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


    }
}