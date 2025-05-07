using Domain.Contracts.Data;
using Domain.Contracts.UseCases.Heroes;
using Domain.Entities;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Application.UseCases
{
    public class UpdateHeroUseCase(IHeroDbContext _context) : IUpdateHeroUseCase
    {
        public async Task<HeroEntity> UpdateHero(HeroEntity hero, int heroId)
        {
            var existsHero = await _context.Heroes.Where(x => x.Id == heroId && !x.Deleted).AnyAsync();
            if (heroId == 0 || !existsHero)
            {
                throw new CustomException("Hero not found, please type valid id");
            }

            hero.Id = heroId;
            _context.Heroes.Update(hero);

            await _context.SaveChangesAsync(cancellationToken: CancellationToken.None);
            return hero;
        }
    }
}
