using System;
using System.Net.Security;

var b = 1;

while (b <= 30)
{
    var a = 0;

    while (a <= 29)
    {
        a++;

        var c = a * b;

        if (c < 10)
        {
            Console.Write("  ");
        }

        if (c < 100 && c > 9)
        {
            Console.Write(" ");
        }

        Console.Write(c);

       

        Console.Write(" ");
    }

    b++;

    Console.WriteLine("");
}





