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

namespace Win.PQ
{
    public partial class UCPQ : DevExpress.XtraEditors.XtraUserControl
    {
        public UCPQ(PurchaseRequests pr)
        {
            InitializeComponent();
            ILoad<PriceQuotations> load = new LoadAddEditPQ(this, pr);
            load.Init();

        }
    }
}
