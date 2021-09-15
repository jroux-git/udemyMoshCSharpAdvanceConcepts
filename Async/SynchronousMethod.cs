using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    public class SynchronousMethod
    {
        public void Run()
        {
            Thread.Sleep(3000);
        }
    }
}
