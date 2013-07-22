//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;
class PointWithinCircle
{
    static void Main()
    {
        Console.WriteLine("Please give coordinates of points X and Y.\n\nFor X give:");
        string XX = Console.ReadLine();
        Console.WriteLine("For Y give:");
        string YY = Console.ReadLine();
        double x = double.Parse(XX);
        double y = double.Parse(YY);
        double radius = 5;

        if (((x * x) + (y * y)) <= radius * radius)
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K(O,5). Yuppee!", x, y);
        }
        else
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is out of the circle K(O,5). Sorry! :(", x, y);
        }
    }
}

