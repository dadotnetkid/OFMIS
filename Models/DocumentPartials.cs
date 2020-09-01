using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class Documents
    {
        private Employees employees;
        private Offices offices;

        public Employees Employees
        {
            get
            {
                if (this.employees == null)
                    this.employees = new UnitOfWork().EmployeesRepo.Find(x => x.Id == this.Signatory);
                return employees;
            }
        }

        public Offices Offices
        {
            get
            {
                if (this.offices == null)
                    this.offices = new UnitOfWork().OfficesRepo.Find(x => x.Id == this.SourceOfficeId);
                return offices;
            }
        }

    }
}
