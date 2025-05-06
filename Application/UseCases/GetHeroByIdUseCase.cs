using Domain.Contracts.Data;
using Domain.Contracts.UseCases.Heroes;
using Domain.Entities;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Application.UseCases
{
    public class GetHeroByIdUseCase(IHeroDbContext _context) : IGetHeroByIdUseCase
    {
        public async Task<HeroEntity> GetHeroById(long heroId)
        {
            return await _context.Heroes.Where(x => x.Id == heroId && !x.Deleted).Include(h => h.HeroSuperPowers).ThenInclude(ti => ti.SuperPower)
                .FirstOrDefaultAsync() ?? throw new CustomException("Hero not found, please type valid id");
        }
    }
}
