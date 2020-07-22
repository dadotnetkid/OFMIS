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
using Models;
using Models.Repository;

namespace Win.PropAckRcpt
{
    public partial class frmAddEditPAR : DevExpress.XtraEditors.XtraForm
    {
        private MethodType methodType;
        private PAR par;

        public frmAddEditPAR(PAR par, MethodType methodType)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.par = par;
            this.Init();
        }

        private void Init()
        {
            try
            {

                if (methodType == MethodType.Edit)
                {
                    Details();
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();

                var pgso = unitOfWork.Signatories.Find(x => x.Office == "Provincial General Services Office");
                par = new PAR()
                {
                    Date = DateTime.Now,
                    DateCreated = DateTime.Now,
                    CreatedBy = User.UserId,
                    PRId = par.PRId,
                    PGSOId = pgso?.Id,
                    PGSO = pgso?.Person,
                    PGSOPosition = pgso?.Position

                };
                unitOfWork.PARRepo.Insert(par);
                unitOfWork.Save();
                this.Details();
            }
            catch (Exception e)
            {

            }
        }

        private void Details()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.ItemsGridControl.DataSource = new
                    BindingList<PARDetails>(unitOfWork.PARDetailsRepo.Get(x => x.PARId == par.Id));
                employeesBindingSource.DataSource = unitOfWork.EmployeesRepo.Get();
                signatoriesBindingSource.DataSource = unitOfWork.Signatories.Get();
                par = unitOfWork.PARRepo.Find(x => x.Id == par.Id);
                this.cboPGSO.EditValue = par.PGSOId;
                this.cboIssuer.EditValue = par.IssuedById;
                this.cboReceiver.EditValue = par.ReceivedById;
                this.dtDate.EditValue = par.Date;

                this.ItemsGridControl.DataSource =
                    new BindingList<PARDetails>(unitOfWork.PARDetailsRepo.Get(x => x.PARId == par.Id));
            }
            catch (Exception e)
            {

            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                frmAddFromPO frmAddFromPO = new frmAddFromPO(par);
                frmAddFromPO.ShowDialog();
                this.ItemsGridControl.DataSource = new
                    BindingList<PARDetails>(unitOfWork.PARDetailsRepo.Get(x => x.PARId == par.Id));

            }
            catch (Exception exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();
                par = unitOfWork.PARRepo.Find(x => x.Id == par.Id);
                par.EntityName = staticSettings.OfficeName;
                par.FundCluster = par.PurchaseRequests.Appropriations.AccountCodeText;

                if (cboIssuer.GetSelectedDataRow() is Employees issuer)
                {
                    par.IssuedBy = issuer.EmployeeName;
                    par.IssuedById = issuer.Id;
                    par.IssuedByPos = issuer.Position;
                }

                if (cboReceiver.GetSelectedDataRow() is Employees receiver)
                {
                    par.ReceivedBy = receiver.EmployeeName;
                    par.ReceivedById = receiver.Id;
                    par.ReceivedByPos = receiver.Position;
                }

                if (cboPGSO.GetSelectedDataRow() is Signatories pgso)
                {
                    par.PGSO = pgso.Person;
                    par.PGSOId = pgso.Id;
                    par.PGSOPosition = pgso.Position;
                }

                unitOfWork.Save();
                this.Close();
            }
            catch (Exception e)
            {

            }
        }

        private void btnDeleteItemRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();

                if (MessageBox.Show("Do you want to Delete this?", "delte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (ItemsGridView.GetFocusedRow() is PARDetails item)
                {
                    unitOfWork.PARDetailsRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    this.ItemsGridControl.DataSource =
                        new BindingList<PARDetails>(unitOfWork.PARDetailsRepo.Get(x => x.PARId == item.PARId));
                }
            }
            catch (Exception exception)
            {

            }
        }
    }
}