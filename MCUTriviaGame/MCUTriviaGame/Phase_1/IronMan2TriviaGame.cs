using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame;

namespace MCUTriviaGame.Phase_1
{
    public class IronMan2TriviaGame : IQuestions
    {
        public static void IronMan2StartMenu()
        {
            IronMan2TriviaGame game = new IronMan2TriviaGame();

            Console.Clear();
            Console.WriteLine("You have chosen to test your knowledge on the film Iron Man 2 (2010)");
            Messages.LineBreak();
            Console.WriteLine("Are you ready to begin?");
            Messages.LineBreak();
            Console.WriteLine("(Y)es");
            Console.WriteLine("(B)ack to previous page");
            Console.WriteLine("(E)nd Program");
            Messages.LineBreak();
            Console.WriteLine("What is your choice?: ");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "Y")
            {
                game.Question1();
            }
            else if (choice == "B")
            {
                Phase_1MainMenu.SelectAMoive();
            }
            else if (choice == "E")
            {
                DisplayMenu.EndGame();
            }
            else
            {
                Messages.NotAValidResponse();
            }
        }
        public void Question1()
        {
            Console.Clear();
            Console.WriteLine("Question 1");
            Messages.LineBreak();
            Console.WriteLine("Iron Man 2 is the debut of this famous character and future Avenger");
            Messages.LineBreak();
            Console.WriteLine("A. Hawkeye");
            Console.WriteLine("B. Black Widow");
            Console.WriteLine("C. Scarlett Witch");
            Console.WriteLine("D. Loki");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "B")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Messages.LineBreak();
                Question2();
            }
            else if (answer == "C" || answer == "A" || answer == "D")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Messages.LineBreak();
                Question2();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question1();
            }
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine("This person directed Iron Man 2");
            Messages.LineBreak();
            Console.WriteLine("A. Jon Favreau");
            Console.WriteLine("B. Sam Raimi");
            Console.WriteLine("C. Martin Scorsese");
            Console.WriteLine("D. Patty Jenkins");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "A")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question3();
            }
            else if (answer == "D" || answer == "B" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question3();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question2();
            }
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Mickey Rourke plays this main villian in the film");
            Messages.LineBreak();
            Console.WriteLine("A. The Mandarin");
            Console.WriteLine("B. Obadiah Stane");
            Console.WriteLine("C. Justin Hammer");
            Console.WriteLine("D. Whiplash");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "D")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question4();
            }
            else if (answer == "A" || answer == "B" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question4();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question3();
            }
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("Tony Stark competes in this race during the film");
            Messages.LineBreak();
            Console.WriteLine("A. Daytona 500");
            Console.WriteLine("B. Indianapolis 500");
            Console.WriteLine("C. Monaco Historic Grand Prix");
            Console.WriteLine("D. 24 Hours of Le Mans");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question5();
            }
            else if (answer == "B" || answer == "D" || answer == "A")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question5();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question4();
            }
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine("Iron Man 2 made this much at the Box Office");
            Messages.LineBreak();
            Console.WriteLine("A. 603.9 Million");
            Console.WriteLine("B. 623.9 Million");
            Console.WriteLine("C. 643.9 Million");
            Console.WriteLine("D. 663.9 Million");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question6();
            }
            else if (answer == "A" || answer == "D" || answer == "B")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question6();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question5();
            }
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("This Actor replaces Terrence Howard as James \"Rhodey\" Rhodes and becomes this superhero");
            Messages.LineBreak();
            Console.WriteLine("A. Cuba Gooding Jr. and War Machine");
            Console.WriteLine("B. Chadwick Boseman and Black Panther");
            Console.WriteLine("C. Don Cheadle and War Machine");
            Console.WriteLine("D. Anthony Mackie and Falcon ");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question7();
            }
            else if (answer == "B" || answer == "D" || answer == "A")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question7();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question6();
            }
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("The Stark Expo takes place in this New York City Borough");
            Messages.LineBreak();
            Console.WriteLine("A. Bronx");
            Console.WriteLine("B. Staten Island");
            Console.WriteLine("C. Brooklyn");
            Console.WriteLine("D. Queens");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "D")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question8();
            }
            else if (answer == "A" || answer == "B" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question8();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question7();
            }
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("Sam Rockwell plays this character who is Tony Stark's business rival");
            Messages.LineBreak();
            Console.WriteLine("A. Howard Stark");
            Console.WriteLine("B. Donald Blake");
            Console.WriteLine("C. Arthur Fleck");
            Console.WriteLine("D. Justin Hammer");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "D")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question9();
            }
            else if (answer == "B" || answer == "C" || answer == "A")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question9();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question8();
            }
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine("As of 7/12/2022, this is Iron Man 2's Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 52%");
            Console.WriteLine("B. 62%");
            Console.WriteLine("C. 72%");
            Console.WriteLine("D. 82%");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question10();
            }
            else if (answer == "A" || answer == "D" || answer == "B")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question10();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question9();
            }
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the Post Credits Scene, S.H.I.E.L.D. agent Phil Coulson reports the discovery of this");
            Messages.LineBreak();
            Console.WriteLine("A. Captain America is Frozen in Ice");
            Console.WriteLine("B. Mjolnir");
            Console.WriteLine("C. Tesseract");
            Console.WriteLine("D. Vibranium");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "B")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                GameCompleted();
            }
            else if (answer == "A" || answer == "D" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                GameCompleted();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question10();
            }
        }
        public static void GameCompleted()
        {
            AuditLog.WriteFiles(NameAndScore.Name, "Iron Man 2 Trivia Game", NameAndScore.Score);
            Messages.LineBreak();
            Messages.GameCompleted();

            Messages.LineBreak();
            Messages.NewGame();
        }
    }
}

