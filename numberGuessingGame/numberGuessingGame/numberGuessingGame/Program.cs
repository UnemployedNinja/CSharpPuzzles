using System;

namespace numberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int winNum = random.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number in between 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("To High! Guess Lower...");
                } 
                else if (i < winNum)
                {
                    Console.WriteLine("To Low! Guess Higher...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("YOU WIN!!");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            Console.WriteLine("Press any key to finished.");
            Console.ReadKey(true);
        }
    }
}
