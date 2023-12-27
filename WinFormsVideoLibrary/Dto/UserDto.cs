namespace WinFormsVideoLibrary.Dto
{
    public class UserDto: BaseEntityDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime? SubscriptionCreationDate { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        public string SubscriptionStatus { get; set;}
    }
}
