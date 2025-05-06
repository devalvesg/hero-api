using Domain.Contracts.Data;
using Domain.Contracts.UseCases.Heroes;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.UseCases
{
    public class GetHeroesUseCase(IHeroDbContext _context) : IGetHeroesUseCase
    {
        public async Task<HeroEntity[]> GetHeroes()
        {
            return await _context.Heroes.Where(x => !x.Deleted).ToArrayAsync();
        }
    }
}
