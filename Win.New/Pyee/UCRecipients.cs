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

namespace Win.Pyee
{
    public partial class UCRecipients : DevExpress.XtraEditors.XtraUserControl, ILoad<Payees>
    {
        public UCRecipients()
        {
            InitializeComponent();
            Init();
            this.RecipientGridView.FocusedRowObjectChanged += RecipientGridView_FocusedRowObjectChanged;
            this.txtSearch.KeyDown += TxtSearch_KeyDown;
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search(txtSearch.Text);
            }
        }

        private void RecipientGridView_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            if (e.Row is Payees item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                Detail(unitOfWork.PayeesRepo.Find(x => x.Id == item.Id));
            }
        }

        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.payeesBindingSource.DataSource = unitOfWork.PayeesRepo.Get();

            }
            catch (Exception e)
            {
            }
        }

        public void Detail(Payees item)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                item = unitOfWork.PayeesRepo.Find(x => x.Id == item.Id);
                txtName.Text = item?.Name;
                txtAddress.Text = item?.Address;
                this.ObligationGridControl.DataSource = unitOfWork.ORDetailsRepo.Get(x => x.Obligations.PayeeId == item.Id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Search(string search)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                IQueryable<Payees> payees = unitOfWork.PayeesRepo.Fetch();
                if (payees.Select(x => new { x.Name }).Any(x => x.Name.Contains(search)))
                {
                    payees = payees.Where(x => x.Name.Contains(search));
                }

                if (payees.Select(x => new { x.Address }).Any(x => x.Address.Contains(search)))
                {
                    payees = payees.Where(x => x.Address.Contains(search));
                }

                this.ObligationGridControl.DataSource = payees.ToList();
                this.Detail(payees.FirstOrDefault());
            }
            catch (Exception e)
            {

            }
        }


        void ILoad<Payees>.Init()
        {
            Init();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (RecipientGridView.GetFocusedRow() is Payees payees)
            {

                frmReportViewer frmReportViewer = new frmReportViewer(new rptRecipientLists()
                {
                    DataSource = new UnitOfWork().PayeesRepo.Get(x => x.Id == payees.Id)

                });
                frmReportViewer.ShowDialog();
            }
        }
    }
}
