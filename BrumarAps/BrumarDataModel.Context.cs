﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrumarAps
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BrumarDataModelContainer : DbContext
    {
        public BrumarDataModelContainer()
            : base("name=DefaultConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Language> LanguageSet { get; set; }
        public virtual DbSet<ContactForm> ContactFormSet { get; set; }
        public virtual DbSet<Logger> LoggerSet { get; set; }
    }
}