using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IT7BTestManagerWenAppCS.Models;

public partial class It7b2026testDbContext : DbContext
{
    private IConfiguration _configuration;
    public It7b2026testDbContext()
    {
    }

    public It7b2026testDbContext(DbContextOptions<It7b2026testDbContext> options,
        IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public virtual DbSet<Test> Tests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(
                _configuration.GetConnectionString("IT7BDBConnection")
            );

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Test>(entity =>
        {
            entity.ToTable("Test");

            entity.Property(e => e.TestId).ValueGeneratedNever();
            entity.Property(e => e.TestName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
