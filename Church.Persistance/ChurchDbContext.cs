using Microsoft.EntityFrameworkCore;
using Church.Application.Interfaces;
using Church.Domain;
using Church.Persistance.EntityTypeConfiguration;

namespace Church.Persistance
{
    public class ChurchDbContext : DbContext, IChurchDbContext
    {
        public DbSet<Tbsystem> Tbsystem { get; set; }
        public DbSet<Tbemployee> Tbemployees { get; set; }   

        public ChurchDbContext(DbContextOptions<ChurchDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChurchConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}