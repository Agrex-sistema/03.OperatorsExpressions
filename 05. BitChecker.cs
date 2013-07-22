//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
//Try it with 7 and 8 in order to check weather it works. 8 is 1000, 7 is 0111.

using System;
class BitChecker
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);
        int mask = 1 << 3;
        int nAndMask = number & mask;
        int bit = nAndMask >> 3;
        Console.WriteLine("Third bit is " + bit);
    }
}
