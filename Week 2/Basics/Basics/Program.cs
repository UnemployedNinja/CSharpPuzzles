using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // OverFlow
            byte number = 255;
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            number += 1;  // Becomes 0

            Console.WriteLine("Number: " + number);

            // Data Types
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Shawn";
            bool isWorking = false;
            var test = false;

            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(test);



        }
    }
}
