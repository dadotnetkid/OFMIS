using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class PurchaseOrders
    {
        private UnitOfWork unitOfWork = new UnitOfWork(false,false);

        [Newtonsoft.Json.JsonIgnoreAttribute]
        private Signatories PA => unitOfWork.Signatories.Find(x => x.Position == "Provincial Administrator");
        [Newtonsoft.Json.JsonIgnoreAttribute]
        private Signatories Gov => unitOfWork.Signatories.Find(x => x.Position == "Governor");
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories Signatories => (TotalAmount??0) >= 500000 ? Gov : PA;
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories PAGov => (TotalAmount ?? 0) < 500000 ? Gov : null;
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public string AmountToWord => this.TotalAmount?.NumberToText();
    }
}
