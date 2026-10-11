using System;
using System.Collections.Generic;
using System.Text;

namespace StudentEFConsoleApp
{
    public class Student
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string Email { get; set; }
        public required int Age { get; set; }
    }
}
