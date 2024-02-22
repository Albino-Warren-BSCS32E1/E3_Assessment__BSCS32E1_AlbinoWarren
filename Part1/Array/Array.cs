using System;

class Array
{
    static void Main()
    {
        // Declare an array of 5 integers
        int[] numbers = new int[5];

        // Ask the user to input 5 integers
        Console.WriteLine("Please enter 5 integers, one at a time:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Integer {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Print 
        Console.WriteLine("Array elements:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Find the largest 
        int largest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        // Print the largest int
        Console.WriteLine("Largest element in the array: " + largest);
    }
}
