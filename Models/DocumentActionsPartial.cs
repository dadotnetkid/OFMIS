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

        private string _CreatedByUser;

        public string CreatedByUserFullName
        {
            get
            {
                if (_CreatedByUser != null)
                    _CreatedByUser = this.CreatedByUser.FullName;
                return _CreatedByUser;
            }
            set { _CreatedByUser = value; }
        }


        [NotMapped]
        public Actions Programs
        {
            get
            {
                if (_programs == null)
                    _programs = unitOfWork.ActionsRepo.Find(x => x.Id == ProgramId, false, false);
                return _programs;
            }
            set => _programs = value;
        }

        [NotMapped]
        public Actions MainActivity
        {
            get
            {
                if (_mainActivity == null)
                    _mainActivity = unitOfWork.ActionsRepo.Find(x => x.Id == MainActivityId, false, false);
                return _mainActivity;
            }
            set => _mainActivity = value;
        }

        [NotMapped]
        public Actions Activity
        {
            get
            {
                if (_activity == null)
                    _activity = unitOfWork.ActionsRepo.Find(x => x.Id == ActivityId, false, false); ;
                return _activity;
            }
            set => _activity = value;
        }

        [NotMapped]
        public Actions SubActivity
        {
            get
            {
                if (_subActivity == null)
                    _subActivity = unitOfWork.ActionsRepo.Find(x => x.Id == SubActivityId, false, false);
                return _subActivity;
            }
            set => _subActivity = value;
        }

        [NotMapped]
        public string RouterUsers
        {
            get
            {
                if (_routerUsers == null)
                {
                    _routerUsers = string.Join(",", this.RoutedToUsers.Select(x => x.FirstName + " " + x.LastName ));
                }
                return _routerUsers;
            }
            set => _routerUsers = value;
        }

        [NotMapped]
        public Users CreatedByUser
        {
            get
            {
                if (_createdByUser == null)
                    _createdByUser = new UnitOfWork().UsersRepo.Fetch(x => x.Id == CreatedBy).Select(x => new
                    {
                        x.FirstName,
                        x.MiddleName,
                        x.LastName
                    }).ToList().Select(x => new Users()
                    {
                        FirstName = x.FirstName,
                        MiddleName = x.MiddleName,
                        LastName = x.LastName
                    }).FirstOrDefault();
                return _createdByUser;
            }
            set => _createdByUser = value;
        }

        [NotMapped]
        public string Description
        {
            get
            {
                if (_description == null)
                    _description = TableName == "PurchaseRequests" ?
                        unitOfWork.PurchaseRequestsRepo.Fetch(x => x.Id == RefId).Select(x => new { x.Description }).ToList().Select(x => new PurchaseRequests() { Description = x.Description }).FirstOrDefault()?.Description
                        :
                        unitOfWork.ObligationsRepo.Fetch(x => x.Id == RefId).Select(x => new { x.Description }).ToList().Select(x => new Obligations()
                        {
                            Description = x.Description
                        }).FirstOrDefault()?.Description;
                return _description;
            }
            set => _description = value;
        }


        private string _description;
        private decimal? _totalAmount;
        private string _routerUsers;
        private Users _createdByUser;
        private Actions _programs;
        private Actions _mainActivity;
        private Actions _activity;
        private Actions _subActivity;


        [NotMapped]
        public decimal? TotalAmount
        {
            get
            {
                if (_totalAmount == null)
                {
                    if (TableName == "PurchaseRequests")
                    {
                        _totalAmount = unitOfWork.PurchaseRequestsRepo.Fetch(x => x.Id == RefId).Select(x => x.TotalAmount).ToList().Select(x => new PurchaseRequests()
                        {
                            TotalAmount = x
                        }).FirstOrDefault()?.TotalAmount;
                    }
                    else
                    {
                        var obr = unitOfWork.ORDetailsRepo.Fetch(x => x.Obligations.ControlNo == this.ControlNo)
                            .Select(x => new {Amount= x.Amount??0 }).ToList();     // unitOfWork.ObligationsRepo.Find(x => x.ControlNo == this.ControlNo, false, false, "ORDetails");
                        var res = obr.Sum(x => x.Amount );
                        _totalAmount = res;
                    }
                }

                return _totalAmount;
            }
            set => _totalAmount = value;
        }
    }
}
