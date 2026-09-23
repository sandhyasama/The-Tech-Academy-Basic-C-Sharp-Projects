//ask the user to enter first number
using MethodAssignment;

Console.WriteLine("please input first number");
//grab and convert the input to an integer
int firstNumber = Convert.ToInt32(Console.ReadLine());

//ask the user to enter second number
Console.WriteLine("please input second number, please note that this is optional, you do not need to enter");
string secondNumberInput = Console.ReadLine();

//instantiate the CustomMath class
CustomMath customMath = new CustomMath();

//use try block to parse the second number input and check if it is valid
//if the second number input is not empty, parse it and call the addTwoNumbers method with both parameters
//if second number input is empty, catch block will be hit
try
{
    //convert the second number input to an integer
    int secondNumber = Convert.ToInt32(secondNumberInput);
    //call the addTwoNumbers method with both parameters
    int result = customMath.addTwoNumbers(firstNumber, secondNumber);
    //display the result
    Console.WriteLine($"The result of adding {firstNumber} and {secondNumber} is: {result}");

}
//handle exception if the second number input is not a valid integer or empty to call the method with just one parameter
catch (Exception ex) {
    //proceed with only the first number and use the default value for the second number
    int result = customMath.addTwoNumbers(firstNumber);
    //display the result
    Console.WriteLine($"The result of adding {firstNumber} with default second parameter {result-firstNumber} is: {result}");

}









