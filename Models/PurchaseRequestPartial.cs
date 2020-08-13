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
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories Governor => this.DeptHeadPos == "Governor" ? new Signatories() : new UnitOfWork(false,false).Signatories.Find(m => m.Position == "Governor");
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories PublicAdministrator => this.PAPos == "Provincial Administrator" ? new UnitOfWork(false,false).Signatories.Find(m => m.Position == "Provincial Administrator") : new Signatories() { Person = PA, Position = PAPos };
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories Head => new UnitOfWork(false,false).Signatories.Find(m => m.Person == this.DeptHead);
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public string AmountToWord => (this.TotalAmount ?? 0).NumberToText();
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories PAGov => this.PAPos == "Provincial Administrator"
            ? new UnitOfWork(false,false).Signatories.Find(m => m.Position == "Governor")
            : new Signatories();}
}
