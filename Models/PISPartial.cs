using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class PIS
    {
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Employees Transferor => new UnitOfWork(false, false).EmployeesRepo.Find(x => x.Id == TransferorId);
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Employees Transferee => new UnitOfWork(false, false).EmployeesRepo.Find(x => x.Id == TransfereeId);

        public string Item => PISDetails?.FirstOrDefault()?.Item;
    }
}