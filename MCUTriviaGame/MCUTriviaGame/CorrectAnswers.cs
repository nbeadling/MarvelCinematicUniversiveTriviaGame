using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame
{
    public class CorrectAnswers
    {
        private static List<string> CorrectOrWrong = new List<string>();

        public static void AddCorrect()
        {
            CorrectOrWrong.Add("Correct"); 
        }

        public static void AddWrong()
        {
            CorrectOrWrong.Add("Wrong"); 
        }
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
                AddCorrect();  
            }
            else
            {
                Messages.Clear(); 
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                AddWrong();  
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
                AddCorrect(); 
            }
            else
            {
                Messages.Clear(); 
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                AddWrong(); 
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
                AddCorrect(); 
            }
            else
            {
                Messages.Clear(); 
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                AddWrong(); 
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
                AddCorrect(); 
            }
            else
            {
                Messages.Clear(); 
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                AddWrong(); 
            }
        }

        public static void DisplayResults()
        {
            int i = 1;
            Messages.LineBreak(); 
            foreach(string answer in CorrectOrWrong)
            {
                Console.WriteLine($"Question {i}: {answer}");
                i++; 
            }
        }

        public static void ClearList()
        {
            CorrectOrWrong.Clear();
        }
    }
}
