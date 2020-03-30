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
using Win.BL;

namespace Win.PR
{
    public partial class frmItems : DevExpress.XtraEditors.XtraForm
    {
        public frmItems()
        {
            InitializeComponent();
            var loadAddEditItems = new LoadAddEditItems(this, new Items());
            ((ILoad<Items>)loadAddEditItems).Init();
        }

        public frmItems(PurchaseRequests item)
        {
            InitializeComponent();

            var loadAddEditItems = new LoadAddEditItems(this, item);
            ((ILoad<Items>)loadAddEditItems).Init();

        }
    }
}