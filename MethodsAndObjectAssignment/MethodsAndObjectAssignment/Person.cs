using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjectAssignment
{
    internal class Person
    {
        // create properties for first and last name of data type string
        public string firstName { get; set; }
        public string lastName { get; set; }
        //create method sayName that prints first and last name to console
        public void sayName() { 
        Console.WriteLine("Name: " + firstName + " " + lastName);
        }

    }
}
