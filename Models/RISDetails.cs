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
    
    public partial class RISDetails
    {
        public int Id { get; set; }
        public Nullable<int> RISId { get; set; }
        public int ItemNo { get; set; }
        public decimal Quantity { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string UOM { get; set; }
        public decimal Cost { get; set; }
        public decimal TotalAmount { get; set; }
    
        public virtual RISHeader RISHeader { get; set; }
    }
}
