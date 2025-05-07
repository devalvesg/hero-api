using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Contracts.Data
{
    public interface IHeroDbContext
    {
        DbSet<HeroEntity> Heroes { get; }
        DbSet<SuperPowerEntity> SuperPower { get; }
        DbSet<HeroSuperPowerEntity> HeroSuperPower { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
