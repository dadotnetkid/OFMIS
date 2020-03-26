using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid;
using Models;
using Models.Repository;
using Win.Accnts;

namespace Win.BL
{
    public class LoadAppropriations : ILoad<Appropriations>
    {
        private UcAccounts uc;

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
        }

        private void BtnReAlignmentDeleteRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uc.ReAlignmentGridView.GetFocusedRow() is ReAlignments item)
            {
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
            frmAddEditAllotment frm = new frmAddEditAllotment(Models.MethodType.Add,
                new Models.Allotments() { Appropriations = this.Appropriations });
            frm.ShowDialog();
            Detail(new UnitOfWork().AppropriationsRepoRepo.Find(m => m.Id == Appropriations.Id));
        }

        public Appropriations Appropriations { get; set; }

        public void Init()
        {
            uc.appropriationGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().AppropriationsRepoRepo.Fetch()
            };

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
                uc.txtAppropriation.Text = item.Appropriation?.ToString("n2");
                uc.txtAllotment.Text = item.Allotment?.ToString("n2");
                uc.txtAppropriationBalance.Text = item.AppropriationBalance?.ToString("n2");
                uc.txtObligationOffice.Text = item.ObligationsOffice?.ToString("n2");
                uc.txtAllotmentBalanceIncEM.Text = item.AllotmentBalanceIncEM?.ToString("n2");
                uc.txtAllotmentBalanceExcEM.Text = item.AllotmentBalanceExcEM?.ToString("n2");
                uc.txtReAlignment.Text = item.ReAligment?.ToString("n2");
                uc.lblHeader.Text = item.AccountCode + " - " + item.AccountName;

                uc.AllotmentGridControl.DataSource = new BindingList<Allotments>(item.Allotments.ToList());
                uc.ObligationGridControl.DataSource = new BindingList<ORDetails>(item.ORDetails.ToList());
                uc.ReAlignmentGridControl.DataSource = new BindingList<ReAlignments>(new UnitOfWork().ReAlignmentsRepo.Get(m => m.SourceAppropriationId == item.Id || m.TargetAppropriationId == item.Id).ToList());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Search(string search)
        {
            IQueryable obj = null;
            var unitOfWork = new UnitOfWork();
            if (unitOfWork.AppropriationsRepoRepo.Fetch(x => x.AccountCode.Contains(search)).Any())
                obj = unitOfWork.AppropriationsRepoRepo.Fetch(x => x.AccountCode.Contains(search));
            else if (unitOfWork.AppropriationsRepoRepo.Fetch(x => x.AccountCodeText.Contains(search)).Any())
                obj = unitOfWork.AppropriationsRepoRepo.Fetch(x => x.AccountCodeText.Contains(search));
            else if (unitOfWork.AppropriationsRepoRepo.Fetch(x => x.AccountName.Contains(search)).Any())
                obj = unitOfWork.AppropriationsRepoRepo.Fetch(x => x.AccountName.Contains(search));

            uc.appropriationGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = obj
            };
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
