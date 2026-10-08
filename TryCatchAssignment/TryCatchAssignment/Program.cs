//ask user for their age
using TryCatchAssignment;

Console.WriteLine("Please enter your age:");
int age = 0;
try
{
    //try to parse the input as an integer
    age = Convert.ToInt32(Console.ReadLine());
    //if it is negative, throw an InvalidAgeException
    if (age < 0)
    {
        throw new InvalidAgeException("Age cannot be negative.");
    }
    //if positive, leverage dateime now year to get current year and subtract age to get birth year
    else
    { 
      int birthYear = DateTime.Now.Year - age;
      Console.WriteLine($"You were born in the year: {birthYear}");
    }
}
//catch InvalidAgeException and display message
catch (InvalidAgeException) { 
    Console.WriteLine("Invalid age entered. Age cannot be negative.");
}
//catch any other exception and display the message
 catch (Exception ex)
{
    Console.WriteLine("You must enter a valid number for your age.");
    return;
}