﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLMuseum.dbo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MuseumEntities : DbContext
    {
        public MuseumEntities()
            : base("name=MuseumEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Execution> Execution { get; set; }
        public virtual DbSet<Exhibition> Exhibition { get; set; }
        public virtual DbSet<Hall> Hall { get; set; }
        public virtual DbSet<Painting> Painting { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
    }
}