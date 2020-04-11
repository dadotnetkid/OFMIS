using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models.ViewModels
{
    public class DvReportViewModel
    {
        private int oBRId;

        public DvReportViewModel()
        {
            
        }
        public DvReportViewModel(int oBRId)
        {
            this.oBRId = oBRId;
        }

        public List<Obligations> Obligations => new UnitOfWork().ObligationsRepo.Get(m => m.Id == oBRId);
    }
}
