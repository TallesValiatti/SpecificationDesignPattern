using SpecificationDesignPattern.Entities;

namespace SpecificationDesignPattern.Specifications
{
    public class IsCountryCapitalSpecification : ISpecification<City>
    {   
        private bool _isCountryCapital;
        public IsCountryCapitalSpecification(bool isCountryCapital)
        {
            this._isCountryCapital = isCountryCapital;
        }
        
        public bool IsSatisfiedBy(City item) => item.IsCountryCapital == _isCountryCapital;
    }
}