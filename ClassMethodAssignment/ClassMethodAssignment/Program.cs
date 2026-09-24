using ClassMethodAssignment;

//instantiate a class object
CustomMath customMath = new CustomMath();

//ask the user to enter the number to be divided by 2
Console.WriteLine("Enter a number to divide by 2: ");
int userInput = Convert.ToInt32(Console.ReadLine());
customMath.divideNumberBy2(userInput);

//call the method with output parameters
int number1, number2;
customMath.changeParameterValuesToTen(out number1, out number2);
Console.WriteLine("After calling changeParameterValuesToTen are number1 {0}; number2: {1}", number1, number2);

//call overloaded method with single output parameter
int number3;
customMath.changeParameterValuesToTen(out number3);
Console.WriteLine("After calling changeParameterValuesToTen are number3: {0}", number3);

//call the static method from CustomStatic class
//static class means no need to create or instantiate an object of the class to call the method
CustomStatic.sayHello();