using BL.DataAccess.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DataAccess.Context
{
    public class BookLibContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public BookLibContext(DbContextOptions<BookLibContext> options) : base(options)
        {

        }
    }
}
