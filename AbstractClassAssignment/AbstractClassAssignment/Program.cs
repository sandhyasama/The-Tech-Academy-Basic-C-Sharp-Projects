//
using AbstractClassAssignment;

//instantiate employee class with firstName as Sample and lastName as Student
Employee employee = new Employee() { firstName = "Sample", lastName = "Student"};
//call the SayName method on the employee object
employee.SayName();
Console.ReadLine();