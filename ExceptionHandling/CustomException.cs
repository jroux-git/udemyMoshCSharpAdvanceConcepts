using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class CustomException : Exception
    {
        public CustomException(string message, Exception innerException)
            :base(String.Concat("Handled by Custom Exception: ", message), innerException)
        {

        }
    }
}
