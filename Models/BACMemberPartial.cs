using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class BACMembers
    {
        [Newtonsoft.Json.JsonIgnoreAttribute]
        private string _EmployeeName;
        [Newtonsoft.Json.JsonIgnoreAttribute]
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
