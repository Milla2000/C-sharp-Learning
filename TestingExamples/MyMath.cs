using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExamples
{
    public  class MyMath
    {

        public int AddNumbers(int a, int b) { return a + b; }

        public int Max(int a, int b) { return (a>b) ? a :(a==b)? a : b; }
    }
}
