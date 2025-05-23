namespace LibraryApp.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public required Author Author { get; set; }
    public  Genre Genre { get; set; }  
    public DateOnly PublishedDate { get; set; }
    public bool IsCheckedOut    { get; set;  }
    public Synopsis? Synopsis { get; set; }
}