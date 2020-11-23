using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using Helpers;
using Microsoft.AspNet.Identity;
using Models;
using Models.Repository;

namespace Web.API.Controllers
{
    public class DashboardController : ApiController
    {
        private UnitOfWork unitOfWork;
        private string userId => User.Identity.GetUserId();
        private int? officeId => User.Identity.GetOfficeId();
        public DashboardController()
        {
            unitOfWork = new UnitOfWork();
        }
        // GET api/<controller>
        public IHttpActionResult GetDocumentActions()
        {
            System.Diagnostics.Debug.Write(unitOfWork.context.Database.Connection.ConnectionString);
            return Ok(unitOfWork.DocumentActionsRepo.Get(x =>
                x.RoutedToUsers.Any(m => m.Id == userId) && x.IsSend == true && x.isDone != true).Select(x => new
                {
                    x.Id,
                    x.RefId,
                    x.Year,
                    x.ControlNo,
                    x.TableName,
                    x.ObR_PR_No,
                    x.Description,
                    x.TotalAmount,
                    CreatedByUsers = new ModelDb().Users.Where(m => m.Id == x.CreatedBy).Select(m => new { FullName = m.FirstName + " " + m.LastName }).FirstOrDefault(),
                    x.Remarks,
                    x.RouterUsers,
                    x.Programs,
                    x.MainActivity,
                    x.Activity,
                    x.SubActivity
                }));
        }

        public IHttpActionResult GetUsers()
        {
            return Ok(unitOfWork.UsersRepo.Fetch(x => x.OfficeId == officeId).Select(x => new
            {
                FullName = x.FirstName + " " + x.LastName,
                x.Id
            }).ToList());
        }
        [HttpPost]
        public IHttpActionResult GetDetails([FromBody] DocumentActions item)
        {
            var list = new UnitOfWork().DocumentActionsRepo.Get(x =>
                    x.RefId == item.RefId && x.TableName == item.TableName)
                .Select(x => new
                {
                    x.DateCreated,
                    x.ActionDate,
                    x.CreatedBy,
                    x.ActionTaken,
                    CreatedByUsers = new ModelDb().Users.Where(m => m.Id == x.CreatedBy)
                        .Select(m => new { FullName = m.FirstName + " " + m.LastName }).FirstOrDefault(),
                    x.RouterUsers,
                    x.Remarks,
                    x.Programs,
                    x.MainActivity,
                    x.Activity,
                    x.SubActivity
                })


                .OrderByDescending(m => m.DateCreated).ToList();
            if (item.TableName == "PurchaseRequests")
            {
                var po = unitOfWork.PurchaseOrdersRepo.Get(x => x.PRId == item.RefId);

                foreach (var i in po)
                {
                    foreach (var obr in i.Obligations)
                    {

                        list.AddRange(unitOfWork.DocumentActionsRepo.Get(x =>
                            x.RefId == obr.Id && x.TableName == "Obligations").Select(x => new
                            {
                                x.DateCreated,
                                x.ActionDate,
                                x.CreatedBy,
                                x.ActionTaken,
                                CreatedByUsers = new ModelDb().Users.Where(m => m.Id == x.CreatedBy)
                                .Select(m => new { FullName = m.FirstName + " " + m.LastName }).FirstOrDefault(),
                                x.RouterUsers,
                                x.Remarks,
                                x.Programs,
                                x.MainActivity,
                                x.Activity,
                                x.SubActivity

                            }));
                    }


                }
            }
            return Ok(list);
        }


    }
}