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
    
    public partial class ORDetails
    {
        public int Id { get; set; }
        public Nullable<int> AppropriationId { get; set; }
        public Nullable<int> ObligationId { get; set; }
        public string Particulars { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual Obligations Obligations { get; set; }
        public virtual Appropriations Appropriations { get; set; }
    }
}
