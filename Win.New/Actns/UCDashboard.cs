using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Models.VM;
using Win.OB;
using Newtonsoft.Json;

namespace Win.Actns
{
    public partial class UCDashboard : DevExpress.XtraEditors.XtraUserControl
    {
        private StaticSettings staticSettings = new StaticSettings();


        public UCDashboard()
        {
            InitializeComponent();
            this.httpClient = new HttpClient()
            {
                BaseAddress = new Uri(Program.URL)
            };
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {User.Token.AccessToken}");
        }


        private async void Init()
        {
            try
            {
                DashboardGridView.ShowLoadingPanel();

                var docs = await httpClient.GetAsync("api/dashboard/GetDocumentActions");
                var userscontent = await httpClient.GetAsync("api/dashboard/GetUsers");
                var docContent = await docs.Content.ReadAsStringAsync();
                var documents = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DocumentActionsVM>>(docContent);

                this.cboUsers.Properties.DataSource = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Users>>(await userscontent.Content.ReadAsStringAsync());
                this.documentActionsBindingSource.DataSource = documents;

                //txtSearchKey.Properties.DataSource = await Task.Run(() =>
                //  {
                //      var userIds = unitOfWork.UsersRepo.Fetch(x => x.OfficeId == staticSettings.OfficeId)
                //          .Select(x => x.Id);
                //      return unitOfWork.DocumentActionsRepo.Fetch(x => x.RoutedToUsers.Any(m => userIds.Contains(m.Id))).Distinct()
                //          .ToList();
                //  });
                this.documentActionsBindingSource.DataSource = documents;

                this.cboUsers.EditValue = User.UserId;
                if (!User.UsersInRole("Super Administrator"))
                {
                    this.DashboardGridView.Columns[0].VisibleIndex = -1;
                }

                this.lblTotalCount.Text = $@"Total Count {documents.Count()}";
                this.Detail(documents.FirstOrDefault());
                DashboardGridView.HideLoadingPanel();
            }
            catch (Exception e)
            {

            }
        }

        private async void Detail(DocumentActionsVM document)
        {
            if (document == null)
                return;

            ActionTakenGridView.ShowLoadingPanel();
            var list = await httpClient.PostAsync("api/dashboard/GetDetails", new FormUrlEncodedContent(
                new Dictionary<string, string>()
                {
                    {"RefId",document.RefId?.ToString()},
                    {"TableName",document.TableName},
                }));

            var _list = await list.Content.ReadAsStringAsync();

            ActionTakenGridControl.DataSource = JsonConvert.DeserializeObject<List<DocumentActionsVM>>(_list);
            ActionTakenGridView.HideLoadingPanel();
        }

        private void lblControlNumber_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void lblControlNo_Click(object sender, EventArgs e)
        {
            if (DashboardGridView.GetFocusedRow() is DocumentActions documentActions)
            {
                if (documentActions.TableName == "Obligations")
                {
                    Main frm = Application.OpenForms["Main"] as Main;
                    frm.pnlMain.Controls.Clear();
                    var obr = new ucObligations() { Dock = DockStyle.Fill };
                    obr.txtSearch.Text = documentActions.ControlNo;
                    frm.pnlMain.Controls.Add(obr);
                    obr.btnSearch.PerformClick();
                }
                else
                {
                    Main frm = Application.OpenForms["Main"] as Main;
                    frm.pnlMain.Controls.Clear();



                    var pr = new PR.UCPurchaseRequest(documentActions.ControlNo) { Dock = DockStyle.Fill };
                    //pr.txtSearch.Text = documentActions.ControlNo;
                    pr.loadAddEditPurchaseRequest.Search(documentActions.ControlNo, true);
                    frm.pnlMain.Controls.Add(pr);
                    pr.btnSearch.PerformClick();
                }
            }
        }

        private void btnAddAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DashboardGridView.GetFocusedRow() is DocumentActions item)
            {
                frmDocActions frm = new frmDocActions(MethodType.Add, new DocumentActions()
                {
                    TableName = item.TableName,
                    ActionDate = DateTime.Now,
                    RefId = item.RefId,
                    CreatedBy = User.UserId,
                    DateCreated = DateTime.Now,
                    ControlNo = item.ControlNo,
                    Year = item.Year
                });
                frm.ShowDialog();
                Init();
            }
        }

        private void btnTaskDone_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DashboardGridView.GetFocusedRow() is DocumentActions item)
            {
                frmTaskDone frm = new frmTaskDone(item);
                frm.ShowDialog();
                Init();
            }
        }

        private void DashboardGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (DashboardGridView.GetFocusedRow() is DocumentActionsVM item)
            {
                Detail(item);
            }
        }

        private void cboUsers_EditValueChanged(object sender, EventArgs e)
        {
            Search();
        }
        IQueryable<DocumentActions> documents;
        private HttpClient httpClient;

        async void Search()
        {
            /*try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                documents = await Task.Run(() =>
                   unitOfWork.DocumentActionsRepo.Fetch(x => x.IsSend == true && x.isDone != true));
                if (cboUsers.EditValue != null)
                {
                    var user = cboUsers.EditValue.ToString();
                    documents = documents.Where(x => x.RoutedToUsers.Any(m => m.Id == user));

                }
                if (dtFrom.EditValue != null && dtTo.EditValue != null)
                {
                    var dateTo = dtTo.DateTime.AddHours(11).AddMinutes(59).AddSeconds(59);
                    documents = documents.Where(x => x.ActionDate >= dtFrom.DateTime && x.ActionDate <= dateTo);

                }


                if (!string.IsNullOrEmpty(cboDocType.EditValue?.ToString()))
                {
                    documents = unitOfWork.DocumentActionsRepo.Fetch().Where((x => x.TableName == cboDocType.Text));
                }

                DashboardGridControl.DataSource = await Task.Run(() => documents.ToList());
                // this.Detail(await Task.Run(() => documents.FirstOrDefault()));
            }
            catch (Exception e)
            {

            }*/
        }

        private void dtTo_EditValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnTaskDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DashboardGridView.GetFocusedRow() is DocumentActions item)
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                item = unitOfWork.DocumentActionsRepo.Find(x => x.Id == item.Id, "RoutedToUsers");
                item.RoutedToUsers.Remove(unitOfWork.UsersRepo.Find(x => x.Id == User.UserId));
                unitOfWork.Save();
                Init();
            }
        }

        private async void UCDashboard_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void cboControlNo_EditValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cboDocType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void DashboardGridView_RowCountChanged(object sender, EventArgs e)
        {
            if (DashboardGridView.GetRow(DashboardGridView.FocusedRowHandle) is DocumentActionsVM item)
                Detail(item);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private async void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (documents == null)
                    documents = await Task.Run(() =>
                        unitOfWork.DocumentActionsRepo.Fetch(x => x.IsSend == true && x.isDone != true));
                var amount = txtSearch.Text.Split(new string[] { "to" }, StringSplitOptions.None);
                if (amount.Any(x => x.ToInt() > 0) && amount.Count() >= 2)
                {
                    var a1 = amount[0]?.ToDecimal();
                    var a2 = amount[1]?.ToDecimal();
                    documents = documents.Where(x => x.TotalAmount >= a1 && x.TotalAmount <= a2);
                }
                else
                {

                    var prs = unitOfWork.PurchaseRequestsRepo.Fetch(x => x.OfficeId == staticSettings.OfficeId && x.Description.Contains(txtSearch.Text)).Select(m => m.ControlNo).ToList();
                    var obrs = unitOfWork.ObligationsRepo.Fetch(x => x.OfficeId == staticSettings.OfficeId && x.Description.Contains(txtSearch.Text)).Select(m => m.ControlNo).ToList();
                    documents = documents.Where(x =>
                     x.ControlNo.Contains(txtSearch.Text) ||
                        x.ObR_PR_No.Contains(txtSearch.Text) || prs.Contains(x.ControlNo) || obrs.Contains(x.ControlNo));
                    var res = documents.ToList();

                }

                this.DashboardGridControl.DataSource = documents.ToList();

            }
        }
    }
}
