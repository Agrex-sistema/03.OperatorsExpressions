//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. Example: v=5; p=1  false.
//E.g 7 = 0111; 8 = 1000!

using System;
class BitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Please give an integer:");
        string str = Console.ReadLine();
        int number = int.Parse(str);
        Console.WriteLine("Please give a bit position:");
        string strP = Console.ReadLine();
        int p = int.Parse(strP);

        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        if (bit == 1)
        {
            Console.WriteLine("The bit in position {0} has a value of One", strP);
        }
        else
        {
            Console.WriteLine("The bit in position {0} has a value of Zero", strP);
        }

    }
}
