using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BussinessLogic.Models.Book
{
    public class BookView
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public int PageNumber { get; set; }
    }
}
