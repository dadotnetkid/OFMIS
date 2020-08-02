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
using Models.Repository;
using Models;

namespace Win.Ofcs
{
    public partial class frmAddEditOffice : DevExpress.XtraEditors.XtraForm
    {
        private MethodType methodType;
        private Offices offices;
        private bool isClosed;

        public frmAddEditOffice(Offices offices, MethodType methodType)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.offices = offices;
            Init();
        }

        void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    Details();
                    return;
                }

                UnitOfWork unitOfWork = new UnitOfWork();
                offices = new Offices()
                {
                    CreatedBy = User.UserId,
                    DateCreated = DateTime.Now
                };
                unitOfWork.OfficesRepo.Insert(offices);
                unitOfWork.Save();
                Details();
            }
            catch (Exception e)
            {

            }
        }
        void Details()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            this.officesBindingSource.DataSource = unitOfWork.OfficesRepo.Get();
            this.employeesBindingSource.DataSource = unitOfWork.EmployeesRepo.Get();
            offices = unitOfWork.OfficesRepo.Find(x => x.Id == offices.Id);
            txtOfficeAcr.Text = offices.OffcAcr;
            txtOfficeName.Text = offices.OfficeName;
            txtTelNo.Text = offices.TelNo;
            txtAddress.Text = offices.Address;
            txtHeadChief.EditValue = offices.Chief;
            txtPosition.Text = offices.ChiefPosition;
            txtResponsibilityCenter.Text = offices.ResponsibilityCenter;
            txtCode.Text = offices.ResponsibilityCenterCode;
            txtInsideAddress.HtmlText = offices.InsideAddress;
            chkDivision.EditValue = offices.IsDivision;
            cboUnderOf.EditValue = offices.UnderOf;

        }

        void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                offices = unitOfWork.OfficesRepo.Find(x => x.Id == offices.Id);
                offices.OffcAcr = txtOfficeAcr.Text;
                offices.OfficeName = txtOfficeName.Text;
                offices.TelNo = txtTelNo.Text;
                offices.Address = txtAddress.Text;
                offices.Chief = txtHeadChief.Text;
                offices.ChiefPosition = txtPosition.Text;
                offices.ResponsibilityCenter = txtResponsibilityCenter.Text;
                offices.ResponsibilityCenterCode = txtCode.Text;
                offices.InsideAddress = txtInsideAddress.ToHtml();
                offices.IsDivision = chkDivision.Checked;
                offices.UnderOf = cboUnderOf.EditValue?.ToInt();
                unitOfWork.Save();
                this.isClosed = true;
                Close();
            }
            catch (Exception ex)
            {

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddEditOffice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (methodType == MethodType.Edit || isClosed)
                return;
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.OfficesRepo.Delete(x => x.Id == offices.Id);
                unitOfWork.Save();
            }
            catch (Exception exception)
            {

            }
        }
    }
}