using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class StatusSummaryOfFinancialDocumentsVM
    {
        public int FinancialDocumentId{ get; set; }
        public string ControlNo { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? LastActionDate { get; set; }
        public string LastActionTaken { get; set; }
        public string Remarks { get; set; }
        public string DocumentType { get; set; }
    }

}
