using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class PAR
    {
        public string Item => this.PARDetails?.FirstOrDefault()?.Item;
    }
}
