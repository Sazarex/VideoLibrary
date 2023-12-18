using Domain.Interfaces;

namespace WinFormsVideoLibrary.Specifications.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
