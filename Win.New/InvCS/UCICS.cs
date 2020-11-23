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
using Models.Repository;

namespace Win.InvCS
{
    public partial class UCICS : DevExpress.XtraEditors.XtraUserControl
    {
        public UCICS()
        {
            InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.ICSGridControl.DataSource = unitOfWork.ICSRepo.Get();
            }
            catch (Exception e)
            {

            }
        }
    }
}
