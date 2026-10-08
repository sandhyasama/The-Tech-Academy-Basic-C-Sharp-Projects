using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorChainAssignment
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //default constructor with all fields
        public Person(string firstName, String lastName, int age) {
            Console.WriteLine("Constructor with firstName, lastName and age called");
            firstName = FirstName;
            LastName = lastName;
            Age = age;
        }

        //constructor with firstName and lastName provided,chaining it with default age of 42
        public Person(string firstName, String lastName) : this(firstName, lastName, 42)
        {
            Console.WriteLine("Constructor with firstName and lastName called, chained it with default age of 42");
        }
        //constructor with firstName provided, chaining it with default lastName of Doe and default age of 42
        public Person(string firstName) : this(firstName, "Doe", 42)
        {
            Console.WriteLine("Constructor with firstName called, chained it with default lastName of Doe and default age of 42");
        }
        

    }
}
