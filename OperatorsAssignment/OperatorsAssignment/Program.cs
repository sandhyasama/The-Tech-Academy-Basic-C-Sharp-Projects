//instanitate two objects of the class Employee and assign values to their properties
using OperatorsAssignment;

//instantiate two objects of the class Employee and assign values to their properties
Employee employee1 = new Employee { Id = 1, firstName = "John", lastName = "Doe" };
Employee employee2 = new Employee { Id = 2, firstName = "Jane", lastName = "Smith" };
//print them to console for better readability
Console.WriteLine($"Employee 1: {employee1.firstName} {employee1.lastName}, Id: {employee1.Id}");
Console.WriteLine($"Employee 2: {employee2.firstName} {employee2.lastName}, Id: {employee2.Id}");

//let's compare the two Employee objects using the overloaded == operator
Console.WriteLine($"Are employee1 and employee2 equal? {employee1 == employee2}");
//let's compare the two Employee objects using the overloaded != operator
Console.WriteLine($"Are employee1 and employee2 not equal? {employee1 != employee2}");