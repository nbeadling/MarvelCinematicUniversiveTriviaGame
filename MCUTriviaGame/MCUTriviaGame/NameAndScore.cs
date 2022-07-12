using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame
{
    public class NameAndScore
    {
        public static string Name { get; set; }

        public static int Score { get; set; }

        public void GetName()
        {
            Console.WriteLine("Enter Your Name: "); 
            Name = Console.ReadLine();
        }

        public static void DisplayNameAndScore(string name, int score = 0)
        {
            Name = name;
            Score = score;

            Console.WriteLine($"Player: {name} | Score: {score}"); 
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
