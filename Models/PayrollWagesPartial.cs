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
        private UnitOfWork unitOfWork = new UnitOfWork();
        public Signatories Governor => Signatories.Position != "Governor" ? unitOfWork.ChiefOfOfficesRepo.Find(m => m.Position == "Governor") : null;
        public Signatories Signatories => unitOfWork.ChiefOfOfficesRepo.Find(m => m.Id == ApprovedById);

        public Signatories ProvincialAdministrator =>
            unitOfWork.ChiefOfOfficesRepo.Find(m => m.Position == "Provincial Administrator");
    }
}
