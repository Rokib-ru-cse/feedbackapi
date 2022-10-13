using feedbackapi.Model.EntityModels;
using feedbackapi.Model.ViewModel;

namespace feedbackapi.BLL.Repository
{
    public interface ICountryBLRepository
    {
        public ReturnResultWithCollection<Country> Countries();
        public ReturnResultWithClass<Country> Country(int countryId);
    }
}
