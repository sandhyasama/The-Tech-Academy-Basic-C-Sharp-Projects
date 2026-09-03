Console.WriteLine("Welcome to While and do-while loop demonstration");
//print 1 to 10 using do while loop

//initialize the counter variable
int i = 0;
do
{
    Console.WriteLine(i); //print the value of counter variable
    i++; //increment the counter variable
}
while (i < 10);


//printing all even numbers from 1 to 20 using while loop

//initialize the counter variable
int j = 0;
while (j <= 20) { 
    if(j % 2 == 0) //check if the number is even
    {
        Console.WriteLine(j); //print the even number
    }

    j++; //increment the counter variable

}
Console.ReadLine(); //wait for user to observe the output before closing the console window
