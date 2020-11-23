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

namespace Win.Usr
{
    public partial class UCFunctions : DevExpress.XtraEditors.XtraUserControl, ILoad<Functions>
    {
        public UCFunctions()
        {
            InitializeComponent();
        }

        public void Init()
        {
            this.UserLevelGridControl.DataSource = new BindingList<Functions>(new UnitOfWork().FunctionsRepo.Get());
        }

        public void Detail(Functions item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

     
    }
}
