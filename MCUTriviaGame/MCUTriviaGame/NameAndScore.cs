using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame
{
    public class NameAndScore
    {
        public static string Name { get; set; }

        public static int Score { get; set; } = 0;

        public void GetName()
        {
            Console.WriteLine("Enter Your Name: "); 
            Name = Console.ReadLine();
        }
        public static void DisplayNameAndScore()
        {
            Console.WriteLine($"Player: {Name} | Score: {Score}");
        }
        public static void CorrectAnswerAddPoint()
        {
            Score++;
        }

        public static void Reset()
        {
            Score = 0;
        }
    }
}
