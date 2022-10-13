using feedbackapi.BLL.Repository;
using feedbackapi.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace feedbackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Category : ControllerBase
    {
        private readonly ICategoryBLRepository categoryBLRepository;

        public Category(ICategoryBLRepository categoryBLRepository)
        {
            this.categoryBLRepository = categoryBLRepository;
        }

        [HttpGet("")]
        public IActionResult Categories()
        {
            try
            {
                return Ok(categoryBLRepository.Categories());
            }
            catch (Exception ex)
            {
                return BadRequest(new ReturnResultWithCollection<Category>()
                {
                    Success = false,
                    Message = ex.Message,
                    Values = new List<Category>()
                });
            }
        }
        [HttpGet("{categoryId}")]
        public IActionResult Categories(int categoryId)
        {
            try
            {
                return Ok(categoryBLRepository.Category(categoryId));
            }
            catch (Exception ex)
            {
                return BadRequest(new ReturnResultWithClass<Model.EntityModels.Category>()
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.EntityModels.Category()
                });

            }
        }
    }
}
