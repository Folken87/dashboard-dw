using System;
using System.Collections.Generic;
using dashboard_dw_back.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace dashboard_dw_back.Models;

public partial class PostgresContext : DbContext
{
    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FederalDistrict> FederalDistricts { get; set; }

    public virtual DbSet<R4> R4s { get; set; }

    public virtual DbSet<R4Category> R4Categories { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }
    public virtual DbSet<R4ViewModel> R4ViewModel { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=79.137.194.168;Port=5432;Database=postgres;Username=postgres;Password=Q1w2e3r4zxc");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FederalDistrict>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Federal Districts_pkey");

            entity.ToTable("Federal Districts");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<R4>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("R4_pkey");

            entity.ToTable("R4");

            entity.HasIndex(e => e.Id, "Primary").IsUnique();

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();

            entity.HasOne(d => d.Category).WithMany(p => p.R4s)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R4Cat");

            entity.HasOne(d => d.FedDistrict).WithMany(p => p.R4s)
                .HasForeignKey(d => d.FedDistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FedDistr");
        });

        modelBuilder.Entity<R4Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("R4-Categories_pkey");

            entity.ToTable("R4-Categories");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Subjects_pkey");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.FedDistrict).WithMany(p => p.Subjects)
                .HasForeignKey(d => d.FedDistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Districts");
        });

        modelBuilder.Entity<R4ViewModel>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("R4View");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
