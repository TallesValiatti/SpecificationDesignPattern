using SpecificationDesignPattern.Data;
using SpecificationDesignPattern.Entities;

namespace SpecificationDesignPattern.Repositories
{
    public class LegacyCityRepository : ILegacyCityRepository
    {
        // Mocking dbContext
        private Context _dbContext;
        
        public LegacyCityRepository()
        {
            _dbContext = new Context();
        }

        public IEnumerable<City> GetCities()
        {
            return _dbContext.Cities;
        }

        public IEnumerable<City> GetCities(bool isCountryCapital)
        {
            return _dbContext.Cities.Where(x => x.IsCountryCapital == isCountryCapital);
        }

        public IEnumerable<City> GetCities(int population)
        {
            return _dbContext.Cities.Where(x => x.Population >= population);
        }

        public IEnumerable<City> GetCities(int population, bool isCountryCapital)
        {
            return _dbContext.Cities.Where(x => 
            {
                return x.Population >= population &&
                       x.IsCountryCapital == isCountryCapital;
            });
        }
    }
}