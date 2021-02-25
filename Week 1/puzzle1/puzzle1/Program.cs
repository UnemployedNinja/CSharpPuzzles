using System;

namespace puzzle1
{
    class Program
    {
        /************************************************************
         * Main
         * 
         * Description:
         *      This project will be the driver that will call the different
         *      functions in the week1Puzzles class. Each function will be
         *      a different puzzle. 
         * *********************************************************/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Week1Puzzles puzzles = new Week1Puzzles();
            puzzles.Puzz1();
        }
    }
}
