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
    
    public partial class ItenaryofTravels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItenaryofTravels()
        {
            this.ItenaryDetails = new HashSet<ItenaryDetails>();
        }
    
        public int Id { get; set; }
        public Nullable<int> OBRId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public string Position { get; set; }
        public string OfficialAddress { get; set; }
        public string Purpose { get; set; }
        public Nullable<int> GovernorId { get; set; }
        public Nullable<int> PAId { get; set; }
        public Nullable<int> PreparedBy { get; set; }
        public string PreparedByPos { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public string ApprovedByPos { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Obligations Obligations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItenaryDetails> ItenaryDetails { get; set; }
    }
}
