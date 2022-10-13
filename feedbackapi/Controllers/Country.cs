using feedbackapi.BLL.Repository;
using feedbackapi.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace feedbackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Country : ControllerBase
    {
        private readonly ICountryBLRepository countryBLRepository;

        public Country(ICountryBLRepository countryBLRepository)
        {
            this.countryBLRepository = countryBLRepository;
        }

        [HttpGet("")]
        public IActionResult Countries()
        {
            try
            {
                return Ok(countryBLRepository.Countries());
            }
            catch (Exception ex)
            {
                return BadRequest(new ReturnResultWithCollection<Model.EntityModels.Country>()
                {
                    Success = false,
                    Message = ex.Message,
                    Values = new List<Model.EntityModels.Country>()
                }); ;
            }
        }
        [HttpGet("{countryId}")]
        public IActionResult Countries(int countryId)
        {
            try
            {
                return Ok(countryBLRepository.Country(countryId));
            }
            catch (Exception ex)
            {
                return BadRequest(new ReturnResultWithClass<Model.EntityModels.Country>()
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.EntityModels.Country()
                });

            }
        }
    }
}
