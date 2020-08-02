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
        private UnitOfWork unitOfWork = new UnitOfWork(false,false);
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Actions Programs => unitOfWork.ActionsRepo.Find(x => x.Id == ProgramId);
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Actions MainActivity => unitOfWork.ActionsRepo.Find(x => x.Id == MainActivityId);
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Actions Activity => unitOfWork.ActionsRepo.Find(x => x.Id == ActivityId);
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Actions SubActivity => unitOfWork.ActionsRepo.Find(x => x.Id == SubActivityId);
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public string RoutedToUsers => string.Join(",", this.Users.Select(x => x.FullName));
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Users CreatedByUsers => new UnitOfWork().UsersRepo.Fetch(x => x.Id == CreatedBy).FirstOrDefault();
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public string Description =>
            TableName == "PurchaseRequests" ? unitOfWork.PurchaseRequestsRepo.Find(x => x.Id == RefId)?.Description : unitOfWork.ObligationsRepo.Find(x => x.Id == RefId)?.Description;
    }
}
