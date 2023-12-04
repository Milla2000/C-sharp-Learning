using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingExamples;

namespace TestingExamplesTests
{
    [TestFixture]
    public  class MyMathTests
    {
        private MyMath mc;
        [SetUp]
        public void Setup()
        {
            mc = new MyMath();
        }

        //Add
        [Test]
        public void AddNumbers_WhenCalled_ShouldReturntheSumofArguments()
        {
            //var mc = new MyMath();
            var result = mc.AddNumbers(12, 5);
            Assert.That(result, Is.EqualTo(17));
        }

        //parametrized Tests
        [Test]
        [TestCase(1,2,2)]
        [TestCase(2, 2, 2)]
        [TestCase(3, 2, 3)]
        public void Max_GetsTwoArguments_ShouldReturnThegreaterOne(int a , int b , int output)
        {
            //var mc = new MyMath();
            var result = mc.Max(a ,b);
            Assert.That(result, Is.EqualTo(output));
        }



        [Test]
        [Ignore("Repetion")]
        public void Max_FirstArgumentisGreater_ShouldReturnFirstArgument()
        {
            //var mc = new MyMath();
            var result = mc.Max(12, 5);
            Assert.That(result , Is.EqualTo(12));
        }

        [Test]
        [Ignore("Repetion")]
        public void Max_BothArgumentAreEqual_returnoneoftheTwoArgument()
        {
            //var mc = new MyMath();
            var result = mc.Max(5, 5);
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        [Ignore("Repetion")]
        public void Max_SecondArgumentisGreater_ShouldReturnSecondArgument()
        {
            //var mc = new MyMath();
            var result = mc.Max(12, 15);
            Assert.That(result, Is.EqualTo(15));
        }




    }
}
