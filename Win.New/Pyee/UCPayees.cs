using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;
using Win.BL;
using Win.OB;

namespace Win.Pyee
{
    public partial class UCPayees : DevExpress.XtraEditors.XtraUserControl, ILoad<Payees>
    {
        public UCPayees()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            try
            {
                StaticSettings staticSettings = new StaticSettings();
                PayeeGridControl.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = new UnitOfWork().PayeesRepo.Fetch(),

                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail(Payees item)
        {

        }

        public void Search(string search)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                PayeeGridControl.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = new UnitOfWork().PayeesRepo.Fetch(x => x.Name.Contains(search)),
                };}
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void btnEditRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (PayeeGridView.GetFocusedRow() is Payees item)
            {
                frmAddEditPayee frm = new frmAddEditPayee(MethodType.Edit, item);
                frm.ShowDialog();
                Init();
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditPayee frm = new frmAddEditPayee(MethodType.Add, null);
            frm.ShowDialog();
            Init();
        }

        private void btnDeleteRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (PayeeGridView.GetFocusedRow() is Payees item)
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PayeesRepo.Delete(m => m.Id == item.Id);
                unitOfWork.Save();
                Init();
            }
        }

        private void PayeeGridView_DoubleClick(object sender, EventArgs e)
        {
            if (PayeeGridView.GetFocusedRow() is Payees item)
            {
                frmAddEditPayee frm = new frmAddEditPayee(MethodType.Edit, item);
                frm.ShowDialog();
                Init();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Search(txtSearch.Text);
            }
        }
    }
}
