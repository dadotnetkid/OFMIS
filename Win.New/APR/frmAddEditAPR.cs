using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Internal.WinApi;
using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win.BL;

namespace Win.APR
{
    public partial class frmAddEditAPR : DevExpress.XtraEditors.XtraForm, ITransactions<APRs>
    {
        private APRs aPRs;
        private bool isClosed;

        public frmAddEditAPR(MethodType methodType, APRs aPRs)
        {
            InitializeComponent();
            this.aPRs = aPRs;
            this.methodType = methodType;
            Init();
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.APRsRepo.Find(x => x.Id == aPRs.Id);
                item.Name = this.txtName.Text;
                item.Address = this.txtAddress.Text;
                item.PGSOId = this.txtPGSOfficer.EditValue?.ToInt();
                item.AccountantId = this.cboPA.EditValue?.ToInt();
                item.GovernorId = this.cboGovernor.EditValue?.ToInt();
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                isClosed = false;
                this.Close();
            }
            isClosed = true;
            this.Close();
        }

        public void Detail()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.aPRs = unitOfWork.APRsRepo.Find(x => x.Id == aPRs.Id);
                this.txtPGSOfficer.Properties.DataSource = unitOfWork.Signatories.Get();
                this.cboGovernor.Properties.DataSource = unitOfWork.Signatories.Get();
                this.cboPA.Properties.DataSource = unitOfWork.Signatories.Get(); this.txtControlNumber.EditValue = this.aPRs.ControlNo;

                this.dtDate.EditValue = this.aPRs.Date;
                this.txtPGSOfficer.EditValue = this.aPRs.PGSOId;
                this.cboPA.EditValue = this.aPRs.AccountantId;
                this.cboGovernor.EditValue = this.aPRs.GovernorId;
                this.ItemsGridControl.DataSource =
                    new BindingList<APRDetails>(unitOfWork.APRDetailsRepo.Get(x => x.APRId == this.aPRs.Id));
                this.cboUOM.DataSource = unitOfWork.ItemsRepo.Fetch().Select(x => new { x.UOM }).GroupBy(x => x.UOM)
                    .Select(x => new { Name = x.Key }).Where(x => x.Name != "" || x.Name != null).ToList();
                this.cboCategory.DataSource = unitOfWork.ItemsRepo.Fetch().Select(x => new { x.Category }).GroupBy(x => x.Category)
                    .Select(x => new { Name = x.Key }).Where(x => x.Name != "" || x.Name != null).ToList();
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
                StaticSettings staticSettings = new StaticSettings();
                var item = unitOfWork.APRsRepo.Fetch(x => x.PurchaseRequests.OfficeId == staticSettings.OfficeId).OrderByDescending(x => x.Id).FirstOrDefault();

                this.aPRs = new APRs()
                {
                    PRId = aPRs.PRId,
                    Date = DateTime.Now,
                    CreatedBy = User.UserId,
                    DateCreated = DateTime.Now,
                    ModifiedBy = User.UserId,
                    DateModified = DateTime.Now,
                    ControlNo = IdHelper.OfficeControlNo(item?.ControlNo, staticSettings.OfficeId,"APR", "APRs"),
                    GovernorId = unitOfWork.Signatories.Find(x => x.Position == "Governor")?.Id,
                    AccountantId = unitOfWork.Signatories.Find(x => x.Position == "Provincial Accountant")?.Id,
                    PGSOId = unitOfWork.Signatories.Find(x => x.Position == "Provincial General Services Officer")?.Id
                };
                unitOfWork.APRsRepo.Insert(this.aPRs);
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
            if (this.isClosed || methodType == MethodType.Edit)
                return;
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.APRsRepo.Delete(x => x.Id == aPRs.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddEditAPR_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close(e);
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void txtPGSOfficer_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteItemRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (ItemsGridView.GetFocusedRow() is APRDetails item)
            {
                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.APRDetailsRepo.Delete(x => x.Id == item.Id);
                unitOfWork.Save();
                var counter=1;
                foreach (var i in unitOfWork.APRDetailsRepo.Get(x => x.APRId == this.aPRs.Id))
                {
                    i.ItemNo = counter;
                    counter++;
                }
                unitOfWork.Save();
                    ItemsGridControl.DataSource =
                        new BindingList<APRDetails>(unitOfWork.APRDetailsRepo.Get(x => x.APRId == this.aPRs.Id));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ItemsGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (ItemsGridView.GetRow(e.RowHandle) is APRDetails item)
            {
                item.TotalAmount = (item.Quantity ?? 1) * (item.Cost ?? 0);

            }
        }

        private void ItemsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is APRDetails item)
            {
                try
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    item.APRId = this.aPRs.Id;
                    if (item.Id == 0)
                        unitOfWork.APRDetailsRepo.Insert(item);
                    else
                    {
                        var res = unitOfWork.APRDetailsRepo.Find(x => x.Id == item.Id);
                        res.Item = item.Item;
                        res.ItemNo = item.ItemNo;
                        res.Quantity = item.Quantity;
                        res.Category = item.Category;
                        res.UOM = item.UOM;
                        res.Cost = item.Cost;
                        res.TotalAmount = item.TotalAmount;
                    }
                    unitOfWork.Save();
                    ItemsGridControl.DataSource =
                        new BindingList<APRDetails>(unitOfWork.APRDetailsRepo.Get(x => x.APRId == this.aPRs.Id));
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }

            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to add item from PQ?", "Add item from PQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var pq = unitOfWork.PriceQuotationsRepo.Find(x => x.PRId == this.aPRs.PRId);
                if (pq != null)
                {
                    var counter = unitOfWork.APRDetailsRepo.Fetch(x => x.APRId == aPRs.Id).Count() + 1;
                    foreach (var i in pq.PQDetails)
                    {
                        unitOfWork.APRDetailsRepo.Insert(new APRDetails()
                        {
                            APRId = this.aPRs.Id,
                            Item = i.Item,
                            ItemNo = counter,
                            Quantity = i.Quantity,
                            UOM = i.UOM,
                            Cost = i.Cost,
                            Category = i.Category,
                            TotalAmount=(i.Quantity??1)*(i.Cost)
                        });
                        counter++;
                    }

                    unitOfWork.Save();
                }
                ItemsGridControl.DataSource =
                    new BindingList<APRDetails>(unitOfWork.APRDetailsRepo.Get(x => x.APRId == this.aPRs.Id));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}