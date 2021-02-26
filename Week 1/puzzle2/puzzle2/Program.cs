using System;
using System.Linq;

namespace puzzle2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing conditions
            string str1 = "Hey fellow warriors";
            string str2 = "This is a test";
            string str3 = "This is another test";

            // Test 1
            str1 = SpinWords(str1);
            Console.WriteLine(str1);
            // Test 2
            str2 = SpinWords(str2);
            Console.WriteLine(str2);
            // Test 3
            str3 = SpinWords(str3);
            Console.WriteLine(str3);
        }

        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    words[i] = new string(words[i].Reverse().ToArray());
                }
            }
            return string.Join(" ", words);
        }
    }
}
