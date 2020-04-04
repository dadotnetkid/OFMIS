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
    
    public partial class Payrolls
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payrolls()
        {
            this.PayrollDetails = new HashSet<PayrollDetails>();
        }
    
        public int OBId { get; set; }
        public string ControlNo { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string ColumnTitle1 { get; set; }
        public string ColumnTitle2 { get; set; }
        public string ChiefOfOffice { get; set; }
        public string Position { get; set; }
        public string Accountant { get; set; }
        public string Treasurer { get; set; }
    
        public virtual Obligations Obligations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayrollDetails> PayrollDetails { get; set; }
    }
}
