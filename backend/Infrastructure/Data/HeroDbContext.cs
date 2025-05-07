using Domain.Contracts.Data;
using Domain.Entities;
using Infrastructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    internal class HeroDbContext : DbContext, IHeroDbContext
    {
        public DbSet<HeroEntity> Heroes { get; init; }
        public DbSet<SuperPowerEntity> SuperPower { get; init; }
        public DbSet<HeroSuperPowerEntity> HeroSuperPower { get; init; }

        public HeroDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HeroMapping());
            modelBuilder.ApplyConfiguration(new SuperPowerMapping());
            modelBuilder.ApplyConfiguration(new HeroSuperPowerMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
