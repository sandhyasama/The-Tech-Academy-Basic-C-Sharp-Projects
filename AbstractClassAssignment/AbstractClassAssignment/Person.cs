using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    // Abstract class Person
    public abstract class  Person
    {
        // FirstName
        public string firstName { get; set; }

        //last name
        public string lastName { get; set; }

        //give it SayName method
        public abstract void SayName();
         
    }
}
