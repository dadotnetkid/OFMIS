using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class OBRPayrollViewModel
    {
        public int PageIndex { get; set; }

        public string ColumnName { get; set; }

        public decimal? Value { get; set; }
        /*   public int PageIndex { get; set; }
           public decimal? ColumnTitle1 { get; set; }
           public decimal? ColumnTitle2 { get; set; }
           public decimal? Total { get; set; }
           public int Id { get; set; }*/
    }
}
