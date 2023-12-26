namespace WinFormsVideoLibrary.Dto
{
    public class MovieListDto: BaseNamedEntityDto
    {
        public string GenreName { get; set; }

        public string ProducerName { get; set; }
        public string Description { get; set; }
    }
}
