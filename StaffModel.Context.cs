﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GregInterviewWinforms
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StaffEntities : DbContext
    {
        public StaffEntities()
            : base("name=StaffEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<StaffStatu> StaffStatus { get; set; }
        public virtual DbSet<StaffTitle> StaffTitles { get; set; }
        public virtual DbSet<StaffType> StaffTypes { get; set; }
        public virtual DbSet<vw_Manager> vw_Manager { get; set; }
        public virtual DbSet<vw_Staff> vw_Staff { get; set; }
    }
}
