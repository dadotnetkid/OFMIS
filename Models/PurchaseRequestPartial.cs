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
        public Signatories Governor => this.DeptHeadPos == "Governor" ? new Signatories() : new UnitOfWork().Signatories.Find(m => m.Position == "Governor");
        public Signatories PublicAdministrator => this.PAPos == "Provincial Administrator" ? new UnitOfWork().Signatories.Find(m => m.Position == "Provincial Administrator") : new Signatories() { Person = PA, Position = PAPos };
        public Signatories Head => new UnitOfWork().Signatories.Find(m => m.Person == this.DeptHead);
        public string AmountToWord => (this.TotalAmount ?? 0).ToString("0.0###").NumberToWords();

        public Signatories PAGov => this.PAPos == "Provincial Administrator"
            ? new UnitOfWork().Signatories.Find(m => m.Position == "Governor")
            : new Signatories();}
}
