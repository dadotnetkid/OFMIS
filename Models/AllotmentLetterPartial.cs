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
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public string ControlNo => this.PurchaseRequests?.ControlNo;
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public string User { get; set; }
    }
}
