using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Helpers;
using Models;
using Models.Repository;
using Win.Xcanner;

namespace Win
{
    public partial class UCFiles : DevExpress.XtraEditors.XtraUserControl
    {
        private int refId;
        private string fileName;

        public UCFiles(int refId)
        {
            InitializeComponent();
            this.refId = refId;
            Init();
        }
        public UCFiles(int refId, string fileName)
        {
            InitializeComponent();
            this.refId = refId;
            this.fileName = fileName;
            Init();
        }
        void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.FilesGridControl.DataSource =
                    unitOfWork.FilesRepo.Get(x => x.RefId == refId && x.TableName == "Document-Files");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ScannerHelper.SaveFiles("DTS", new StaticSettings().Offices.OffcAcr, refId, "Document-Files", User.UserId,
                web =>
                {
                    web.UploadProgressChanged += (wE, sE) =>
                    {
                        tsDownloading.Text = $"Uploading: {sE.ProgressPercentage} %";
                        tsProgress.Value = (sE.ProgressPercentage);
                    };
                }); this.Init();
        }

        private void btnDeletePQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.FilesGridView.GetFocusedRow() is Files item)
            {
                ScannerHelper.DeleteFile(item.Id);

                this.Init();
            }
        }

        private void btnDownload_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.FilesGridView.GetFocusedRow() is Files item)
            {

                ScannerHelper.DownloadFile("Document-Files", item.Id, web =>
                {
                    web.DownloadProgressChanged += Web_DownloadProgressChanged;

                });
            }
        }



        private void Web_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            tsDownloading.Text = $"Downloading: {e.ProgressPercentage} %";
            tsProgress.Value = e.ProgressPercentage;
        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            WIAHelper wIAHelper = new WIAHelper();
            wIAHelper.GetDefaultDeviceID();
            SplashScreenManager.ShowForm(this, typeof(frmLoading), true, true, SplashFormStartPosition.Default, new Point(0, 0), ParentFormState.Locked);
            var res = await wIAHelper.ScanPages();
            SplashScreenManager.CloseForm();
            foreach (var i in res)
            {
                ScannerHelper.SaveImage("OFMIS", new StaticSettings().Offices.OffcAcr, this.refId, "Document-Files",
                    fileName , User.UserId, i);
           
            }
            this.Init();
        }
    }
}
