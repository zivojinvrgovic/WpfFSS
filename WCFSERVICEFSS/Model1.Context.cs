﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFSERVICEFSS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FSSEntities : DbContext
    {
        public FSSEntities()
            : base("name=FSSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblIgrac> tblIgracs { get; set; }
        public virtual DbSet<tblKategorija> tblKategorijas { get; set; }
        public virtual DbSet<tblLiga> tblLigas { get; set; }
        public virtual DbSet<tblNacionalnost> tblNacionalnosts { get; set; }
        public virtual DbSet<tblTim> tblTims { get; set; }
        public virtual DbSet<vwIgrac> vwIgracs { get; set; }
        public virtual DbSet<vwKategorija> vwKategorijas { get; set; }
        public virtual DbSet<vwLiga> vwLigas { get; set; }
        public virtual DbSet<vwNacionalnost> vwNacionalnosts { get; set; }
        public virtual DbSet<vwTim> vwTims { get; set; }
        public virtual DbSet<tblSudija> tblSudijas { get; set; }
        public virtual DbSet<tblTrener> tblTreners { get; set; }
        public virtual DbSet<vwSudija> vwSudijas { get; set; }
        public virtual DbSet<vwTrener> vwTreners { get; set; }
    }
}
