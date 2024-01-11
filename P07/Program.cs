using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a series of integers separated by spaces:");

        // Reading input and converting it into an array of integers
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        // Creating a queue and adding numbers to it
        Queue<int> numberQueue = new Queue<int>(numbers);

        // Printing even numbers separated by ", "
        PrintEvenNumbers(numberQueue);

        Console.ReadLine(); // To prevent the console window from closing immediately
    }

    static void PrintEvenNumbers(Queue<int> numbers)
    {
        Console.Write("Even Numbers: ");

        bool isFirst = true; // Flag to check if it's the first even number

        while (numbers.Count > 0)
        {
            int currentNumber = numbers.Dequeue();

            // Check if the number is even
            if (currentNumber % 2 == 0)
            {
                // Print ", " only if it's not the first even number
                if (!isFirst)
                {
                    Console.Write(", ");
                }

                Console.Write(currentNumber);

                // Set the flag to false after printing the first even number
                isFirst = false;
            }
        }

        Console.WriteLine(); // Move to the next line after printing even numbers
    }
}
