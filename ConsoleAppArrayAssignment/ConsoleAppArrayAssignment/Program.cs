//create one dimentional array of string
string[] names = {"Bob", "Sam", "Rob", "Mary", "Alpha"};

//create one dimentional array of int
int[] numbers = { 1, 2, 3, 4, 5 };

//ask the user to select the index of the name they want to see
Console.WriteLine("Select the index of the name you want to see (0-4):");
//read the user input for the name index
string nameIndex = Console.ReadLine();
int nameIndexInput = Convert.ToInt32(nameIndex);
if (nameIndexInput < 0 || nameIndexInput > 4)
{
    Console.WriteLine("Invalid index. Please enter a number between 0 and 4.");
}
else
//user input is valid, so display the name at the selected index
{
Console.WriteLine($"The name at index {nameIndexInput} is: {names[nameIndexInput]}");
}
 
//ask the user to select the index of the number they want to see
Console.WriteLine("Select the index of the number you want to see (0-4):");
//read the user input for the number index
string numberIndex = Console.ReadLine();
//convert the user input to an integer
int numberIndexInput = Convert.ToInt32(numberIndex);
//check if the user input is valid
if (numberIndexInput < 0 || numberIndexInput > 4)
{
    Console.WriteLine("Invalid index. Please enter a number between 0 and 4.");
}
else
//user input is valid, display the number at the selected index
{
Console.WriteLine($"The number at index {numberIndexInput} is: {numbers[numberIndexInput]}");
}

//create a list of string
List<string> namesList = new List<string>();
namesList.Add("Bob");
namesList.Add("Sam");
namesList.Add("Rob");
namesList.Add("Mary");
namesList.Add("Alpha");

//prompt the user to select the index of the name they want to see from the list
Console.WriteLine("Select the index of the name you want to see from the list (0-4):");
//read the user input for the name index from the list
string nameListIndex = Console.ReadLine();
int nameListIndexInput = Convert.ToInt32(nameListIndex);

//check if the user input is valid
if(nameListIndexInput < 0 || nameListIndexInput > 4)
{
    Console.WriteLine("Invalid index. Please enter a number between 0 and 4.");
}
else
{
    Console.WriteLine($"The name at index {nameListIndexInput} is: {namesList[nameListIndexInput]}");

}
Console.ReadLine();