using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;
using Models.ViewModels;
using Win.BL;
using Win.Rprts;

namespace Win.OB
{
    public partial class ucObligations : DevExpress.XtraEditors.XtraUserControl
    {
        private LoadObligations loadObligations;

        public ucObligations()
        {
            InitializeComponent();
            this.loadObligations = new LoadObligations(this);
            loadObligations.Init();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Add Obligations"))
                return;
            frmAddEditObligation frm = new frmAddEditObligation(MethodType.Add, null);
            frm.ShowDialog();
            loadObligations.Init();
        }

        private void ucObligations_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadObligations.Search(txtSearch.Text);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            loadObligations.Init();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (OBGridView.GetFocusedRow() is Obligations item)
            {
                frmReportViewer frm = new frmReportViewer(new rptObligationRequestPreview()
                {
                    DataSource = new UnitOfWork().ObligationsRepo.Get(m => m.Id == item.Id)
                });
                frm.ShowDialog();
            }

        }

        private void btnDVPreview_Click(object sender, EventArgs e)
        {
            if (OBGridView.GetFocusedRow() is Obligations item)
            {
                frmReportViewer frm = new frmReportViewer(new rptDV()
                {
                    DataSource = new List<DvReportViewModel>() {new  DvReportViewModel(item.Id) }
                });
                frm.ShowDialog();
            }
        }
    }
}
