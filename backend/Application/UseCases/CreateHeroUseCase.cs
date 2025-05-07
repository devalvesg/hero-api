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

            var superPowers = _context.SuperPower.Where(w => hero.SuperPowerIds.Contains(w.Id)).Select(s => s).ToList();

            await _context.Heroes.AddAsync(hero, CancellationToken.None);

            await _context.SaveChangesAsync(CancellationToken.None);

            foreach (var sp in superPowers)
            {
                await _context.HeroSuperPower.AddAsync(new HeroSuperPowerEntity()
                {
                    HeroId = hero.Id,
                    SuperPowerId = sp.Id
                });
                hero.SuperPowers.Add(new SuperPowerEntity()
                {
                    Description = sp.Description,
                    SuperPower = sp.SuperPower
                });
            }

            await _context.SaveChangesAsync(CancellationToken.None);

            return hero;
        }
    }
}
