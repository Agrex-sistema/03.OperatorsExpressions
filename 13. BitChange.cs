//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int position1 = 3;
        int position2 = 24;

        int mask1 = 7 << position1;
        int mask2 = 7 << position2;

        int getNumbers1 = number & mask1;
        int getNumbers2 = number & mask2;
        int change = (number & ~mask1) & ~mask2;

        int mask3 = (getNumbers1 >> position1) << position2;
        int mask4 = (getNumbers2 >> position2) << position1;
        int result = (change | mask3) | mask4;

        Console.WriteLine(result);
    }
}
