//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;
class ThirdDigitCheck
{
    static void Main()
    {
        Console.WriteLine("checks for given integer if its third digit (right to left) is 7.");
        Console.WriteLine("Please, give a five digit integer.\nIf you give other type of integer, the program may not work correctly");
        string width = Console.ReadLine();
        int fiveDigitInt = int.Parse(width);        
        bool checker = (fiveDigitInt / 100) % 10 == 7;
        Console.WriteLine("Is the third digit 7? True means YES, False means NO.");
        Console.WriteLine(checker);

    }
}
