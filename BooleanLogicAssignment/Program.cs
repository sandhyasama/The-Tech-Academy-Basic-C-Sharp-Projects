//display age question
Console.WriteLine("What is your age?");
//capture user input and convert to byte
byte ageInput = Convert.ToByte(Console.ReadLine());

//display DUI question
Console.WriteLine("Have you ever had a DUI? (true/false)");
//get the user input and convert to boolean
bool duiInput = Convert.ToBoolean(Console.ReadLine());

//display speeding tickets
Console.WriteLine("How many speeding tickets do you have?");
//get the user input and convert to byte
byte ticketsInput = Convert.ToByte(Console.ReadLine());

Boolean isQualified = (ageInput > 15) && (duiInput == false) && (ticketsInput <= 3);

//write result message line
Console.WriteLine("Qualified? \n" + isQualified);


