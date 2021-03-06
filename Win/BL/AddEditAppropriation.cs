﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win.Accnts;

namespace Win.BL
{
    public class AddEditAppropriation : ITransactions<Appropriations>
    {
        private Appropriations appropriation;
        private frmAddEditAppropriation frm;
        public bool isClosed;

        public AddEditAppropriation(frmAddEditAppropriation frm, Appropriations appropriation)
        {
            this.frm = frm;
            this.appropriation = appropriation;
            frm.txtAccountCode.EditValueChanged += TxtAccountCode_EditValueChanged;
            frm.btnNewAccount.Click += BtnNewAccount_Click;
        }

        private void BtnNewAccount_Click(object sender, EventArgs e)
        {
            try
            {
                frmDefaultAccounts frm = new frmDefaultAccounts();
                frm.ShowDialog();
                Init();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtAccountCode_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is SearchLookUpEdit lookUpEdit)
            {
                if (lookUpEdit.GetSelectedDataRow() is DefaultAccounts item)
                {
                    frm.txtAccountCodeText.Text = item.AccountCodeText;
                    frm.txtAccountName.Text = item.AccountName;
                    frm.cboFundType.EditValue = item.FundType ?? item.FundTypes.FundType;

                }
            }

        }

        public AddEditAppropriation()
        {

        }



        public MethodType methodType { get; set; }

        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                var unitOfWork = new UnitOfWork();
                var item = unitOfWork.AppropriationsRepoRepo.Find(x => x.Id == appropriation.Id);
                StaticSettings staticSettings = new StaticSettings();
                if (unitOfWork.AppropriationsRepoRepo.Fetch(x => x.AccountCode == frm.txtAccountCode.Text && x.OfficeId == staticSettings.OfficeId).Any())
                {

                    if (MessageBox.Show($@"Duplicate Entry for { frm.txtAccountCode.Text} - {frm.txtAccountName.Text}, Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                item.AccountCode = frm.txtAccountCode.Text;
                item.AccountCodeText = frm.txtAccountCodeText.Text;
                item.FundType = frm.cboFundType.Text;
                item.AccountName = frm.txtAccountName.Text;
                item.Appropriation = frm.txtAppropriationAmount.EditValue.ToDecimal();
                item.Year = appropriation.Year ?? staticSettings.Year;
                item.FundTypeId = (frm.cboFundType.GetSelectedDataRow() as FundTypes)?.Id;
                item.Createdby = User.UserName;
                item.OfficeId = staticSettings.OfficeId;
                unitOfWork.Save();
                isClosed = true;
                frm.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {
            try
            {

                if (appropriation == null) return;
                appropriation = new UnitOfWork().AppropriationsRepoRepo.Find(m => m.Id == appropriation.Id);
                frm.txtAccountCode.Properties.DataSource = new BindingList<DefaultAccounts>(new UnitOfWork()
                    .DefaultAccountsRepo.Fetch().OrderBy(x => x.FundTypes.ItemNumber).ToList());
                frm.txtAccountCode.Text = appropriation.AccountCode;
                frm.txtAccountCodeText.Text = appropriation.AccountCodeText;
                frm.cboFundType.EditValue = appropriation.FundType;
                frm.txtAccountName.Text = appropriation.AccountName;
                frm.txtAppropriationAmount.EditValue = appropriation.Appropriation;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Init()
        {
            try
            {
                LoadFundType();
                if (methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                appropriation = new Appropriations()
                {
                    FT = Win.Properties.Settings.Default.FundType
                };
                appropriation.DateCreated = DateTime.Now;
                unitOfWork.AppropriationsRepoRepo.Insert(appropriation);
                unitOfWork.Save();
                Detail();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close(FormClosingEventArgs e)
        {
            try
            {
                if (methodType == MethodType.Edit) return;

                if (this.isClosed) return;


                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.AppropriationsRepoRepo.Delete(m => m.Id == appropriation.Id);
                unitOfWork.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadFundType()
        {
            frm.cboFundType.Properties.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().FundTypesRepo.Fetch()
            };
        }
    }
}
