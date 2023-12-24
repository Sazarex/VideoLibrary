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
            return new AndSpecification<T>(this, other);
        }

        public ISpecification<T> Not()
        {
            return new NotSpecification<T>(this);
        }

        public ISpecification<T> Or(ISpecification<T> other)
        {
            return new OrSpecification<T>(this, other);
        }
    }
}
