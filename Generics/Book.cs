using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Book: Product
    {
        public string Isbn { get; set; }

        public Book(string pIsbn, string pTitle)
        {
            Isbn = pIsbn;
            Title = pTitle;
        }
    }
}
