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
using Win.OB;

namespace Win.BL
{
    public class LoadObligations : ILoad<Obligations>
    {
        private ucObligations uc;
        private int year = new StaticSettings().Year;
        public LoadObligations(ucObligations uc)
        {
            this.uc = uc;
            uc.btnDeleteRepoOBR.ButtonClick += BtnDeleteRepoOBR_ButtonClick;
            uc.btnEditRepoOBR.ButtonClick += BtnEditRepoOBR_ButtonClick;
            uc.OBGridView.FocusedRowChanged += GridObligation_FocusedRowChanged;
            uc.btnEditDV.Click += BtnEditDV_Click;
        }

        private void BtnEditDV_Click(object sender, EventArgs e)
        {
            if (uc.OBGridView.GetFocusedRow() is Obligations item)
            {
                frmEditDisbursementVoucher frm = new frmEditDisbursementVoucher(item);
                frm.ShowDialog();
                this.Init();
            }
        }

        private void BtnEditRepoOBR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (uc.OBGridView.GetFocusedRow() is Obligations item)
            {
                frmAddEditObligation frm = new frmAddEditObligation(MethodType.Edit, item);
                frm.ShowDialog();
                Init();
            }

        }

        private void GridObligation_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is GridView gridView)
            {
                if (gridView.GetFocusedRow() is Obligations item)
                {
                    Detail(new UnitOfWork().ObligationsRepo.Find(m => m.Id == item.Id));
                }
            }
        }

        private void BtnDeleteRepoOBR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (uc.OBGridView.GetFocusedRow() is Obligations item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.ObligationsRepo.Delete(m => m.Id == item.Id);
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
            uc.OBGridControl.DataSource = new EntityServerModeSource()
            { QueryableSource = new UnitOfWork().ObligationsRepo.Fetch(m => m.Year == year) };
            if (uc.OBGridView.GetFocusedRow() is Obligations item)
            {
                Detail(new UnitOfWork().ObligationsRepo.Find(m => m.Id == item.Id));
            }
        }

        public void Detail(Obligations item)
        {
            try
            {
                if (item == null)
                    return;
                uc.lblHeader.Text = item.ControlNo + " - " + item.Payees?.Name;
                uc.txtDate.Text = item.Date.ToString();
                uc.txtControl.Text = item.ControlNo;
                uc.txtPayee.Text = item.Payees?.Name;
                uc.txtOffice.Text = item.Payees?.Office;
                uc.txtAddress.Text = item.Payees?.Address;
                uc.txtORDescription.Text = item.Description;
                uc.txtBudgetOfficer.Text = item.PBO;
                uc.txtChiefOfficer.Text = item.Chief;
                uc.txtPosition.Text = item.ChiefPosition;
                uc.txtAmount.Text = item.Amount.ToString("n2");
                uc.txtStatus.Text = item.Status;
                uc.txtBudgetCtl.Text = item.BudgetControlNo;
                uc.txtParticular.Text = item.DVParticular;
                uc.ORDetailGridControl.DataSource = new BindingList<ORDetails>(item.ORDetails.ToList());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Search(string search)
        {
            var ob = new UnitOfWork().ObligationsRepo.Fetch(m => m.Year == year);
            if (ob.Any(x => x.Description.Contains(search)))
                ob = ob.Where(x => x.Description.Contains(search));
            else if (ob.Any(x => x.ControlNo.Contains(search)))
                ob = ob.Where(x => x.ControlNo.Contains(search));
            else if (ob.Any(x => x.Payees.Name.Contains(search)))
                ob = ob.Where(x => x.Payees.Name.Contains(search));
            else
                ob = null;
            if (uc.cboStatus.Text != "All")
                ob = ob.Where(x => x.Status.Contains(uc.cboStatus.Text));
            this.uc.OBGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = ob
            };
        }
    }
}
