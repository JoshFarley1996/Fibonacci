using System.ComponentModel.Design;
using System.Net.Security;
using System.Runtime.InteropServices.Marshalling;
using System.Xml;

int num1 = 0;
int num2 = 0;


while (num1 <= 100)
{
    if (num1 == 0)
    {
        num1 += 1;
        Console.WriteLine(num1);
    }
    else if (num2 == 0 )
    {
        num2 = num1;
        Console.WriteLine(num2);
    }
    else if ( num1 >0 && num2 > 0)
    {
        int num3 = num1 + num2;
        Console.WriteLine(num3);
        num1 = num2;
        num2 = num3;
    }    
}