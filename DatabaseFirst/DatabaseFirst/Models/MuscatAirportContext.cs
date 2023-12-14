using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseFirst.Models
{
    public partial class MuscatAirportContext : DbContext
    {
        public MuscatAirportContext()
        {
        }

        public MuscatAirportContext(DbContextOptions<MuscatAirportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department2> Department2s { get; set; } = null!;
        public virtual DbSet<Employee2> Employee2s { get; set; } = null!;
        public virtual DbSet<Project2> Project2s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-VU0IRUE;Initial Catalog=MuscatAirport;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department2>(entity =>
            {
                entity.HasKey(e => e.DpId);

                entity.ToTable("department2");

                entity.Property(e => e.DepFloor).HasColumnName("depFloor");

                entity.Property(e => e.Deptname)
                    .HasMaxLength(50)
                    .HasColumnName("deptname");
            });

            modelBuilder.Entity<Employee2>(entity =>
            {
                entity.ToTable("employee2");

                entity.HasIndex(e => e.DepId, "IX_employee2_depId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepId).HasColumnName("depId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.ProjId).HasColumnName("projId");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salary");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.Employee2s)
                    .HasForeignKey(d => d.DepId);

                entity.HasMany(d => d.Projects)
                    .WithMany(p => p.Employees)
                    .UsingEntity<Dictionary<string, object>>(
                        "EmployeesProject",
                        l => l.HasOne<Project2>().WithMany().HasForeignKey("ProjectsId"),
                        r => r.HasOne<Employee2>().WithMany().HasForeignKey("EmployeesId"),
                        j =>
                        {
                            j.HasKey("EmployeesId", "ProjectsId");

                            j.ToTable("EmployeesProjects");

                            j.HasIndex(new[] { "ProjectsId" }, "IX_EmployeesProjects_ProjectsID");

                            j.IndexerProperty<int>("EmployeesId").HasColumnName("EmployeesID");

                            j.IndexerProperty<int>("ProjectsId").HasColumnName("ProjectsID");
                        });
            });

            modelBuilder.Entity<Project2>(entity =>
            {
                entity.ToTable("Project2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
