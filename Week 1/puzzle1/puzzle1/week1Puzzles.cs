using System;

namespace puzzle1
{
	public class Week1Puzzles
	{
		public Week1Puzzles()
		{
			
		}

        /************************************************************
         * Puzzle 1
         * 
         * Instructions:
         * Write a function that takes in a string of one or more words, and returns the same string, 
         * but with all five or more letter words reversed (Just like the name of this Kata). Strings 
         * passed in will consist of only letters and spaces. Spaces will be included only when more t
         * han one word is present.
         * 
         * Examples:
         * "Hey fellow warriors" => returns "Hey wollef sroirraw"
         * "This is a test" => returns "This is a test"
         * "This is another test" => returns "This is rehtona test"
         *      
         * *********************************************************/
        public void Puzz1()
        {
            // Testing conditions
            string str1 = "Hey fellow warriors";
            string str2 = "This is a test";
            string str3 = "This is another test";

            
            string newStr = "";
            string temp = "";
            int letterCount = 0;

            // Change based on string passed in 
            string str = str3;

            for (int i = 0; i <= str.Length; i++)
            {
                // End of Sentence? 
                if (i == str.Length)
                {
                    if (letterCount >= 5)
                    {
                        // reverse word
                        temp = ReverseWord(temp);
                        newStr += temp;

                    } else
                    {
                        // No change in word
                        newStr += temp;
                  
                    }
                    break;
                } 

                // End of Word?
                if(str[i] == ' ')
                {
                    
                    if(letterCount >= 5)
                    {
                        // reverse word
                        temp = ReverseWord(temp);

                        newStr += temp + " ";
                        letterCount = 0;
                        temp = "";

                    } else
                    {
                        // No change in word
                        newStr += temp + " ";
                        letterCount = 0;
                        temp = "";
                    }
                } else
                {
                    letterCount += 1;
                    temp += str[i];
                }
            }
            // Last iteration of loop c is Null 
            Console.WriteLine("The New Sentence is: ");
            Console.WriteLine(newStr);

        }

        public string ReverseWord(string temp)
        {
            // reverse word
            char[] charArray = temp.ToCharArray();
            Array.Reverse(charArray);
            temp = new string(charArray);

            return temp;
        }


        // This was the Actual Solution
        /*
        public class Kata
        {
            public static string SpinWords(string sentence)
            {
                var words = sentence.Split(' ').Where(w => w.Length > 4);
                foreach (var w in words) sentence = sentence.Replace(w, Reverse(w));
                return sentence;
            }

            public static string Reverse(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
        */


        // Another example is
        /*
        public class Kata
        {
            public static string SpinWords(string sentence)
            {
                string[] words = sentence.Split(' ');
                for (var i = 0; i < words.Count(); i++)
                {
                    if (words[i].Length >= 5)
                    {
                        words[i] = new string(words[i].Reverse().ToArray());
                    }
                }

                return string.Join(" ", words);

            }
        }
        */
    }
}
