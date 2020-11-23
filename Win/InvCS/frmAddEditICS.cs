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
using DevExpress.DataProcessing;

namespace Win.InvCS
{
    public partial class frmAddEditICS : DevExpress.XtraEditors.XtraForm
    {
        private ICS item;
        private MethodType methodType;
        private bool isClosed;

        public frmAddEditICS(ICS item, MethodType methodType)
        {
            InitializeComponent();
            this.item = item;
            this.methodType = methodType;
            this.Init();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            frmAddFromPO frm = new frmAddFromPO(item);
            frm.ShowDialog();


        }

        void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    this.isClosed = true;
                    this.Details(new UnitOfWork().ICSRepo.Find(x => x.Id == item.Id));
                    return;
                }

                item = new ICS()
                {
                    Date = DateTime.Now,
                    CreatedBy = User.UserId,
                };

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.ICSRepo.Insert(item);
                unitOfWork.Save();
                Details(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Save()
        {

            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                UnitOfWork unitOfWork = new UnitOfWork();
                var res = unitOfWork.ICSRepo.Find(x => x.Id == item.Id);
                res.Date = dtDate.DateTime;
                if (cboIssuer.GetSelectedDataRow() is Employees issuer)
                {
                    res.Issuer = issuer.EmployeeName;
                    res.IssuerPosition = issuer.Position;
                }

                if (cboReceiver.GetSelectedDataRow() is Employees receiver)
                {
                    res.Receiver = receiver.EmployeeName;
                    res.ReceiverPos = receiver.Position;
                }

                if (cboPGSO.GetSelectedDataRow() is Signatories sig)
                {
                    res.PGSO = sig.Person;
                    res.PGSOPos = sig.Position;
                }

                unitOfWork.Save();
                isClosed = true;
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Details(ICS item)
        {
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                this.ItemsGridControl.DataSource =
                    new BindingList<ICSDetails>(unitOfWork.ICSDetailsRepo.Get(x => x.ICSId == item.Id));
                this.employeesBindingSource.DataSource = unitOfWork.EmployeesRepo.Get();
                this.signatoriesBindingSource.DataSource = unitOfWork.Signatories.Get();
                this.dtDate.EditValue = item.Date;
                this.cboIssuer.EditValue = item.Issuer;
                this.cboReceiver.EditValue = item.Receiver;
                this.cboPGSO.EditValue = item.PGSO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}