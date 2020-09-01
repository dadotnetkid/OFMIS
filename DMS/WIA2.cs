using System.Runtime.InteropServices;
using WIA;
using System.Drawing.Imaging;
using System.Windows.Forms;
using WIA2test;

namespace WIA2test
{
    public static class WIAExtender
    {
        public static string TiffFormat = ImageFormat.Tiff.Guid.ToString("B");

        // copies of constants that are found in WiaDef.h

        public const int WIAFacility = 33;

        public const int WIA_ERROR_GENERAL_ERROR = 1;
        public const int WIA_ERROR_PAPER_JAM = 2;
        public const int WIA_ERROR_PAPER_EMPTY = 3;
        public const int WIA_ERROR_PAPER_PROBLEM = 4;
        public const int WIA_ERROR_OFFLINE = 5;
        public const int WIA_ERROR_BUSY = 6;
        public const int WIA_ERROR_WARMING_UP = 7;
        public const int WIA_ERROR_USER_INTERVENTION = 8;
        public const int WIA_ERROR_ITEM_DELETED = 9;
        public const int WIA_ERROR_DEVICE_COMMUNICATION = 10;
        public const int WIA_ERROR_INVALID_COMMAND = 11;
        public const int WIA_ERROR_INCORRECT_HARDWARE_SETTING = 12;
        public const int WIA_ERROR_DEVICE_LOCKED = 13;
        public const int WIA_ERROR_EXCEPTION_IN_DRIVER = 14;
        public const int WIA_ERROR_INVALID_DRIVER_RESPONSE = 15;
        public const int WIA_S_NO_DEVICE_AVAILABLE = 21;

        public const int WIA_COMPRESSION_JPEG = 5;

        public const int WIA_PROPERTY_CurrentIntent = 6146;
        public const int WIA_PROPERTY_HorizontalResolution = 6147;
        public const int WIA_PROPERTY_VerticalResolution = 6148;
        public const int WIA_PROPERTY_HorizontalExtent = 6151;
        public const int WIA_PROPERTY_VerticalExtent = 6152;
        public const int WIA_PROPERTY_DocumentHandlingSelect = 3088;
        public const int WIA_PROPERTY_DocumentHandlingStatus = 3087;

        public const int WIA_PROPERTY_BitsPerPixel = 4104;
        public const int WIA_PROPERTY_Format = 4106;
        public const int WIA_PROPERTY_Compression = 4107;

        public const int WIA_PROPERTY_VALUE_Color = 1;
        public const int WIA_PROPERTY_VALUE_Gray = 2;
        public const int WIA_PROPERTY_VALUE_BlackAndWhite = 4;
        public static string GetErrorCodeDescription(int errorCode)
        {
            string desc = null;

            switch (errorCode)
            {
                case (WIA_ERROR_GENERAL_ERROR):
                    {
                        desc = "A general error occurred";
                        break;
                    }
                case (WIA_ERROR_PAPER_JAM):
                    {
                        desc = "There is a paper jam";
                        break;
                    }
                case (WIA_ERROR_PAPER_EMPTY):
                    {
                        desc = "The feeder tray is empty";
                        break;
                    }
                case (WIA_ERROR_PAPER_PROBLEM):
                    {
                        desc = "There is a problem with the paper";
                        break;
                    }
                case (WIA_ERROR_OFFLINE):
                    {
                        desc = "The scanner is offline";
                        break;
                    }
                case (WIA_ERROR_BUSY):
                    {
                        desc = "The scanner is busy";
                        break;
                    }
                case (WIA_ERROR_WARMING_UP):
                    {
                        desc = "The scanner is warming up";
                        break;
                    }
                case (WIA_ERROR_USER_INTERVENTION):
                    {
                        desc = "The scanner requires user intervention";
                        break;
                    }
                case (WIA_ERROR_ITEM_DELETED):
                    {
                        desc = "An unknown error occurred";
                        break;
                    }
                case (WIA_ERROR_DEVICE_COMMUNICATION):
                    {
                        desc = "An error occurred attempting to communicate with the scanner";
                        break;
                    }
                case (WIA_ERROR_INVALID_COMMAND):
                    {
                        desc = "The scanner does not understand this command";
                        break;
                    }
                case (WIA_ERROR_INCORRECT_HARDWARE_SETTING):
                    {
                        desc = "The scanner has an incorrect hardware setting";
                        break;
                    }
                case (WIA_ERROR_DEVICE_LOCKED):
                    {
                        desc = "The scanner device is in use by another application";
                        break;
                    }
                case (WIA_ERROR_EXCEPTION_IN_DRIVER):
                    {
                        desc = "The scanner driver reported an error";
                        break;
                    }
                case (WIA_ERROR_INVALID_DRIVER_RESPONSE):
                    {
                        desc = "The scanner driver gave an invalid response";
                        break;
                    }
                default:
                    {
                        desc = "An unknown error occurred";
                        break;
                    }
            }

            return desc;
        }

        public static int GetWIAErrorCode(this COMException cx)
        {
            int origErrorMsg = cx.ErrorCode;

            int errorCode = origErrorMsg & 0xFFFF;

            int errorFacility = ((origErrorMsg) >> 16) & 0x1fff;

            if (errorFacility == WIAFacility)
                return errorCode;

            return -1;
        }

        public static void SetProperty(this WIA.Properties searchBag, int propID, object propValue)
        {
            foreach (Property prop in searchBag)
            {
                if (prop.PropertyID == propID)
                {
                    prop.set_Value(ref propValue);
                    return;
                }
            }
        }

        public static object GetProperty(this WIA.Properties searchBag, int propID)
        {
            foreach (Property prop in searchBag)
            {
                if (prop.PropertyID == propID)
                {
                    return prop.get_Value();
                }
            }
            return null;
        }
    }
}

