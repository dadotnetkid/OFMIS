using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using Helpers;
using Models;
using Models.Repository;
using Win.BL;

namespace Win.AOQ
{
    public partial class frmAddEditAOQ : DevExpress.XtraEditors.XtraForm, ITransactions<Models.AOQ>
    {
        private Models.AOQ abstractofQuotation;
        private bool isClosed;

        public frmAddEditAOQ(Models.AOQ aOQ, MethodType methodType)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.abstractofQuotation = aOQ;
            Init();
            btnDeleteItemRepo.ButtonClick += BtnDeleteItemRepo_ButtonClick;
        }

        private void BtnDeleteItemRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (ItemsGridView.GetFocusedRow() is AOQDetails item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.AOQDetailsRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    ItemsGridControl.DataSource =
                        new BindingList<AOQDetails>(unitOfWork.AOQDetailsRepo.Get(x => x.AOQId == item.AOQId));
                }

            }
            catch (Exception exception)
            {

            }
        }

        private void btnAddPayee_Click(object sender, EventArgs e)
        {
            frmBACCommittees frm = new frmBACCommittees(abstractofQuotation);
            frm.ShowDialog();
            UnitOfWork unitOfWork = new UnitOfWork();
            var aoq = unitOfWork.AOQRepo.Find(x => x.Id == abstractofQuotation.Id);
            this.txtBACCommittees.Text = aoq.BACCommittees;
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.AOQRepo.Find(x => x.Id == abstractofQuotation.Id);

                item.Date = dtDate.DateTime;
                item.RFQNo = txtRFQ.EditValue.ToInt();
                item.NameofProject = txtNameOfProject.Text;
                item.RequisitioningOffice = txtReqOffice.Text;
                item.ABC = txtABC.Text.ToDecimal();
                item.BACChairperson = cboBACChairperson.EditValue.ToInt();
                unitOfWork.Save();
                isClosed = true;
                Close();
            }
            catch (Exception e)
            {

            }
        }

        public void Detail()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();

                this.cboCategoryRepo.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = new UnitOfWork().CategoriesRepo.Fetch()
                };
                var item = unitOfWork.AOQRepo.Find(x => x.Id == abstractofQuotation.Id);
                dtDate.EditValue = item.Date;
                txtControlNumber.EditValue = item.ControlNo;
                txtRFQ.EditValue = item.RFQNo;
                txtNameOfProject.EditValue = item.NameofProject;
                txtReqOffice.EditValue = item.RequisitioningOffice;
                txtABC.EditValue = item.ABC;
                txtHead.EditValue = item.Head;
                txtBACCommittees.EditValue = item.BACCommittees;
                ItemsGridControl.DataSource =
                    new BindingList<AOQDetails>(unitOfWork.AOQDetailsRepo.Get(x => x.AOQId == item.Id));
                cboBACChairperson.Properties.DataSource = unitOfWork.Signatories.Get(x => x.IsBacMember == true);
                cboBACChairperson.EditValue = item.BACChairperson ?? unitOfWork.Signatories.Find(x => x.IsBacMember == true)?.Id;
            }
            catch (Exception e)
            {
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
                var item = unitOfWork.AOQRepo.Fetch(m => m.OfficeId == staticSettings.OfficeId)
                    .OrderByDescending(m => m.Id).FirstOrDefault();

                abstractofQuotation = new Models.AOQ()
                {
                    Description = abstractofQuotation.Description,
                    PRId = abstractofQuotation.PRId,
                    CreatedBy = User.GetFullName(),
                    CreatedById = User.UserId,
                    Date = DateTime.Now,
                    ControlNo = IdHelper.OfficeControlNo(item?.ControlNo, staticSettings.OfficeId, "AOQ", "AOQ"),
                    RequisitioningOffice = staticSettings.OfficeName,
                    OfficeId = staticSettings.OfficeId,
                    Head = staticSettings.Head,
                    HeadPosition = staticSettings.HeadPos,
                    ABC = abstractofQuotation.ABC,
                };
                unitOfWork.AOQRepo.Insert(abstractofQuotation);
                unitOfWork.Save();
                Detail();
            }
            catch (Exception e)
            {

            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            try
            {
                if (methodType == MethodType.Edit)
                    return;

                if (this.isClosed)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.AOQRepo.Delete(x => x.Id == abstractofQuotation.Id);
                unitOfWork.Save();

            }
            catch (Exception e)
            {

            }
        }

        private void frmAddEditAOQ_Load(object sender, EventArgs e)
        {

        }

        private void frmAddEditAOQ_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ItemsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                if (e.Row is AOQDetails item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    item.AOQId = abstractofQuotation.Id;
                    item.CreatedBy = User.GetFullName();
                    item.CreatedById = User.UserId;
                    item.Cost = null;
                    item.TotalAmount = null;
                    if (item.Id == 0)
                    {
                        unitOfWork.AOQDetailsRepo.Insert(item);
                    }
                    else
                    {
                        var res = unitOfWork.AOQDetailsRepo.Find(x => x.Id == item.Id);
                        res.ItemNo = item.ItemNo;
                        res.Quantity = item.Quantity;
                        res.Category = item.Category;
                        res.Item = item.Item;
                        res.UOM = item.UOM;
                        res.Cost = null;
                    }

                    unitOfWork.Save();
                    ItemsGridControl.DataSource =
                        new BindingList<AOQDetails>(unitOfWork.AOQDetailsRepo.Get(x => x.AOQId == item.AOQId));
                }

            }
            catch (Exception exception)
            {

            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (unitOfWork.AOQDetailsRepo.Fetch(x => x.AOQId == abstractofQuotation.Id).Any())
                {

                    if (MessageBox.Show("Purchase Detail has already item do you want to add this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                var itemNo = 1;

                var item = unitOfWork.PurchaseRequestsRepo.Find(x => x.Id == abstractofQuotation.PRId)?.PriceQuotations.FirstOrDefault();
                if (item == null)
                    MessageBox.Show("No PQ available", "No PQ available", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                foreach (var i in item.PQDetails)
                {

                    var rtf = new RichEditControl();
                    //rtf.Font = new Font("Calibri", 9.5f);
                    rtf.RtfText = i.Item;
                    if (string.IsNullOrEmpty(rtf.Text))
                    {
                        RichEditDocumentServer server = new RichEditDocumentServer();
                        server.Text = i.Item;
                        i.Item = server.RtfText;
                    }

                    unitOfWork.AOQDetailsRepo.Insert(new AOQDetails()
                    {
                        Category = i.Category,
                        Cost = null,
                        Item = i.Item,
                        ItemNo = i.ItemNo ?? itemNo,
                        AOQId = abstractofQuotation.Id,
                        Quantity = i.Quantity ?? 1,
                        UOM = i.UOM,
                        TotalAmount = null
                    });
                    itemNo++;

                    unitOfWork.Save();

                }
                ItemsGridControl.DataSource =
                    new BindingList<AOQDetails>(unitOfWork.AOQDetailsRepo.Get(x => x.AOQId == abstractofQuotation.Id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ItemsGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(new Point(e.X + 300, e.Y + 450));
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            unitOfWork.AOQDetailsRepo.Insert(new AOQDetails()
            {
                AOQId = abstractofQuotation.Id
            });
            unitOfWork.Save();
            ItemsGridControl.DataSource =
                new BindingList<AOQDetails>(unitOfWork.AOQDetailsRepo.Get(x => x.AOQId == abstractofQuotation.Id));
        }
    }
}