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

namespace Win.PQ
{
    public partial class frmAddEditPQ : DevExpress.XtraEditors.XtraForm
    {
        private readonly MethodType methodType;
        ITransactions<PriceQuotations> priceQuotations;
        public frmAddEditPQ(MethodType methodType, PriceQuotations pq)
        {
            InitializeComponent();
            this.methodType = methodType;
            priceQuotations = new LoadAddEditPQ(this, pq) { methodType = methodType };
            priceQuotations.Init();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditPQ_FormClosing(object sender, FormClosingEventArgs e)
        {
            priceQuotations.Close(e);
        }
    }
}