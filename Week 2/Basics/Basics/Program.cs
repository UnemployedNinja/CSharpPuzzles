using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // OverFlow
            byte number = 255;

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

            // Size
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("{0} {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("{0} {1}", short.MinValue, short.MaxValue);

            // Constants
            const float Pi = 3.14f;
            // Pi = 1; // Does not compile!! Can not change constants 
            
            // Type Conversion
            byte b = 1;
            int i = b;

            // Won't Compile. It will have data loss
            // int i = 1;
            // byte b = i;

            // Cast
            int num = 1000;
            byte bit = (byte)num;
            Console.WriteLine(bit);

            // Use the Convert Class to change data types
            

        }
    }
}
