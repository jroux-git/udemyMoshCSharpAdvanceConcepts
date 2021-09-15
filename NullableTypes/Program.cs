using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<DateTime> date1 = null;
            DateTime? date2 = DateTime.Now;

            Console.WriteLine($"Date1 GetValueOrDefault: {date1.GetValueOrDefault()}");
            Console.WriteLine($"Date1 HasValue: {date1.HasValue}");
            //Console.WriteLine($"Date1 Value: {date1.Value}");

            Console.WriteLine($"Date2 GetValueOrDefault: {date2.GetValueOrDefault()}");
            Console.WriteLine($"Date2 HasValue: {date2.HasValue}");
            Console.WriteLine($"Date2 Value: {date2.Value}");

            // Null coalescing
            DateTime? date3 = null;
            DateTime date4 = date3 ?? DateTime.Now;

            Console.WriteLine($"Date4 Value: {date4.ToUniversalTime()}");

            Console.Read();
        }
    }
}
