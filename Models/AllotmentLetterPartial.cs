using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class AllotmentLetter
    {
        public string ControlNo => this.PurchaseRequests?.ControlNo;
        public string User { get; set; }
    }
}
