using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingExamples;

namespace TestingExamplesTests
{
    [TestFixture]
    public  class FizzBuzzTest
    {
        [Test]
        [TestCase(15,"FizzBuzz")]
        [TestCase(18, "Buzz")]
        [TestCase(10, "Fizz")]
        [TestCase(1, "1")]

        public void PrintNumbers_GiveANumber_PrintTherightString(int number, string output)
        {
            var fb= new FizzBuzz();
            var result = fb.printNumber(number);
            Assert.That(result, Is.EqualTo(output));

        }
    }
}
