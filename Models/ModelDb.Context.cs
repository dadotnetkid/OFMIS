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
    
        public virtual DbSet<Actions> Actions { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<Towns> Towns { get; set; }
        public virtual DbSet<UserClaims> UserClaims { get; set; }
        public virtual DbSet<UserLogins> UserLogins { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<UserRolesInActions> UserRolesInActions { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Offices> Offices { get; set; }
        public virtual DbSet<Obligations> Obligations { get; set; }
        public virtual DbSet<Payees> Payees { get; set; }
    }
}