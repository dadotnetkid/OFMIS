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
    
    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            this.PayrollDetails = new HashSet<PayrollDetails>();
            this.Payees = new HashSet<Payees>();
            this.BACMembers = new HashSet<BACMembers>();
            this.PayrollWageDetails = new HashSet<PayrollWageDetails>();
            this.PayrollDifferentialDetails = new HashSet<PayrollDifferentialDetails>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string OfficeName { get; set; }
        public string OffcAcr { get; set; }
        public Nullable<int> OfficeId { get; set; }
        public string TIN { get; set; }
        public string PagIbig { get; set; }
        public string PhilHealth { get; set; }
        public string Status { get; set; }
        public string Salutation { get; set; }
        public string SG { get; set; }
        public string SSS { get; set; }
        public string ExtName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayrollDetails> PayrollDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payees> Payees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BACMembers> BACMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayrollWageDetails> PayrollWageDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayrollDifferentialDetails> PayrollDifferentialDetails { get; set; }
    }
}
