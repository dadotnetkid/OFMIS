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
using Win.BL;

namespace Win.PO
{
    public partial class frmAddEditPO : DevExpress.XtraEditors.XtraForm
    {
        private ITransactions<PurchaseOrders> purchaseOrder;
        public frmAddEditPO(MethodType methodType, PurchaseOrders purchaseOrders)
        {
            InitializeComponent();
            purchaseOrder = new LoadAddEditPO(this, purchaseOrders) { methodType = methodType };
            purchaseOrder.Init();
        }

        private void frmAddEditPO_FormClosing(object sender, FormClosingEventArgs e)
        {
            purchaseOrder.Close(e);
        }
    }
}