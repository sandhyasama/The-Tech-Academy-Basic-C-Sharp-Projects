Console.WriteLine("Enter a number for multiplication");
long inputedNumber = Convert.ToInt64(Console.ReadLine());

//multiply the number by 50
Console.WriteLine("multiplying the number you entered by 50");
long multipliedNumber = inputedNumber * 50;
Console.WriteLine(multipliedNumber);


//take an input from the user
Console.WriteLine("Enter another number for addition");
long numberToAdd = Convert.ToInt64(Console.ReadLine());

//add 25 to the number
long addedNumber = numberToAdd + 25;
//simulated adding a 25 number to the number
Console.WriteLine("Adding 25 to the number you entered");
Console.WriteLine(addedNumber);

Console.WriteLine("Enter another number number to divide by");
long numberToDivideBy = Convert.ToInt64(Console.ReadLine());

//divide the number by 12.5
Console.WriteLine("Dividing the number you entered by 12.5");
//divide the number by 12.5 can yield decimal fractions , so we need to use double for the result
double dividedNumber = (double) numberToDivideBy / 12.5;
Console.WriteLine(dividedNumber);


//take an input from the user and check whether it is greater than 50 or not
Console.WriteLine("Enter a number to check if it is greater than 50 or not");
long numberForGreaterThan50Check = Convert.ToInt64(Console.ReadLine());
//simulating message
Console.WriteLine("Checking if the number you entered is greater than 50 or not");
//do the actual check here and right to console
Console.WriteLine(numberForGreaterThan50Check > 50);
//wait for reading the result


//take an input from the user and divide by 7
Console.WriteLine("Enter a number to check to divide it by 7");
long numberToDivideBy7 = Convert.ToInt64(Console.ReadLine());
//make sure fractions are captured by using double for the result
double result = (double)numberToDivideBy7 / 7.0;
Console.WriteLine("Dividing the number you entered by 7");
//write the result to console
Console.WriteLine(result);
Console.ReadLine();









