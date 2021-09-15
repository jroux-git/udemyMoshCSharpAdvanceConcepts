using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookRepo = new BookRepository();
            var books = bookRepo.GetBooks();

            //Sample1(books);
            //Sample2(books);

            Console.Read();
        }

        // LINQ extension methods
        private static void Sample1(IEnumerable<Book> books)
        {
            
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            foreach (string book in cheapBooks)
            {
                Console.WriteLine(book);
            }
        }

        // LINQ Query operators
        private static void Sample2(IEnumerable<Book> books)
        {
            var cheaperBooks = from book in books
                               where book.Price < 10
                               orderby book.Title
                               select book.Title;

            foreach (string book in cheaperBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
