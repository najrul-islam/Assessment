using Assessment.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Infrastructure.Data
{
    public class AssessmentDbContext : DbContext
    {
        public AssessmentDbContext(DbContextOptions<AssessmentDbContext> options)
            : base(options)
        {

        }
        public DbSet<Building> Building { get; set; }
        public DbSet<Core.Entities.Object> Object { get; set; }
        public DbSet<DataField> DataField { get; set; }
        public DbSet<Reading> Reading { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-LBC2NVV;Database=Assessment;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Reading>(entity =>
            //{
            //    entity.HasNoKey();
            //});
        }
    }
}
