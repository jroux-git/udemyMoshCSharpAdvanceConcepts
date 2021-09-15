using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book("isbn", "title");

            //// Non-generic
            //var numbers = new List<int>();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            //// Generic
            //var gNumbers = new GenericList<int>();
            //gNumbers.Add(10);
            
            //Console.WriteLine(gNumbers[0]);

            //var gBooks = new GenericList<Book>();
            //gBooks.Add(book);

            //Console.WriteLine(gBooks[0]);

            //// Generic Dictionary
            //var gDictionary = new GenericDictionary<string, Book>();
            //gDictionary.Add("1234", book);

            // Nullable T
            var number = new Nullable<int>(5);
            Console.WriteLine(number.HasValue);
            Console.WriteLine(number.GetValueOrDefault());
            Console.Read();

        }
    }
}
