using System.Text;

Console.WriteLine("Hello, Welcome to String Assignment!");

//prompt user to enter their first name
Console.WriteLine("Please enter your first name: ");
string firstName = Console.ReadLine();

//prompt user to enter their last name
Console.WriteLine("Please enter your last name: ");
string lastName = Console.ReadLine();

//prompt user to enter their city they live in
Console.WriteLine("Please enter the city you live in: ");
string city = Console.ReadLine();

//conatinate the first name, last name, and city into a single string
string meaningFulMessage = "Hello, "+ firstName + " " + lastName + " you live in " + city ;
Console.WriteLine(meaningFulMessage);

//convert the message to uppercase
Console.WriteLine("Your message in uppercase is: " + meaningFulMessage.ToUpper());

//simulate pargraph build message
Console.WriteLine("Now lets build an auto paragraph using string builder");
Console.WriteLine("Builing......., here is it is");

//string builder to build the paragraph
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.AppendLine("This is a paragraph built using StringBuilder.");
stringBuilder.AppendLine("It allows for efficient string manipulation.");
stringBuilder.AppendLine("You can append multiple lines of text.");
stringBuilder.AppendLine("StringBuilder is useful when you need to modify strings frequently.");

Console.WriteLine(stringBuilder);

//wait for the message to be read
Console.ReadLine();
