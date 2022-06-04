using SpecificationDesignPattern.Entities;
using SpecificationDesignPattern.Specifications;

namespace SpecificationDesignPattern.Repositories
{
    public interface ICityRepository
    {
        IEnumerable<City> GetCities(ISpecification<City> spec);
    }
}