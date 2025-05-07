using Domain.Entities;

namespace Domain.Contracts.UseCases.Heroes
{
    public interface IUpdateHeroUseCase
    {
        Task<HeroEntity> UpdateHero(HeroEntity hero, int heroId);
    }
}
