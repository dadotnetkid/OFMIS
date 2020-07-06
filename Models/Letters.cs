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
    
    public partial class Letters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Letters()
        {
            this.Obligations = new HashSet<Obligations>();
        }
    
        public int Id { get; set; }
        public Nullable<int> OfficeId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string InsideAddress { get; set; }
        public string Salutation { get; set; }
        public Nullable<int> TemplateId { get; set; }
        public string Body { get; set; }
        public string Closing { get; set; }
        public string Signatory { get; set; }
        public string Position { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string CC { get; set; }
        public Nullable<bool> ShowInTheAbsenceofthePLO { get; set; }
        public Nullable<System.DateTime> DocumentDate { get; set; }
        public string OfficeHead { get; set; }
        public string OfficeHeadPos { get; set; }
        public string OfficeName { get; set; }
        public string OfficeNameUnderOf { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obligations> Obligations { get; set; }
        public virtual Offices Offices { get; set; }
    }
}