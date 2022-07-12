using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame
{
    public class Messages
    {
        public static void LineBreak()
        {
            Console.WriteLine("\n");
        }

        public static void NotAValidResponse()
        {
            Console.WriteLine("Not A Valid Response, Try Again!"); 
        }

        public static void Correct()
        {
            Console.WriteLine("Correct!");
        }

        public static void Wrong()
        {
            Console.WriteLine("Wrong!");
        }
    }
}
