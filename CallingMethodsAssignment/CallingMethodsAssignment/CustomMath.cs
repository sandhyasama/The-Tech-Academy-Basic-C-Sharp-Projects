using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethodsAssignment
{
    //class containing methods to add, multiply, and subtract a number by 10
    internal class CustomMath
    {

        //add number by 10
        public int AddNumberByTen(int number)
        {
            return number + 10;
        }

        //multiply number by 10
        public int MultiplyNumberByTen(int number)
        {
            return number * 10;
        }

        //subtract number by 10
        public int SubtractNumberByTen(int number)
        {
            return number - 10;
        }
    }
}
