using FakeXC.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FakeXC.API.Dtos;
using FakeXC.API.Models;

namespace FakeXC.API.Controllers
{
    [Route("api/touristRoutes/{touristRouteId}/pictures")]
    [ApiController]
    public class TouristRoutePicturesController : ControllerBase
    {
        private ITouristRouteRepository _touristRouteRepository;
        private readonly IMapper _mapper;
        public TouristRoutePicturesController(ITouristRouteRepository touristRouteRepository, IMapper mapper)
        {
            _touristRouteRepository = touristRouteRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetPictureListForTouristRoute(Guid touristRouteId)
        {
            if (!(await _touristRouteRepository.TouristRouteExistsAsync(touristRouteId)))
            {
                return NotFound("旅游线程不存在");
            }
            var picturesFromRepo = await _touristRouteRepository.GetPicturesByTouristRouteIdAsync(touristRouteId);
            if(picturesFromRepo==null || picturesFromRepo.Count() <= 0)
            {
                return NotFound("找不到旅游路线照片");
            }
           var touristRoutePictureDto=  _mapper.Map<IEnumerable<TouristRoutePictureDto>>(picturesFromRepo);
            return Ok(touristRoutePictureDto);
        }
        [HttpGet("{pictureId}",Name = "GetPicture")]
        //对于父子关系的资源，需要先判断父资源，再判断子资源
        //https://localhost:5001/api/TouristRoutes/10d318ad-e39c-4b8f-baa3-858431affc67/pictures/5
        public async Task<IActionResult> GetPicture(Guid touristRouteId,int pictureId)
        {
            if (!(await _touristRouteRepository.TouristRouteExistsAsync(touristRouteId)))
            {
                return NotFound("旅游线程不存在");
            }
            var pictureFromRepo = _touristRouteRepository.GetPictureAsync(pictureId);
            if (pictureFromRepo == null)
            {
                return NotFound("照片不存在");
            }
            return Ok(_mapper.Map<TouristRoutePictureDto>(pictureFromRepo));
        }
    
        [HttpPost]
        public async Task<IActionResult> CreateTouristRoutePicture([FromRoute]Guid touristRouteId,
            [FromBody] TouristRoutePictureForCreationDto touristRoutePictureForCreationDto
            )
        {
            if (!(await _touristRouteRepository.TouristRouteExistsAsync(touristRouteId)))
            {
                return NotFound("旅游线程不存在");
            }
            var pictureModel = _mapper.Map<TouristRoutePicture>(touristRoutePictureForCreationDto);
            _touristRouteRepository.AddTouristRoutePicture(touristRouteId, pictureModel);
            await _touristRouteRepository.SaveAsync();
            var pictureToReturn = _mapper.Map<TouristRoutePictureDto>(pictureModel);
            return CreatedAtRoute("GetPicture", 
                //传入url 参数对象
                new { touristRouteId = touristRouteId, pictureId = pictureModel.Id }, 
                pictureToReturn);

        }
        //https://localhost:5001/api/touristRoutes/10d318ad-e39c-4b8f-baa3-858431affc67/pictures/5
        [HttpDelete("{pictureID}")]
        public async Task<IActionResult> DeleteTouristRoutePicture([FromRoute] Guid touristRouteId, int pictureID)
        {
            if (!(await _touristRouteRepository.TouristRouteExistsAsync(touristRouteId)))
            {
                return NotFound("旅游线程不存在");
            }
            var picture=await _touristRouteRepository.GetPictureAsync(pictureID);
            _touristRouteRepository.DeleteTouristRoutePicture(picture);
            await _touristRouteRepository.SaveAsync();
            return NoContent();
        }
    }
}
