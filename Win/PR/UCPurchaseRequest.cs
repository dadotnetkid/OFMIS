using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Win.BL;

namespace Win.PR
{
    public partial class UCPurchaseRequest : DevExpress.XtraEditors.XtraUserControl
    {
        public UCPurchaseRequest()
        {
            InitializeComponent();
            LoadAddEditPurchaseRequest loadAddEditPurchaseRequest = new LoadAddEditPurchaseRequest(this);
            ((ILoad<PurchaseRequests>)loadAddEditPurchaseRequest).Init();
        }
    }
}
