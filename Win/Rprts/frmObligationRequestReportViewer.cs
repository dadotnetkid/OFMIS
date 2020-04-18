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
using System.Data.Entity;
using Helpers;
using Models;
using Models.Repository;
using Models.ViewModels;

namespace Win.Rprts
{
    public partial class frmObligationRequestReportViewer : DevExpress.XtraEditors.XtraForm
    {
        public frmObligationRequestReportViewer()
        {
            InitializeComponent();

            cboYearList.Properties.DataSource = new BindingList<Years>(new UnitOfWork().YearsRepo.Get());
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (cboYearList.GetSelectedDataRow() is Years item)
            {
                ObligationRequestViewModel model = new ObligationRequestViewModel();
                model.GenerateReport(item.Year.ToInt(), new StaticSettings().OfficeId);
                frmReportViewer frm = new frmReportViewer(new rptObligationRequests()
                {
                    DataSource = new List<ObligationRequestViewModel>() { model }
                });
                frm.ShowDialog();
            }
        }
    }
}