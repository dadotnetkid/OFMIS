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
        private decimal? _budgetAccountBalance;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public decimal? BudgetAccountBalance
        {
            get
            {
                _budgetAccountBalance = this.ORDetails.Where(x => x.Obligations.BudgetControlNo != null && x.Obligations.OfficeId == this.OfficeId)
                    .Sum(x => x.Amount);
                return _budgetAccountBalance;
            }
            set { _budgetAccountBalance = value; }
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Allotment
        {
            get
            {
                _allotment = Allotments.Sum(x => x.AllotmentAmount);
                return _allotment - this.PurchaseRequestEarmarked;
            }
            set => _allotment = value;
        }
        public decimal PurchaseRequestEarmarked
        {
            get
            {
                return this.PurchaseRequests.Where(x => x.IsEarmark == true && x.IsClosed != true && x.IsCancelled != true).Sum(x => x.TotalAmount) ?? 0;
            }
        }
        public decimal PurchaseRequestCancelled
        {
            get
            {
                return this.PurchaseRequests.Where(x => x.IsCancelled == true).Sum(x => x.TotalAmount) ?? 0;
            }
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ReAlignment
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
        //pr without obr + 
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? AllotmentBalanceIncEM => (this.PurchaseRequests.Where(x => !x.Obligations.Any()).Sum(x => x.TotalAmount) ?? 0) + (PurchaseRequests.Where(x => x.Obligations.Any())
            .Sum(x => x.Obligations.Sum(m => m.TotalAmount)) ?? 0);

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? AllotmentBalanceExcEM => Allotments.Sum(x => x.AllotmentAmount) - this.ObligationsOffice;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ObligationsOffice
        {
            get
            {
                var amount =this.ORDetails.Where(x => x.Obligations.Year == Year && x.Obligations.OfficeId == OfficeId).Sum(x => x.Amount);
                return amount;
            }
        }


    }
}
