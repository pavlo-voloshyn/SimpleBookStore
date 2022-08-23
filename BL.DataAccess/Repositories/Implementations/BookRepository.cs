using BL.DataAccess.Context;
using BL.DataAccess.Enteties;
using BL.DataAccess.Repositories.Defenitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DataAccess.Repositories.Implementations
{
    public class BookRepository : IBookRepository
    {
        private readonly BookLibContext context;

        public BookRepository(BookLibContext context)
        {
            this.context = context;
        }

        public async Task Create(Book book)
        {
            context.Books.Add(book);
            await context.SaveChangesAsync();   
        }

        public async Task Delete(Book book)
        {
            context.Books.Remove(book);
            await context.SaveChangesAsync();
        }

        public Book Get(Guid id)
        {
            var book = context.Books.FirstOrDefault(b => b.Id == id);
            return book;
        }

        public List<Book> GetAll()
        {
            var books = context.Books.ToList();
            return books;
        }

        public async Task Update(Book book)
        {
            context.Books.Update(book);
            await context.SaveChangesAsync();
        }
    }
}
