using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win;

namespace DMS.PAPS
{
    public partial class frmAddEditPAPsManager : DevExpress.XtraEditors.XtraForm
    {
        private MethodType methodType;
        private Documents documents;
        private bool isClosed;

        public frmAddEditPAPsManager(MethodType methodType, Documents documents)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.documents = documents;
            this.Init();
        }

        void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    Details(this.documents);
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork(new DTSDb());
                StaticSettings staticSettings = new StaticSettings();
                var res = unitOfWork.DocumentsRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault();
                this.documents = new Documents()
                {
                    Date = DateTime.Now,
                    CommunicationType = this.documents.CommunicationType,
                    CreatedBy = User.UserId,
                    OfficeId = staticSettings.OfficeId,
                    ControlNo = IdHelper.OfficeControlNo(res?.ControlNo, staticSettings.OfficeId, "DTS", "Documents"),

                };
                unitOfWork.DocumentsRepo.Insert(documents);
                unitOfWork.Save();
                Details(this.documents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Details(Documents item)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new DTSDb());
                StaticSettings staticSettings = new StaticSettings();
                this.documentTypesBindingSource.DataSource = unitOfWork.DocumentTypesRepo.Get();
                this.officesBindingSource.DataSource = new UnitOfWork().OfficesRepo.Get();
                this.employeesBindingSource.DataSource = new UnitOfWork().EmployeesRepo.Get();
                item = unitOfWork.DocumentsRepo.Find(x => x.Id == item.Id);
                this.dtDate.EditValue = item.Date;
                this.cboCommType.EditValue = item.CommunicationType;
                this.cboType.EditValue = item.DocumentType;
                this.cboSourceOffice.EditValue = item.SourceOfficeId;
                this.txtSubjects.EditValue = item.Subject;
                this.lblControlNo.Text = item.ControlNo;
                this.cboSignatories.EditValue = item.Signatory;
                this.pctScannedDocs.Image = ScannerHelper.ToImageByte(item.Id, "Documents");
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
                UnitOfWork unitOfWork = new UnitOfWork(new DTSDb());
                var item = unitOfWork.DocumentsRepo.Find(x => x.Id == documents.Id);
                item.CommunicationType = cboCommType.EditValue?.ToString();
                item.DocumentType = cboType.EditValue?.ToString();
                item.SourceOfficeId = cboSourceOffice.EditValue?.ToInt();
                item.Signatory = cboSignatories.EditValue?.ToInt();
                item.Subject = txtSubjects.EditValue?.ToString();
                var image = ((byte[]) pctScannedDocs.Image);
                if (image.Length == 0)
                    ScannerHelper.DeleteFile("Documents", item.Id);
                else
                    ScannerHelper.SaveImage("DTS", new StaticSettings().Offices.OffcAcr, item.Id, "Documents", Image.FromStream(new MemoryStream((byte[])pctScannedDocs.Image)));
                unitOfWork.Save();
                this.isClosed = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmAddEditPAPsManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isClosed == true || this.methodType == MethodType.Edit)
                return;

            try
            {

                if (MessageBox.Show("Do you want to close this?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork(new DTSDb());
                unitOfWork.DocumentsRepo.Find(x => x.Id == documents.Id);
                unitOfWork.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}