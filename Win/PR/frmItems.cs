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
using System.Data.Entity;
using Models;
using Models.Repository;
using Win.BL;

namespace Win.PR
{
    public partial class frmItems : DevExpress.XtraEditors.XtraForm
    {
        private LoadAddEditItems loadAddEditItems;

        public frmItems()
        {
            InitializeComponent();
            loadAddEditItems = new LoadAddEditItems(this, new Items());
            ((ILoad<Items>)loadAddEditItems).Init();
        }

        public frmItems(PurchaseRequests item)
        {
            InitializeComponent();
            this.loadAddEditItems = new LoadAddEditItems(this, item);
            ((ILoad<Items>)loadAddEditItems).Init();

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ItemsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is Items item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var res = unitOfWork.ItemsRepo.Find(m => m.Id == item.Id);
                if (res == null)
                    return;
                res.Item = item.Item;
                res.Cost = item.Cost;
                res.Category = item.Category;
                res.UOM = item.UOM;
                unitOfWork.Save();
            }
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            loadAddEditItems.Search(txtSearch.Text);

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                ItemsGridView.Focus();
        }

        private void ItemsGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }
    }
}