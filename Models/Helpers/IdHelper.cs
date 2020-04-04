using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class IdHelper
    {
        public static string OfficeControlNo(string lastId)
        {
            var id = DateTime.Now.ToString("yyyy-MM-") + "0001";
            if (lastId == null)
                return id;
            if (lastId.Contains(DateTime.Now.ToString("yyyy-MM")))
            {
                var ids = lastId.Split(new string[] { DateTime.Now.ToString("yyyy-MM-") }, StringSplitOptions.RemoveEmptyEntries);
                id = DateTime.Now.ToString("yyyy-MM-") + (ids[0].ToInt() + 1).ToString("0000");
            }


            return id;
        }
    }
}
