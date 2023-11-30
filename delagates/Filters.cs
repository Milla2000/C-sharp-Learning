
using System.ComponentModel;

namespace delagates
{
    public class Filters
    {
        //""framework""
        public void AddBrightness(Photo photo)
        {
            Console.WriteLine("Adding Brightness" );
        }

        public void changeBackground(Photo photo)
        {
            Console.WriteLine("Changing Background");
        }
    }
}
