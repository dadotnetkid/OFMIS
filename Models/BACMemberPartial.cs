using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class BACMembers
    {
        private string _EmployeeName;

        public string EmployeeName
        {
            get
            {
                if (_EmployeeName == null)
                    _EmployeeName = this.FirstName + " " + this.LastName;
                return _EmployeeName;
            }
            set { _EmployeeName = value; }
        }
    }
}
