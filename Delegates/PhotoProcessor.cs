using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void ProcessWithoutDelegate(string path)
        {
            var photo = Photo.Load(path);

            // Without delegate
            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }

        public void ProcessWithDelegate(string path, PhotoFilterHandler photoFilterHandler)
        {
            var photo = Photo.Load(path);

            // Without delegate
            photoFilterHandler(photo);

            // With Delegate
            photo.Save();
        }

        public void ProcessWithActionDelegate(string path, Action<Photo> photoFilterHandler)
        {
            var photo = Photo.Load(path);

            // Without delegate
            photoFilterHandler(photo);

            // With Delegate
            photo.Save();
        }

        public void ProcessWithFuncDelegate(string path, Func<Photo, int> photoFilterHandler)
        {
            var photo = Photo.Load(path);
            photo.Size = 10;

            // Without delegate
            photoFilterHandler(photo);

            // With Delegate
            photo.Save();
        }
    }
}
