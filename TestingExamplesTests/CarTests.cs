using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingExamples;

namespace TestingExamplesTests
{
    [TestFixture]
    public  class CarTests
    {
        [Test]
        public void AddCars_AddCartoList_ShouldAddCarsToList()
        {
            var car= new Cars();

            car.AddCar("Mercedes Benz");

            //Assert.That(car.carNames.Count, Is.EqualTo(1));
            Assert.That(car.carNames.Contains("Mercedes Benz"), Is.EqualTo(true));

            //Assert.That(car.carNames, Is.EquivalentTo(new List<string>() {"Mercedes Benz"}));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void AddCars_AddCartoList_ShouldThrowAnError(string carName)
        {
            var car = new Cars();

            //Assert.That(()=> car.AddCar(carName), Throws.TypeOf<ArgumentNullException>());
            //Checks exactType returns 


            //Checks the Class and all the Children of the class

         Assert.That(()=> car.AddCar(carName), Throws.InstanceOf<Exception>());
        }
    }
}
