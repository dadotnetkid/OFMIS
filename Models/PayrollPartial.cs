using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class Payrolls
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public Signatories Governor => this.ApprovedByPos == "Governor" ? null : unitOfWork.Signatories.Find(m => m.Position == "Governor");
        public string Note => unitOfWork.Signatories.Find(m => m.Id == ApprovedById)?.Note;

        public Signatories ProvincialAdministrator =>
            unitOfWork.Signatories.Find(m => m.Id == this.ApprovedById);
    }
}
