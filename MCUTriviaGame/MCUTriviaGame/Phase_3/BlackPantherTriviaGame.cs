using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_3
{
    public class BlackPantherTriviaGame : IQuestions
    {
        public static void BlackPantherStartMenu()
        {
            BlackPantherTriviaGame game = new BlackPantherTriviaGame();
            NameAndScore.MovieTitle = "Black Panther";
            Console.Clear();
            Messages.MovieChoice();
            DisplayMenu.StartTriviaGame();

            if (DisplayMenu.StartGame == "Y")
            {
                game.Question1();
            }
            else if (DisplayMenu.StartGame == "B")
            {
                Phase_3MainMenu.SelectAMoive();
            }
            else if (DisplayMenu.StartGame == "E")
            {
                DisplayMenu.EndGame();
            }
            else
            {
                Messages.NotAValidResponse();
                DisplayMenu.StartTriviaGame();
            }
        }
        public void Question1()
        {
            Console.Clear();
            Console.WriteLine("Question 1");
            Messages.LineBreak();
            Console.WriteLine("Ingesting a heart-shaped herb with this metal leads to human super human abilities");
            Messages.LineBreak();
            Console.WriteLine("A. Cooper");
            Console.WriteLine("B. Gold");
            Console.WriteLine("C. Silver");
            Console.WriteLine("D. Vibranium");
            CorrectAnswers.CorrectAnswerD();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Messages.DirectorQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. Ava DuVernay");
            Console.WriteLine("B. Jordan Peele");
            Console.WriteLine("C. Ryan Coogler");
            Console.WriteLine("D. Spike Lee");
            CorrectAnswers.CorrectAnswerC();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("This actor portrays T'Challa / BlackPanther");
            Messages.LineBreak();
            Console.WriteLine("A. Chadwick Boseman");
            Console.WriteLine("B. Michael B. Jordan");
            Console.WriteLine("C. John David Washington");
            Console.WriteLine("D. Daniel Kaluuya");
            CorrectAnswers.CorrectAnswerA();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This actor portrays Erik \"KillMonger\" Stevens");
            Messages.LineBreak();
            Console.WriteLine("A. Michael A. Jordan");
            Console.WriteLine("B. Michael B. Jordan");
            Console.WriteLine("C. Michael C. Jordan");
            Console.WriteLine("D. Michael D. Jordan");
            CorrectAnswers.CorrectAnswerB();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Messages.BoxOfficeQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. 1.148 Billion");
            Console.WriteLine("B. 1.248 Billion");
            Console.WriteLine("C. 1.348 Billion");
            Console.WriteLine("D. 1.448 Billion");
            CorrectAnswers.CorrectAnswerC();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("To gain entrance into Wakanda, KillMonger kills this villian");
            Messages.LineBreak();
            Console.WriteLine("A. Doctor Doom");
            Console.WriteLine("B. Klaue");
            Console.WriteLine("C. White Wolf");
            Console.WriteLine("D. Namor");
            CorrectAnswers.CorrectAnswerB();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("T'Challa is saved by this tribe");
            Messages.LineBreak();
            Console.WriteLine("A. The River Tribe");
            Console.WriteLine("B. The Border Tribe");
            Console.WriteLine("C. The Mining Tribe");
            Console.WriteLine("D. The Jabari Tribe");
            CorrectAnswers.CorrectAnswerD();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("Before KillMonger dies, T'Challa shows him this");
            Messages.LineBreak();
            Console.WriteLine("A. Wakanda Sunrise");
            Console.WriteLine("B. Wakanda Sunset");
            Console.WriteLine("C. Wakanda Mine");
            Console.WriteLine("D. Wakanda Gold");
            CorrectAnswers.CorrectAnswerB();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/16/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 66");
            Console.WriteLine("B. 76%");
            Console.WriteLine("C. 86%");
            Console.WriteLine("D. 96%");
            CorrectAnswers.CorrectAnswerD();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the Post-Credits scene, Shuri helps this person with his recovery");
            Messages.LineBreak();
            Console.WriteLine("A. Scott Lang");
            Console.WriteLine("B. Sam Wilson");
            Console.WriteLine("C. Bucky Barnes");
            Console.WriteLine("D. Steve Rogers");
            CorrectAnswers.CorrectAnswerC();
            NameAndScore.GameCompleted();
        }
    }
}
