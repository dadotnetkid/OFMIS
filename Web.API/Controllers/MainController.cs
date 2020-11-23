using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.API.Controllers
{
    public class MainController : ApiController
    {
        private int? officeId => User.Identity.GetOfficeId();
        private UnitOfWork unitOfWork = new UnitOfWork();

        [HttpGet]
        public IHttpActionResult HasDefaultYear()
        {
            return Ok(unitOfWork.YearsRepo.Fetch(x => x.OfficeId == officeId).Any(x => x.IsActive == true));
        }
    }
}
