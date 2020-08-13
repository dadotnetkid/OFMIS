using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace Win.Test
{
    public struct PageSize
    {
        public double Height;
        public double Width;

        public PageSize(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
    }

    class WIA_PROPERTIES
    {
        public const uint WIA_RESERVED_FOR_NEW_PROPS = 1024;
        public const uint WIA_DIP_FIRST = 2;
        public const uint WIA_DPA_FIRST = WIA_DIP_FIRST + WIA_RESERVED_FOR_NEW_PROPS;

        public const uint WIA_DPC_FIRST = WIA_DPA_FIRST + WIA_RESERVED_FOR_NEW_PROPS;

        //
        // Scanner only device properties (DPS)
        //
        public const uint WIA_DPS_FIRST = WIA_DPC_FIRST + WIA_RESERVED_FOR_NEW_PROPS;
        public const uint WIA_DPS_DOCUMENT_HANDLING_STATUS = WIA_DPS_FIRST + 13;
        public const uint WIA_DPS_DOCUMENT_HANDLING_SELECT = WIA_DPS_FIRST + 14;
    }



    public class WiaWrapper
    {

        //Image Filenames
        const string wiaFormatBMP = "{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}";
        const string wiaFormatPNG = "{B96B3CAF-0728-11D3-9D7B-0000F81EF32E}";
        const string wiaFormatGIF = "{B96B3CB0-0728-11D3-9D7B-0000F81EF32E}";
        const string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
        const string wiaFormatTIFF = "{B96B3CB1-0728-11D3-9D7B-0000F81EF32E}";

        //Standard Page Sizes
        public PageSize A3 = new PageSize(16.5, 11.7);
        public PageSize A4 = new PageSize(11.7, 8.3);
        public PageSize A5 = new PageSize(8.3, 5.8);
        public PageSize A6 = new PageSize(5.8, 4.1);

        public string DeviceID;

        #region Setup/select Scanner

        /// <summary>
        /// Select Scanner.
        /// If you need to save the Scanner, Save WiaWrapper.DeviceID
        /// </summary>
        public void SelectScanner()
        {
            WIA.CommonDialog wiaDiag = new WIA.CommonDialog();

            try
            {
                Device d = wiaDiag.ShowSelectDevice(WiaDeviceType.UnspecifiedDeviceType, true, false);
                if (d != null)
                {
                    DeviceID = d.DeviceID;
                    return;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error, Is a scanner chosen?");
            }

            throw new Exception("No Device Selected");
        }

        /// <summary>
        /// Connect to Scanning Device
        /// </summary>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        private Device Connect()
        {
            Device WiaDev = null;

            DeviceManager manager = new DeviceManager();

            //Iterate through each Device until correct Device found
            foreach (DeviceInfo info in manager.DeviceInfos)
            {
                if (info.DeviceID == DeviceID)
                {
                    WIA.Properties infoprop = info.Properties;

                    WiaDev = info.Connect();
                    return WiaDev;
                }
            }

            throw new Exception("Scanner not found - Is it setup in DeviceID?");
        }

        #endregion

        #region Scanning utilities - hasMorePages, SetupPageSize, SetupADF, DeleteFile

        /// <summary>
        /// Check to see if ADF has more pages loaded
        /// </summary>
        /// <param name="wia"></param>
        /// <returns></returns>
        private bool HasMorePages(Device wia)
        {

            //determine if there are any more pages waiting
            Property documentHandlingSelect = null;
            Property documentHandlingStatus = null;

            string test = string.Empty;

            foreach (Property prop in wia.Properties)
            {
                string propername = prop.Name;
                string propvalue = prop.get_Value().ToString();

                test += propername + " " + propvalue + "<br>";

                if (prop.PropertyID == WIA_PROPERTIES.WIA_DPS_DOCUMENT_HANDLING_SELECT)
                    documentHandlingSelect = prop;
                if (prop.PropertyID == WIA_PROPERTIES.WIA_DPS_DOCUMENT_HANDLING_STATUS)
                    documentHandlingStatus = prop;
            }

            if ((Convert.ToUInt32(documentHandlingSelect.get_Value()) & 0x00000001) != 0)
            {
                return ((Convert.ToUInt32(documentHandlingStatus.get_Value()) & 0x00000001) != 0);
            }

            string tester = test;

            return false;

        }

        /// <summary>
        /// Setup Page Size
        /// </summary>
        /// <param name="wia"></param>
        private void SetupPageSize(Device wia, bool rotatePage, PageSize pageSize, int DPI, WIA.Item item)
        {

            try
            {
                foreach (WIA.Property itemProperty in item.Properties)
                {

                    if (itemProperty.Name.Equals("Horizontal Resolution"))
                    {
                        ((IProperty)itemProperty).set_Value(DPI);
                    }
                    else if (itemProperty.Name.Equals("Vertical Resolution"))
                    {
                        ((IProperty)itemProperty).set_Value(DPI);
                    }
                    else if (itemProperty.Name.Equals("Horizontal Extent"))
                    {

                        double extent = DPI * pageSize.Height;

                        if (rotatePage)
                        {
                            extent = DPI * pageSize.Width;
                        }


                        ((IProperty)itemProperty).set_Value(extent);


                    }
                    else if (itemProperty.Name.Equals("Vertical Extent"))
                    {
                        double extent = DPI * pageSize.Width;

                        if (rotatePage)
                        {
                            extent = pageSize.Height * DPI;
                        }


                        ((IProperty)itemProperty).set_Value(extent);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Setup Page Size Property
            

        }

        /// <summary>
        /// Setup device to Use ADF if required
        /// </summary>
        private void SetupADF(Device wia, bool duplex)
        {
            string adf = string.Empty;

            foreach (WIA.Property deviceProperty in wia.Properties)
            {
                adf += deviceProperty.Name + "<br>";
                if (deviceProperty.Name == "Document Handling Select") //or PropertyID == 3088
                {
                    int value = duplex ? 0x004 : 0x001;
                    deviceProperty.set_Value(value);
                }

            }

        }

        private void Delete_File(string filename)
        {
            //Overwrite File
            if (File.Exists(filename))
            {
                //file exists, delete it
                File.Delete(filename);
            }

        }

        #endregion

        #region Scan Page - Main Public Method

        /// <summary>
        /// Scan Page,
        /// </summary>
        /// <param name="wia">Connected Device</param>
        /// <param name="pageSize">Page Size. A4, A3, A2 Etc</param>
        /// <param name="RotatePage">Rotation of page while scanning</param>
        public void Scan(PageSize pageSize, bool rotatePage, int DPI, string filepath, bool useAdf, bool duplex)
        {
            int pages = 0;
            bool hasMorePages = false;

            WIA.CommonDialog WiaCommonDialog = new WIA.CommonDialog();

            try
            {
                do
                {
                    //Connect to Device
                    Device wia = Connect();
                    WIA.Item item = wia.Items[1] as WIA.Item;

                    //Setup ADF
                    if ((useAdf) || (duplex))
                        SetupADF(wia, duplex);

                    //Setup Page Size
                    SetupPageSize(wia, rotatePage, pageSize, DPI, item);

                    WIA.ImageFile imgFile = null;
                    WIA.ImageFile imgFile_duplex = null; //if duplex is setup, this will be back page


                    imgFile = (ImageFile)WiaCommonDialog.ShowTransfer(item, wiaFormatJPEG, false);

                    //If duplex page, get back page now.
                    if (duplex)
                    {
                        imgFile_duplex = (ImageFile)WiaCommonDialog.ShowTransfer(item, wiaFormatJPEG, false);
                    }

                    string varImageFileName = filepath + "\\Scanned-" + pages.ToString() + ".jpg";
                    Delete_File(varImageFileName); //if file already exists. delete it.
                    imgFile.SaveFile(varImageFileName);

                    string varImageFileName_duplex;

                    if (duplex)
                    {
                        varImageFileName_duplex = filepath + "\\Scanned-" + pages++.ToString() + ".jpg";
                        Delete_File(varImageFileName_duplex); //if file already exists. delete it.
                        imgFile_duplex.SaveFile(varImageFileName);
                    }

                    //Check with scanner to see if there are more pages.
                    if (useAdf || duplex)
                    {
                        hasMorePages = HasMorePages(wia);
                        pages++;@
                    }

                } while (hasMorePages);
            }
            catch (COMException ex)
            {

            }
        }

        #endregion
    }
}