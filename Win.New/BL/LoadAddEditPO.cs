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
                item.PODetails = item.PODetails.OrderBy(x => x.ItemNo).ToList();
                //if (item.PODetails.Count < 15)
                //{
                //    var counter = 15 - item.PODetails.Count;
                //    for (var i = 1; i <= counter; i++)
                //    {
                //        item.PODetails.Add(new PODetails());
                //    }
                //}


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
                if (!User.UserInAction("can delete"))
                    return;
                if (uCPO.POGridView.GetFocusedRow() is PurchaseOrders item)
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork(false, false);
                    TrashbinHelper trashbinHelper = new TrashbinHelper();
                    item = unitOfWork.PurchaseOrdersRepo.Find(x => x.Id == item.Id, false, includeProperties: "PODetails");
                    trashbinHelper.Delete(item, "PurchaseOrders", item.Description, User.UserId, new StaticSettings().OfficeId);
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
            frm.btnAddItems.Click += BtnAddItems_Click;
            frm.btnSelectItemFromAbstract.Click += BtnSelectItemFromAbstract_Click;
            frm.btnCreateObR.Click += BtnCreateObR_Click;
        }

        private void BtnCreateObR_Click(object sender, EventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (this.purchaseOrders.Obligations.Any())
                    if (MessageBox.Show("OBR is already created!,Do you want to create new OBR?", "OBR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                var staticSttings = new StaticSettings();
                var item = unitOfWork.PurchaseOrdersRepo.Find(x => x.Id == purchaseOrders.Id);
                var ob = unitOfWork.ObligationsRepo.Fetch(m => m.OfficeId == staticSttings.OfficeId).OrderByDescending(x => x.Id).FirstOrDefault();
                var payee = unitOfWork.PayeesRepo.Find(x => x.Name == item.Supplier);
                var obr = new Obligations()
                {
                    ControlNo = IdHelper.OfficeControlNo(ob?.ControlNo, staticSttings.OfficeId, "ObR", "Obligations"),
                    Year = staticSttings.Year,
                    Date = DateTime.Now,
                    Description = "",
                    OfficeId = new StaticSettings().OfficeId,
                    PayeeId = payee?.Id,
                    PayeeAddress = payee?.Address,
                    PayeeOffice = payee?.Office,
                    FT = new StaticSettings().FT,
                    ORDetails = new List<ORDetails>()
                     {
                          new ORDetails()
                          {
                              Amount=item.TotalAmount,
                              AppropriationId=item.PurchaseRequests.AppropriationId ,
                              Particulars = ""
                          }
                     },
                    CreatedBy = User.UserId,
                    POId = this.purchaseOrders.Id
                };
                unitOfWork.ObligationsRepo.Insert(obr);
                unitOfWork.Save();
                var main = Application.OpenForms["Main"] as Main;
                var uc = new OB.ucObligations() { Dock = DockStyle.Fill };
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(uc);
                uc.txtSearch.Text = obr.ControlNo;
                uc.loadObligations.Search(obr.ControlNo);
                uc.loadObligations.EditObR(obr);
                frm.Close();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void BtnSelectItemFromAbstract_Click(object sender, EventArgs e)
        {
            purchaseOrders = new UnitOfWork().PurchaseOrdersRepo.Find(x => x.Id == purchaseOrders.Id);
            frmSelectedItem frms = new frmSelectedItem(purchaseOrders.PurchaseRequests, this.purchaseOrders, frm);
            frms.ShowDialog();
        }

        private void BtnAddItems_Click(object sender, EventArgs e)
        {
            //frmPriceQuotations frmPriceQuotations = new frmPriceQuotations(this.purchaseOrders.PurchaseRequests, this.purchaseOrders.Id);
            //frmPriceQuotations.ShowDialog();
            UnitOfWork unitOfWork = new UnitOfWork();
            try
            {

                if (unitOfWork.PODetailsRepo.Fetch(x => x.POId == purchaseOrders.Id).Any())
                {

                    if (MessageBox.Show("Purchase Detail has already item do you want to add this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                var itemNo = 1;
                var item = unitOfWork.PurchaseRequestsRepo.Find(x => x.Id == purchaseOrders.PRId)?.AOQ.FirstOrDefault();
                if (item == null)
                {
                    MessageBox.Show("No Abstract created!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (var i in item.AOQDetails)
                {
                    unitOfWork.PODetailsRepo.Insert(new PODetails()
                    {
                        Category = i.Category ?? "",
                        Cost = i.Cost ?? 0,
                        Item = i.Item,
                        ItemNo = i.ItemNo ?? itemNo,
                        POId = purchaseOrders.Id,
                        Quantity = i.Quantity ?? 1,
                        UOM = i.UOM ?? "",
                        TotalAmount = (i.Cost ?? 0) * (i.Quantity ?? 1)
                    });
                    itemNo++;

                }
                unitOfWork.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //var item = unitOfWork.PurchaseOrdersRepo.Find(m => m.Id == purchaseOrders.Id);
            frm.ItemsGridControl.DataSource = new BindingList<PODetails>(unitOfWork.PurchaseOrdersRepo.Find(x => x.Id == purchaseOrders.Id).PODetails.ToList());




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
                    frm.ItemsGridControl.DataSource = new BindingList<PODetails>(unitOfWork.PurchaseOrdersRepo.Find(x => x.Id == purchaseOrders.Id).PODetails.ToList());
                    //Detail();
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
                    {
                        item.Category = item.Category ?? "";
                        unitOfWork.PODetailsRepo.Insert(item);
                    }
                    else
                    {
                        var res = unitOfWork.PODetailsRepo.Find(x => x.Id == item.Id);
                        res.Category = item.Category ?? "";
                        res.Cost = item.Cost;
                        res.Item = item.Item;
                        res.ItemNo = item.ItemNo;
                        res.Quantity = item.Quantity;
                        res.TotalAmount = item.TotalAmount;
                        res.UOM = item.UOM;
                    }

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
            {
                return;
            }
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
                po.TotalAmount = po.PODetails.Sum(x => x.TotalAmount);
                po.Description = frm.txtDescription.Text;
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
                StaticSettings staticSettings = new StaticSettings();
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
                frm.txtDescription.Text = item.Description ?? item.PurchaseRequests?.Description;
                frm.cboSuppliers.EditValue = item.Supplier;
                frm.txtAddress.Text = item.SupplierAddress;
                frm.ItemsGridControl.DataSource = new BindingList<PODetails>(item.PODetails.ToList());
                frm.obligationsBindingSource.DataSource = unitOfWork.ObligationsRepo.Get(x =>
                    x.OfficeId == staticSettings.OfficeId && x.FT == staticSettings.FT && x.POId == null &&
                    x.PRNo == null);
                frm.cboOBR.EditValue = item.Obligations.FirstOrDefault()?.Id;
                if (item.Obligations.Any())
                {
                    frm.cboOBR.Enabled = false;
                }


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
                        Description = unitOfWork.PurchaseRequestsRepo.Find(x => x.Id == purchaseOrders.PRId)?.Description,
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
            try
            {
                if (isClosed)
                    return;
                if (methodType == MethodType.Edit)
                    return;

                if (MessageBox.Show("Do you want to close this?", "Close", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                {
                    eventArgs.Cancel = true;
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PurchaseOrdersRepo.Delete(m => m.Id == purchaseOrders.Id);
                unitOfWork.Save();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public void LoadPayees()
        {
            frm.cboSuppliers.Properties.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().PayeesRepo.Fetch()
            };
        }
    }
}
