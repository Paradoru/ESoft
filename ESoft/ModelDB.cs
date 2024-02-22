using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ESoft
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Apartment> Apartment { get; set; }
        public virtual DbSet<House> House { get; set; }
        public virtual DbSet<ResidentialComplex> ResidentialComplex { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartment>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<House>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<House>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<House>()
                .HasMany(e => e.Apartment)
                .WithRequired(e => e.House)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResidentialComplex>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ResidentialComplex>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ResidentialComplex>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<ResidentialComplex>()
                .HasMany(e => e.House)
                .WithRequired(e => e.ResidentialComplex)
                .WillCascadeOnDelete(false);
        }
    }
}
