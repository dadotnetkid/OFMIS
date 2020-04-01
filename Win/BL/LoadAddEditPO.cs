using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using Models;
using Models.Repository;
using Win.PO;

namespace Win.BL
{
    public class LoadAddEditPO : ILoad<PurchaseOrders>, ITransactions<PurchaseOrders>
    {
        private UCPO uCPO;
        private PurchaseOrders purchaseOrders;
        private PurchaseRequests purchaseRequests;

        public LoadAddEditPO(UCPO uCPO, PurchaseOrders purchaseOrders)
        {
            this.uCPO = uCPO;
            this.purchaseOrders = purchaseOrders;
            uCPO.btnNew.Click += BtnNew_Click;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                
            }
        }

        public MethodType methodType { get; set; }
        public void Save()
        {

        }

        public void Detail()
        {
            throw new NotImplementedException();
        }

        void ITransactions<PurchaseOrders>.Init()
        {
            throw new NotImplementedException();
        }

        public void Close(FormClosingEventArgs eventArgs)
        {

        }

        void ILoad<PurchaseOrders>.Init()
        {
            try
            {
                uCPO.POGridControl.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = new UnitOfWork().PurchaseOrdersRepo.Fetch(m => m.PRId == purchaseOrders.PRId)
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail(PurchaseOrders item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
