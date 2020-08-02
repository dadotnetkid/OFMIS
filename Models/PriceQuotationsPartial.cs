using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class PriceQuotations
    {
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories BACChairperson => new UnitOfWork(false,false).Signatories.Find(x => x.Person == this.PGSOfficer);
    }
}
