using feedbackapi.BLL.Repository;
using feedbackapi.DAL;
using feedbackapi.Model.EntityModels;
using feedbackapi.Model.ViewModel;

namespace feedbackapi.BLL.Service
{
    public class CountryBLService : ICountryBLRepository
    {

        private readonly AppDbContext context;

        public CountryBLService(AppDbContext context)
        {
            this.context = context;
        }

        public ReturnResultWithCollection<Country> Countries()
        {
            try
            {
                return new ReturnResultWithCollection<Country>()
                {
                    Success = true,
                    Message = "Country list found",
                    Values = context.Countries.ToList()
                };
            }
            catch (Exception ex)
            {
                return new ReturnResultWithCollection<Country>()
                {
                    Success = false,
                    Message = ex.Message,
                    Values = new List<Country>()
                };
            }
        }

        public ReturnResultWithClass<Country> Country(int countryId)
        {
            try
            {
                return new ReturnResultWithClass<Country>()
                {
                    Success = true,
                    Message = "Country found",
                    Value = context.Countries.Find(countryId)
                };
            }
            catch (Exception ex)
            {
                return new ReturnResultWithClass<Country>()
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new Country()
                };
            }
        }
    }
}
