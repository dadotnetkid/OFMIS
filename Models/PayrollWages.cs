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
    
    public partial class PayrollWages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PayrollWages()
        {
            this.PayrollWageDetails = new HashSet<PayrollWageDetails>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string ControlNo { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string ChiefOfOffice { get; set; }
        public string Position { get; set; }
        public string Accountant { get; set; }
        public string AccountantPos { get; set; }
        public string Treasurer { get; set; }
        public string TreasurerPos { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedByPos { get; set; }
        public Nullable<int> ApprovedById { get; set; }
    
        public virtual Obligations Obligations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayrollWageDetails> PayrollWageDetails { get; set; }
    }
}
