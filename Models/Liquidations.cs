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
    
    public partial class Liquidations
    {
        public int Id { get; set; }
        public Nullable<int> ObRId { get; set; }
        public Nullable<int> PayeeId { get; set; }
        public string PayeeName { get; set; }
        public string PayeeAddress { get; set; }
        public Nullable<int> PAId { get; set; }
        public Nullable<int> HeadOfDep { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Particulars { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string AccountantName { get; set; }
        public string AccountantPosition { get; set; }
        public string HeadName { get; set; }
        public string HeadPosition { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public string PeriodCovered { get; set; }
    
        public virtual Obligations Obligations { get; set; }
        public virtual Payees Payees { get; set; }
        public virtual Signatories Accountant { get; set; }
        public virtual Signatories Head { get; set; }
        public virtual Employees Employees { get; set; }
    }
}
