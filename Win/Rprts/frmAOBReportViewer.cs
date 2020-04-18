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
    public partial class frmAOBReportViewer : DevExpress.XtraEditors.XtraForm
    {
        public frmAOBReportViewer()
        {
            InitializeComponent();
            cboYearList.Properties.DataSource = new BindingList<Years>(new UnitOfWork().YearsRepo.Get());
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            if (cboYearList.GetSelectedDataRow() is Years item)
            {
                AOBViewModel model = new AOBViewModel();
                model.GenerateReport(item.Year.ToInt(), new StaticSettings().OfficeId);
                frmReportViewer frm = new frmReportViewer(new rptAccountOutstandingBalance()
                {
                    DataSource = new List<AOBViewModel>() { model }
                });
                frm.ShowDialog();
            }
        }
    }
}