﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Db_Vandrarhem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VandrarhemEntities : DbContext
    {
        public VandrarhemEntities()
            : base("name=VandrarhemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bokningar> Bokningars { get; set; }
        public virtual DbSet<Kund> Kunds { get; set; }
        public virtual DbSet<KundBokning> KundBoknings { get; set; }
        public virtual DbSet<Rum> Rums { get; set; }
        public virtual DbSet<RumsBokning> RumsBoknings { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}