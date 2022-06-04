using SpecificationDesignPattern.Entities;

namespace SpecificationDesignPattern.Specifications
{
    public class PopulationIsGreaterThanOrEqualSpecification : ISpecification<City>
    {   
        private int _population;
        public PopulationIsGreaterThanOrEqualSpecification(int population)
        {
            this._population = population;
        }
        
        public bool IsSatisfiedBy(City item) => item.Population >= _population;
    }
}