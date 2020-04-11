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
        public frmAddEditPO(MethodType methodType, PurchaseOrders purchaseOrders)
        {
            InitializeComponent();
            ITransactions<PurchaseOrders> purchaseOrder = new LoadAddEditPO(this, purchaseOrders) { methodType = methodType };
            purchaseOrder.Init();
        }
    }
}