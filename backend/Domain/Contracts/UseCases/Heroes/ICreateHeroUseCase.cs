using Domain.Entities;

namespace Domain.Contracts.UseCases.Heroes
{
    public interface ICreateHeroUseCase
    {
        Task<HeroEntity> CreateHeroAsync(HeroEntity entity);
    }
}
