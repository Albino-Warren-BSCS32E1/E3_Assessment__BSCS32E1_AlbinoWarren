using System;

class AreaOfTriangle
{
    static void Main()
    {

        Console.WriteLine("Enter the base of the triangle:");
        double baseLength = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the triangle:");
        double height = double.Parse(Console.ReadLine());

     
        double area = CalculateTriangleArea(baseLength, height);

    
        Console.WriteLine($"The area of the triangle is: {area}");
    }

    static double CalculateTriangleArea(double b, double h)
    {
        return 0.5 * b * h;
    }
}
