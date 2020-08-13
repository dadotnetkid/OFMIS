using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [MetadataType(typeof(EmployeeMeta))]
    public partial class Employees
    {
        [Newtonsoft.Json.JsonIgnore]
        public bool isSelected { get; set; }

        [Newtonsoft.Json.JsonIgnoreAttribute]
        public string EmployeeNameByLastName => this.LastName + ", " + this.FirstName + " " + this.MiddleName[0] + ".";

        private string _EmployeeName;
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public string EmployeeName
        {
            get
            {
                if (_EmployeeName == null)
                {
                    if (FirstName != null && MiddleName != null && LastName != null)
                    {
                        var MI = string.IsNullOrEmpty(MiddleName) ? "" : MiddleName[0].ToString();
                        _EmployeeName = this.FirstName + " " + MI + ". " + this.LastName + " " + this.ExtName;
                    }
                }

                return _EmployeeName;
            }
            set { _EmployeeName = value; }
        }
        public string EmployeeFullNameWithMiddleName => this.FirstName + " " + MiddleName  + this.LastName + " " + this.ExtName;
    }


    public class EmployeeMeta
    {
        [Required]
        public int OfficeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Position { get; set; }
    }
}
