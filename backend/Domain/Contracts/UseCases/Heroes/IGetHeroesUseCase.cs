using Domain.Entities;

namespace Domain.Contracts.UseCases.Heroes
{
    public interface IGetHeroesUseCase
    {
        Task<HeroEntity[]> GetHeroes();
    }
}
