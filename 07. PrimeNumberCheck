//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;
class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please, enter a prime number to be checked!");
        int number = int.Parse(Console.ReadLine());
        if ((number > 0) && (number < 100)) 
        {

            bool isPrime = ((number % 2 > 0)
            && (number % 3 > 0) && (number % 5 > 0)
            && (number % 7 > 0)) || ((number == 2)
            || (number == 3) || (number == 5)
            || (number == 7));
            Console.WriteLine(isPrime);
        }
        else
        {
       Console.WriteLine("Number is out of range");
        }
    }
}
