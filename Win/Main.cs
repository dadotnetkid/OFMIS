using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.XtraBars.ToastNotifications;
using Helpers;
using Models;
using Models.Repository;
using Models.ViewModels;
using Win.Accnts;
using Win.Actns;
using Win.BGMembers;
using Win.BL;
using Win.Emps;
using Win.Ltr;
using Win.OB;
using Win.Ofcs;
using Win.PR;
using Win.Pyee;
using Win.Rprts;
using Win.TB;
using Win.Tmplts;
using Win.Usr;

namespace Win
{

    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        class ShowFormThreadData
        {
            public DevExpress.LookAndFeel.UserLookAndFeel mainLookAndFeel;
            // TODO add more fields to pass data to a new thread
        }
        private string[] param;

        public Main(string[] param)
        {
            new frmSplashScreen().ShowDialog(this);
            frmFundTypeChoices frmFundTypeChoices = new frmFundTypeChoices();
            frmFundTypeChoices.ShowDialog();
            InitializeComponent();
            Init();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        public Main()
        {
            frmFundTypeChoices frmFundTypeChoices = new frmFundTypeChoices();
            frmFundTypeChoices.ShowDialog();
            InitializeComponent();
            Init();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        void Impersonate(string[] param)
        {
            User.UserId = param[0];
            lblUsername.Caption = $"Name: {User.GetFullName() }";
            lblUserLevel.Caption = $"User Level: {User.GetUserLevel()}";
            var unitOfWork = new UnitOfWork();
            if (!unitOfWork.YearsRepo.Fetch().Any(x => x.IsActive == true))
            {
                MessageBox.Show("No Default Year Selected", "Default Year", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                var frm = new frmYears();
                frm.ShowDialog();
            }
        }
        void Init(bool isLogged = false)
        {
           
            Form frm = new frmLogin();
            if (isLogged == false)
                frm.ShowDialog();
            StaticSettings staticSettings = new StaticSettings();
            lblUsername.Caption = $"Name: {User.GetFullName() }";
            lblUserLevel.Caption = $"User Level: {User.GetUserLevel()} - " + staticSettings?.Offices?.OffcAcr + $"-[{staticSettings.FT}]";
            var unitOfWork = new UnitOfWork();
            if (!unitOfWork.YearsRepo.Fetch(x => x.OfficeId == staticSettings.OfficeId).Any(x => x.IsActive == true))
            {
                MessageBox.Show("No Default Year Selected", "Default Year", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                frm = new frmYears();
                frm.ShowDialog();
            }
            this.Text = $"OFMIS[{staticSettings.Year}]" + $"-[{staticSettings.FT}]";
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCDashboard() { Dock = DockStyle.Fill });


        }
        private void btnObligation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pnlMain.Controls[0].Name == "ucObligations")
                return;
            if (!User.UserInAction("Obligations"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new ucObligations() { Dock = DockStyle.Fill });

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pnlMain.Controls[0].Name == "UcAccounts")
                return;
            if (!User.UserInAction("Accounts"))
                return;

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UcAccounts() { Dock = DockStyle.Fill });
        }

        private void btnYear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Years"))
                return;
            frmYears frm = new frmYears();
            frm.ShowDialog();
        }

        private void btnDefaultSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Years"))
                return;
            frmDefaultSettings frm = new frmDefaultSettings();
            frm.ShowDialog();
        }

        private void btnSignatories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Signatories"))
                return;
            frmSignatories frm = new frmSignatories();
            frm.ShowDialog();
        }

        private void btnORReports_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("OB Reports"))
                return;
            frmObligationRequestReportViewer frm = new frmObligationRequestReportViewer();
            frm.ShowDialog();
        }

        private void btnDetailedobligationRequest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("OB Detailed Reports"))
                return;
            frmDetailedObligationRequestReportViewer frm = new frmDetailedObligationRequestReportViewer();
            frm.ShowDialog();
        }

        private void btnAOBReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("AOB Report"))
                return;
            frmAOBReportViewer frm = new frmAOBReportViewer();
            frm.ShowDialog();
        }

        private void btnItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Items"))
                return;

            frmItems frm = new frmItems();
            frm.ShowDialog();
        }

        private void btnPR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pnlMain.Controls[0].Name == "UCPurchaseRequest")
                return;
            if (!User.UserInAction("Purchase Requests"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCPurchaseRequest() { Dock = DockStyle.Fill });
        }

        private void btnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Users"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCUsers() { Dock = DockStyle.Fill });
        }

        private void btnUserlevel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("User Level"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCUserLevels() { Dock = DockStyle.Fill });
        }

        private void btnPayees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Payees"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCPayees() { Dock = DockStyle.Fill });
        }

        private void btnDefaultAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Default Accounts"))
                return;
            frmDefaultAccounts frm = new frmDefaultAccounts();
            frm.ShowDialog();
        }



        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

            if (MessageBox.Show("Do you want to close this application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Application.Exit();
        }
        [STAThread]
        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            this.Close();
            ShowFormThreadData data = new ShowFormThreadData();
            data.mainLookAndFeel = DevExpress.LookAndFeel.UserLookAndFeel.Default;
            var th = new Thread(() =>
              {
                  ShowFormThreadData td = data as ShowFormThreadData;

                // this thread 
#pragma warning disable 618
                DevExpress.UserSkins.OfficeSkins.Register();
#pragma warning restore 618
                DevExpress.UserSkins.BonusSkins.Register();
                  DevExpress.LookAndFeel.UserLookAndFeel.Default.Assign(td.mainLookAndFeel);

                  Application.Run(new Main());
              });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //Application.Restart();
            //Application.Restart();
            /*User.UserId = null;
            backstageViewControl1.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            Init(true);*/
        }

        private void btnOffices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Offices"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCOffices() { Dock = DockStyle.Fill });
        }

        private void btnEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Employees"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCEmployees() { Dock = DockStyle.Fill });
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                if (this.pnlMain.Controls.Count > 0)
                {
                    if (this.pnlMain.Controls[0] is IUserControl uc)
                    {
                        uc.Refresh();
                    }


                }

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnBACMembers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("BAC Members"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCBACMembers() { Dock = DockStyle.Fill });
        }

        private void btnTemplates_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Templates"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UcTemplates() { Dock = DockStyle.Fill });
        }

        private void btnLetter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (!User.UserInAction("Letter"))
            //    return;
            //pnlMain.Controls.Clear();
            //pnlMain.Controls.Add(new UcLetters() { Dock = DockStyle.Fill });
        }

        private void btnLAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLARReportViewer frm = new frmLARReportViewer();
            frm.Show();
        }

        private void btnActionTree_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Action Tree"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new Actns.UCActions() { Dock = DockStyle.Fill });
        }

        private void btnRecipientLists_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Recipient Lists"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new Pyee.UCRecipients() { Dock = DockStyle.Fill });
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool updateNow = true;
            while (updateNow)
            {
                Thread.Sleep(1000);
                if (UpdateHelpers.InstallUpdateSyncWithInfo())
                {
                    this.Invoke(new Action(() =>
                    {
                        updateNow = false;
                        lblTime.Caption = @"OFMIS: Update available(the system is updating)";
                        UpdateHelpers.applicationDeployment.UpdateCompleted += (se, ev) =>
                        {
                            new frmUpdateNotification().ShowDialog(this);
                        };
                        UpdateHelpers.applicationDeployment.UpdateProgressChanged += (se, ev) =>
                        {
                            lblTime.Caption = $@"OFMIS: Update available(the system is updating) {ev.ProgressPercentage}%";
                        };
                        UpdateHelpers.applicationDeployment.UpdateAsync();


                    }));

                }
            }
        }

        private void btnDashboard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pnlMain.Controls[0].Name=="UCDashboard")
                return;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(new UCDashboard()
            {
                Dock = DockStyle.Fill
            });
        }

        private void btnAccomplishmentReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StaticSettings staticSettings = new StaticSettings();
            frmAccomplishmentReport frm = new frmAccomplishmentReport(null, $"[{staticSettings.Offices.OffcAcr}]Office Management Information System({User.UserName })");
            frm.ShowDialog();
        }

        private void btnTrashbin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(new UCTrashbin()
            {
                Dock = DockStyle.Fill
            });
        }

        private void btnRemarks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmInstructionRemarks frmInstructionRemarks = new frmInstructionRemarks();
            frmInstructionRemarks.ShowDialog();
        }

        private void btnActionTaken_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmActionTaken frm = new frmActionTaken();
            frm.ShowDialog();
        }

        private void btnUserSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUserSettings frm = new frmUserSettings();
            frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var db = new FDTSDb();

                //var docTrNo = db.SP_GetObrNo("General Fund", null, null, null).FirstOrDefault();
                //var ctrlNo = db.SP_GetCtrlNo("General Fund",null,null, "2020").FirstOrDefault();
                //var trknNo = db.SP_GetTrknNo("2020", null).FirstOrDefault();
                //db.SP_InsertDoc(2020, trknNo, "", "OBR", User.UserName, new StaticSettings().ResponsibilityCenter, docTrNo, "General Fund");
                /* var res = db.Database.SqlQuery<OBRVM>("exec SP_GetObrNo", 
                new SqlParameter("@category", "General Fund"), 
                new SqlParameter("@currentnumber", ""),
                new SqlParameter("@code", null), 
                new SqlParameter("@mon", null)).FirstOrDefault();*/
            }
            catch (Exception exception)
            {

            }

        }

        private void btnStatusSummary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSummaryOfStatusFinancialDocuments frm = new frmSummaryOfStatusFinancialDocuments();
            frm.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSummaryOfStatusFinancialDocuments frm = new frmSummaryOfStatusFinancialDocuments();
            frm.ShowDialog();
        }
    }
}
