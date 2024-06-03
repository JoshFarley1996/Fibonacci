//Fibonacci:
//1) output user selectable quantity of values starting with the value one (1)
//2) each value after the first will be the sum of the previous two numbers
//3) Then turn it into a list
//3) Bonus: output 1000 without bigint

//ex: 1, 1, 2, 3, 5, 8

using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;

//Give required variables a value
int userinput = 0;
//Ask user for the amount of time the code needs to be ran.
Console.WriteLine("Please enter how many times the Fibonacci needs to run.");

//Validate the users input. Cannot be a negative number or letter
while (userinput <= 0)
{
    //get input from the user
    string input = Console.ReadLine();

    //validate if (1 the input is a number (2 is that number positive
    if (!int.TryParse(input, out userinput))
    {
    Console.WriteLine("The input is a not valid. Please enter how many times the Fibonacci needs to run.");        
    }
    else if (userinput < 0)
    {
    Console.WriteLine("The input is a not a positive number. Please enter how many times the Fibonacci needs to run.");    
    }
    else
    {
        break;
    }
}

    //Add list 
    List<int> numbers = [];

//Run the Fibonacci loop as many times as the user wants adding the final value to the list.
for (int i = 1; i <= userinput; i++)
{
    if(i<= 2)
    {
        numbers.Add(1);
    }
    if(i>2)
    {
        numbers.Add(numbers[numbers.Count - 1] + numbers[numbers.Count - 2]);
    }
    
}

////Display list to user
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
