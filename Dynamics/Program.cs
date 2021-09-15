using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strongly types, knows what methods/props are on x. Resolved compile time: CLR
            object x = "string";
            x.GetHashCode();

            // Mot stronghly type, resolved at runtime: DLR
            dynamic y = "string";
            //y.MyDynamicallyKnownMethod();

            dynamic z = "string";
            z = 10;

            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
