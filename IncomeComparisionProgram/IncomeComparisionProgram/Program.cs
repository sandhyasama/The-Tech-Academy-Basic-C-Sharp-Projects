//print program name
Console.WriteLine("Anonymous Income Comparison Program");
//first person name
Console.WriteLine("Person 1");
//get hourly rate for person 1
Console.WriteLine("Hourly Rate?");
double person1HourlyRate = Convert.ToDouble(Console.ReadLine());

//get hours worked per week for person 1
Console.WriteLine("Hours worked per week?");
byte person1HoursWorked = Convert.ToByte(Console.ReadLine());

//start second person name with hourly rate capture
Console.WriteLine("Person 2");
Console.WriteLine("Hourly Rate?");
double person2HourlyRate = Convert.ToDouble(Console.ReadLine());

//get hours worked per week for person 2
Console.WriteLine("Hours worked per week");
byte person2HoursWorked = Convert.ToByte(Console.ReadLine());

//calculate annual salary for person 1
double annualSalaryPerson1 = person1HourlyRate * (double) person1HoursWorked * 52.0;
//print annual salary for person 1
Console.WriteLine("Annual salary of Person 1:");
Console.WriteLine(annualSalaryPerson1);

//calculate annual salary for person 2
double annualSalaryPerson2 = person2HourlyRate * (double)person2HoursWorked * 52.0;
//print annual salary for person 2
Console.WriteLine("Annual salary of Person 2:");
Console.WriteLine(annualSalaryPerson2);

//now check if person 1 makes more than person 2
bool isPerson1MakesMoreThanPerson2 = annualSalaryPerson1 > annualSalaryPerson2;

//print the result of the comparison to console
Console.WriteLine("Person 1 makes more money than Person 2:");
Console.WriteLine(isPerson1MakesMoreThanPerson2);
Console.ReadLine();


