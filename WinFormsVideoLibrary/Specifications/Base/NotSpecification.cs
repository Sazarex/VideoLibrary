using Domain.Interfaces;
using WinFormsVideoLibrary.Specifications.Interfaces;

namespace WinFormsVideoLibrary.Specifications.Base
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> Wrapped;

        public NotSpecification(ISpecification<T> wrapped)
        {
            Wrapped = wrapped;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return !Wrapped.IsSatisfiedBy(entity);
        }
    }
}
