using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BusinessObject.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace BusinessObject.Context
{
    public partial class EmployeeJobTitleContext : DbContext
    {
        public EmployeeJobTitleContext()
        {
        }

        public EmployeeJobTitleContext(DbContextOptions<EmployeeJobTitleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dbaccount> Dbaccounts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<JobTitle> JobTitles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }
        //EmployeeJobTitle
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Dbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__DBAccoun__349DA58607842573");

                entity.ToTable("DBAccount");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(20)
                    .HasColumnName("AccountID");

                entity.Property(e => e.AccountPassword)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.FullName).HasMaxLength(100);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(20)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.JobTitleId)
                    .HasMaxLength(20)
                    .HasColumnName("JobTitleID");

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobTitleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Employee__JobTit__286302EC");
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.ToTable("JobTitle");

                entity.Property(e => e.JobTitleId)
                    .HasMaxLength(20)
                    .HasColumnName("JobTitleID");

                entity.Property(e => e.JobTitleDescription).HasMaxLength(250);

                entity.Property(e => e.JobTitleName)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
