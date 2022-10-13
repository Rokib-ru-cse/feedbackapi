using feedbackapi.BLL.Repository;
using feedbackapi.DAL;
using feedbackapi.Model.EntityModels;
using feedbackapi.Model.ViewModel;

namespace feedbackapi.BLL.Service
{
    public class CategoryBLService : ICategoryBLRepository
    {

        private readonly AppDbContext context;

        public CategoryBLService(AppDbContext context)
        {
            this.context = context;
        }

        public ReturnResultWithCollection<Category> Categories()
        {
            try
            {
                return new ReturnResultWithCollection<Category>()
                {
                    Success = true,
                    Message = "Category list found",
                    Values = context.Categories.ToList()
                };
            }
            catch (Exception ex)
            {
                return new ReturnResultWithCollection<Category>()
                {
                    Success = false,
                    Message = ex.Message,
                    Values = new List<Category>()
                };
            }
        }

        public ReturnResultWithClass<Category> Category(int categoryId)
        {
            try
            {
                return new ReturnResultWithClass<Category>()
                {
                    Success = true,
                    Message = "Category found",
                    Value = context.Categories.Find(categoryId)
                };
            }
            catch (Exception ex)
            {
                return new ReturnResultWithClass<Category>()
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new Category()
                };
            }
        }
    }
}
