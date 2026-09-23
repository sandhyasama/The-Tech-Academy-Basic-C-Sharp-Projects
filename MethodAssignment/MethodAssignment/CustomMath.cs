using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssignment
{
    internal class CustomMath
    {
        //method with second parameter with default value i.e optional parameter
        public int addTwoNumbers(int num1, int num2 = 5)
        {
            return num1 + num2;
        }
    }
}
