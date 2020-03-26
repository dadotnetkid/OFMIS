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

namespace Win.Accnts
{
    public partial class frmAddEditAppropriation : DevExpress.XtraEditors.XtraForm
    {
        public frmAddEditAppropriation(MethodType methodType, Appropriations item)
        {
            InitializeComponent();
            this.AddEditAppropriation = new AddEditAppropriation(this, item) { methodType = methodType };
            AddEditAppropriation.Init();
        }

        public AddEditAppropriation AddEditAppropriation { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddEditAppropriation.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditAppropriation_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddEditAppropriation.Close(e);
        }
    }
}