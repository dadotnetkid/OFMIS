using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Appropriations
    {
        private decimal? _allotment;
        private decimal? _reAligment;
        private decimal? _appropriationBalance;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Allotment
        {
            get
            {
                _allotment = Allotments.Sum(x => x.AllotmentAmount);
                return _allotment;
            }
            set => _allotment = value;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ReAligment
        {
            get
            {
                _reAligment = (this.SourceReAlignments.Sum(x => x.Amount) ?? 0) - (this.TargetReAlignments.Sum(x => x.Amount) ?? 0);
                return _reAligment;
            }
            set => _reAligment = value;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? AppropriationBalance
        {
            get
            {
                _appropriationBalance = (this.Appropriation ?? 0) - (this.Allotment ?? 0);
                return _appropriationBalance;
            }
            set => _appropriationBalance = value;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? AllotmentBalanceIncEM => (Allotment ?? 0) - (this.ObligationsOffice ?? 0);
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? AllotmentBalanceExcEM => (Allotment ?? 0) - (this.ObligationsOffice ?? 0);

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ObligationsOffice => this.ORDetails.Sum(x => x.Amount);

    }
}
