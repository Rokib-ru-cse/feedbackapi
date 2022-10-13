using feedbackapi.BLL.Repository;
using feedbackapi.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace feedbackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategory : ControllerBase
    {

        private readonly ISubCategoryBLRepository _subCategoryBLRepository;

        public SubCategory(ISubCategoryBLRepository subCategoryBLRepository)
        {
            _subCategoryBLRepository = subCategoryBLRepository;
        }

        [HttpGet("")]
        public IActionResult SubCategories()
        {
            try
            {
                return Ok(_subCategoryBLRepository.SubCategories());
            }
            catch (Exception ex)
            {
                return BadRequest(new ReturnResultWithCollection<Model.EntityModels.SubCategory>()
                {
                    Success = false,
                    Message = ex.Message,
                    Values = new List<Model.EntityModels.SubCategory>()
                });
            }
        }
        [HttpGet("{subcategoryId}")]
        public IActionResult SubCategories(int subcategoryId)
        {
            try
            {
                return Ok(_subCategoryBLRepository.SubCategory(subcategoryId));
            }
            catch (Exception ex)
            {
                return BadRequest(new ReturnResultWithClass<Model.EntityModels.SubCategory>()
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.EntityModels.SubCategory()
                });
            }
        }
    }
}
