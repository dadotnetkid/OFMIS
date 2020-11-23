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
using Win.Properties;

namespace Win
{
    public partial class frmUserSettings : DevExpress.XtraEditors.XtraForm
    {
        public frmUserSettings()
        {
            InitializeComponent();
            this.Init();
        }

        void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();
                this.yearsBindingSource.DataSource = unitOfWork.YearsRepo.Get(x => x.OfficeId == staticSettings.OfficeId);
                this.checkEdit1.EditValue = Settings.Default.UseDefaultYear;
                this.cboYear.EditValue = Settings.Default.DefaultYear;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Settings.Default.UseDefaultYear = false;
                Settings.Default.DefaultYear = 0;
                if (checkEdit1.Checked == true)
                {
                    Settings.Default.UseDefaultYear = true;
                    Settings.Default.DefaultYear = cboYear.EditValue.ToInt();
                }

                Settings.Default.Save();
                (Application.OpenForms?["Main"]).Text = $@"OFMIS[{cboYear.EditValue}]";
                MessageBox.Show($@"Succesfully select {cboYear.EditValue}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}