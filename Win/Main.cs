using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models.Repository;
using Win.Accnts;
using Win.OB;
using Win.PR;
using Win.Rprts;

namespace Win
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            new frmSplashScreen().ShowDialog();
            InitializeComponent();


        }

        private void btnObligation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new ucObligations() { Dock = DockStyle.Fill });

        }

        private void Main_Load(object sender, EventArgs e)
        {
            Form frm = new frmLogin();
            frm.ShowDialog();
            var unitOfWork = new UnitOfWork();
            if (!unitOfWork.YearsRepo.Fetch().Any(x => x.IsActive == true))
            {
                MessageBox.Show("No Default Year Selected", "Default Year", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                frm = new frmYears();
                frm.ShowDialog();
            }
        }

        private void btnAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UcAccounts() { Dock = DockStyle.Fill });
        }

        private void btnYear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYears frm = new frmYears();
            frm.ShowDialog();
        }

        private void btnDefaultSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDefaultSettings frm = new frmDefaultSettings();
            frm.ShowDialog();
        }

        private void btnSignatories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSignatories frm = new frmSignatories();
            frm.ShowDialog();
        }

        private void btnORReports_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmObligationRequestReportViewer frm = new frmObligationRequestReportViewer();
            frm.ShowDialog();
        }

        private void btnDetailedobligationRequest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDetailedObligationRequestReportViewer frm = new frmDetailedObligationRequestReportViewer();
            frm.ShowDialog();
        }

        private void btnAOBReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAOBReportViewer frm = new frmAOBReportViewer();
            frm.ShowDialog();
        }

        private void btnItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmItems frm = new frmItems();
            frm.ShowDialog();
        }

        private void btnPR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCPurchaseRequest() { Dock = DockStyle.Fill });
        }
    }
}
