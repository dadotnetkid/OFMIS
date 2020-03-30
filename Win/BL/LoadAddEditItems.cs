using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using Helpers;
using Models;
using Models.Repository;
using Win.PR;

namespace Win.BL
{
    public class LoadAddEditItems : ITransactions<Items>, ILoad<Items>
    {
        private frmAddEditItems frmAddEditItems;
        private frmItems frmItems;
        private Items items;
        private bool isClose;
        private PurchaseRequests purchaseRequests;
        public LoadAddEditItems(frmItems frmItems, Items items)
        {
            this.frmItems = frmItems;
            this.items = items;

        }
        public LoadAddEditItems(frmItems frmItems, PurchaseRequests purchaseRequests)
        {
            this.frmItems = frmItems;
            this.purchaseRequests = purchaseRequests;
        }

        public LoadAddEditItems(frmAddEditItems frmAddEditItems, Items items)
        {
            this.frmAddEditItems = frmAddEditItems;
            this.items = items;
        }


        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                var unitOfWork = new UnitOfWork();
                items = unitOfWork.ItemsRepo.Find(m => m.Id == items.Id);
                items.Cost = frmAddEditItems.txtCost.Text?.ToInt();
                items.Item = frmAddEditItems.txtItem.Text;
                items.Category = frmAddEditItems.cboCategory.Text;
                items.UOM = frmAddEditItems.cboUOM.Text;
                unitOfWork.Save();
                isClose = true;
                frmAddEditItems.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {
            items = new UnitOfWork().ItemsRepo.Find(m => m.Id == items.Id);
            frmAddEditItems.txtCost.EditValue = items.Cost;
            frmAddEditItems.txtItem.EditValue = items.Item;
            frmAddEditItems.cboCategory.EditValue = items.Category;
            frmAddEditItems.cboUOM.EditValue = items.UOM;
            frmAddEditItems.lblHeader.Text = string.IsNullOrWhiteSpace(items.Item) ? frmAddEditItems.lblHeader.Text : items.Item;
        }

        void ITransactions<Items>.Init()
        {
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.ItemsRepo.Insert(items);
                unitOfWork.Save();
                Detail();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail(Items item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            try
            {
                if (this.isClose)
                {
                    eventArgs.Cancel = true;
                    return;

                }
                if (MessageBox.Show("Do you want to close this?", "Close", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                {
                    eventArgs.Cancel = true;
                    return;
                }

                var unitOfWork = new UnitOfWork();
                unitOfWork.ItemsRepo.Delete(m => m.Id == items.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ILoad<Items>.Init()
        {
            frmItems.ItemsGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().ItemsRepo.Fetch()
            };
            frmItems.btnNew.Click += BtnNew_Click;
            frmItems.btnSubmit.Click += BtnSubmit_Click;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var pr = unitOfWork.PurchaseRequestsRepo.Find(m => m.Id == purchaseRequests.Id);
            foreach (var i in frmItems.ItemsGridView.GetSelectedRows())
            {
                if (frmItems.ItemsGridView.GetRow(i) is Items item)
                {
                    pr.PRDetails.Add(new PRDetails()
                    {
                        Category = item.Category,
                        UOM = item.UOM,
                        Item = item.Item,
                        Cost = item.Cost,

                    });
                    unitOfWork.Save();
                }
            }

    
            frmItems.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddEditItems frmAddEditItems = new frmAddEditItems(MethodType.Add, new Items() { DateCreated = DateTime.Now });
            frmAddEditItems.ShowDialog();
            ((ILoad<Items>)this).Init();
        }
    }
}
