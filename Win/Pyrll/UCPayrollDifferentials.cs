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
using Win.Rprts;

namespace Win.Pyrll
{
    public partial class UCPayrollDifferentials : DevExpress.XtraEditors.XtraUserControl, ITransactions<PayrollDifferentials>
    {
        private Obligations item;

        public UCPayrollDifferentials(Obligations item)
        {
            InitializeComponent();
            this.item = item;
            btnEditPayrollRepo.ButtonClick += BtnEditPayrollRepo_ButtonClick;
            btnDeletePayrollRepo.ButtonClick += BtnDeletePayrollRepo_ButtonClick;
            Init();
        }

        private void BtnDeletePayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (PayrollDiffGridView.GetFocusedRow() is PayrollDifferentials _item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PayrollDifferentialsRepo.Delete(x => x.Id == _item.Id);
                unitOfWork.Save();
                Init();
            }
        }

        private void BtnEditPayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (PayrollDiffGridView.GetFocusedRow() is PayrollDifferentials _item)
            {
                frmAddEditPayrollDifferentials frm = new frmAddEditPayrollDifferentials(new PayrollDifferentials()
                {
                    ObId = _item.Id,
                    Id = _item.Id
                }, MethodType.Edit);
                frm.ShowDialog();
                Init();
            }
        }

        private void btnEditNew_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddEditPayrollDifferentials frm = new frmAddEditPayrollDifferentials(new PayrollDifferentials()
                {
                    ObId = item.Id
                }, MethodType.Add);
                frm.ShowDialog();
                Init();
            }
            catch (Exception exception)
            {

            }
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Detail()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.PayrollDiffGridControl.DataSource =
                    unitOfWork.PayrollDifferentialsRepo.Get(x => x.ObId == this.item.Id);
            }
            catch (Exception e)
            {

            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (PayrollDiffGridView.GetFocusedRow() is PayrollDifferentials _item)
            {
                var res = new UnitOfWork().PayrollDifferentialsRepo.Find(x => x.Id == _item.Id);
                if (res.PayrollDifferentialDetails.Count() < 7)
                {
                    res.PayrollDifferentialDetails.Add(new PayrollDifferentialDetails()
                    {
                        EmployeeName = "*******Nothing follows*******"
                    });
                    var count = 7 - res.PayrollDifferentialDetails.Count();
                    for (var i = 0; i <= count - 1; i++)
                    {
                        res.PayrollDifferentialDetails.Add(new PayrollDifferentialDetails()
                        {
                            EmployeeName = ""
                        });
                    }

                }
                frmReportViewer frm = new frmReportViewer(new rptPayrollDifferential()
                {
                    DataSource = new List<PayrollDifferentials>() { res }
                });
                frm.ShowDialog();
                Init();
            }
        }
    }
}
