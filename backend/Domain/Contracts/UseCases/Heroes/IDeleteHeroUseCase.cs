﻿namespace Domain.Contracts.UseCases.Heroes
{
    public interface IDeleteHeroUseCase
    {
        Task DeleteHero(int heroId);
    }
}
