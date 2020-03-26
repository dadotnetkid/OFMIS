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
        private string _description;

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
