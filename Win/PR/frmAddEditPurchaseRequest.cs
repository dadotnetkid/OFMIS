using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraEditors;
using Models;
using Win.BL;

namespace Win.PR
{
    public partial class frmAddEditPurchaseRequest : DevExpress.XtraEditors.XtraForm
    {
        private ITransactions<PurchaseRequests> transaction;
        public PurchaseRequests Item;

        public frmAddEditPurchaseRequest(MethodType methodType, PurchaseRequests item)
        {
            InitializeComponent();
            var tran = new LoadAddEditPurchaseRequest(this, item) { methodType = methodType };
            transaction = ((ITransactions<PurchaseRequests>)tran);
            transaction.Init();
            this.Item = tran.item;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            transaction.Save();
            ((LoadAddEditPurchaseRequest)transaction).isClosed = true;
            this.Close();

        }

        private void frmAddEditPurchaseRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            transaction.Close(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditPurchaseRequest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == Keys.F2.ToString())
                btnAddItems.PerformClick();
        }

        private void cboAccountCode_EditValueChanged(object sender, EventArgs e)
        {
            if (cboAccountCode.GetSelectedDataRow() is Appropriations item)
            {
                var purpose = txtPurpose.Text?.Split(new string[] { "charge" }, StringSplitOptions.None);
                txtPurpose.Text = purpose?[0]?.TrimEnd() + $" charged to {item?.AccountName} - {item?.AccountCode}";


            }

        }
    }
}