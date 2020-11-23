using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Models.ViewModels;
using WIA;
namespace Win.Xcanner
{
    public partial class frmListOfScanner : DevExpress.XtraEditors.XtraForm
    {
        private List<ScannerViewModels> Devices = new List<ScannerViewModels>();
        public Scanners scanners = new Scanners();

        public frmListOfScanner(Action<Scanners> scanners)
        {
            InitializeComponent();
            scanners(this.scanners);
        }

        private async void frmListOfScanner_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmLoading), true, true, SplashFormStartPosition.Default, new Point(0, 0), ParentFormState.Locked);
            await Task.Run((() =>
            {
                ListOfDevices();

            }));


        }


        void ListOfDevices()
        {
            try
            {
                var deviceManager = new DeviceManager();



                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++) // Loop Through the get List Of Devices.
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType) // Skip device If it is not a scanner
                    {
                        continue;
                    }

                    this.Devices.Add(new ScannerViewModels()
                    {
                        Id = i,
                       // ScannerName = deviceManager.DeviceInfos[i].Properties["Name"].get_Value()

                    });
                }
                this.Invoke(new Action(() =>
                {

                    SplashScreenManager.CloseForm();
                    this.scannerViewModelsBindingSource.DataSource = Devices;
                    var dev = Devices.FirstOrDefault(x => x.ScannerName == Properties.Settings.Default.DefaultScanner);
                    this.cboScanner.EditValue = dev.Id;
                }));
                if (deviceManager.DeviceInfos.Count <= 0)
                    throw new COMException("No Device found");

            }
            catch (COMException ex)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }));
            }
        }

        private async void btnSelect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultScanner = cboScanner.Text;
            Properties.Settings.Default.Save();
            SplashScreenManager.ShowForm(this, typeof(frmLoading), true, true, SplashFormStartPosition.Default, new Point(0, 0), ParentFormState.Locked);
            await Task.Run((() => { Scan(); }));
            SplashScreenManager.CloseForm();
        }

        void Scan()
        {
            var deviceManager = new DeviceManager();

            DeviceInfo AvailableScanner = null;
            if (cboScanner.GetSelectedDataRow() is ScannerViewModels item)
            {
                AvailableScanner = deviceManager.DeviceInfos[item.Id];
                var device = AvailableScanner.Connect(); //Connect to the available scanner.

                var ScanerItem = device.Items[1]; // select the scanner.

                var imgFile = (ImageFile)ScanerItem.Transfer(); //Retrive an image in Jpg format and store it into a variable.
                this.Invoke(new Action(() =>
                {
                    this.scanners.ScanImage = Image.FromStream(new MemoryStream((byte[])imgFile.FileData.get_BinaryData()));
             
                    this.Close();
                }));
            }

        }
    }
}