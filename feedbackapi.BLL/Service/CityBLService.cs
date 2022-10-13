using feedbackapi.BLL.Repository;
using feedbackapi.DAL;
using feedbackapi.Model.EntityModels;
using feedbackapi.Model.ViewModel;

namespace feedbackapi.BLL.Service
{
    public class CityBLService : ICityBLRepository
    {

        private readonly AppDbContext context;

        public CityBLService(AppDbContext context)
        {
            this.context = context;
        }

        public ReturnResultWithCollection<City> Cities()
        {
            try
            {
                return new ReturnResultWithCollection<City>()
                {
                    Success = true,
                    Message = "City list found",
                    Values = context.Cities.ToList()
                };
            }
            catch (Exception ex)
            {
                return new ReturnResultWithCollection<City>()
                {
                    Success = false,
                    Message = ex.Message,
                    Values = new List<City>()
                };
            }
        }

        public ReturnResultWithClass<City> City(int cityId)
        {
            try
            {
                return new ReturnResultWithClass<City>()
                {
                    Success = true,
                    Message = "City found",
                    Value = context.Cities.Find(cityId)
                };
            }
            catch (Exception ex)
            {
                return new ReturnResultWithClass<City>()
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new City()
                };
            }
        }
    }
}
