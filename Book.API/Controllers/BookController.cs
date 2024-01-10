using Book.API.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepo;
        public BookController(IBookRepository bookRepo)
        {
            _bookRepo = bookRepo;
        }

        [HttpGet("Books")]
        public async Task<IActionResult> GetBooks()
        {
            var bookEntities = await _bookRepo.GetBooksAsync();
            return Ok(bookEntities);
        }
        [HttpGet("Books/{Id}")]
        public async Task<IActionResult> GetBook(int Id)
        {
            var bookEntity = await _bookRepo.GetBookAsync(Id);
            if (bookEntity == null)
            {
                return NotFound();
            }
            return Ok(bookEntity);
        }
    }
}
