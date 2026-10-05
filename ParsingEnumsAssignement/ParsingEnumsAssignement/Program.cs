//ask the user to enter current day of the week
using ParsingEnumsAssignement;
using static ParsingEnumsAssignement.DaysOfTheWeek;

//enclose the error prone code parser in a try catch block to handle any exceptions that may occur
bool isEnteredDayOfTheWeekValid = false;

while (!isEnteredDayOfTheWeekValid)
{
    try
    {
        //ask the user to enter current day of the week
        Console.WriteLine("Please enter the current day of the week:");
        //read the user input to a string variable
        String userInputDayOfTheWeek = Console.ReadLine();
        //parse the user input to the enum type DayOfTheWeek
        DayOfTheWeek dayOfTheWeek = (DayOfTheWeek)DayOfTheWeek.Parse(typeof(DayOfTheWeek), userInputDayOfTheWeek);
        //print the parsed enum value to the console
        Console.WriteLine($"You entered: {dayOfTheWeek}");
        //greet the user 
        Console.WriteLine("Have a great day!");
        //flip the boolean to true to exit the loop if the user entered a valid day of the week
        isEnteredDayOfTheWeekValid = true;

        //handle the exception and display a message to the user
    }
    catch (Exception ex)
    {
        //display a message to the user to enter a valid day of the week
        Console.WriteLine("Please enter an actual day of the week");
    }
}