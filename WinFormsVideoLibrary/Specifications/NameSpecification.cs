using WinFormsVideoLibrary.Specifications.Interfaces;
using Domain.Interfaces;

namespace WinFormsVideoLibrary.Specifications
{
    public class NameSpecification : ISpecification<INamedEntity>
    {
        private string name;
        public NameSpecification(string name)
        {
            this.name = name;
        }

        public bool IsSatisfiedBy(INamedEntity entity)
        {
            return entity.Name.Contains(name, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
