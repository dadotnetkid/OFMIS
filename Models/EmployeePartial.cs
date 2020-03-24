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
