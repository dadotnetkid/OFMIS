using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class PurchaseRequests
    {
        public Signatories Governor => this.DeptHeadPos == "Governor" ? new Signatories() : new UnitOfWork().ChiefOfOfficesRepo.Find(m => m.Position == "Governor");
        public Signatories PublicAdministrator => new UnitOfWork().ChiefOfOfficesRepo.Find(m => m.Position=="Provincial Administrator");
        public Signatories Head => new UnitOfWork().ChiefOfOfficesRepo.Find(m => m.Person == this.DeptHead);
        public string AmountToWord => this.TotalAmount?.ToString().NumberToWords();

    }
}
