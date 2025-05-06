using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Contracts.Data
{
    public interface IHeroDbContext
    {
        DbSet<HeroEntity> Heroes { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
