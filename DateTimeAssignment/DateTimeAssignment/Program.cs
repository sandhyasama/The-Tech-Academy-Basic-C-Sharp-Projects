//Print the current date and time to the console
Console.WriteLine("Current date and time is : " + DateTime.Now);

//ask the user for a number
Console.WriteLine("Please enter a number to see what the time will be after that many hours: ");
float  hours = float.Parse(Console.ReadLine());
//print the hours added to the current time
Console.WriteLine("The time after " + hours + " hours will be: " + DateTime.Now.AddHours(hours));
