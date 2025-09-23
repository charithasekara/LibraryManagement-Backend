using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public BooksController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(dbContext.Set<Book>().ToList()); // Use Set<Book>() instead of Books
        }

        [HttpPost]
        public IActionResult AddBook(AddBookDto addBookDto)
        {
            var bookEntity = new Book()
            {
                Name = addBookDto.Name,
                Author = addBookDto.Author,
                Description = addBookDto.Description,
            };

            dbContext.Set<Book>().Add(bookEntity); // Use Set<Book>() instead of Books
            dbContext.SaveChanges();

            return Ok(bookEntity);
        }

    }

}
