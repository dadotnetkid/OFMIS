using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class PayrollDifferentials
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public Signatories Governor
        {
            get
            {
                if (this.Obligations?.Offices?.IsDivision == true)
                    return Signatories?.Position != "Governor" ? unitOfWork.Signatories.Find(m => m.Position == "Governor") : null;
                return null;
            }
        }
        public Signatories Signatories => unitOfWork.Signatories.Find(m => m.Id == ApprovedById);

        public Signatories ProvincialAdministrator =>
            unitOfWork.Signatories.Find(m => m.Position == "Provincial Administrator");

        public Signatories UnderSignPA => unitOfWork.Signatories.Find(m => m.Position == "Governor");
        public Signatories GovernorSig => unitOfWork.Signatories.Find(m => m.Position == "Governor");
    }
}
