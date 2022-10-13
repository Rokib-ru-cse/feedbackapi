using feedbackapi.Model.EntityModels;
using feedbackapi.Model.ViewModel;

namespace feedbackapi.BLL.Repository
{
    public interface ICityBLRepository
    {
        public ReturnResultWithCollection<City> Cities();
        public ReturnResultWithClass<City> City(int cityId);
    }
}