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
            txtResponsibilityCenter.Text = i.ResponsibilityCenterCode;
            txtResponsibilityCenterCode.Text = i.ResponsibilityCenterCode;
            txtOfficeId.Text = i.OfficeId;


        }

        private void btnSave_Click(object sender, EventArgs e)
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
                    Id = settings.Id
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
    }
}