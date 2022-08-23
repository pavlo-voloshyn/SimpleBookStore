using BL.BussinessLogic.Models.Book;
using BL.BussinessLogic.Services.Defenitions;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var book = bookService.Get(id);
            return Ok(book);
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var books = bookService.GetAll();
            return Ok(books);
        }
        
        [HttpPost("create")]
        public async Task<IActionResult> Create(BookInsert book)
        {
            await bookService.Create(book);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, BookUpdate book)
        {
            await bookService.Update(id, book);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await bookService.Delete(id);
            return Ok();
        }

    }
}
