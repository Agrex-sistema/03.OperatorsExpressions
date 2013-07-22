//Write a boolean expression that checks for given integer if it can be divided 
//(without remainder) by 7 and 5 in the same time.

using System;
class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Please enter a number, which will be checked whether it can be divided by 7 and 5 in the same time.");
        string str = Console.ReadLine();
        int numberToBeChecked = int.Parse(str);

        bool divideBy5= numberToBeChecked % 5 == 0; //Gives True only if the number can be divided by 5 w/o remainder.
        bool divideBy7 = numberToBeChecked % 7 == 0; //Gives True only if the number can be divided by 7 w/o remainder.
        bool divide = divideBy5 && divideBy7; //Only if both conditions are TRUE gives True, thus it checks both remainders.
        Console.WriteLine("Can it be divided? True means YES, False means NO");
        Console.WriteLine(divide);
    }
}
