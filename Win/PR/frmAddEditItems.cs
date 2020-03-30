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
using Win.BL;

namespace Win.PR
{
    public partial class frmAddEditItems : DevExpress.XtraEditors.XtraForm
    {
        private ITransactions<Items> loadAddEditItems;

        public frmAddEditItems(MethodType methodType, Items items)
        {
            InitializeComponent();
            this.loadAddEditItems = new LoadAddEditItems(this, items) { methodType = methodType };
            loadAddEditItems.Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            loadAddEditItems.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadAddEditItems.Close(e);
        }
    }
}