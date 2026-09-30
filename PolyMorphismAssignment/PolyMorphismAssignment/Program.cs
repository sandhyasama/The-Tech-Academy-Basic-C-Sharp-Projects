//using polymorphism to create object for IQuittable interface
using PolyMorphismAssignment;


//IQuittable interface reference variable assigned to Employee class object
//polymorphic object creation for IQuittable interface
IQuittable employeeQuit = new Employee();

//call quit method
employeeQuit.Quit();
Console.ReadLine();
