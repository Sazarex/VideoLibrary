namespace Domain.Interfaces
{
    public interface INamedEntity: IEntity
    {
        public string Name { get; set; }
    }
}
