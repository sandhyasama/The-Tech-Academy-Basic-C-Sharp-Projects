//assignment part1
string[] names = {"Sam", "Bob", "Tom", "Adam"};
Console.WriteLine("Please enter a text to append to each name:");
string userInput = Console.ReadLine();
//add the user inputted text to each name in the array
for (int i = 0; i < names.Length; i++)
{
    names[i] += userInput;
}
//print the updated names to the console
for(int j = 0; j < names.Length; j++)
{
    Console.WriteLine(names[j]);
}
 

//assignment part2
//add infinite loop to the program
//missing initialization of the loop variable
//missing condition and increment/decrement creates infinite loop
for (int k=0; k<2 ; k++ )
{
    Console.WriteLine("This is an fixed code from infinite to finite loop.");
};

//assignment part3
int[] numbers = { 1, 2, 3, 4, 5,6,7,8,9,10 };
//print the numbers which are less than 5
Console.WriteLine("Numbers less than 5:");
for (int l = 0; l < numbers.Length; l++)
{
    if (numbers[l] < 5)
    {
        Console.WriteLine(numbers[l]);
    }
}

//use less than or equal to operator to print the numbers which are less than or equal to 5
Console.WriteLine("Numbers less than or equal to 5:");
for(int m = 0; m < numbers.Length; m++)
{
    if (numbers[m] <= 5)
    {
        Console.WriteLine(numbers[m]);
    }
}

//assignment part4
//initialize fruits array with 5 elements
string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
//ask the user to enter fruit name to search
Console.WriteLine("Please enter a fruit name to search for:");
//read the user input
string userInputedFruit = Console.ReadLine();
//check if the fruit is in the list
if (!fruits.Contains(userInputedFruit))
{
    //if the fruit is not in the list, print a message
    Console.WriteLine("The fruit is not in the list.");
}
else {
    //if the fruit is in the list, print a message with index of matching fruit
    for (int n = 0; n < fruits.Length; n++)
    {
        if (fruits[n] == userInputedFruit)
        {
            Console.WriteLine("Fruit found at index: " + n);
            break;
        }
    }
}


//assignment part5
//initialize a array of another fruits with duplicate entries
string[] fruitsList = { "Apple", "Banana", "Cherry", "Date", "Elderberry", "Apple","Banana" };
//ask the user to enter fruit name to search
Console.WriteLine("Please enter a fruit name to search for:");
//grab the user input
string fruitInput = Console.ReadLine();
//initialize matchedIndexes list to store the indexes of matching fruits
List<int> matchedIndexes = new List<int>();
//check if the fruit is in the list
if (fruitsList.Contains(fruitInput))
{
    for (int p = 0; p < fruitsList.Length; p++)
    {
        //fruit name matches the user input, add the index to the matchedIndexes list
        if (fruitsList[p] == fruitInput)
        {
            matchedIndexes.Add(p);
            //DO NOT BREAK THE LOOP, CONTINUE TO SEARCH FOR OTHER MATCHES
        }
    }
    Console.WriteLine("Fruit found at indexes: " + string.Join(", ", matchedIndexes));
}
//not in the list, print a message
else
{
    Console.WriteLine("The fruit is not in the list.");
}

//assignment part6
//initialize a list of names with duplicate entries one at least
List<string> namesList = new List<string> { "Sam", "Bob", "Tom", "Adam", "Sam" ,"Tom"};
//initiaize a parsed list to store the names that have already been printed to the console
List<string> printedList = new List<string>();
foreach (var item in namesList)
{
    //flag to store is the name is a duplicate or not
    bool isDuplicate = false;
    //check if the name has already been printed to the console
    foreach (var printedItem in printedList)
    {
        //matches with already printed name, set the flag to true and break the loop
        if (item == printedItem)
        {
            isDuplicate = true;
            break;
        }
    }
    //if the name is a duplicate, print a message to the console with the name and that it is a duplicate
    if (isDuplicate)
    {
        Console.WriteLine(item + " is a duplicate name.");
    }
    //not a duplicate , print a message to the console and that is unique 
    //more importantly add the name to printed list
    else
    {
        Console.WriteLine(item + " is a unique name.");
        printedList.Add(item);
    }
}