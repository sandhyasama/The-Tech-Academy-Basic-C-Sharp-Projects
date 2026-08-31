//display starting greeting message
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

//display text for asking user to enter package weight
Console.WriteLine("Please enter the package weight: ");

//read the package weight from user input and convert it to an integer
int packageWeight = Convert.ToInt32(Console.ReadLine());
if (packageWeight > 50)
{
    //display error message for package weight exceeds limit of 50
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
}
else
{
    //display text for asking user to enter package width
    Console.WriteLine("Please enter the package width: ");

    //convert user input to integer for package width
    int packageWidth = Convert.ToInt32(Console.ReadLine());

    //display text for asking user to enter package height
    Console.WriteLine("Please enter the package height: ");

    //convert user input to integer for package height
    int packageHeight = Convert.ToInt32(Console.ReadLine());

    //display text for asking user to enter package length
    Console.WriteLine("Please enter the package length: ");

    //convert user input to integer for package length
    int packageLength = Convert.ToInt32(Console.ReadLine());

    //check if the sum of package dimensions exceeds 50
    int packageDimensions = packageWidth + packageHeight + packageLength;
    if(packageDimensions > 50)
    {
        //display error message for package dimensions exceeding limit of 50
        Console.WriteLine("Package too big to be shipped via Package Express.");
    }
    else {
        //calculate quote for shipping based on package dimensions and weight
        Double quote = ((packageDimensions * packageWeight) / 100.00);

        //display the estimated total for shipping the package including quote
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
    }

}