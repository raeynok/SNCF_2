﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SNCF_2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sncfEntities : DbContext
    {
        public sncfEntities()
            : base("name=sncfEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<billet> billet { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<place> place { get; set; }
        public virtual DbSet<train> train { get; set; }
        public virtual DbSet<villes> villes { get; set; }
        public virtual DbSet<voiture> voiture { get; set; }
    }
}