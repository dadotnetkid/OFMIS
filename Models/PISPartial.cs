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
        public Employees Transferor => new UnitOfWork().EmployeesRepo.Find(x => x.Id == TransferorId);
        public Employees Transferee => new UnitOfWork().EmployeesRepo.Find(x => x.Id == TransfereeId);
    }
}