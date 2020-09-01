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

namespace Win.Accnts
{
    public partial class UCEarmarkPR : DevExpress.XtraEditors.XtraUserControl
    {
        private Appropriations appropriations;

        public UCEarmarkPR(Appropriations appropriations)
        {
            InitializeComponent();
            this.appropriations = appropriations;
            Init();
        }

        void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();
                var pr = unitOfWork.PurchaseRequestsRepo.Fetch(x => x.OfficeId == staticSettings.OfficeId)
                    .Where(x => x.AppropriationId == appropriations.Id && x.IsEarmark==true).ToList();
                this.purchaseRequestsBindingSource.DataSource = pr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
