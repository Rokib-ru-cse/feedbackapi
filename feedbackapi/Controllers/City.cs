using feedbackapi.BLL.Repository;
using feedbackapi.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace feedbackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class City : ControllerBase
    {
        private readonly ICityBLRepository cityBLRepository;

        public City(ICityBLRepository cityBLRepository)
        {
            this.cityBLRepository = cityBLRepository;
        }

        [HttpGet("")]
        public IActionResult Cities()
        {
            try
            {
                return Ok(cityBLRepository.Cities());
            }
            catch (Exception ex)
            {
                return BadRequest(new ReturnResultWithCollection<Model.EntityModels.City>()
                {
                    Success = false,
                    Message = ex.Message,
                    Values = new List<Model.EntityModels.City>()
                });
            }
        }
        [HttpGet("{cityId}")]
        public IActionResult Cities(int cityId)
        {
            try
            {
                return Ok(cityBLRepository.City(cityId));
            }
            catch (Exception ex)
            {
                return BadRequest(new ReturnResultWithClass<Model.EntityModels.City>()
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.EntityModels.City()
                });

            }
        }
    }
}
