using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DataAccess.Enteties
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public int PageNumber { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
