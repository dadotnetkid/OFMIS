using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Models;
using Models.Repository;
using Win.Accnts;
using Win.OB;
using Win.Rprts;

namespace Win.BL
{
    public class LoadAppropriations : ILoad<Appropriations>
    {
        private UcAccounts uc;
        int year => new StaticSettings().Year;
        public LoadAppropriations(UcAccounts uc)
        {
            this.uc = uc;
            uc.AppropriationGrid.FocusedRowChanged += AppropriationGrid_FocusedRowChanged;
            uc.btnAccountEditRepo.ButtonClick += btnAccountEditRepo_ButtonClick;
            uc.btnAllotments.Click += BtnAllotments_Click;
            uc.btnRealigment.Click += BtnRealigment_Click;
            uc.BtnAllotmentDeleteRepo.ButtonClick += BtnDelAllotmentRepo_ButtonClick;
            uc.BtnAllotmentEditRepo.ButtonClick += BtnEditAllotmentRepo_ButtonClick;
            uc.btnReAlignmentEditRepo.ButtonClick += BtnReAlignmentEditRepo_ButtonClick;
            uc.btnReAlignmentDeleteRepo.ButtonClick += BtnReAlignmentDeleteRepo_ButtonClick;
            uc.btnAccountEditRepo.ButtonClick += BtnAccountEditRepo_ButtonClick;
            uc.btnOBREdit.ButtonClick += BtnOBREdit_ButtonClick;
            uc.btnAccountDel.ButtonClick += BtnAccountDel_ButtonClick;
            uc.btnSOA.Click += BtnSOA_Click;
            //   uc.txtSearch.TextChanged += TxtSearch_TextChanged;
            uc.txtSearch.KeyDown += TxtSearch_KeyDown;
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (sender is TextEdit item)
                {
                    Search(item.Text);
                }
            }
        }


        private void BtnSOA_Click(object sender, EventArgs e)
        {
            if (uc.AppropriationGrid.GetFocusedRow() is Appropriations item)
            {
                frmReportViewer frm = new frmReportViewer(new rptSOA()
                {
                    DataSource = new UnitOfWork().AppropriationsRepoRepo.Get(m => m.Id == item.Id)
                });
                frm.ShowDialog();
            }
        }

        private void BtnAccountDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!User.UserInAction("can delete"))
                return;
            if (uc.AppropriationGrid.GetFocusedRow() is Appropriations item)
            {

                UnitOfWork unitOfWork = new UnitOfWork();

                if (MessageBox.Show($@"Do you want to Delete this account? { item.AccountCode}", $@"Delete {item.AccountCode}", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                unitOfWork.AppropriationsRepoRepo.Delete(m => m.Id == item.Id);
                unitOfWork.Save();
                Init();

            }
        }

        private void BtnOBREdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uc.ObligationGridView.GetFocusedRow() is ORDetails item)
            {
                var rowHandle = uc.ObligationGridView.FocusedRowHandle;
                frmAddEditObligation frm = new frmAddEditObligation(MethodType.Edit, item.Obligations);
                frm.ShowDialog();
                if (uc.AppropriationGrid.GetFocusedRow() is Appropriations account)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    Detail(new UnitOfWork().AppropriationsRepoRepo.Find(m => m.Id == account.Id));
                }

            }
        }

        private void BtnAccountEditRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uc.AppropriationGrid.GetFocusedRow() is Appropriations item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                Detail(new UnitOfWork().AppropriationsRepoRepo.Find(m => m.Id == item.Id));
            }
        }

        private void BtnReAlignmentDeleteRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uc.ReAlignmentGridView.GetFocusedRow() is ReAlignments item)
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.ReAlignmentsRepo.Delete(m => m.Id == item.Id);
                unitOfWork.Save();

                Detail(new UnitOfWork().AppropriationsRepoRepo.Find(m => m.Id == Appropriations.Id));
            }
        }

        private void BtnReAlignmentEditRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uc.ReAlignmentGridView.GetFocusedRow() is ReAlignments item)
            {
                frmAddEditReAlignment frm = new frmAddEditReAlignment(Models.MethodType.Edit, item);
                frm.ShowDialog();
                Detail(new UnitOfWork().AppropriationsRepoRepo.Find(m => m.Id == Appropriations.Id));
            }
        }

        private void BtnRealigment_Click(object sender, EventArgs e)
        {
            frmAddEditReAlignment frm = new frmAddEditReAlignment(Models.MethodType.Add, new ReAlignments() { SourceAppropriations = Appropriations });
            frm.ShowDialog();
            Detail(new UnitOfWork().AppropriationsRepoRepo.Find(m => m.Id == Appropriations.Id));
        }

        private void BtnEditAllotmentRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uc.AllotmentGridView.GetFocusedRow() is Allotments item)
            {
                frmAddEditAllotment frm = new frmAddEditAllotment(Models.MethodType.Edit, item);
                frm.ShowDialog();
                Detail(new UnitOfWork().AppropriationsRepoRepo.Find(m => m.Id == Appropriations.Id));
            }
        }

        private void BtnDelAllotmentRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uc.AllotmentGridView.GetFocusedRow() is Allotments item)
            {
                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.AllotmentsRepo.Delete(m => m.Id == item.Id);
                unitOfWork.Save();
                Detail(new UnitOfWork().AppropriationsRepoRepo.Find(m => m.Id == Appropriations.Id));
            }
        }

        private void BtnAllotments_Click(object sender, EventArgs e)
        {
            if (this.uc.AppropriationGrid.GetFocusedRow() is Appropriations item)
            {
                frmAddEditAllotment frm = new frmAddEditAllotment(Models.MethodType.Add,
                    new Models.Allotments() { Appropriations = item });
                frm.ShowDialog();
                Detail(new UnitOfWork().AppropriationsRepoRepo.Find(m => m.Id == item.Id));
            }

        }

        public Appropriations Appropriations { get; set; }

        public void Init()
        {
            var staticSettings = new StaticSettings();
            var ft = Win.Properties.Settings.Default.FundType;
            uc.appropriationGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().AppropriationsRepoRepo.Fetch(m => m.Year == staticSettings.Year && m.OfficeId == staticSettings.OfficeId && m.FT == ft)
            };
            if (staticSettings.FT != "GF")
            {
                uc.appropriationGridControl.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = new UnitOfWork().AppropriationsRepoRepo.Fetch(m => m.OfficeId == staticSettings.OfficeId && m.FT == ft)
                };
            }

        }

        private void btnAccountEditRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uc.AppropriationGrid.GetFocusedRow() is Appropriations item)
            {
                frmAddEditAppropriation frm = new frmAddEditAppropriation(MethodType.Edit, item);
                frm.ShowDialog();
                Init();
            }
        }

        public void Detail(Appropriations item)
        {
            try
            {
                if (item == null)
                    return;
                uc.txtEarmarked.Text = item.PurchaseRequestEarmarked.ToString("n2");
                uc.txtAppropriation.Text = item.Appropriation?.ToString("n2");
                uc.txtAllotment.Text = item.Allotment?.ToString("n2");
                uc.txtAppropriationBalance.Text = item.AppropriationBalance?.ToString("n2");
                uc.txtObligationOffice.Text = item.ObligationsOffice?.ToString("n2");
                uc.txtAllotmentBalanceIncEM.Text = item.AllotmentBalanceIncEM?.ToString("n2");
                uc.txtAllotmentBalanceExcEM.Text = item.AllotmentBalanceExcEM?.ToString("n2");
                uc.txtReAlignment.Text = item.ReAlignment?.ToString("n2");
                uc.lblHeader.Text = item.AccountCode + " - " + item.AccountName;
                uc.txtObligationBudget.Text = item.BudgetAccountBalance?.ToString("n2");
                uc.txtPRCancelled.Text = item.PurchaseRequestCancelled.ToString("n2");
                uc.txtEarmarked.Text = item.PurchaseRequestEarmarked.ToString("n2");
                uc.AllotmentGridControl.DataSource = new BindingList<Allotments>(item.Allotments.ToList());
                uc.ObligationGridControl.DataSource = new BindingList<ORDetails>(new UnitOfWork().ORDetailsRepo.Get(m => m.AppropriationId == item.Id, includeProperties: "Obligations,Obligations.Payees"));
                uc.ReAlignmentGridControl.DataSource = new BindingList<ReAlignments>(new UnitOfWork().ReAlignmentsRepo.Get(m => m.SourceAppropriationId == item.Id || m.TargetAppropriationId == item.Id).ToList());
                uc.tabEarmarked.Controls.Clear();

                uc.tabEarmarked.Controls.Add(new UCEarmarkPR(item) { Dock = DockStyle.Fill });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Search(string search)
        {

            var unitOfWork = new UnitOfWork();
            StaticSettings staticSettings = new StaticSettings();
            IQueryable<Appropriations> obj = unitOfWork.AppropriationsRepoRepo.Fetch(m => m.FT == staticSettings.FT && m.OfficeId == staticSettings.OfficeId);
            if (staticSettings.FT == "GF")
                obj = obj.Where(x => x.Year == staticSettings.Year);
            if (obj.Any(x => x.AccountCode.Contains(search)))
                obj = obj.Where(x => x.AccountCode.Contains(search));
            else if (obj.Any(x => x.AccountCodeText.Contains(search)))
                obj = obj.Where(x => x.AccountCodeText.Contains(search));
            else if (obj.Any(x => x.AccountName.Contains(search)))
                obj = obj.Where(x => x.AccountName.Contains(search));
            else if (obj.Any(x => x.ORDetails.Any(m => m.Obligations.BudgetControlNo.Contains(search))))
                obj = obj.Where(x => x.ORDetails.Any(m => m.Obligations.BudgetControlNo.Contains(search)));
            else if (obj.Any(x => x.ORDetails.Any(m => m.Particulars.Contains(search))))
                obj = obj.Where(x => x.ORDetails.Any(m => m.Particulars.Contains(search)));
            uc.appropriationGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = obj
            };
            Detail(obj.FirstOrDefault());
        }


        private void AppropriationGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is GridView gridView)
            {
                if (gridView.GetFocusedRow() is Appropriations item)
                {
                    Appropriations = item;
                    Detail(new UnitOfWork().AppropriationsRepoRepo.Find(m => m.Id == item.Id));

                }
            }
        }
    }


}
