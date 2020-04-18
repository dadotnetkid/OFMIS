using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win.BL;

namespace Win
{
    public partial class frmDefaultSettings : DevExpress.XtraEditors.XtraForm, ITransactions<DefaultSettings>
    {

        public frmDefaultSettings()
        {
            InitializeComponent();
            Detail();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDefaultSettings_Load(object sender, EventArgs e)
        {



        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Save();

        }

        private void cboIsDivision_CheckedChanged(object sender, EventArgs e)
        {
            var s = sender as CheckEdit;
            if (s.CheckState == CheckState.Checked)
                cboUnderOf.Enabled = true;

        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                var settings = new StaticSettings();
                var defaultSettings = new DefaultSettings()
                {
                    ResponsibilityCenter = txtResponsibilityCenter.Text,
                    ResponsibilityCenterCode = txtResponsibilityCenterCode.Text,
                    OfficeId = txtOfficeId.Text,
                    Year = settings.Year,
                    Id = settings.Id,
                    ChiefOfOffice = txtHead.Text,
                    ChiefOfOfficePos = txtPosition.Text,
                    Department = txtDivision.Text,
                    IsDepartment = chkIsDivision.Checked,
                    UnderOf = cboUnderOf.Text
                };
                var unitOfWork = new UnitOfWork();
                if (settings.Id == 0)
                    unitOfWork.DefaultSettingsRepo.Insert(defaultSettings);
                else
                    unitOfWork.DefaultSettingsRepo.Update(defaultSettings);
                unitOfWork.Save();

                MessageBox.Show("Successfully Save Default Setting", "Default Setting", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {
            var i = new StaticSettings().settings();
            if (i == null)
                return;
            cboUnderOf.Properties.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().DefaultSettingsRepo.Fetch()
            };
            txtResponsibilityCenter.Text = i.ResponsibilityCenterCode;
            txtResponsibilityCenterCode.Text = i.ResponsibilityCenter;
            txtOfficeId.Text = i.OffcAcr.ToString();
            txtHead.Text = i.Chief;
            txtPosition.Text = i.ChiefPosition;
            chkIsDivision.Checked = i.IsDivision.ToBool();
            cboUnderOf.Properties.DataSource = new BindingList<Offices>(new UnitOfWork().OfficesRepo.Get());
            cboUnderOf.EditValue = i.UnderOf;
            txtDivision.Text = i.OfficeName;
        }

        public void Init()
        {

        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }
    }
}