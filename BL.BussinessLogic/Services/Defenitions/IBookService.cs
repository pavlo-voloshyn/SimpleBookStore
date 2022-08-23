using BL.BussinessLogic.Models.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BussinessLogic.Services.Defenitions
{
    public interface IBookService
    {
        Task Create(BookInsert book);

        Task Update(Guid id, BookUpdate book);

        Task Delete(Guid id);

        BookView Get(Guid id);

        List<BookView> GetAll();
    }
}
