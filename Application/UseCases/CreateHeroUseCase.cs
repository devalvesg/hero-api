using Domain.Contracts.Data;
using Domain.Contracts.UseCases.Heroes;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.UseCases
{
    public class CreateHeroUseCase(IHeroDbContext _context) : ICreateHeroUseCase
    {
        public async Task<HeroEntity> CreateHeroAsync(HeroEntity hero)
        {
            await _context.Heroes.AddAsync(hero, CancellationToken.None);

            await _context.SaveChangesAsync(CancellationToken.None);

            return hero;
        }
    }
}
