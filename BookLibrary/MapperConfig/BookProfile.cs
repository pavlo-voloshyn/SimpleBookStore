using AutoMapper;
using BL.BussinessLogic.Models.Book;
using BL.DataAccess.Enteties;

namespace BookLibrary.MapperConfig
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<BookInsert, Book>();
            CreateMap<BookUpdate, Book>();
            CreateMap<Book, BookView>();
        }
    }
}
