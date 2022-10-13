using feedbackapi.Model.EntityModels;
using feedbackapi.Model.ViewModel;

namespace feedbackapi.BLL.Repository
{
    public interface ISubCategoryBLRepository
    {
        public ReturnResultWithCollection<SubCategory> SubCategories();
        public ReturnResultWithClass<SubCategory> SubCategory(int subcategoryId);
    }
}
