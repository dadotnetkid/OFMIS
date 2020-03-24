using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class ScannerViewModels
    {
        public int Id { get; set; }
        public string ScannerName { get; set; }
    }

    public class Scanners
    {
        public System.Drawing.Image ScanImage { get; set; }
        public string ImageId { get; set; }
        public int RefId { get; set; }
        public string TableName { get; set; }
    }
}
