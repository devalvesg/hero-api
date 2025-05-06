using Application.RequestObjects;
using Application.ResponseObjects;
using AutoMapper;
using Domain.Contracts.UseCases.Heroes;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HeroController(IMapper _mapper, ICreateHeroUseCase _createHeroUseCase, IGetHeroesUseCase _getHeroesUseCase) : ControllerBase
    {
        [HttpPost]
        public virtual async Task<IActionResult> CreateHero([FromBody] HeroRequestObject request) 
        {
            var response = await _createHeroUseCase.CreateHeroAsync(_mapper.Map<HeroEntity>(request));
            return Ok(_mapper.Map<HeroResponseObject>(response));
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetHeroes()
        {
            return Ok(_mapper.Map<HeroResponseObject[]>(await _getHeroesUseCase.GetHeroes()));
        }
    }
}
