﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepoWithValidations.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MidExamScenario1Entities : DbContext
    {
        public MidExamScenario1Entities()
            : base("name=MidExamScenario1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Group> Groups { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicineSupplier> MedicineSuppliers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}