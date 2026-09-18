//create a list of integers
List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);
numbers.Add(50);

//ask the user to enter an integer to divide each number in the list by
Console.WriteLine("Enter an integer to divide each number in the list by: ");
bool hitErrorBlock = false;

try
{
    int divisor = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < numbers.Count; i++)
    {
        //divide each number in the list by the user input and print the result
        int result = numbers[i] / divisor;
        Console.WriteLine($"{numbers[i]} divided by {divisor} is {result}");
    }
}

//format exception hadling when non integer is entered
catch (FormatException)
{
    Console.WriteLine("You did not enter a valid integer. Please try again.");
    hitErrorBlock = true;
}

//exception handling for divide by zero
 
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. Please enter a non-zero integer.");
    hitErrorBlock = true;
}

//catch all other exceptions
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    hitErrorBlock = true;
}
//let user know that the program has resumed after the exception handling 
finally
{
    if (hitErrorBlock)
    {
        Console.WriteLine("The program has resumed the operation after it hit try catch block:");
    }

}
//give opportunity to see th error message before the program ends
Console.ReadLine();