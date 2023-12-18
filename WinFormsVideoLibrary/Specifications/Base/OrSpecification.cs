using WinFormsVideoLibrary.Specifications.Interfaces;

namespace WinFormsVideoLibrary.Specifications.Base
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        public OrSpecification(ISpecification<T> one, ISpecification<T> other) : base(one, other)
        {
        }

        public override bool IsSatisfiedBy(T entity)
        {
            return One.IsSatisfiedBy(entity) && Other.IsSatisfiedBy(entity);
        }
    }
}
