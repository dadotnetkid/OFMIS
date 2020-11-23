using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.RichEdit.Export;
using DevExpress.XtraEditors;
using Microsoft.JScript;
using Win.Properties;
using Settings = Win.Properties.Settings;

namespace Win
{
    public partial class frmFundTypeChoices : DevExpress.XtraEditors.XtraForm
    {
        public frmFundTypeChoices()
        {
            InitializeComponent();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SimpleButton btn)
                {
                    ctrl.Click += (btnS, btnE) =>
                    {
                        Settings.Default.FundType = ctrl.Tag.ToString();
                        Close();
                    };
                }
            }
        }
    }
}