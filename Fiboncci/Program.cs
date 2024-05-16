//Fibbonacci:
//1) output user selectable quantity of values starting with the value one (1)
//2) each value after the first will be the sum of the previous two numbers
//3) Then turn it into a list
//3) Bonus: output 1000 without bigint

//ex: 1, 1, 2, 3, 5, 8

using System.ComponentModel.Design;
using System.Numerics;

int num1 = 1;
int num2 = 0;
int userinput = 0;

Console.WriteLine("Please enter how many times the Fibonacci needs to run.");

string input = Console.ReadLine();

while (userinput <= 0)
{
    if (userinput < 0)
    {
        Console.WriteLine("The input is not a positive number. Please enter how many times the Fibonacci needs to run.");
        input = Console.ReadLine();
    }
    try
    {
        userinput = Convert.ToInt32(input);
    }
    catch (Exception)
    {
        Console.WriteLine("The input is not a number. Please enter how many times the Fibonacci needs to run.");
        input = Console.ReadLine();
    }
    
}

for (int i = 1; i <= userinput; i++)
{
    int num3 = num1 + num2;
    Console.WriteLine(num3);
    num1 = num2;
    num2 = num3;       
}