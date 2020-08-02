using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class LetterViewModel
    {
        public string LetterHeadOffice { get; set; }
        public DateTime Date { get; set; }
        public string HeadOfOffice { get; set; }
        public string HeadOfOfficePosition { get; set; }
        public string HeadOfOfficeAddress { get; set; }
        public string Salutation { get; set; }
        public string Signaturies { get; set; }
        public string SignatoriesPosition { get; set; }

        public string Closing { get; set; }
        public string CC { get; set; }
        public string ShowInTheAbsenceOf { get; set; }
    }
}
