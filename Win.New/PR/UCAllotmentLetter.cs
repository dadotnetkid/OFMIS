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
using Helpers;
using Models;
using Models.Repository;
using Win.BL;
using Win.Rprts;

namespace Win.PR
{
    public partial class UCAllotmentLetter : DevExpress.XtraEditors.XtraUserControl, ILoad<AllotmentLetter>
    {
        private PurchaseRequests purchaseRequests;
        private AllotmentLetter allotmentLetter;


        public UCAllotmentLetter(PurchaseRequests purchaseRequests)
        {
            InitializeComponent();
            this.purchaseRequests = purchaseRequests;
            Detail(purchaseRequests?.AllotmentLetter.FirstOrDefault());

        }

        public void Init()
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail(AllotmentLetter item)
        {
            try
            {
                btnDelete.Enabled = true;
                btnPreview.Enabled = true;
                if (item == null)
                {
                    btnNew.Text = "Add Letter";
                    btnNew.Tag = MethodType.Add;
                    btnDelete.Enabled = false;
                    btnPreview.Enabled = false;
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                item = unitOfWork.AllotmentLetterRepo.Find(x => x.Id == item.Id);
                this.dtDate.EditValue = item.DateCreated;
                this.txtAccountCode.Text = item.Appropriations.AccountCode;
                this.txtAccountName.Text = item.Appropriations.AccountName;
                this.txtReason.Text = item.Reason;
                this.txtDescription.Text = item.Letter;
                this.txtChiefOfficer.EditValue = item.HeadofDivision;
                this.txtPBO.EditValue = item.PBO;
                this.allotmentLetter = item;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditAllotmentLetter frmAddEditAllotmentLetter;
            if (btnNew.Text == "Add Letter")
                frmAddEditAllotmentLetter = new frmAddEditAllotmentLetter(purchaseRequests,
                    allotmentLetter, MethodType.Add);
            else
                frmAddEditAllotmentLetter = new frmAddEditAllotmentLetter(purchaseRequests,
                    allotmentLetter, MethodType.Edit);
            frmAddEditAllotmentLetter.ShowDialog();

            Detail(new UnitOfWork().PurchaseRequestsRepo.Find(x => x.Id == purchaseRequests.Id)?.AllotmentLetter.FirstOrDefault());
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            allotmentLetter.User = User.UserName;
            frmReportViewer frm = new frmReportViewer(new rptAllotmentLetters()
            {
                DataSource = new List<AllotmentLetter>() { allotmentLetter }
            });
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.AllotmentLetterRepo.Delete(m => m.PRId == purchaseRequests.Id);
                unitOfWork.Save();
                Detail(unitOfWork.PurchaseRequestsRepo.Find(x => x.Id == purchaseRequests.Id)?.AllotmentLetter?.FirstOrDefault());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
