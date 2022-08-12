using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame
{
    public class CorrectAnswers
    {
        public static void CorrectAnswerA()
        {
            Messages.LineBreak(); 
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "A")
            {
                Messages.Clear(); 
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
            }
            else
            {
                Messages.Clear(); 
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
            }
        }

        public static void CorrectAnswerB()
        {
            Messages.LineBreak(); 
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "B")
            {
                Messages.Clear(); 
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
            }
            else
            {
                Messages.Clear(); 
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
            }
        }

        public static void CorrectAnswerC()
        {
            Messages.LineBreak(); 
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.Clear(); 
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
            }
            else
            {
                Messages.Clear(); 
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
            }
        }

        public static void CorrectAnswerD()
        {
            Messages.LineBreak(); 
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "D")
            {
                Messages.Clear(); 
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
            }
            else
            {
                Messages.Clear(); 
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
            }
        }
    }
}
