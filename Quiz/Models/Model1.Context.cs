﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quiz.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBQUIZEntities : DbContext
    {
        public DBQUIZEntities()
            : base("name=DBQUIZEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_ADMIN> TBL_ADMIN { get; set; }
        public virtual DbSet<TBL_QUESTIONS> TBL_QUESTIONS { get; set; }
        public virtual DbSet<TBL_SETEXAM> TBL_SETEXAM { get; set; }
        public virtual DbSet<TBL_STUDENT> TBL_STUDENT { get; set; }
        public virtual DbSet<TBL_CATEGORY> TBL_CATEGORY { get; set; }
    }
}
