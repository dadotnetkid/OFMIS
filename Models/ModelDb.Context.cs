﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelDb : DbContext
    {
        public ModelDb()
            : base("name=ModelDb")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Allotments> Allotments { get; set; }
        public virtual DbSet<Appropriations> Appropriations { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<DefaultAccounts> DefaultAccounts { get; set; }
        public virtual DbSet<DefaultSettings> DefaultSettings { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Functions> Functions { get; set; }
        public virtual DbSet<FundTypes> FundTypes { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Obligations> Obligations { get; set; }
        public virtual DbSet<Offices> Offices { get; set; }
        public virtual DbSet<Payees> Payees { get; set; }
        public virtual DbSet<PayrollDetails> PayrollDetails { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<PRDetails> PRDetails { get; set; }
        public virtual DbSet<PriceQuotations> PriceQuotations { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<PurchaseOrders> PurchaseOrders { get; set; }
        public virtual DbSet<ReAlignments> ReAlignments { get; set; }
        public virtual DbSet<Signatories> Signatories { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Towns> Towns { get; set; }
        public virtual DbSet<UserClaims> UserClaims { get; set; }
        public virtual DbSet<UserLogins> UserLogins { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Years> Years { get; set; }
        public virtual DbSet<Payrolls> Payrolls { get; set; }
        public virtual DbSet<PayrollWages> PayrollWages { get; set; }
        public virtual DbSet<BACMembers> BACMembers { get; set; }
        public virtual DbSet<AllotmentLetter> AllotmentLetter { get; set; }
        public virtual DbSet<ControlNumbers> ControlNumbers { get; set; }
        public virtual DbSet<PayrollWageDetails> PayrollWageDetails { get; set; }
        public virtual DbSet<Templates> Templates { get; set; }
        public virtual DbSet<SalarySchedules> SalarySchedules { get; set; }
        public virtual DbSet<PayrollDifferentials> PayrollDifferentials { get; set; }
        public virtual DbSet<ORDetails> ORDetails { get; set; }
        public virtual DbSet<PODetails> PODetails { get; set; }
        public virtual DbSet<PQDetails> PQDetails { get; set; }
        public virtual DbSet<AOQ> AOQ { get; set; }
        public virtual DbSet<AOQDetails> AOQDetails { get; set; }
        public virtual DbSet<Letters> Letters { get; set; }
        public virtual DbSet<APRs> APRs { get; set; }
        public virtual DbSet<APRDetails> APRDetails { get; set; }
        public virtual DbSet<Actions> Actions { get; set; }
        public virtual DbSet<DocumentActions> DocumentActions { get; set; }
        public virtual DbSet<PayrollDifferentialDetails> PayrollDifferentialDetails { get; set; }
        public virtual DbSet<AIRDetails> AIRDetails { get; set; }
        public virtual DbSet<PIS> PIS { get; set; }
        public virtual DbSet<PISDetails> PISDetails { get; set; }
        public virtual DbSet<AIReports> AIReports { get; set; }
        public virtual DbSet<PurchaseRequests> PurchaseRequests { get; set; }
    }
}
