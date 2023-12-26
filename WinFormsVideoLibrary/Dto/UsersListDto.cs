namespace WinFormsVideoLibrary.Dto
{
    public class UsersListDto : BaseEntityDto
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public string IsSubscriptionActive { get; set; }
    }
}
