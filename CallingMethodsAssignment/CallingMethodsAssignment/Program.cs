using CallingMethodsAssignment;

//ask the user for a number to perform math operations on
Console.WriteLine("Hello, enter the number you want to perform math operations on:");
//get the user input and convert it to an integer
int userInput = Convert.ToInt32(Console.ReadLine());

//instantiate the CustomMath class
CustomMath customMath = new CustomMath();
//perform addition
int addedResult = customMath.AddNumberByTen(userInput);
//display the result of addition
Console.WriteLine($"Adding 10 to {userInput} gives: {addedResult}");

//perform multiplication
int multipliedResult = customMath.MultiplyNumberByTen(userInput);
//display the result of multiplication
Console.WriteLine($"Multiplying {userInput} by 10 gives: {multipliedResult}");

//perform subtraction
int subtractedResult = customMath.SubtractNumberByTen(userInput);
//display the result of subtraction
Console.WriteLine($"Subtracting 10 from {userInput} gives: {subtractedResult}");
