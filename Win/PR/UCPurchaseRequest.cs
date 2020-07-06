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
using Win.BL;
using Win.OB;

namespace Win.PR
{
    public partial class UCPurchaseRequest : DevExpress.XtraEditors.XtraUserControl, IUserControl

    {
        private LoadAddEditPurchaseRequest loadAddEditPurchaseRequest;

        public override void Refresh()
        {
            var frm = Application.OpenForms["Main"] as Main;
            frm.pnlMain.Controls.Clear();
            frm.pnlMain.Controls.Add(new UCPurchaseRequest() { Dock = DockStyle.Fill });
            base.Refresh();
        }
        public UCPurchaseRequest()
        {
            InitializeComponent();
            this.loadAddEditPurchaseRequest = new LoadAddEditPurchaseRequest(this);
            ((ILoad<PurchaseRequests>)loadAddEditPurchaseRequest).Init();
        }

        private void lnkOBR_Click(object sender, EventArgs e)
        {
            if (this.PRGrid.GetFocusedRow() is PurchaseRequests item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();

                if (!unitOfWork.ObligationsRepo.Fetch(x => x.PRNo == item.Id).Any())
                {
                    MessageBox.Show("No OBR created", "OBR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Application.OpenForms["Main"] is Main frm)
                {
                    frm.pnlMain.Controls.Clear();
                    var uc = new ucObligations()
                    {
                        Dock = DockStyle.Fill
                    };
                    var obr = unitOfWork.ObligationsRepo.Find(x => x.PRNo == item.Id);
                    uc.txtSearch.Text = obr.ControlNo;
                    uc.loadObligations.Search(uc.txtSearch.Text); frm.pnlMain.Controls.Add(uc);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();
                this.PRGridControl.DataSource = new BindingList<PurchaseRequests>(unitOfWork.PurchaseRequestsRepo.Get(x => x.OfficeId == staticSettings.OfficeId && x.Description.Contains(txtSearch.Text)));
            }
            catch (Exception exception)
            {

            }
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //UnitOfWork unitOfWork = new UnitOfWork();
                //this.PRGridControl.DataSource = new BindingList<PurchaseRequests>(unitOfWork.PurchaseRequestsRepo.Get(x => x.r.Contains(txtSearch.Text)));
            }
            catch (Exception exception)
            {

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
