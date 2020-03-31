using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using Models;
using Models.Repository;
using Win.PQ;

namespace Win.BL
{
    public class LoadAddEditPQ : ILoad<PriceQuotations>, ITransactions<PriceQuotations>
    {
        private UCPQ uCPQ;
        private PurchaseRequests pr;
        private frmAddEditPQ frmAddEditPQ;
        private PriceQuotations priceQuotations;
        private bool isClosed;

        public LoadAddEditPQ(UCPQ uCPQ, PurchaseRequests purchaseRequests)
        {
            this.uCPQ = uCPQ;
            this.pr = purchaseRequests;
            uCPQ.btnDeletePQRepo.ButtonClick += BtnDeletePQRepo_ButtonClick;
            uCPQ.btnEditPQRepo.ButtonClick += BtnEditPQRepo_ButtonClick;
            uCPQ.btnNew.Click += BtnNew_Click;

        }
        public LoadAddEditPQ(frmAddEditPQ frmAddEditPQ, PriceQuotations priceQuotations)
        {
            this.frmAddEditPQ = frmAddEditPQ;
            this.priceQuotations = priceQuotations;
            frmAddEditPQ.btnSave.Click += BtnSave_Click;
            frmAddEditPQ.btnAddItems.Click += BtnAddItems_Click;
            frmAddEditPQ.btnDeleteItemRepo.ButtonClick += BtnDeleteItemRepo_ButtonClick;
            frmAddEditPQ.ItemsGridView.RowUpdated += ItemsGridView_RowUpdated;
        }

        private void BtnDeleteItemRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmAddEditPQ.ItemsGridView.GetFocusedRow() is PQDetails item)
            {
                try
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.PQDetailsRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    frmAddEditPQ.ItemsGridControl.DataSource =
                        new BindingList<PQDetails>(new UnitOfWork().PQDetailsRepo.Get(m => m.PQId == priceQuotations.Id));
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAddItems_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var res = unitOfWork.PRDetailsRepo.Get(m => m.PRId == priceQuotations.PRId);
            foreach (var item in res)
            {
                unitOfWork.PQDetailsRepo.Insert(new PQDetails()
                {
                    PQId = priceQuotations.Id,
                    Item = item.Item,
                    ItemNo = item.ItemNo,
                    Category = item.Category,
                    Cost = item.Cost,
                    Quantity = item.Quantity,
                    TotalAmount = item.TotalAmount,
                    UOM = item.UOM,
                });
                unitOfWork.Save();
            }
            frmAddEditPQ.ItemsGridControl.DataSource =
                new BindingList<PQDetails>(new UnitOfWork().PQDetailsRepo.Get(m => m.PQId == priceQuotations.Id));
        }

        private void ItemsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (e.Row is PQDetails item)
                {
                    item.TotalAmount = (item.Quantity ?? 0) * (item.Cost ?? 0);
                    if (item.Id == 0)
                        unitOfWork.PQDetailsRepo.Insert(item);
                    else
                    {
                        item = new PQDetails()
                        {
                            PQId = item.PQId,
                            Item = item.Item,
                            ItemNo = item.ItemNo,
                            Category = item.Category,
                            Cost = item.Cost,
                            Quantity = item.Quantity,
                            TotalAmount = item.TotalAmount,
                            UOM = item.UOM,
                            Id = item.Id
                        };
                        unitOfWork.PQDetailsRepo.Update(item);
                   
                    }
                    unitOfWork.Save();
                    frmAddEditPQ.ItemsGridControl.DataSource =
                        new BindingList<PQDetails>(new UnitOfWork().PQDetailsRepo.Get(m => m.PQId == item.PQId));
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddEditPQ frm = new frmAddEditPQ(MethodType.Add, new PriceQuotations() { PRId = pr.Id });
            frm.ShowDialog();
            ((ILoad<PriceQuotations>)this).Init();
        }


        private void BtnEditPQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uCPQ.PQGridView.GetFocusedRow() is PriceQuotations pq)
            {
                frmAddEditPQ frm = new frmAddEditPQ(MethodType.Edit, pq);
                frm.ShowDialog();
                ((ILoad<PriceQuotations>)this).Init();
            }
        }

        private void BtnDeletePQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (uCPQ.PQGridView.GetFocusedRow() is PriceQuotations pq)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.PriceQuotationsRepo.Delete(m => m.Id == pq.Id);
                    unitOfWork.Save();
                    ((ILoad<PriceQuotations>)this).Init();
                }

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
                //this.frmAddEditPQ.dtDate.EditValue
                var unitOfWork = new UnitOfWork();
                var pq = unitOfWork.PriceQuotationsRepo.Find(m => m.Id == priceQuotations.Id);
                pq.Date = frmAddEditPQ.dtDate.DateTime;
                pq.ControlNo = frmAddEditPQ.txtControlNumber.Text;
                pq.Description = frmAddEditPQ.txtDescription.Text;
                pq.PGSOfficer = frmAddEditPQ.txtPGSOfficer.Text;
                pq.Position = frmAddEditPQ.txtPGSOPosition.Text;
                unitOfWork.Save();
                this.isClosed = true;
                frmAddEditPQ.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {
            priceQuotations = new UnitOfWork().PriceQuotationsRepo.Find(m => m.Id == priceQuotations.Id);
            if (priceQuotations == null) return;

            frmAddEditPQ.dtDate.EditValue = priceQuotations.Date ?? DateTime.Now;
            frmAddEditPQ.txtControlNumber.Text = priceQuotations.ControlNo;
            frmAddEditPQ.txtDescription.Text = priceQuotations.Description;
            frmAddEditPQ.txtPGSOfficer.Text = string.IsNullOrEmpty(priceQuotations.PGSOfficer) ? new StaticSettings().PGSO : priceQuotations.PGSOfficer;
            frmAddEditPQ.txtPGSOPosition.Text = string.IsNullOrEmpty(priceQuotations.Position) ? new StaticSettings().PGSOPosition : priceQuotations.Position;
            frmAddEditPQ.ItemsGridControl.DataSource =
                new BindingList<PQDetails>(new UnitOfWork().PQDetailsRepo.Get(m => m.PQId == priceQuotations.Id));
        }

        void ITransactions<PriceQuotations>.Init()
        {
            try
            {
                if (methodType == MethodType.Add)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var id = (unitOfWork.PriceQuotationsRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
                    var controlNo = DateTime.Now.ToString("yyyy-MM-") + id.ToString("0000");
                    priceQuotations = new PriceQuotations()
                    {
                        Id = id,
                        PRId = priceQuotations.PRId,
                        ControlNo = controlNo,

                    };
                    unitOfWork.PriceQuotationsRepo.Insert(priceQuotations);
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
                if (methodType == MethodType.Edit || isClosed)
                    return;

                if (MessageBox.Show("Do you want to close this?", "close", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                {
                    eventArgs.Cancel = true;
                    return;
                }

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PriceQuotationsRepo.Delete(m => m.Id == priceQuotations.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ILoad<PriceQuotations>.Init()
        {
            try
            {
                uCPQ.PQGridControl.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = new UnitOfWork().PriceQuotationsRepo.Fetch(m => m.PRId == pr.Id)
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail(PriceQuotations item)
        {

        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
