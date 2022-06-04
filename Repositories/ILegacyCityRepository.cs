using SpecificationDesignPattern.Entities;

namespace SpecificationDesignPattern.Repositories
{
    public interface ILegacyCityRepository
    {
        IEnumerable<City> GetCities();
        IEnumerable<City> GetCities(bool isCountryCapital);
        IEnumerable<City> GetCities(int population);
        IEnumerable<City> GetCities(int population, bool isCountryCapital);
    }
}