using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Enums;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess
{
    public class WorkerBenefitsDbContext : DbContext
    {
        public WorkerBenefitsDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<JobPositionEnrolment> JobPositionEnrolments { get; set; }
        public DbSet<TechnologyType> TechnologyTypes { get; set; }
        public DbSet<TechnologyTypeEnrolment> TechnologyTypeEnrolments { get; set; }
        public DbSet<IndividualEnrolment> IndividualEnrolments { get; set; }
        public DbSet<Benefit> Benefits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Benefit>()
                .HasData(
                new Benefit()
                {
                    Id = 1,
                    BenefitType = BenefitType.Individual,
                    BenefitTypeId = 2,
                    Name = "Angel",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                }
                ); ;
        }
    }
}
