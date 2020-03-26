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
using Models.Repository;
using Win.BL;

namespace Win.OB
{
    public partial class ucObligations : DevExpress.XtraEditors.XtraUserControl
    {
        private LoadObligations loadObligations;

        public ucObligations()
        {
            InitializeComponent();
            this.loadObligations = new LoadObligations(this);
            loadObligations.Init();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditObligation frm = new frmAddEditObligation(MethodType.Add, null);
            frm.ShowDialog();
            loadObligations.Init();
        }

        private void ucObligations_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadObligations.Search(txtSearch.Text);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            loadObligations.Init();
        }
    }
}
