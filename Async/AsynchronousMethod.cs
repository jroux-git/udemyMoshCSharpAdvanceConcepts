using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    public class AsynchronousMethod
    {
        public async Task RunAsync()
        {
            Console.WriteLine("Starting Async call...");
            await RunTaskAsync();
        }

        private async Task RunTaskAsync()
        {
            Console.WriteLine("RunTask starting...");

            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("RunTask done!");
            });
        }

        public async Task RunWithReturnAsync()
        {
            Console.WriteLine("Starting Async call...");
            await RunTaskWithReturnAsync();
        }

        private async Task RunTaskWithReturnAsync()
        {
            Console.WriteLine("RunTask starting...");

            string result = await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("RunTask done!");

                return "string result returned. Ready for manipulation";
            });

            Console.WriteLine(result);
        }
    }
}
