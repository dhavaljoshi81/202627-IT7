using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IT7APatientManagementWebAPPCS.Models;

public partial class It7apatientManagmentDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public It7apatientManagmentDbContext()
    {
    }

    public It7apatientManagmentDbContext(DbContextOptions<It7apatientManagmentDbContext> options, 
        IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(_configuration.GetConnectionString("IT7APatientDB"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId).HasName("PK__Doctors__2DC00EBFECC08FEC");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Specialization).HasMaxLength(100);
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__Patients__970EC3664E8774C3");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Doctor).WithMany(p => p.Patients)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("FK__Patients__Doctor__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
