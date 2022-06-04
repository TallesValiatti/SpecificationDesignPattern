using SpecificationDesignPattern.Data;
using SpecificationDesignPattern.Entities;
using SpecificationDesignPattern.Specifications;

namespace SpecificationDesignPattern.Repositories
{
    public class CityRepository : ICityRepository
    {
         // Mocking dbContext
        private Context _dbContext;
        
        public CityRepository()
        {
            _dbContext = new Context();
        }

        public IEnumerable<City> GetCities(ISpecification<City> spec)
        {
            return _dbContext.Cities.Where(x => spec.IsSatisfiedBy(x));
        }
    }
}