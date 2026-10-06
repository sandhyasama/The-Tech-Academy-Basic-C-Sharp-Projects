//ask the user to enter a number
Console.WriteLine("Please enter a number:");

//read the user input 
string userInput = Console.ReadLine();

//convert the user input to an integer
int userEnteredNumber = Convert.ToInt32(userInput);

//display the user entered number to console for tracking
Console.WriteLine("You entered: " + userEnteredNumber);

//write the user entered number to a file 
File.WriteAllText(@"C:\Users\sandy\logs\log.txt", Convert.ToString(userEnteredNumber));

//read from a file
string fileContent = File.ReadAllText(@"C:\Users\sandy\logs\log.txt");
Console.WriteLine("The number read from the file is: " + fileContent);

