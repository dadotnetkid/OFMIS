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
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Signatories PA => unitOfWork.Signatories.Find(x => x.Position == "Provincial Administrator");
        private Signatories Gov => unitOfWork.Signatories.Find(x => x.Position == "Governor");
        public Signatories Signatories => (TotalAmount??0) >= 500000 ? Gov : PA;
        public Signatories PAGov => (TotalAmount ?? 0) < 500000 ? Gov : null;
        public string AmountToWord => this.TotalAmount?.ToString("0.00##").NumberToWords();
    }
}
