//Write an expression that checks if given integer is odd or even.

using System;
class OddOrEvenCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        string str = Console.ReadLine();
        int number = int.Parse(str);
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}
