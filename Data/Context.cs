using SpecificationDesignPattern.Entities;

namespace SpecificationDesignPattern.Data
{
    public class Context
    {
        // Mocking dbContext
        public IEnumerable<City> Cities
        {
            get 
            { 
                return new List<City>
                {
                    new City(1, "Brasília", 4291577, "Brazil", true),
                    new City(2, "Vitória", 365855, "Brazil", false),
                    new City(3, "Curitiba", 3400100, "Brazil", false),
                    new City(4, "Rio de Janeiro", 6748000, "Brazil", false)
                }; 
            }
        }
        
    }
}
