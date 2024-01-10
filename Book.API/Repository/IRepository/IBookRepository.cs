namespace Book.API.Repository.IRepository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Entities.Book>> GetBooksAsync();
        Task<Entities.Book>? GetBookAsync(Guid Id);
    }
}
