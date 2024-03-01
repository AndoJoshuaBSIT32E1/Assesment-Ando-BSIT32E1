// Area of Triangle
// Intructions:
// Enter the number base and height to find the Area of triangle

using System;

namespace AreaofTriangle
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double baseLength;
            double height;
            double area;

            //to enter base length
            Console.WriteLine("------------------------------------------");
            Console.Write("1. Please enter the length of the base: ");
            while (!double.TryParse(Console.ReadLine(), out baseLength) || baseLength <= 0)
            {
                Console.WriteLine("Invalid input. Please try again! :( ");
                Console.Write("Please enter the length of the base: ");
                return;
            }

            //to enter height

            Console.Write("2. Please enter the height of the triangle: ");
            while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.WriteLine("Invalid input. Please try again! :(");
                Console.Write("Please enter the height of the triangle: ");
                return;
            }

            //To calculate the area of the triangle
            area = 0.5 * baseLength * height;

            // Result Display
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Result:");
            Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {area}");

            Console.WriteLine("------------------------------------------");

            Console.ReadLine();


        }
    }

}

