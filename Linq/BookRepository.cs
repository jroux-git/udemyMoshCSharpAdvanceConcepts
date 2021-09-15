using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Book 1", Price = 10.20f},
                new Book() { Title = "Book 2", Price = 12.56f},
                new Book() { Title = "Book 3", Price = 15.50f},
                new Book() { Title = "Book 4", Price = 7.34f},
                new Book() { Title = "Book 5", Price = 6.21f},
            };
        }
    }
}
