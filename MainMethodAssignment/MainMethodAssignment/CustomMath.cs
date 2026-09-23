using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    internal class CustomMath
    {
        //add 10 to the number that is passed in
        public int performMath(int num) {
            return num + 10;
        }

        //multiply the number that is passed in by 10
        public decimal performMath(decimal num)
        {
            return num * 10;
        }

        public int performMath(string num)
        {
            //convert the string to an integer and divide it by 2
            int convertedNum = Convert.ToInt32(num);
            return convertedNum / 2;
        }
    }
}
