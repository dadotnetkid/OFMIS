using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Helpers;
using Models.Repository;
using Models.ViewModels;

namespace Win.Xcanner
{
    public partial class frmScanner : DevExpress.XtraEditors.XtraForm
    {
        public Scanners scanners = new Scanners();

        public frmScanner(Action<Scanners> scanner)
        {
            InitializeComponent();
            scanner(scanners);
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            
            frmListOfScanner frmListOfScanner = new frmListOfScanner(scanner => { scanner.RefId = scanners.RefId; });
            var frm = frmListOfScanner.ShowDialogResult();
            scanners = frm.scanners;
            this.pctScanImage.Image = scanners.ScanImage;

        }

        private void btnTestFileServer_Click(object sender, EventArgs e)
        {
            using (NetworkShareAccesser.Access("PLGUNV_NAS", @"", "pitd.is_user", "Apple_01"))
            {
                StaticSettings staticSettings = new StaticSettings();
                var path = $@"\\plgunv_nas\is_docs\ofmis\{staticSettings.Offices.OffcAcr}";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                File.Create(Path.Combine(path, "txt.txt"));
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (NetworkShareAccesser.Access("PLGUNV_NAS", @"", "pitd.is_user", "Apple_01"))
            {
                StaticSettings staticSettings = new StaticSettings();
                UnitOfWork unitOfWork = new UnitOfWork();
                var root = $@"\\plgunv_nas\is_docs\ofmis\{staticSettings.Offices.OffcAcr}";
                if (!Directory.Exists(root))
                    Directory.CreateDirectory(root);
                var fileName = Guid.NewGuid().ToString();
                var path = Path.Combine(root, fileName + ".png");
                pctScanImage.Image.Save(path, ImageFormat.Png);
                unitOfWork.FilesRepo.Insert(new Models.Files()
                {
                    RefId = scanners.RefId,
                    TableName = "Action",
                    RootFolder = root,
                    Path = fileName,

                });
                unitOfWork.Save();
                Close();
            }
        }
    }
}