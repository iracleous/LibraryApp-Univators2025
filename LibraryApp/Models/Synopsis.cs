namespace LibraryApp.Models
{
    public class Synopsis
    {
        public int Id { get; set; }
        public DateOnly PublicationDate { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
