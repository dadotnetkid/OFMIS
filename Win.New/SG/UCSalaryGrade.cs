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

namespace Win.SG
{
    public partial class UCSalaryGrade : DevExpress.XtraEditors.XtraUserControl, ILoad<SalarySchedules>
    {
        public UCSalaryGrade()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            UnitOfWork unitOfWork = new UnitOfWork();

        }

        public void Detail(SalarySchedules item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
