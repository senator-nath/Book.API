using Book.API.Dbcontext;
using Book.API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Book.API.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _dbContext;
        public BookRepository(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Entities.Book>? GetBookAsync(int Id)
        {
            return await _dbContext.Book.FirstOrDefaultAsync(b => b.Id == Id);
        }

        public async Task<IEnumerable<Entities.Book>> GetBooksAsync()
        {
            var BookList = await _dbContext.Book
                .Include(a => a.Author)
                .ToListAsync();
            return BookList;
        }
    }
}
