//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Please enter value for A in centimeters:");
        string strOne = Console.ReadLine();
        double a = double.Parse(strOne);
        Console.WriteLine("Please enter value for B in centimeters:");
        string strTwo = Console.ReadLine();
        double b = double.Parse(strTwo);
        Console.WriteLine("Please enter value for h in centimeters:");
        string strThree = Console.ReadLine();
        double h = double.Parse(strThree);
        Console.WriteLine("\n\n\nYou have successfully entered the following values\nFor A - {0} cm.\nFor B - {1} cm.\nFor h - {2} cm\n\n\n",a,b,h);

        double trapezoidArea = ((a + b) / 2) * h;
        
        Console.WriteLine("Your trapezoid area is: " + trapezoidArea + " centimeters.\n\n\n");
    }
}
