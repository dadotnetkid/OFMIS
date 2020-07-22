using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win.BL;

namespace Win.PropIsSlp
{
    public partial class frmAddEditPIS : DevExpress.XtraEditors.XtraForm, ITransactions<PIS>
    {
        private PIS pIS;

        public frmAddEditPIS(MethodType methodType, PIS pIS)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.pIS = pIS;
            Init();
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.PISRepo.Find(x => x.Id == pIS.Id);
                item.TransfereeId = cboTransferee.EditValue?.ToInt();
                item.TransferorId = cboTransferror.EditValue?.ToInt();
                item.Date = dtDate.DateTime;
                unitOfWork.Save();
                Close();
            }
            catch (Exception e)
            {

            }
        }

        public void Detail()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.PISRepo.Find(x => x.Id == pIS.Id);
                cboTransferror.EditValue = item.TransferorId;
                cboTransferee.EditValue = item.TransfereeId;
                dtDate.EditValue = item.Date;
                this.ItemsGridControl.DataSource =
                    new BindingList<PISDetails>(new UnitOfWork(false, false).PISDetailsRepo.Get(x => x.PISId == item.Id));
                this.cboTransferee.Properties.DataSource = unitOfWork.EmployeesRepo.Get();
                this.cboTransferror.Properties.DataSource = unitOfWork.EmployeesRepo.Get();
            }
            catch (Exception e)
            {

            }
        }

        public void Init()
        {
            try
            {
                if (this.methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                this.pIS = new PIS()
                {
                    Date = DateTime.Now,
                    PreparedBy = User.UserId,
                    PRId = this.pIS.PRId
                };
                unitOfWork.PISRepo.Insert(pIS);
                unitOfWork.Save();
                Detail();
            }
            catch (Exception e)
            {

            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void frmAddEditPIS_Load(object sender, EventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            frmAddFromPO frm = new frmAddFromPO(new UnitOfWork().PISRepo.Find(x => x.Id == this.pIS.Id));
            frm.ShowDialog();
            this.ItemsGridControl.DataSource =
                new BindingList<PISDetails>(new UnitOfWork().PISDetailsRepo.Get(x => x.PISId == pIS.Id));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ItemsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (e.Row is PISDetails item)
                {

                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    item.PISId = pIS.Id;
                    if (item.Id == 0)
                        unitOfWork.PISDetailsRepo.Insert(item);
                    else
                        unitOfWork.PISDetailsRepo.Update(item);
                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void btnDeleteItemRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (ItemsGridView.GetFocusedRow() is PISDetails item)
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    unitOfWork.PISDetailsRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    this.ItemsGridControl.DataSource =
                        new BindingList<PISDetails>(unitOfWork.PISDetailsRepo.Get(x => x.PISId == item.PISId));
                }
            }
            catch (Exception exception)
            {

            }
        }
    }
}