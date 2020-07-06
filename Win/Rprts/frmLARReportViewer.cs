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
    public partial class frmLARReportViewer : DevExpress.XtraEditors.XtraForm
    {
        public frmLARReportViewer()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            cboYearList.Properties.DataSource = new BindingList<Years>(new UnitOfWork().YearsRepo.Get());
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            if (cboYearList.GetSelectedDataRow() is Years item)
            {
                /*  AOBViewModel model = new AOBViewModel();
                  model.GenerateReport(item.Year.ToInt(), new StaticSettings().OfficeId);
                  frmReportViewer frm = new frmReportViewer(new rptAccountOutstandingBalance()
                  {
                      DataSource = new List<AOBViewModel>() { model }
                  });
                  frm.ShowDialog();*/
                var vm = new LARViewModel()
                {
                    OfficeId = new StaticSettings().OfficeId,
                    Year = item.Year.ToInt()
                };
                vm.Generate();
                frmReportViewer frm = new frmReportViewer(new rptLAR()
                {
                    DataSource = new List<LARViewModel>() { vm }
                });
                frm.ShowDialog();
            }
        }
    }
}