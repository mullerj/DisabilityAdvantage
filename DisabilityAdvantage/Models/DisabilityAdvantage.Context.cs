﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DisabilityAdvantage.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DisabilityAdvantageContainer : DbContext
    {
        public DisabilityAdvantageContainer()
            : base("name=DisabilityAdvantageContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<ChildCount> ChildCounts { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Disability> Disabilities { get; set; }
        public DbSet<DisabilityType> DisabilityTypes { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<State> States { get; set; }
    }
}
