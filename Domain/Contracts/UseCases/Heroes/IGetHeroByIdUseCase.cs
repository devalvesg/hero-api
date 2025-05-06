using Domain.Entities;

namespace Domain.Contracts.UseCases.Heroes
{
    public interface IGetHeroByIdUseCase
    {
        Task<HeroEntity> GetHeroById(long heroId);
    }
}
