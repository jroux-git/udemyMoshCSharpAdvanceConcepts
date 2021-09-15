using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Normal method
            Console.WriteLine($"Non-Lambda: {Square(5)}");

            // Lambda with 1 argument
            Action noParamsLambda = () => Console.WriteLine("no params");

            noParamsLambda();

            // Lambda with 1 argument
            Func<int, int> squareLambda = number => number * number;
            Console.WriteLine($"1 Param Lambda: {squareLambda(5)}");

            // Lambda with multiple argument
            Func<int, int, int> twoParamLambda = (number1, number2) => number1 * number2;
            Console.WriteLine($"Multi param Lambda: {twoParamLambda(5,4 )}");
            
            Console.ReadKey();
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}
