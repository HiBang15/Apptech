using System;
using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> Options)
           : base(Options)
        {
        }

        public DbSet<HospitalDetails> Hospitaldetails { get; set; }
        public DbSet<Hospitals> Hospitals { get; set; }

        protected override void OnModelCreating(ModelBuilder Modelbuilder)
        {
            Modelbuilder.Entity<Hospitals>().ToTable("Hospitals");

            Modelbuilder.Entity<HospitalDetails>().ToTable("HospitalDetails");
        }
    }
}
