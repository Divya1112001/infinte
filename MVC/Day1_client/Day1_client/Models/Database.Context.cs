﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Day1_client.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmployeetravelsystemEntities : DbContext
    {
        public EmployeetravelsystemEntities()
            : base("name=EmployeetravelsystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dept_tbl> Dept_tbl { get; set; }
        public virtual DbSet<Employee_tbl> Employee_tbl { get; set; }
        public virtual DbSet<Project_tbl> Project_tbl { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}