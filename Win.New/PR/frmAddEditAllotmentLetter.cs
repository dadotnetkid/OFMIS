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
using Models;
using Models.Repository;
using Win.BL;

namespace Win.PR
{
    public partial class frmAddEditAllotmentLetter : DevExpress.XtraEditors.XtraForm, ITransactions<AllotmentLetter>
    {
        private PurchaseRequests purchaseRequests;
        private AllotmentLetter allotmentLetter;
        private bool isClosed;
        StaticSettings staticSettings = new StaticSettings();
        public frmAddEditAllotmentLetter(PurchaseRequests purchaseRequests, AllotmentLetter allotmentLetter, MethodType methodType)
        {
            InitializeComponent();
            this.purchaseRequests = purchaseRequests;
            this.methodType = methodType;
            this.allotmentLetter = allotmentLetter;
            Init();
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();

                var pbo = (txtPBO.GetSelectedDataRow() as Signatories);
                var item = unitOfWork.AllotmentLetterRepo.Find(m => m.Id == allotmentLetter.Id);

                item.AccountCode = txtAccountCode.Text;
                item.AccountName = txtAccountName.Text;
                item.AppropriationId = allotmentLetter.AppropriationId;
                item.CreatedBy = allotmentLetter.CreatedBy;
                item.DateCreated = dtDate.DateTime;
                item.HeadofDivision = staticSettings.Offices.Chief;
                item.HeadofDivisionPOS = staticSettings.Offices.ChiefPosition;
                item.PBO = pbo?.Person;
                item.PBOPos = pbo?.Position;
                item.Letter = txtDescription.Text;
                item.Reason = txtReason.Text;

                unitOfWork.Save();
                isClosed = true;
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.AllotmentLetterRepo.Find(m => m.Id == allotmentLetter.Id);
                this.txtPBO.Properties.DataSource = new BindingList<Signatories>(
                    unitOfWork.Signatories.Get(x =>
                        x.Position == "Provincial Budget Officer" || x.Position == "PBO"));
                this.dtDate.EditValue = item.DateCreated;
                this.txtAccountCode.Text = item.Appropriations?.AccountCode;
                this.txtAccountName.Text = item.Appropriations?.AccountName;
                this.txtReason.Text = item.Reason;
                this.txtDescription.Text = item.Letter;
                this.txtChiefOfficer.Text = staticSettings.Offices.Chief;
                this.txtPBO.EditValue = unitOfWork.Signatories.Find(x =>
                     x.Position == "Provincial Budget Officer" || x.Position == "PBO")?.Person;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }

                UnitOfWork unitOfWork = new UnitOfWork();
                this.allotmentLetter = new AllotmentLetter()
                {
                    PRId = purchaseRequests.Id,
                    DateCreated = DateTime.Now,
                    CreatedBy = User.GetFullName(),
                    AppropriationId = purchaseRequests.AppropriationId,
                    AccountCode = purchaseRequests.Appropriations?.AccountCode,
                    AccountName = purchaseRequests.Appropriations.AccountName,
                    Reason = "",
                    Letter =
                        $"This is to respectfully from good office the release of allotment of the {purchaseRequests.Date?.Year} {purchaseRequests.Appropriations?.AccountName} to {purchaseRequests.Date?.Year} {purchaseRequests.Appropriations?.AccountCode} amounting to {purchaseRequests.AmountToWord} {Environment.NewLine + Environment.NewLine + Environment.NewLine } Hoping for your favorable action."
                };
                unitOfWork.AllotmentLetterRepo.Insert(allotmentLetter);
                unitOfWork.Save();
                Detail();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            if (isClosed)
            {
                return;
            }
            if (methodType == MethodType.Edit)
                return;
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.AllotmentLetterRepo.Delete(m => m.Id == allotmentLetter.Id);
                unitOfWork.Save();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmAddEditAllotmentLetter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReason_EditValueChanged(object sender, EventArgs e)
        {
            this.txtDescription.Text =
                $"This is to respectfully from good office the release of allotment of the {purchaseRequests.Date?.Year} {purchaseRequests.Appropriations?.AccountName} to {purchaseRequests.Date?.Year} {purchaseRequests.Appropriations?.AccountCode} amounting to {purchaseRequests.AmountToWord} {this.txtReason.Text} {Environment.NewLine + Environment.NewLine + Environment.NewLine } Hoping for your favorable action.";
        }
    }
}