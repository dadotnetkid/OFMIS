using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models.Repository;

namespace Web.API.Controllers
{
    public class StaticSettingController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private int? officeId => User.Identity.GetOfficeId();
        public IHttpActionResult ChiefOfOffice(int year)
        {
            return Ok(new UnitOfWork().Signatories.Get(m => m.Year == year));
        }
        [HttpGet]
        public IHttpActionResult DefaultOffice()
        {
            return Ok(unitOfWork.OfficesRepo.Fetch(m => m.Id == officeId, "UnderOfOffice").FirstOrDefault());
        }
        [HttpGet]
        public IHttpActionResult Year()
        {
            return Ok(unitOfWork.YearsRepo.Fetch(m => m.IsActive == true && m.OfficeId == officeId).Select(x=>new
            {
                x.Id,
                x.IsActive,
                x.OfficeId,
                x.Year,
                
            }).FirstOrDefault());
        }
    }
}
