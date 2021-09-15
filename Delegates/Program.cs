using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Without delegate
            var photoProcessor = new PhotoProcessor();
            //photoProcessor.ProcessWithoutDelegate("path");

            var photoFilters = new PhotoFilters();

            // With delegate
            //PhotoProcessor.PhotoFilterHandler filterHandler = photoFilters.ApplyBrightness;
            //filterHandler += photoFilters.ApplyContrast;
            //filterHandler += RemoveRedEyeFilter;

            //photoProcessor.ProcessWithDelegate("path", filterHandler);

            // With Action Delegate
            //Action<Photo> actionFilterHandler = photoFilters.ApplyBrightness;
            //actionFilterHandler += photoFilters.ApplyContrast;
            //actionFilterHandler += RemoveRedEyeFilter;
            //photoProcessor.ProcessWithActionDelegate("path", actionFilterHandler);

            // With Func Delegate
            Func<Photo, int> funcFilterHandler = GetPictureSize;
            //funcFilterHandler += photoFilters.ApplyContrast;
            photoProcessor.ProcessWithFuncDelegate("path", funcFilterHandler);

            Console.Read();
        }

        // Now create a custom filter
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("RemoveRedEyeFilter");
        }

        static int GetPictureSize(Photo photo)
        {
            Console.WriteLine("Photo Size = " + photo.Size);

            return photo.Size;
        }
    }
}
