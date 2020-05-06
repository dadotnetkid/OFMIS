using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid;
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
        private List<Items> SelectedItems = new List<Items>();
        public LoadAddEditItems(frmItems frmItems, Items items)
        {
            this.frmItems = frmItems;
            this.items = items;
            frmItems.ItemsGridView.OptionsSelection.MultiSelect = false;
            frmItems.btnSubmit.Visible = false;
            frmItems.btnNew.Click += BtnNew_Click;
            frmItems.btnSubmit.Click += BtnSubmit_Click;
            frmItems.btnDeleteItemRepo.ButtonClick += BtnDeleteItemRepo_Click;

        }
        public LoadAddEditItems(frmItems frmItems, PurchaseRequests purchaseRequests)
        {
            this.frmItems = frmItems;
            this.purchaseRequests = purchaseRequests;
            frmItems.btnNew.Click += BtnNew_Click;
            frmItems.btnSubmit.Click += BtnSubmit_Click;
            frmItems.btnDeleteItemRepo.ButtonClick += BtnDeleteItemRepo_Click;
            frmItems.ItemsGridView.SelectionChanged += ItemsGridView_SelectionChanged;
        }

        private void ItemsGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (sender is GridView gridView)
            {
                var item = gridView.GetRow(e.ControllerRow) as Items;
                SelectedItems.Add(item);
                if (e.Action == CollectionChangeAction.Remove)
                    SelectedItems.RemoveAll(x => x.Id == item.Id);
            }
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
            frmAddEditItems.cboCategory.Properties.DataSource = new UnitOfWork().CategoriesRepo.Get();
            frmAddEditItems.cboUOM.Properties.DataSource = new UnitOfWork().ItemsRepo.Get().GroupBy(x => x.UOM)
                .Select(x => new { UOM = x.Key }).ToList();
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
            frmItems.ItemsGridControl.DataSource = new BindingList<Items>(new UnitOfWork().ItemsRepo.Get(m => m.Item.StartsWith(search) || m.Category.Contains(search)));
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            try
            {
                if (this.isClose)
                {
                    eventArgs.Cancel = false;
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
            frmItems.ItemsGridControl.DataSource = new BindingList<Items>(new UnitOfWork().ItemsRepo.Get());
            frmItems.txtSearch.Properties.DataSource = new UnitOfWork().ItemsRepo.Get();
        }

        private void BtnDeleteItemRepo_Click(object sender, EventArgs e)
        {
            foreach (var i in frmItems.ItemsGridView.GetSelectedRows())
            {
                if (frmItems.ItemsGridView.GetRow(i) is Items item)
                {
                    try
                    {
                        UnitOfWork unitOfWork = new UnitOfWork();
                        unitOfWork.ItemsRepo.Delete(m => m.Id == item.Id);
                        unitOfWork.Save();
                        ((ILoad<Items>)this).Init();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var pr = unitOfWork.PurchaseRequestsRepo.Find(m => m.Id == purchaseRequests.Id, includeProperties: "PRDetails");

            var count = pr.PRDetails.Count() + 1;
            foreach (var item in SelectedItems)
            {
                pr.PRDetails.Add(new PRDetails()
                {
                    Category = item.Category,
                    UOM = item.UOM,
                    Item = item.Item,
                    Cost = item.Cost,
                    Quantity = 1,
                    ItemNo = count,
                    TotalAmount = item.Cost
                });
                unitOfWork.Save();
                count++;
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
