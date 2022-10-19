using feedbackapi.Model.EntityModels;
using feedbackapi.Model.ViewModel;

namespace feedbackapi.BLL.Repository
{
    public interface ICategoryBLRepository
    {
        public ReturnResultWithCollection<Category> Categories();
        public ReturnResultWithClass<Category> Category(int categoryId);
        public ReturnResultWithClass<Category> SaveCategory(Category category);
        public ReturnResultWithClass<Category> UpdateCategory(Category category);
        public ReturnResultWithClass<Category> DeleteCategory(int categoryId);
    }
}
