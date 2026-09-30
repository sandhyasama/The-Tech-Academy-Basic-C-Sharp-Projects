using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    //Employee class inherits from Person class 
    internal class Employee : Person
    {

        //override the SayName method 
        //print name to the console in the format of "Name: [full name]"
        public override void SayName()
        {
            Console.WriteLine("Name: "+firstName+" "+lastName);
        }

    }
}
