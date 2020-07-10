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
using Models.Repository;
using Win.BL;
using Win.OB;

namespace Win.PO
{
    public partial class frmAddEditPO : DevExpress.XtraEditors.XtraForm
    {
        private ITransactions<PurchaseOrders> purchaseOrder;
        private PurchaseOrders po;

        public frmAddEditPO(MethodType methodType, PurchaseOrders purchaseOrders)
        {
            InitializeComponent();
            this.po = purchaseOrders;
            purchaseOrder = new LoadAddEditPO(this, purchaseOrders) { methodType = methodType };
            purchaseOrder.Init();
            if (methodType == MethodType.Add)
                btnCreateObR.Enabled = false;
        }

        private void frmAddEditPO_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnAddPayee_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPayee(MethodType.Add, null);
            frm.ShowDialog();
            ((LoadAddEditPO)purchaseOrder).LoadPayees();
        }

        private void frmAddEditPO_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectItemFromAbstract_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateObR_Click(object sender, EventArgs e)
        {

        }
    }
}