using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TalentManagement.Models
{
    public partial class Talent_ManagementContext : DbContext
    {
        public Talent_ManagementContext()
        {
        }

        public Talent_ManagementContext(DbContextOptions<Talent_ManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agent> Agents { get; set; } = null!;
        public virtual DbSet<Artiste> Artistes { get; set; } = null!;
        public virtual DbSet<Gig> Gigs { get; set; } = null!;
        public virtual DbSet<Venue> Venues { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>(entity =>
            {
                entity.Property(e => e.AgentId).ValueGeneratedNever();

                entity.Property(e => e.AgentFirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AgentLastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Artiste>(entity =>
            {
                entity.ToTable("Artiste");

                entity.Property(e => e.ContractStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gigs)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StageName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gig>(entity =>
            {
                entity.HasKey(e => e.GigsId);

                entity.Property(e => e.GigsId).ValueGeneratedNever();

                entity.Property(e => e.GigDate).HasColumnType("date");

                entity.Property(e => e.IncomeGenerated).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VenueName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Venue>(entity =>
            {
                entity.HasKey(e => e.VenueName);

                entity.Property(e => e.VenueName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VenueCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
