using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IT7AExamWebAppCS.Models;

public partial class It7a2026examDbContext : DbContext
{
    private IConfiguration _configuration;
    public It7a2026examDbContext()
    {
    }

    public It7a2026examDbContext(DbContextOptions<It7a2026examDbContext> options,
        IConfiguration configuration
        )
        : base(options)
    {
        _configuration = configuration;
    }

    public virtual DbSet<Exam> Exams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ExamDBConnectionString"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exam>(entity =>
        {
            entity.ToTable("Exam");

            entity.Property(e => e.ExamId)
                .ValueGeneratedNever()
                .HasColumnName("ExamID");
            entity.Property(e => e.ExamName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
