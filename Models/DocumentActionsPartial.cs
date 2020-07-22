using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class DocumentActions
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public Actions Programs => unitOfWork.ActionsRepo.Find(x => x.Id == ProgramId);
        public Actions MainActivity => unitOfWork.ActionsRepo.Find(x => x.Id == MainActivityId);
        public Actions Activity => unitOfWork.ActionsRepo.Find(x => x.Id == ActivityId);
        public Actions SubActivity => unitOfWork.ActionsRepo.Find(x => x.Id == SubActivityId);
        public string RoutedToUsers => string.Join(",", this.Users.Select(x => x.FullName));
        public Users CreatedByUsers => new UnitOfWork().UsersRepo.Fetch(x => x.Id == CreatedBy).FirstOrDefault();

        public string Description =>
            TableName == "PurchaseRequests" ? unitOfWork.PurchaseRequestsRepo.Find(x => x.Id == RefId)?.Description : unitOfWork.ObligationsRepo.Find(x => x.Id == RefId)?.Description;
    }
}
