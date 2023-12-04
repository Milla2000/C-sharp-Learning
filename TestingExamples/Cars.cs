using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExamples
{
    public  class Cars
    {

        public  List<string> carNames = new List<string>();

        public void AddCar(string CarName)
        {

            if (string.IsNullOrWhiteSpace(CarName))
            {
                throw new ArgumentNullException("Name is Required");
            }

            carNames.Add(CarName);
        }
    }
}
