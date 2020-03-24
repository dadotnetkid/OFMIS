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
    
    public partial class Obligations
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string ControlNo { get; set; }
        public string BudgetControlNo { get; set; }
        public Nullable<int> PayeeId { get; set; }
        public string PayeeOffice { get; set; }
        public string PayeeAddress { get; set; }
        public string Chief { get; set; }
        public string ChiefPosition { get; set; }
        public string PBOPos { get; set; }
        public string PBO { get; set; }
        public Nullable<bool> Closed { get; set; }
        public string Description { get; set; }
        public string DVParticular { get; set; }
        public string DVApprovedBy { get; set; }
        public string DVApprovedByPosition { get; set; }
        public string DVNote { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateClosed { get; set; }
        public Nullable<bool> Earmarked { get; set; }
        public Nullable<int> PRNo { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Payees Payees { get; set; }
    }
}