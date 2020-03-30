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

        public frmAddEditPurchaseRequest(MethodType methodType, PurchaseRequests item)
        {
            InitializeComponent();
            transaction = new LoadAddEditPurchaseRequest(this, item) { methodType = methodType };
            transaction.Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            transaction.Save();
        }

        private void frmAddEditPurchaseRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            transaction.Close(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}