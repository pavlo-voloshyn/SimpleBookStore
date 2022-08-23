using BL.DataAccess.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DataAccess.Repositories.Defenitions
{
    public interface IBookRepository
    {
        Task Create(Book book);
        
        Task Update(Book book);

        Task Delete(Book book);

        Book Get(Guid id);

        List<Book> GetAll();
    }
}
