using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Photo
    {
        public int Size { get; set; }
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {

        }
    }
}
