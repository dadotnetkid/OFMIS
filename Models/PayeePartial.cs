using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Payees
    {
        [Newtonsoft.Json.JsonIgnoreAttribute]
        private string _description;
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string Description
        {
            get
            {
                if (_description == null)
                    _description = this.Name + "-" + this.Office;
                return _description;
            }
            set => _description = value;
        }
    }
}
