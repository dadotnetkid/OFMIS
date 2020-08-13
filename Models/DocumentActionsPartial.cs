using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;
using Newtonsoft.Json;

namespace Models
{
    public partial class DocumentActions
    {
        private UnitOfWork unitOfWork = new UnitOfWork(false, false);




        [JsonIgnore]
        [NotMapped]
        public Actions Programs => unitOfWork.ActionsRepo.Find(x => x.Id == ProgramId);
        [JsonIgnore]
        [NotMapped]
        public Actions MainActivity => unitOfWork.ActionsRepo.Find(x => x.Id == MainActivityId);
        [JsonIgnore]
        [NotMapped]
        public Actions Activity => unitOfWork.ActionsRepo.Find(x => x.Id == ActivityId);
        [JsonIgnore]
        [NotMapped]
        public Actions SubActivity => unitOfWork.ActionsRepo.Find(x => x.Id == SubActivityId);
        [JsonIgnore]
        [NotMapped]
        public string RouterUsers => string.Join(",", this.RoutedToUsers.Select(x => x.FullName));
        [JsonIgnore]
        [NotMapped]
        public Users CreatedByUser => new UnitOfWork().UsersRepo.Fetch(x => x.Id == CreatedBy).FirstOrDefault();
        [JsonIgnore]
        [NotMapped]
        public string Description =>
            TableName == "PurchaseRequests" ? unitOfWork.PurchaseRequestsRepo.Find(x => x.Id == RefId)?.Description : unitOfWork.ObligationsRepo.Find(x => x.Id == RefId)?.Description;
        [JsonIgnore]
        [NotMapped]
        public decimal? TotalAmount=> TableName == "PurchaseRequests" ? unitOfWork.PurchaseRequestsRepo.Find(x => x.Id == RefId)?.TotalAmount : unitOfWork.ObligationsRepo.Find(x => x.Id == RefId)?.TotalAmount;
    }
}
