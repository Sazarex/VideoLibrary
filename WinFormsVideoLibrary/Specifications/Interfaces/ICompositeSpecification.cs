namespace WinFormsVideoLibrary.Specifications.Interfaces
{
    public interface ICompositeSpecification<T>: ISpecification<T>
    {
        ISpecification<T> And(ISpecification<T> other);
        ISpecification<T> Or(ISpecification<T> other);
        ISpecification<T> Not();
    }
}
