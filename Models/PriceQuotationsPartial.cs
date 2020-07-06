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
        public Signatories BACChairperson => new UnitOfWork().Signatories.Find(x => x.Person == this.PGSOfficer);
    }
}
