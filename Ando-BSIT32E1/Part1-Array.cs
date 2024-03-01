using System;

namespace LargestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // the user will input 5 integers
            int[] num = new int[5];
            Console.WriteLine("Enter 5 integers (eg. 12, 6, 13, 69, 53):");
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the first number {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            // Find the largest number
            int largeNumber = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > largeNumber)
                {
                    largeNumber = num[i];
                }
            }

            // Print the largest number
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Largest number in the array that you enter is: {largeNumber}");
            Console.ReadLine();
        }
    }
}

