using Domain.Contracts.Data;
using Domain.Contracts.UseCases.Heroes;
using Domain.Entities;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Application.UseCases
{
    public class CreateHeroUseCase(IHeroDbContext _context) : ICreateHeroUseCase
    {
        public async Task<HeroEntity> CreateHeroAsync(HeroEntity hero)
        {
            var existsHero = await _context.Heroes.AnyAsync(x => x.HeroName.ToLower() == hero.HeroName.ToLower());

            if (existsHero)
            {
                throw new CustomException("Hero name already exists");
            }

            await _context.Heroes.AddAsync(hero, CancellationToken.None);

            await _context.SaveChangesAsync(CancellationToken.None);

            return hero;
        }
    }
}
