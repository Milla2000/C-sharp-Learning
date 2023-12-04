using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingExamples;

namespace TestingExamplesTests
{
    [TestFixture]
    public  class HelloWorldTest
    {


        [Test]
        public void greet_WhenCalled_ShouldReturnHelloworld()
        {
            // TRIPLE A => AAA- Arrange , Act and Assert
            //Arrange - create instance 
            var hw = new HelloWorld();
            //Act =Call the method
            var result = hw.greet();
            //Assert - Confirm if you are getting what you wanted
            //Assert.That(result, Is.EqualTo("Hello World"));
            Assert.That(result, Does.Contain("World"));

        }


    }
}
