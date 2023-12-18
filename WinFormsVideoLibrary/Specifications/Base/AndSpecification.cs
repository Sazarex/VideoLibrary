using WinFormsVideoLibrary.Specifications.Interfaces;

namespace WinFormsVideoLibrary.Specifications.Base
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public AndSpecification(ISpecification<T> one, ISpecification<T> other) : base(one, other)
        {
        }

        public override bool IsSatisfiedBy(T entity)
        {
            return One.IsSatisfiedBy(entity) && Other.IsSatisfiedBy(entity);
        }
    }
}
