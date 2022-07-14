using FakeXC.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FakeXC.API.Dtos;
using FakeXC.API.ResourceParameters;
using FakeXC.API.Models;
using FakeXC.API.IServiceTest;
using Microsoft.AspNetCore.JsonPatch;
using FakeXC.API.Helper;
using Microsoft.AspNetCore.Authorization;

namespace FakeXC.API.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class TouristRoutesController : ControllerBase
    {
        private ITouristRouteRepository _touristRouteRepository;
        private readonly IMapper _mapper;
        
        public TouristRoutesController(ITouristRouteRepository touristRouteRepository, IMapper mapper)
        {
            _touristRouteRepository = touristRouteRepository;
            _mapper = mapper;
           
    }
        [HttpGet]
        [HttpHead]
        public async Task<IActionResult> GetTouristRoutes(
            [FromQuery]TouristRouteResourceParameters parameters)
        {
            var tourRoutesFromRepo=await _touristRouteRepository.GetTouristRoutesAsync(parameters.Keyword, 
                parameters.RatingOperator,
                parameters.RatingValue);
           
            if(tourRoutesFromRepo==null|| tourRoutesFromRepo.Count() <= 0)
            {
                return NotFound("没有旅游路线");
            }
            var touristRoutesDto = _mapper.Map<IEnumerable<TouristRouteDto>>(tourRoutesFromRepo);
            return Ok(touristRoutesDto);
        }
      
        
        [HttpGet("{TouristRouteId}", Name = "GetTouristRoutesById")]
    
        public async Task<IActionResult> GetTouristRoutesById([FromRoute]string TouristRouteId)
        {
            var tourRoutesFromRepo = await _touristRouteRepository.GetTouristRouteAsync(new Guid(TouristRouteId));
            if (tourRoutesFromRepo == null)
            {
                return NotFound("旅游路线没找到");
            }
            var touristRouteDto = _mapper.Map<TouristRouteDto>(tourRoutesFromRepo);
            return Ok(touristRouteDto);
        }
        //使用 Identity 认证时一定要用这个标签
        [Authorize(AuthenticationSchemes ="Bearer")]
        //[Authorize]
        [HttpPost]
       
        public async Task< IActionResult> CreateTouristRoute([FromBody] TouristRouteForCreationDto touristRouteForCreationDto)
        {
            var touristRouteModel = _mapper.Map<TouristRoute>(touristRouteForCreationDto);
            _touristRouteRepository.AddTouristRoute(touristRouteModel);
           await _touristRouteRepository.SaveAsync();
            var touristRouteToReturn = _mapper.Map<TouristRouteDto>(touristRouteModel);
            //CreatedAtRoute返回201,CreatedAtRoute 会在 header 的 location 中添加查询该路线的 URL，这就是 Hatoas
            return CreatedAtRoute("GetTouristRoutesById", new { touristRouteId = touristRouteToReturn.Id }, touristRouteToReturn);
        }
    
    
        [HttpPut("{touristRouteId}")]
        public async Task<IActionResult> UpdateTouristRoute([FromRoute]Guid touristRouteId,
            [FromBody] TouristRouteForUpdateDto touristRouteForUpdateDto
            )
        {
          
            if (!(await _touristRouteRepository.TouristRouteExistsAsync(touristRouteId)))
            {
                return NotFound("旅游路线没找到");
            }

            var touristRouteFromRepo = await _touristRouteRepository.GetTouristRouteAsync(touristRouteId);
            _mapper.Map(touristRouteForUpdateDto, touristRouteFromRepo);

            //可以直接保存，因为 ORM 框架会追踪 touristRouteFromRepo 状态
           await _touristRouteRepository.SaveAsync();

            return NoContent();
        }
   
        [HttpPatch("{touristRouteId}")]
        public async Task<IActionResult> PartiallyUpdateTouristRoute([FromRoute] Guid touristRouteId,
            [FromBody] JsonPatchDocument<TouristRouteForUpdateDto> patchDocument
            )
        {
            if (!(await _touristRouteRepository.TouristRouteExistsAsync(touristRouteId)))
            {
                return NotFound("旅游路线没找到");
            }

            var touristRouteFromRepo = await _touristRouteRepository.GetTouristRouteAsync(touristRouteId);
            var touristRouteToPatch = _mapper.Map<TouristRouteForUpdateDto>(touristRouteFromRepo);
           patchDocument.ApplyTo(touristRouteToPatch, ModelState);
            if (!TryValidateModel(touristRouteToPatch)) {
                return ValidationProblem(ModelState);
            };
            _mapper.Map(touristRouteToPatch, touristRouteFromRepo);
           await _touristRouteRepository.SaveAsync();
            return NoContent();
        }

        [HttpDelete("{touristRouteId}")]
        public async Task<IActionResult> DeleteTouristRoute([FromRoute] Guid touristRouteId)
        {
            if (!(await _touristRouteRepository.TouristRouteExistsAsync(touristRouteId)))
            {
                return NotFound("旅游路线没找到");
            }
            var touristRoute=await _touristRouteRepository.GetTouristRouteAsync(touristRouteId);
             _touristRouteRepository.DeleteTouristRoute(touristRoute);
            await _touristRouteRepository.SaveAsync();
            return NoContent();
        }

        [HttpDelete("({touristRouteIds})")]
        public async Task<IActionResult> DeleteByIds([ModelBinder(BinderType=typeof(ArrayModelBinder))][FromRoute] IEnumerable<Guid> touristRouteIds)
        {
            if (touristRouteIds == null)
            {
                return BadRequest();
            }
            var touristRoutesFromRepo = await _touristRouteRepository.GetTouristRoutesByIDListAsync(touristRouteIds);
            _touristRouteRepository.DeleteTouristRoutesByIDList(touristRoutesFromRepo);
           await _touristRouteRepository.SaveAsync();
            return NoContent();
        }
    }
}
