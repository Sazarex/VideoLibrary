using WinFormsVideoLibrary.Specifications.Interfaces;

namespace WinFormsVideoLibrary.Specifications
{
    public class FilterSpecification<T> : ISpecification<T>
    {
        public bool IsSatisfiedBy(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
