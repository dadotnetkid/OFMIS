using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Win.Accnts;
using Win.OB;

namespace Win
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnObligation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new ucObligations() { Dock = DockStyle.Fill });

        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void btnAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UcAccounts() { Dock = DockStyle.Fill });
        }
    }
}
