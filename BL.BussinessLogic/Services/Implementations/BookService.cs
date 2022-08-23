using AutoMapper;
using BL.BussinessLogic.Models.Book;
using BL.BussinessLogic.Services.Defenitions;
using BL.DataAccess.Enteties;
using BL.DataAccess.Repositories.Defenitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BussinessLogic.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;
        private readonly IMapper mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            this.bookRepository = bookRepository;
            this.mapper = mapper;
        }

        public async Task Create(BookInsert bookInsert)
        {
            var book = mapper.Map<Book>(bookInsert);
            await bookRepository.Create(book);
        }

        public async Task Delete(Guid id)
        {
            var bookToDelete = bookRepository.Get(id);
            
            if (bookToDelete == null)
            {
                throw new ArgumentException($"Not found book with id {id}");
            }

            await bookRepository.Delete(bookToDelete);
        }

        public BookView Get(Guid id)
        {
            var book = bookRepository.Get(id);

            if (book == null)
            {
                throw new ArgumentException($"Not found book with id {id}");
            }

            var bookView = mapper.Map<BookView>(book);
            return bookView;
        }

        public List<BookView> GetAll()
        {
            var books = bookRepository.GetAll();

            var bookViews = mapper.Map<List<BookView>>(books);
            return bookViews;
        }

        public async Task Update(Guid id, BookUpdate bookUpdate)
        {
            var book = bookRepository.Get(id);

            if (book == null)
            {
                throw new ArgumentException($"Not found book with id {id}");
            }

            mapper.Map(bookUpdate, book);
            await bookRepository.Update(book);
        }
    }
}
