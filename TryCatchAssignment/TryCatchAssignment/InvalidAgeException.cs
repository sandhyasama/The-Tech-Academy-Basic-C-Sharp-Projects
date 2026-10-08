using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatchAssignment
{
    public class InvalidAgeException : Exception
    {

        //custom exception for age
        public InvalidAgeException() : base() { }
        public InvalidAgeException(string message) : base(message) { }

    }
}
