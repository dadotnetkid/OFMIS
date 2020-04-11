using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win.PO;
using Win.Rprts;

namespace Win.BL
{
    public class LoadAddEditPO : ILoad<PurchaseOrders>, ITransactions<PurchaseOrders>
    {
        private UCPO uCPO;
        private PurchaseOrders purchaseOrders;
        private PurchaseRequests purchaseRequests;
        private frmAddEditPO frm;
        private bool isClosed;

        public LoadAddEditPO(UCPO uCPO, PurchaseRequests purchaseRequests)
        {
            this.uCPO = uCPO;
            this.purchaseRequests = purchaseRequests;
            uCPO.btnNew.Click += BtnNew_Click;
            uCPO.btnDeletePQRepo.ButtonClick += BtnDeletePQRepo_ButtonClick;
            uCPO.btnEditPORepo.ButtonClick += BtnEditPORepo_ButtonClick;
            uCPO.btnPreview.Click += BtnPreview_Click;
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            if (uCPO.POGridView.GetFocusedRow() is PurchaseOrders item)
            {
                item = new UnitOfWork().PurchaseOrdersRepo.Find(m => m.Id == item.Id);
                frmReportViewer frm = new frmReportViewer(new rptPO(item)
                {
                    DataSource = new List<PurchaseOrders>() { item }
                });
                frm.ShowDialog();
            }
        }

        private void BtnEditPORepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (uCPO.POGridView.GetFocusedRow() is PurchaseOrders item)
                {

                    frmAddEditPO frm = new frmAddEditPO(MethodType.Edit, item);
                    frm.ShowDialog();
                    ((ILoad<PurchaseOrders>)this).Init();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeletePQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (uCPO.POGridView.GetFocusedRow() is PurchaseOrders item)
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.PurchaseOrdersRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    ((ILoad<PurchaseOrders>)this).Init();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public LoadAddEditPO(frmAddEditPO frm, PurchaseOrders purchaseOrders)
        {
            this.frm = frm;
            this.purchaseOrders = purchaseOrders;

            frm.cboSuppliers.EditValueChanged += CboSuppliers_EditValueChanged;
            frm.btnSave.Click += BtnSave_Click;
            frm.btnClose.Click += BtnClose_Click;
            frm.FormClosing += Frm_FormClosing;
            frm.ItemsGridView.RowUpdated += ItemsGridView_RowUpdated;
            frm.btnDeleteItemRepo.ButtonClick += BtnDeleteItemRepo_ButtonClick;
        }

        private void BtnDeleteItemRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (frm.ItemsGridView.GetFocusedRow() is PODetails item)
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.PODetailsRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    Detail();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (e.Row is PODetails item)
                {
                    item.POId = purchaseOrders.Id;
                    item.TotalAmount = item.Quantity * item.Cost;
                    if (item.Id == 0)
                        unitOfWork.PODetailsRepo.Insert(item);
                    else
                        unitOfWork.PODetailsRepo.Update(new PODetails()
                        {
                            Id = item.Id,
                            Category = item.Category,
                            Cost = item.Cost,
                            Item = item.Item,
                            ItemNo = item.ItemNo,
                            POId = item.POId,
                            Quantity = item.Quantity,
                            TotalAmount = item.TotalAmount,
                            UOM = item.UOM
                        });
                    unitOfWork.Save();
                    Detail();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (methodType == MethodType.Edit)
                return;
            if (isClosed)
                return;

            if (MessageBox.Show("Do you want to close this?", "Closing", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PurchaseOrdersRepo.Delete(m => m.Id == purchaseOrders.Id);
                unitOfWork.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            frm.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ((ITransactions<PurchaseOrders>)this).Save();
        }

        private void CboSuppliers_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender is LookUpEdit lookUpEdit)
                {
                    if (lookUpEdit.GetSelectedDataRow() is Payees payees)
                    {
                        frm.txtAddress.Text = payees.Address;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddEditPO frm = new frmAddEditPO(MethodType.Add, new PurchaseOrders() { PRId = purchaseRequests.Id });
                frm.ShowDialog();
                ((ILoad<PurchaseOrders>)this).Init();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var po = unitOfWork.PurchaseOrdersRepo.Find(m => m.Id == purchaseOrders.Id);
                if (po == null)
                    return;
                po.Supplier = frm.cboSuppliers.Text;
                po.SupplierAddress = frm.txtAddress.Text;
                unitOfWork.Save();
                this.isClosed = true;
                frm.Close();
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
                frm.cboSuppliers.Properties.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = new UnitOfWork().PayeesRepo.Fetch()
                };
                frm.cboCategoryRepo.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = new UnitOfWork().CategoriesRepo.Fetch()
                };

                var item = unitOfWork.PurchaseOrdersRepo.Find(m => m.Id == purchaseOrders.Id);
                frm.dtDate.DateTime = item.Date ?? DateTime.Now;
                frm.txtControlNumber.Text = item.ControlNo;
                frm.txtDescription.Text = item.Description;
                frm.cboSuppliers.Text = item.Supplier;
                frm.txtAddress.Text = item.SupplierAddress;
                frm.ItemsGridControl.DataSource = new BindingList<PODetails>(item.PODetails.ToList());


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ITransactions<PurchaseOrders>.Init()
        {
            try
            {
                if (methodType == MethodType.Add)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var po = unitOfWork.PurchaseOrdersRepo.Fetch().OrderByDescending(m => m.Id);
                    var id = (po.FirstOrDefault()?.Id ?? 0) + 1;
                    purchaseOrders = new PurchaseOrders()
                    {
                        Id = id,
                        PRId = purchaseOrders.PRId,
                        Date = DateTime.Now,

                        PODate = DateTime.Now,
                        ControlNo = IdHelper.OfficeControlNo(po.FirstOrDefault()?.ControlNo)
                    };
                    unitOfWork.PurchaseOrdersRepo.Insert(purchaseOrders);
                    unitOfWork.Save();
                }

                Detail();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {

        }

        void ILoad<PurchaseOrders>.Init()
        {
            try
            {
                uCPO.POGridControl.DataSource =
                    new EntityServerModeSource()
                    {
                        QueryableSource = new UnitOfWork().PurchaseOrdersRepo.Fetch(m => m.PRId == purchaseRequests.Id)
                    };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail(PurchaseOrders item)
        {
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
