using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delagates
{
    internal class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler (Photo photo);
        public void Process(Action<Photo> handler)
        {
            var photo = new Photo();
            Console.WriteLine("Editing the Photo");
            handler(photo);//executing
            //filters.AddBrightness(photo);
            //filters.changeBackground(photo);
        }
    }
}
