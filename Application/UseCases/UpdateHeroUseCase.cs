using Domain.Contracts.Data;
using Domain.Contracts.UseCases.Heroes;
using Domain.Entities;
using Domain.Exceptions;

namespace Application.UseCases
{
    public class UpdateHeroUseCase(IHeroDbContext _context) : IUpdateHeroUseCase
    {
        public async Task<HeroEntity> UpdateHero(HeroEntity hero)
        {
            if (hero.Id == 0)
            {
                throw new CustomException("Hero not found, please type valid id");
            }

            _context.Heroes.Update(hero);

            await _context.SaveChangesAsync(cancellationToken: CancellationToken.None);
            return hero;
        }
    }
}
