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
    
    public partial class ControlNumbers
    {
        public int Id { get; set; }
        public string ControlNo { get; set; }
        public Nullable<int> OfficeId { get; set; }
        public string TableName { get; set; }
    
        public virtual Offices Offices { get; set; }
    }
}