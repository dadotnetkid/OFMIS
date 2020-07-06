using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class APRs
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public Signatories Governors => unitOfWork.Signatories.Find(x => x.Id == GovernorId);
        public Signatories PA => unitOfWork.Signatories.Find(x => x.Id == AccountantId);
        public Signatories PGSO => unitOfWork.Signatories.Find(x => x.Id == PGSOId);
    }
}
