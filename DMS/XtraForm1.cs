using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WIA2test;

namespace DMS
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Then the usage looks like:
            // item.Properties.SetProperty(WIAExtender.WIA_PROPERTY_CurrentIntent, WIAExtender.WIA_PROPERTY_VALUE_Gray);
            // int handlingStatus = (int)scannerDevice.Properties.GetProperty(WIAExtender.WIA_PROPERTY_DocumentHandlingStatus);

            try
            {
                // some WIA operation
            }
            catch (COMException cx)
            {
                int comErrorCode = cx.GetWIAErrorCode();
                if (comErrorCode > 0)
                {
                    MessageBox.Show(WIAExtender.GetErrorCodeDescription(comErrorCode));
                }
            }
        }
    }
}