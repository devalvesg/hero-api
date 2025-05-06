using Application.UseCases;
using Domain.Contracts.Data;
using Domain.Contracts.UseCases.Heroes;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            var conn = configuration.GetConnectionString("Default");
            services.AddDbContext<IHeroDbContext, HeroDbContext>(cfg =>
                cfg.UseSqlServer(conn)
            );

            services.TryAddScoped<ICreateHeroUseCase, CreateHeroUseCase>();
            services.TryAddScoped<IGetHeroesUseCase, GetHeroesUseCase>();

            return services;
        }
    }
}
