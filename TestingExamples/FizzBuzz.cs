﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExamples
{
    public class FizzBuzz
    {
        public string printNumber(int number)
        {
                //logic fizzbuzz
                if((number%5==0) && (number % 3 == 0))
                {
                    return "FizzBuzz";

                }
                else if ((number % 5 == 0))
                {
                    return "Fizz";
                }
                else if ((number % 3 == 0))
                {
                    return "Buzz";
                }
                else
                {
                    return number.ToString();
                } 
        }
    }
}
