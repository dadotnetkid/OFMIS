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
    public partial class UCPurchaseRequest : DevExpress.XtraEditors.XtraUserControl, IUserControl

    {
        private LoadAddEditPurchaseRequest loadAddEditPurchaseRequest;

        public override void Refresh()
        {
            var frm = Application.OpenForms["Main"] as Main;
            frm.pnlMain.Controls.Clear();
            frm.pnlMain.Controls.Add(new UCPurchaseRequest() { Dock = DockStyle.Fill });
            base.Refresh();
        }
        public UCPurchaseRequest()
        {
            InitializeComponent();
            this.loadAddEditPurchaseRequest = new LoadAddEditPurchaseRequest(this);
            ((ILoad<PurchaseRequests>)loadAddEditPurchaseRequest).Init();
        }
    }
}
