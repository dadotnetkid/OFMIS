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
using Win.BL;

namespace Win.Accnts
{
    public partial class UcAccounts : DevExpress.XtraEditors.XtraUserControl, IUserControl
    {
        public override void Refresh()
        {
            var frm = Application.OpenForms["Main"] as Main;
            frm.pnlMain.Controls.Clear();
            frm.pnlMain.Controls.Add(new UcAccounts() { Dock = DockStyle.Fill });
            base.Refresh();
        }
        private LoadAppropriations loadAppropriations;

        public UcAccounts()
        {
            InitializeComponent();
            this.loadAppropriations = new LoadAppropriations(this);
            loadAppropriations.Init();
        }

        private void btnAppropriations_Click(object sender, EventArgs e)
        {
            frmAddEditAppropriation frm =
                new frmAddEditAppropriation(Models.MethodType.Add, null);
            frm.ShowDialog();
            loadAppropriations.Init();
        }

        private void UcAccounts_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadAppropriations.Search(txtSearch.Text);
        }
    }
}
