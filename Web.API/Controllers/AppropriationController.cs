using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Microsoft.Ajax.Utilities;
using System.Security.Cryptography.X509Certificates;

namespace Web.API.Controllers
{
    public class AppropriationController : ApiController
    {
        private int? officeId => User.Identity.GetOfficeId();
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IHttpActionResult GetAppropriation()
        {
            return Ok(new UnitOfWork().AppropriationsRepoRepo.Fetch(m =>
                m.Year == 2020 && m.OfficeId == officeId && m.FT == "GF").Select(x => new
                {
                    x.Id,
                    x.FundType,
                    x.AccountName,
                    x.AccountCodeText
                }).ToList());
        }
        [HttpGet]
        public IHttpActionResult Appropriation(int id)
        {
            var model = new UnitOfWork().AppropriationsRepoRepo
                .Get(x => x.Id == id, includeProperties: "Allotments,ORDetails,PurchaseRequests").Select(x => new
                {
                    x.Id,
                    x.DateCreated,
                    x.AccountCodeText,
                    x.AccountCode,
                    x.FundType,
                    x.AccountName,
                    x.Appropriation,
                    x.OfficeId,
                    x.PurchaseRequestEarmarked,
                    x.Allotment,
                    x.AppropriationBalance,
                    x.ObligationsOffice,
                    x.AllotmentBalanceExcEM,
                    x.AllotmentBalanceIncEM,
                    x.ReAlignment,
                    x.BudgetAccountBalance,
                    x.PurchaseRequestCancelled,
                    Allotments = x.Allotments.Select(a => new
                    {
                        a.Id,
                        a.AppropriationId,
                        a.AllotmentDate,
                        a.AllotmentAmount,
                        a.Remarks,
                        a.CreatedB
                    }),
                    ORDetails = x.ORDetails.Select(m => new
                    {
                        Obligations = new Obligations
                        {
                            Year = m.Obligations.Year,
                            OfficeId = m.Obligations.OfficeId,
                            Amount = m.Obligations.Amount,
                            BudgetControlNo = m.Obligations.BudgetControlNo
                        },
                        m.Amount
                    }).ToList(),

                    PurchaseRequests = x.PurchaseRequests.Select(m => new
                    {
                        Obligations = m.Obligations.Select(o => new { m.TotalAmount }),
                        m.IsEarmark,
                        m.IsClosed,
                        m.IsCancelled,
                        m.TotalAmount
                    }).ToList(),
                    SourceReAlignments = x.SourceReAlignments.Select(m => new
                    {
                        m.Amount
                    }).ToList(),
                    TargetReAlignments = x.TargetReAlignments.Select(m => new
                    {
                        m.Amount
                    }).ToList()
                }).FirstOrDefault();
            return Ok(model);
        }

        [HttpPost]
        public IHttpActionResult Search([FromBody] string search)
        {
            var year = 2020;
            var ft = "GF";
            IQueryable<Appropriations> obj =
                new UnitOfWork().AppropriationsRepoRepo.Fetch(m => m.FT == ft && m.OfficeId == officeId);
            if (ft == "GF")
                obj = obj.Where(x => x.Year == year);
            if (obj.Any(x => x.AccountCode.Contains(search)))
                obj = obj.Where(x => x.AccountCode.Contains(search));
            else if (obj.Any(x => x.AccountCodeText.Contains(search)))
                obj = obj.Where(x => x.AccountCodeText.Contains(search));
            else if (obj.Any(x => x.AccountName.Contains(search)))
                obj = obj.Where(x => x.AccountName.Contains(search));
            else if (obj.Any(x => x.ORDetails.Any(m => m.Obligations.BudgetControlNo.Contains(search))))
                obj = obj.Where(x => x.ORDetails.Any(m => m.Obligations.BudgetControlNo.Contains(search)));
            else if (obj.Any(x => x.ORDetails.Any(m => m.Particulars.Contains(search))))
                obj = obj.Where(x => x.ORDetails.Any(m => m.Particulars.Contains(search)));
            var ret = obj.ToList().Select(x => new
            {
                x.PurchaseRequestEarmarked,
                x.Appropriation,
                x.Allotment,
                x.AppropriationBalance,
                x.ObligationsOffice,
                x.AllotmentBalanceExcEM,
                x.AllotmentBalanceIncEM,
                x.ReAlignment,
                x.AccountCode,
                x.AccountName,
                x.BudgetAccountBalance,
                x.PurchaseRequestCancelled,
            });
            return Ok(ret);
        }

        [HttpPost]
        public IHttpActionResult GetPR([FromBody] Appropriations item)
        {
            var pr = unitOfWork.PurchaseRequestsRepo.Fetch(x => x.OfficeId == officeId)
                .Where(x => x.AppropriationId == item.Id && x.IsEarmark == true).Select(x => new
                {
                    x.Date,
                    x.ControlNo,
                    x.Description,
                    x.Purpose,
                    x.TotalAmount
                });
            return Ok(pr);
        }
        [HttpGet]
        [Route("api/appropriation/ordetails/{id?}")]
        public IHttpActionResult GetORDetails(int? id)
        {
            var orDetails = new UnitOfWork().ORDetailsRepo.Get(m => m.AppropriationId == id,
                includeProperties: "Obligations,Obligations.Payees");
            return Ok(
                orDetails.Select(x => new
                {
                    Obligations = new Obligations()
                    { Date = x.Obligations.Date, ControlNo = x.Obligations.ControlNo, Description = x.Obligations.Description },
                    x.Amount,
                    x.Particulars,
                    x.AppropriationId,
                })
            );
        }
        [HttpGet]
        [Route("api/appropriation/realignment/{id?}")]
        public IHttpActionResult GetRealignment(int? id)
        {
            var realignment = new UnitOfWork().ReAlignmentsRepo
                .Get(m => m.SourceAppropriationId == id || m.TargetAppropriationId == id).ToList();
            return Ok(realignment.Select(x => new
            {
                x.Id,
                x.Date,
                SourceAppropriations = new Appropriations() { AccountName = x.SourceAppropriations.AccountName },
                TargetAppropriations = new Appropriations() { AccountName = x.TargetAppropriations.AccountName },
                x.Amount,
                x.Remarks

            }));
        }

        [HttpPost]
        public IHttpActionResult NewAppropriation([FromBody] Appropriations item)
        {
            unitOfWork.AppropriationsRepoRepo.Insert(item);
            unitOfWork.Save();
            return Ok(item);
        }
        [HttpPost]
        public IHttpActionResult UpdateAppropriation([FromBody] Appropriations item)
        {
            unitOfWork.AppropriationsRepoRepo.Update(item);
            unitOfWork.Save();
            return Ok(item);
        }
        [Route("api/appropriation/GetAppropriationDetails/{id?}")]
        public IHttpActionResult GetAppropriationDetails(int? id)
        {
            return Ok(unitOfWork.AppropriationsRepoRepo.Fetch(x => x.Id == id).Select(x => new
            {
                x.AccountCode,
                x.AccountCodeText,
                x.FundType,
                x.AccountName,
                x.Appropriation,

            }).FirstOrDefault());
        }

        public IHttpActionResult GetDefaultAccount()
        {
            return Ok(
                new UnitOfWork()
                    .DefaultAccountsRepo.Fetch().OrderBy(x => x.FundTypes.ItemNumber).Select(x => new
                    {
                        FundTypes = new { x.FundTypes.FundType },
                        x.AccountCode,
                        x.AccountName
                    }).ToList());
        }
    }

}