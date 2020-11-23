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
using Models.Repository;
using Win.PR;
using Models;
using Win.PO;

namespace Win.OB
{
    public partial class frmPrompPR : DevExpress.XtraEditors.XtraForm
    {
        public bool CreateObR { get; set; }
        public frmPrompPR()
        {
            InitializeComponent();
            this.Init();
        }

        void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();
                this.purchaseRequestsBindingSource.DataSource = unitOfWork.PurchaseRequestsRepo.Get(x =>
                    x.OfficeId == staticSettings.OfficeId && x.FT == staticSettings.FT &&
                    x.Year == staticSettings.Year);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboPR.EditValue != null)
            {
                Main main = Application.OpenForms["Main"] as Main;
                main.pnlMain.Controls.Clear();
                if (cboPR.GetSelectedDataRow() is PurchaseRequests item)
                {
                    var pr = new UCPurchaseRequest(item.ControlNo)
                    {
                        Dock = DockStyle.Fill
                    };
                    main.pnlMain.Controls.Add(pr);
                    pr.PRTabControl.SelectedTabPageIndex = 4;
                    UCPO po = pr.tabPO.Controls[0] as UCPO;
                    po.btnNew.PerformClick();
                    CreateObR = true;
                    this.Close();
                }

            }
        }
    }
}