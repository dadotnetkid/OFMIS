using Models;
using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Description;

namespace Web
{
    /// <summary>
    /// Summary description for wsDashboard
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsDashboard : System.Web.Services.WebService
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        [WebMethod]
        public object documentActions()
        {
            var res = unitOfWork.DocumentActionsRepo.Get(x =>
        x.IsSend == true && x.isDone != true).Select(x => new 
               DocumentActions {
                    Year = x.Year,
                    ControlNo = x.ControlNo,
                    TableName = x.TableName,
                    ObR_PR_No = x.ObR_PR_No,
                    Description = x.Description,
                    TotalAmount = x.TotalAmount,
                    CreatedByUserFullName = x.CreatedByUser.FullName,
                    Remarks = x.Remarks,
                    RouterUsers = x.RouterUsers
                }).ToList();
            return res;
        }
    }
}
