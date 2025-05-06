using Domain.Contracts.Data;
using Domain.Contracts.UseCases.Heroes;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Application.UseCases
{
    public class DeleteHeroUseCase(IHeroDbContext _context) : IDeleteHeroUseCase
    {
        public async Task DeleteHero(long heroId)
        {
            var hero = await _context.Heroes.Where(x => x.Id == heroId && !x.Deleted).FirstOrDefaultAsync() ?? throw new CustomException("Hero not found, please type valid id");

            hero.Deleted = true;

            _context.Heroes.Update(hero);

            await _context.SaveChangesAsync(cancellationToken: CancellationToken.None);
        }
    }
}
