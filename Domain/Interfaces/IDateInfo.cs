namespace Domain.Interfaces
{
    public interface IDateInfo
    {
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
