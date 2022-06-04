using System.Linq.Expressions;

namespace SpecificationDesignPattern.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T item);
    }
}