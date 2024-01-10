using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Book.API.Dbcontext
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        { }
        public DbSet<Entities.Book> Book { get; set; }
    }
}

