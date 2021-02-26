using System;

namespace Puzzle3
{
    /**********************************************************************************
     * Puzzle 3
     * 
     * Instructions:
     * 
     * In a factory a printer prints labels for boxes. For one kind of boxes the printer 
     * has to use colors which, for the sake of simplicity, are named with letters from a to m.
     * The colors used by the printer are recorded in a control string. For example a "good" 
     * control string would be aaabbbbhaijjjm meaning that the printer used three times color a,
     * four times color b, one time color h then one time color a...
     * 
     * Sometimes there are problems: lack of colors, technical malfunction and a "bad" control 
     * string is produced e.g. aaaxbbbbyyhwawiwjjjwwm with letters not from a to m.
     * 
     * You have to write a function printer_error which given a string will return the error 
     * rate of the printer as a string representing a rational whose numerator is the number
     * of errors and the denominator the length of the control string. Don't reduce this
     * fraction to a simpler expression.
     * 
     * The string has a length greater or equal to one and contains only letters from ato z.
     * 
     * Examples:
     * s="aaabbbbhaijjjm"
     * error_printer(s) => "0/14"
     * 
     * s="aaaxbbbbyyhwawiwjjjwwm"
     * error_printer(s) => "8/22"
     * *********************************************************************************/
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "aaabbbbhaijjjm";
            string str2 = "aaaxbbbbyyhwawiwjjjwwm";

            str1 = PrinterError(str1);
            str2 = PrinterError(str2);

            // Output test cases
            Console.WriteLine(str1);
            Console.WriteLine(str2);

        }

        public static string PrinterError(String s)
        {
            string ratio = "";
            s = s.ToLower();
            int errorCount = 0;

            for(int i = 0; i < s.Length; i++)
            {
                // Is n - z? 
                if(s[i].Equals('n') || s[i].Equals('o') || s[i].Equals('p') || s[i].Equals('q') || s[i].Equals('r') ||
                    s[i].Equals('s') || s[i].Equals('t') || s[i].Equals('u') || s[i].Equals('v') || s[i].Equals('w') ||
                    s[i].Equals('x') || s[i].Equals('y') || s[i].Equals('z'))
                {
                    errorCount += 1;
                }
            }

            ratio = errorCount + "/" + s.Length;

            return ratio;
        }
    }
}

/* SOLUTIONS
public static string PrinterError(string s)
{
    return s.Where(c => c > 'm').Count() + "/" + s.Length;
}

public static string PrinterError(String s)
{
    int num = s.Select(c => IsValid(c)).Sum();
    return String.Format("{0}/{1}", num, s.Length);
}

public static int IsValid(char c)
{
    if ('a' <= c && 'm' >= c)
        return 0;
    else
        return 1;
}
*/