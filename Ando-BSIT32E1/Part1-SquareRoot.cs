using System;

class Program
{
    static void Main(string[] args)
    {
        // from 10 to 20
        for (int i = 10; i <= 20; i++)
        {
            // Calculate square root
            double square = Math.Sqrt(i);

            // Result
            Console.WriteLine($"The number is: {i},  and the Square is : {square}");
            Console.WriteLine("------------------------------------------");
        }
        Console.ReadKey();
    }
}
