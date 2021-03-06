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
    
    public partial class PurchaseOrders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrders()
        {
            this.PODetails = new HashSet<PODetails>();
            this.Obligations = new HashSet<Obligations>();
        }
    
        public int Id { get; set; }
        public Nullable<int> PRId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string ControlNo { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string PGSOfficer { get; set; }
        public string Position { get; set; }
        public string Supplier { get; set; }
        public string SupplierAddress { get; set; }
        public string PONo { get; set; }
        public Nullable<System.DateTime> PODate { get; set; }
        public string ModeOfProcurement { get; set; }
        public string PRNo { get; set; }
        public string PlaceOfDelivery { get; set; }
        public Nullable<System.DateTime> DateOfDelivery { get; set; }
        public string DeliveryTerm { get; set; }
        public string PaymentTerm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PODetails> PODetails { get; set; }
        public virtual PurchaseRequests PurchaseRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obligations> Obligations { get; set; }
    }
}
