using System;
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
using RestSharp;
using Win.Accnts;

namespace Win.BL
{
    public class AddEditAppropriation : ITransactions<Appropriations>
    {
        private Appropriations appropriation;
        private frmAddEditAppropriation frm;
        public bool isClosed;
        private RestClient restClient;
        public AddEditAppropriation(frmAddEditAppropriation frm, Appropriations appropriation)
        {
            this.frm = frm;
            this.restClient = new RestClient(Program.URL);
            restClient.AddDefaultHeader("Authorization", "Bearer " + User.Token.AccessToken);
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

        public async void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                //var unitOfWork = new UnitOfWork();
                //var item = unitOfWork.AppropriationsRepoRepo.Find(x => x.Id == appropriation.Id);
                StaticSettings staticSettings = new StaticSettings();
                /*if (unitOfWork.AppropriationsRepoRepo.Fetch(x => x.AccountCode == frm.txtAccountCode.Text && x.OfficeId == staticSettings.OfficeId).Any())
                {

                    if (MessageBox.Show($@"Duplicate Entry for { frm.txtAccountCode.Text} - {frm.txtAccountName.Text}, Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }*/

                appropriation.AccountCode = frm.txtAccountCode.Text;
                appropriation.AccountCodeText = frm.txtAccountCodeText.Text;
                appropriation.FundType = frm.cboFundType.Text;
                appropriation.AccountName = frm.txtAccountName.Text;
                appropriation.Appropriation = frm.txtAppropriationAmount.EditValue.ToDecimal();
                appropriation.Year = appropriation.Year ?? staticSettings.Year;
                appropriation.FundTypeId = (frm.cboFundType.GetSelectedDataRow() as FundTypes)?.Id;
                appropriation.Createdby = User.UserName;
                appropriation.OfficeId = staticSettings.OfficeId;

                this.appropriation = await restClient.PostTaskAsync<Appropriations>(
                    new RestRequest("api/appropriation/UpdateAppropriation", Method.POST).AddJsonBody(appropriation));



                //unitOfWork.Save();
                isClosed = true;
                frm.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void Detail()
        {
            try
            {

                if (appropriation == null) return;
                appropriation =
                    await restClient.GetTaskAsync<Appropriations>(
                        new RestRequest("api/appropriation/GetAppropriationDetails", Method.GET).AddParameter("id",
                            appropriation.Id));



                frm.txtAccountCode.Properties.DataSource =
                    await restClient.GetTaskAsync<List<DefaultAccounts>>(
                        new RestRequest("api/appropriation/getdefaultAccount", Method.GET));
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

        public async void Init()
        {
            try
            {
                LoadFundType();
                if (methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }
                /*UnitOfWork unitOfWork = new UnitOfWork();
                appropriation = new Appropriations()
                {
                    FT = Win.Properties.Settings.Default.FundType
                };
                appropriation.DateCreated = DateTime.Now;
                unitOfWork.AppropriationsRepoRepo.Insert(appropriation);
                unitOfWork.Save();*/
                var restRequest = new RestRequest("api/appropriation/newappropriation", Method.POST).AddJsonBody(new Appropriations()
                {
                    FT = Win.Properties.Settings.Default.FundType,
                    DateCreated = DateTime.Now
                });
                this.appropriation = await this.restClient.PostTaskAsync<Appropriations>(restRequest);

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
