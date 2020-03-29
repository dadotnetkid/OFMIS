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

namespace Win
{
    public partial class frmDefaultSettings : DevExpress.XtraEditors.XtraForm
    {

        public frmDefaultSettings()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDefaultSettings_Load(object sender, EventArgs e)
        {
            var i = new StaticSettings().settings();
            if (i == null)
                return;
            txtPG.Text = i.PG;
            txtPGPos.Text = i.PGPos;
            txtPA.Text = i.PA;
            txtPAPos.Text = i.PAPos;
            txtPBO.Text = i.PBO;
            txtPBOPos.Text = i.PBOPos;
            txtPT.Text = i.PT;
            txtPTPos.Text = i.PTPos;
            txtPAccountant.Text = i.PAccountant;
            txtPAccountantPos.Text = i.PAccountantPos;
            txtPGSO.Text = i.PGSO;
            txtPGSOPos.Text = i.PGSOPosition;
            txtDepartment.Text = i.Department;
            txtChiefOfOffice.Text = i.ChiefOfOffice;
            txtChiefOfOfficePos.Text = i.ChiefOfOfficePos;
            txtResponsibilityCenter.Text = i.ResponsibilityCenterCode;
            txtResponsibilityCenterCode.Text = i.ResponsibilityCenterCode;
            txtOfficeId.Text = i.OfficeId;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                var settings = new StaticSettings();
                var defaultSettings = new DefaultSettings()
                {
                    PG = txtPG.Text,
                    PGPos = txtPGPos.Text,
                    PA = txtPA.Text,
                    PAPos = txtPAPos.Text,
                    PT = txtPT.Text,
                    PTPos = txtPTPos.Text,
                    PAccountant = txtPAccountant.Text,
                    PAccountantPos = txtPAccountantPos.Text,
                    PGSO = txtPGSO.Text,
                    PGSOPosition = txtPGSOPos.Text,
                    Department = txtDepartment.Text,
                    ChiefOfOffice = txtChiefOfOffice.Text,
                    ChiefOfOfficePos = txtChiefOfOfficePos.Text,
                    ResponsibilityCenter = txtResponsibilityCenter.Text,
                    ResponsibilityCenterCode = txtResponsibilityCenterCode.Text,
                    OfficeId = txtOfficeId.Text,
                    PBO = txtPBO.Text,
                    PBOPos = txtPBOPos.Text,
                    Year = settings.Year,
                    Id = settings.Id
                };
                var unitOfWork = new UnitOfWork();
                if (settings.Id == 0)
                    unitOfWork.DefaultSettingsRepo.Insert(defaultSettings);
                else
                    unitOfWork.DefaultSettingsRepo.Update(defaultSettings);
                unitOfWork.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}