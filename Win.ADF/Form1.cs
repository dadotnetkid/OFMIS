using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace Win.ADF
{
    public partial class Form1 : Form
    {
        string deviceId = "";
        private string _deviceId;
        private object _deviceInfo;
        private Device _device;

        public Form1()
        {
            InitializeComponent();
            _deviceId = FindDefaultDeviceId();
            //Find Device  
            _deviceInfo = FindDevice(_deviceId);
            //Connect the device  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Image> obj = ScanPages();
            //This code i written to upload the file  
            foreach (Image aa in obj)
            {
                //aa.Save("D:\\ScanerUploadedFileWIA\\myfile.png _" + DateTime.Now.ToLongTimeString(), ImageFormat.Png);  
                aa.Save(@"D:\ScanerUploadedFileWIA\" + DateTime.Now.ToString("yyyy - MM - dd HHmmss ") + ".jpeg ", ImageFormat.Jpeg);
            }
        }
        private DeviceInfo FindDevice(string deviceId)
        {
            DeviceManager manager = new DeviceManager();
            foreach (DeviceInfo info in manager.DeviceInfos)
                if (info.DeviceID == deviceId)
                    return info;
            return null;
        }
        private string FindDefaultDeviceId()
        {
            if (String.IsNullOrEmpty(deviceId))
            {
                // Select a scanner  
                WIA.CommonDialog wiaDiag = new WIA.CommonDialog();
                Device d = wiaDiag.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, true, false);
                if (d != null)
                {
                    deviceId = d.DeviceID;

                }
            }
            return deviceId;
        }
        public List<Image> ScanPages(int dpi = 150, double width = 8.5, double height = 11)
        {
            Item item = _device.Items[1];
            // configure item of the device  
            SetDeviceItemProperty(ref item, 6146, 2); // greyscale  
            SetDeviceItemProperty(ref item, 6147, dpi); // 150 dpi  
            SetDeviceItemProperty(ref item, 6148, dpi); // 150 dpi  
            SetDeviceItemProperty(ref item, 6151, (int)(dpi * width)); // set scan width  
            SetDeviceItemProperty(ref item, 6152, (int)(dpi * height)); // set scan height  
            SetDeviceItemProperty(ref item, 4104, 8); // bit depth  
            // Detect if the ADF is loaded, if not use the flatbed  
            List<Image> images = GetPagesFromScanner(ScanSource.DocumentFeeder, item);
            if (images.Count == 0)
            {
                // check the flatbed if ADF is not loaded, try from flatbed  
                DialogResult dialogResult;
                do
                {
                    List<Image> singlePage = GetPagesFromScanner(ScanSource.Flatbed, item);
                    images.AddRange(singlePage);
                    dialogResult = MessageBox.Show("Do you want to scan another page?", "ScanToEvernote", MessageBoxButtons.YesNo);
                }
                while (dialogResult == DialogResult.Yes);
            }
            return images;
        }

        private List<Image> GetPagesFromScanner(ScanSource source, Item item)
        {
            SetDeviceProperty(ref _device, 3088, (int)source);
            List<Image> images = new List<Image>();
            int handlingStatus = GetDeviceProperty(ref _device, WIA_DPS_DOCUMENT_HANDLING_STATUS);
            if ((source == ScanSource.DocumentFeeder && handlingStatus == FEED_READY) || (source == ScanSource.Flatbed && handlingStatus == FLATBED_READY))
            {
                do
                {
                    ImageFile wiaImage = null;
                    try
                    {
                        wiaImage = item.Transfer(WIA_FORMAT_JPEG);
                    }
                    catch (COMException ex)
                    {
                        if ((uint)ex.ErrorCode == WIA_ERROR_PAPER_EMPTY)
                            break;
                        else
                            throw;
                    }
                    if (wiaImage != null)
                    {
                        System.Diagnostics.Trace.WriteLine(String.Format("Image is {0} x {1} pixels", (float)wiaImage.Width / 150, (float)wiaImage.Height / 150));
                        Image image = ConvertToImage(wiaImage);
                        images.Add(image);
                    }
                }
                while (source == ScanSource.DocumentFeeder);
            }
            return images;
        }
        private static Image ConvertToImage(ImageFile wiaImage)
        {
            byte[] imageBytes = (byte[])wiaImage.FileData.get_BinaryData();
            MemoryStream ms = new MemoryStream(imageBytes);
            Image image = Image.FromStream(ms);
            return image;
        }
        #region Get / set device properties  
        private void SetDeviceProperty(ref Device device, int propertyID, int propertyValue)
        {
            foreach (Property p in device.Properties)
            {
                if (p.PropertyID == propertyID)
                {
                    object value = propertyValue;
                    p.set_Value(ref value);
                    break;
                }
            }
        }
        private int GetDeviceProperty(ref Device device, int propertyID)
        {
            int ret = -1;
            foreach (Property p in device.Properties)
            {
                if (p.PropertyID == propertyID)
                {
                    ret = (int)p.get_Value();
                    break;
                }
            }
            return ret;
        }
        private void SetDeviceItemProperty(ref Item item, int propertyID, int propertyValue)
        {
            foreach (Property p in item.Properties)
            {
                if (p.PropertyID == propertyID)
                {
                    object value = propertyValue;
                    p.set_Value(ref value);
                    break;
                }
            }
        }
        private int GetDeviceItemProperty(ref Item item, int propertyID)
        {
            int ret = -1;
            foreach (Property p in item.Properties)
            {
                if (p.PropertyID == propertyID)
                {
                    ret = (int)p.get_Value();
                    break;
                }
            }
            return ret;
        }
        #endregion
      
    }
    enum ScanSource
    {
        DocumentFeeder = 1,
        Flatbed = 2,
    }
}
}
