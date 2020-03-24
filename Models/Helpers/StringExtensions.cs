using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Helpers
{
    public static class StringExtensions
    {
        public static Icon ToIcon(this Bitmap bitmap)
        {
            return Icon.FromHandle(bitmap.GetHicon());
        }

        public static DateTime ToDate(this object obj)
        {
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch (Exception e)
            {
                return DateTime.Now;
            }
        }
        public static int ToInt(this object obj)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public static Boolean ToBool(this object obj)
        {
            try
            {
                return Convert.ToBoolean(obj);
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static decimal ToDecimal(this object obj)
        {
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public static string ImageToBase64(byte[] array)
        {
            try
            {
                var base64 = Convert.ToBase64String(array);
                return $"data:image/png;base64,{base64}";
            }
            catch (Exception e)
            {
                var ms = new MemoryStream();
                var img = Image.FromFile(HttpContext.Current.Server.MapPath("~/Content/admin-lte/img/avatar2.png"));
                img.Save(ms, ImageFormat.Png);
                var base64 = Convert.ToBase64String(ms.ToArray());
                return $"data:image/png;base64,{base64}";
            }

        }
    }
}
