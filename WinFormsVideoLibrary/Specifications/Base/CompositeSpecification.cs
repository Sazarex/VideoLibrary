using WinFormsVideoLibrary.Specifications.Interfaces;

namespace WinFormsVideoLibrary.Specifications.Base
{
    public abstract class CompositeSpecification<T> : ICompositeSpecification<T>
    {
        protected ISpecification<T> One;
        protected ISpecification<T> Other;
        public abstract bool IsSatisfiedBy(T entity);

        public CompositeSpecification(ISpecification<T> one, ISpecification<T> other)
        {
            One = one;
            Other = other;
        }

        public ISpecification<T> And(ISpecification<T> other)
        {
            throw new NotImplementedException();
        }

        public ISpecification<T> Not()
        {
            throw new NotImplementedException();
        }

        public ISpecification<T> Or(ISpecification<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
