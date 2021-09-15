using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExecuteSynchronousMethod();
            //ExecuteAsynchronousMethod();
            ExecuteAsynchronousMethodWithReturn();

            Console.ReadLine();
        }

        private static void ExecuteSynchronousMethod()
        {
            var syncMethod = new SynchronousMethod();

            Console.WriteLine("Start Synchronous operation...");
            syncMethod.Run();
            Console.WriteLine("End Synchronous operation...");
        }

        private static async void ExecuteAsynchronousMethod()
        {
            var asyncMethod = new AsynchronousMethod();

            Console.WriteLine("Start Asynchronous operation...");
            asyncMethod.RunAsync().ConfigureAwait(false);
            Console.WriteLine("End Asynchronous operation...");
        }

        private static async void ExecuteAsynchronousMethodWithReturn()
        {
            var asyncMethod = new AsynchronousMethod();

            Console.WriteLine("Start Asynchronous operation...");
            asyncMethod.RunWithReturnAsync();
            Console.WriteLine("End Asynchronous operation...");
        }
    }
}
