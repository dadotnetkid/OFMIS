using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class PayrollWages
    {
        private UnitOfWork unitOfWork = new UnitOfWork(false,false);
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories Governor
        {
            get
            {
                if (this.Obligations.Offices.IsDivision == true)
                    return Signatories?.Position != "Governor" ? unitOfWork.Signatories.Find(m => m.Position == "Governor") : null;
                return null;
            }
        }
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories Signatories => unitOfWork.Signatories.Find(m => m.Id == ApprovedById);
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories ProvincialAdministrator =>
            unitOfWork.Signatories.Find(m => m.Position == "Provincial Administrator");
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories UnderSignPA => unitOfWork.Signatories.Find(m => m.Position == "Governor");
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories GovernorSig => unitOfWork.Signatories.Find(m => m.Position == "Governor");
    }
}
