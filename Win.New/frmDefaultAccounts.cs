using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;
using Win.BL;

namespace Win
{
    public partial class frmDefaultAccounts : DevExpress.XtraEditors.XtraForm, ILoad<DefaultAccounts>
    {
        public frmDefaultAccounts()
        {
            InitializeComponent();
            Init();
        }

        private void btnDeleteRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (DefaultAccountsGridView.GetFocusedRow() is DefaultAccounts item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.DefaultAccountsRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Init()
        {
            try
            {
                DefaultAccountsGridControl.DataSource = new BindingList<DefaultAccounts>(new UnitOfWork().DefaultAccountsRepo.Fetch().OrderBy(x => x.FundTypes.ItemNumber).ToList());

                cboFundTypeRepo.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = new UnitOfWork().FundTypesRepo.Fetch()
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail(DefaultAccounts item)
        {

        }

        public void Search(string search)
        {
            try
            {
                IQueryable<DefaultAccounts> defaultAccounts = new UnitOfWork().DefaultAccountsRepo.Fetch()
                    .OrderBy(x => x.FundTypes.ItemNumber);
                if (defaultAccounts.Select(x => new { x.AccountName }).Any(x => x.AccountName.Contains(search)))
                    defaultAccounts = defaultAccounts.Where(x => x.AccountName.Contains(search));
                else if (defaultAccounts.Select(x => new { x.AccountCode }).Any(x => x.AccountCode.Contains(search)))
                    defaultAccounts = defaultAccounts.Where(x => x.AccountCode.Contains(search));
                DefaultAccountsGridControl.DataSource = new BindingList<DefaultAccounts>(defaultAccounts.ToList());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void DefaultAccountsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (e.Row is DefaultAccounts item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var fundType = unitOfWork.FundTypesRepo.Find(m => m.Id == item.FundTypeId);

                    if (item.Id == 0)
                    {
                        item.FundType = fundType.FundType;
                        unitOfWork.DefaultAccountsRepo.Insert(item);
                    }

                    else
                    {

                        unitOfWork.DefaultAccountsRepo.Update(new DefaultAccounts()
                        {
                            Id = item.Id,
                            AccountCode = item.AccountCode,
                            AccountCodeText = item.AccountCodeText,
                            AccountName = item.AccountName,
                            FundType = fundType?.FundType,
                            FundTypeId = fundType?.Id,
                        });
                    }

                    unitOfWork.Save();
                    Init();
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }
    }
}