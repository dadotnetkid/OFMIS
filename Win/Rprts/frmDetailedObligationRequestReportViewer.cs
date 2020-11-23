using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Models.ViewModels;

namespace Win.Rprts
{
    public partial class frmDetailedObligationRequestReportViewer : DevExpress.XtraEditors.XtraForm
    {
        public frmDetailedObligationRequestReportViewer()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (cboYearList.GetSelectedDataRow() is Years item)
            {
                ObligationRequestViewModel model = new ObligationRequestViewModel();
                model.GenerateReport(vm =>
                {
                    var user = new UnitOfWork().UsersRepo.Find(x => x.Id == User.UserId);
                    vm.PreparedBy = user?.FullName;
                    vm.PreparedByPos = user?.Position;

                }, item.Year.ToInt(), new StaticSettings().OfficeId, Win.Properties.Settings.Default.FundType);
                frmReportViewer frm = new frmReportViewer(new rptDetailedObligationRequests()
                {
                    DataSource = new List<ObligationRequestViewModel>() { model }
                });
                frm.ShowDialog();
            }
        }

        private void frmDetailedObligationRequestReportViewer_Load(object sender, EventArgs e)
        {
            StaticSettings staticSettings = new StaticSettings();
            cboYearList.Properties.DataSource = new BindingList<Years>(new UnitOfWork().YearsRepo.Get(m => m.OfficeId == staticSettings.OfficeId));
        }
    }
}