using Labb1;
using System.Runtime.CompilerServices;

int total = 0;

for(int j = 0; j < 2; j++)
{
    Console.WriteLine("Enter a string of letters and numbers");

    string input = Console.ReadLine();

    var v = Utils.StringChecker(input);

    if (v != null)
    {
        var stringFromList = string.Join("", v);

        var index = input.IndexOf(stringFromList);

        var substringLength = stringFromList.Length;

        int stringToInt = Int32.Parse(stringFromList);

        total += stringToInt;

        for (int i = 0; i < index; i++)
        {
            Console.Write(input[i]);
        }

        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write(stringFromList);

        Console.ForegroundColor = ConsoleColor.White;

        for (int i = index + substringLength; i < input.Length; i++)
        {
            Console.Write(input[i]);

            
        }

        if (j > 0)
        {
            Console.WriteLine("  ");

            Console.Write("Total = ");

            Console.WriteLine(total);
        }

        Console.WriteLine(" ");


    }
    else
    {
        Console.WriteLine("No Valid Substring Found");
    }
}

