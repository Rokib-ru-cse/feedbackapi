using feedbackapi.BLL.Repository;
using feedbackapi.DAL;
using feedbackapi.Model.EntityModels;
using feedbackapi.Model.ViewModel;

namespace feedbackapi.BLL.Service
{
    public class SubCategoryBLService : ISubCategoryBLRepository
    {
        private readonly AppDbContext context;

        public SubCategoryBLService(AppDbContext context)
        {
            this.context = context;
        }

        public ReturnResultWithCollection<SubCategory> SubCategories()
        {
            try
            {
                return new ReturnResultWithCollection<SubCategory>()
                {
                    Success = true,
                    Message = "SubCategory list found",
                    Values = context.SubCategories.ToList()
                };
            }
            catch (Exception ex)
            {
                return new ReturnResultWithCollection<SubCategory>()
                {
                    Success = false,
                    Message = ex.Message,
                    Values = new List<SubCategory>()
                };
            }
        }

        public ReturnResultWithClass<SubCategory> SubCategory(int subcategoryId)
        {
            try
            {
                return new ReturnResultWithClass<SubCategory>()
                {
                    Success = true,
                    Message = "SubCategory found",
                    Value = context.SubCategories.Find(subcategoryId)
                };
            }
            catch (Exception ex)
            {
                return new ReturnResultWithClass<SubCategory>()
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new SubCategory()
                };
            }
        }
    }
}
