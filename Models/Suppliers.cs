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
    
    public partial class Suppliers
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CellNumber { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}