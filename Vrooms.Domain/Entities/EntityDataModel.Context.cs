﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vrooms.Domain.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("name=EFDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<BookItem> BookItems { get; set; }
        public virtual DbSet<Patron> Patrons { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<ReservedBookItem> ReservedBookItems { get; set; }
    }
}
