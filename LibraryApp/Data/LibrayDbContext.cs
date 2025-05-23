using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data;

public class LibrayDbContext: DbContext
{
    public LibrayDbContext(DbContextOptions<LibrayDbContext> options) : base(options)
    {
    }
    public DbSet<Book> Books { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .Property(b => b.Genre)
            .HasConversion<string>();
    }
}
 