//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PayrollWageDetails
    {
        public int Id { get; set; }
        public Nullable<int> ItemNumber { get; set; }
        public Nullable<int> PayrollWageId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<decimal> NoOfdays { get; set; }
        public Nullable<decimal> RatePerDay { get; set; }
        public Nullable<decimal> GrossAmount { get; set; }
        public Nullable<decimal> PERA { get; set; }
        public Nullable<decimal> PHPS { get; set; }
        public Nullable<decimal> PHGS { get; set; }
        public Nullable<decimal> PIPS { get; set; }
        public Nullable<decimal> PIGS { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> MPL { get; set; }
        public Nullable<decimal> PIFCalLoan { get; set; }
        public Nullable<decimal> NVPEA { get; set; }
        public Nullable<decimal> SSSLoan { get; set; }
        public Nullable<decimal> LBP { get; set; }
        public Nullable<decimal> DBP { get; set; }
        public Nullable<decimal> BIRWH { get; set; }
        public Nullable<decimal> GSISPolicy { get; set; }
        public Nullable<decimal> GSISConsol { get; set; }
        public Nullable<decimal> SSSPS { get; set; }
        public Nullable<decimal> OT { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual PayrollWages PayrollWages { get; set; }
    }
}
