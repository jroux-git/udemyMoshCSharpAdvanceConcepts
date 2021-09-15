using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "this is a very long string that we want to shorten with an extension methods.";
            Console.WriteLine($"Original post: {post}");
            Console.WriteLine($"Shortened post: {post.Shorten(20)}");

            Console.Read();
        }
    }
}
