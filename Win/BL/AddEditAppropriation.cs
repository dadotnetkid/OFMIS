using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
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
                unitOfWork.AppropriationsRepoRepo.Update(new Appropriations()
                {
                    AccountCode = frm.txtAccountCode.Text,
                    AccountCodeText = frm.txtAccountCodeText.Text,
                    FundType = frm.cboFundType.Text,
                    AccountName = frm.txtAccountName.Text,
                    Appropriation = frm.txtAppropriationAmount.EditValue.ToDecimal(),
                    Id = appropriation.Id,
                    Year = appropriation.Year ?? new StaticSettings().Year
                });
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
                if (methodType == MethodType.Add) return;
                if (appropriation == null) return;
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
                appropriation = new Appropriations();
                unitOfWork.AppropriationsRepoRepo.Insert(appropriation);
                unitOfWork.Save();
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
