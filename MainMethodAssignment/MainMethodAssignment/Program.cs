//ask the user to input the number 
using MainMethodAssignment;

Console.WriteLine("Please enter a number:");
//grab the user input and convert it to an integer
int userInput = Convert.ToInt32(Console.ReadLine());

//instantiate the CustomMath class
CustomMath math = new CustomMath();
//call the performMath method and pass in the user input
int additionResult = math.performMath(userInput);
//display the result of the addition
Console.WriteLine("The result of adding 10 to your number is: " + additionResult);

//ask the user to input a decimal number
Console.WriteLine("Please enter a decimal number:");
//read the user input and convert it to a decimal
decimal userDecimalInput = Convert.ToDecimal(Console.ReadLine());
//call the performMath method and pass in the user input
decimal decOutput = math.performMath(userDecimalInput);
Console.WriteLine("The result of multiplying your decimal number by 10 is: " + decOutput);

//ask the user to input a string number
Console.WriteLine("Please enter a number:");
//read the user input as a string
string userStringInput = Console.ReadLine();
//call the performMath method that takes a string parameter
int stringOutput = math.performMath(userStringInput);
Console.WriteLine("The result of dividing your string number by 2 is: " + stringOutput);