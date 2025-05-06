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
    public class HeroController(IMapper _mapper, ICreateHeroUseCase _createHeroUseCase, IGetHeroesUseCase _getHeroesUseCase, IGetHeroByIdUseCase _getHeroByIdUseCase, IUpdateHeroUseCase _updateHeroUseCase, IDeleteHeroUseCase _deleteHeroUseCase) : ControllerBase
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

        [HttpGet]
        public virtual async Task<IActionResult> GetHeroById([FromQuery] long heroId)
        {
            return Ok(_mapper.Map<HeroResponseObject[]>(await _getHeroByIdUseCase.GetHeroById(heroId)));
        }

        [HttpPut]
        public virtual async Task<IActionResult> UpdateHero([FromBody] HeroRequestObject request)
        {
            return Ok(_mapper.Map<HeroResponseObject[]>(await _updateHeroUseCase.UpdateHero(_mapper.Map<HeroEntity>(request))));
        }

        [HttpDelete]
        public virtual async Task<IActionResult> DeleteHero([FromQuery] long heroId)
        {
            await _deleteHeroUseCase.DeleteHero(heroId);
            return Ok();
        }
    }
}
