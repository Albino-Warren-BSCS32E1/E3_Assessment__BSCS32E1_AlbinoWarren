using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            // Get the squre root
            double squareRoot = Math.Sqrt(i);

            // Print 
            Console.WriteLine($"Number: {i}, Square Root: {squareRoot}");
        }
    }
}
