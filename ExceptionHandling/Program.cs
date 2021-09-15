using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //NotUsingSample();
            //UsingSample();

            try
            {
                CustomExceptionSample();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }

        private static void NotUsingSample()
        {
            StreamReader streamReader = null;

            try
            {
                string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                streamReader = new StreamReader(dir + "\\..\\..\\file.txt");
                var content = streamReader.ReadToEnd();

                int i = 5;
                dynamic x = i / 0;
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine("Oops! A DivideByZero error occured!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops! Nn error occured!");
            }
            finally
            {
                Console.WriteLine("Finally! Do some cleanup.");

                streamReader?.Dispose();
            }
        }

        private static void UsingSample()
        {
            try
            {
                string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                using (var streamReader = new StreamReader(dir + "\\..\\..\\file.txt"))
                {
                    var content = streamReader.ReadToEnd();
                }

                int i = 5;
                dynamic x = i / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops! Nn error occured!");
            }
        }

        private static void CustomExceptionSample()
        {
            try
            {
                throw new Exception("Throw my custom exception");
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message, ex);
            }
        }
    }
}
