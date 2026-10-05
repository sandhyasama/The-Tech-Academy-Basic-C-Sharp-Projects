//instantiate 10 employees
using LambdaExpressionAssignment;

Console.WriteLine("Instantiating 10 employees...");
//create a list of employees
List<Employee> employees = new List<Employee>();
//for simplicity, we will create 10 employees with Id from 0 to 9 and Name as Employee0, Employee1, ..., Employee9
for (int i = 0; i < 10; i++)
{
    //using modulus so that we can get 3 (0,4,8) objects with Joe as first name
    employees.Add(new Employee { Id = i, FirstName =  i%4 == 0 ?  "Joe" :"First Name" + i, LastName="Last Name"+i});
}
Console.WriteLine("Instantiated 10 employees.");

//using for each loop to make a new list of employees with first name Joe
List<Employee> employeesWithFirstNameJoe = new List<Employee>();
foreach(Employee employee in employees)
{
    //check if the first name is Joe
    if (employee.FirstName == "Joe")
    {
        //if yes, add it to the list
        employeesWithFirstNameJoe.Add(employee);
    }
}
Console.WriteLine("Employees with first name Joe using for each loop:"+employeesWithFirstNameJoe.Count());

//using lambda expression to make a new list of employees with first name Joe
List<Employee> employeesWithFirstNameJoeUsingLambda = employees.Where(e => e.FirstName == "Joe").ToList();

//print the count of employees with first name Joe using lambda expression
Console.WriteLine("Employees with first name Joe using lambda expression:" + employeesWithFirstNameJoeUsingLambda.Count());

//using Lambda expression make list of employees here Id is greater than 5
List<Employee> employeesWithIdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();
Console.WriteLine("Employees with Id greater than 5 using lambda expression:" + employeesWithIdGreaterThan5.Count());
