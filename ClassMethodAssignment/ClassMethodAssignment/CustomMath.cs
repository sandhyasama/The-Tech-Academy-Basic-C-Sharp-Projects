using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodAssignment
{
    internal class CustomMath
    {


        //divide the number by 2
        public void divideNumberBy2(int number)
        {
            number = number / 2;
            Console.WriteLine("The number divided by 2 is: " + number);
        }

        // method with outout parameters
        public void changeParameterValuesToTen(out int num1, out int num2) {
            num1 = 10;
            num2 = 10;

        }

        // overload method with outout parameter
        public void changeParameterValuesToTen(out int num1)
        {
            num1 = 10;

        }

    }
}
