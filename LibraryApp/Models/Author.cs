namespace LibraryApp.Models
{
    public class Author
    {
        public int Id { get; set; } //Will automatically be detected as the primary key
        public string FirstName { get; set; } = string.Empty;
        public string LatName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public List<Book> Books { get; set; } = new();
    }
}
