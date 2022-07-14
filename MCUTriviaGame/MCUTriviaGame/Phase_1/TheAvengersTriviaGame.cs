using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_1
{
    public class TheAvengersTriviaGame
    {
        public static void TheAvengersStartMenu()
        {
            TheAvengersTriviaGame game = new TheAvengersTriviaGame();

            Console.Clear();
            Console.WriteLine("You have chosen to test your knowledge on the film The Avengers (2012)");
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
            Console.WriteLine("Loki uses the Tesseract to enslave Dr. Erik Selvig and this Avenger");
            Messages.LineBreak();
            Console.WriteLine("A. Hawkeye");
            Console.WriteLine("B. Black Widow");
            Console.WriteLine("C. Iron Man");
            Console.WriteLine("D. Thor");
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
                Messages.LineBreak();
                Question2();
            }
            else if (answer == "C" || answer == "B" || answer == "D")
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
            Console.WriteLine("This person directed The Avengers");
            Messages.LineBreak();
            Console.WriteLine("A. Anthony Russo");
            Console.WriteLine("B. Joe Russo");
            Console.WriteLine("C. Zack Snyder");
            Console.WriteLine("D. Joss Whedon");
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
                Question3();
            }
            else if (answer == "A" || answer == "B" || answer == "C")
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
            Console.WriteLine("This Actor makes his MCU debut as the The Incredible Hulk");
            Messages.LineBreak();
            Console.WriteLine("A. Edward Norton");
            Console.WriteLine("B. Mark Ruffalo");
            Console.WriteLine("C. Lou Ferrigno");
            Console.WriteLine("D. Eric Bana");
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
                Question4();
            }
            else if (answer == "A" || answer == "D" || answer == "C")
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
            Console.WriteLine("Which Place is not visited in the movie?");
            Messages.LineBreak();
            Console.WriteLine("A. New York City");
            Console.WriteLine("B. Stuttgart");
            Console.WriteLine("C. Moscow");
            Console.WriteLine("D. Kolkata");
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
            Console.WriteLine("The Avengers made this much at the Box Office:");
            Messages.LineBreak();
            Console.WriteLine("A. 1.419 Billion");
            Console.WriteLine("B. 1.519 Billion");
            Console.WriteLine("C. 1.619 Billion");
            Console.WriteLine("D. 1.719 Billion");
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
                Question6();
            }
            else if (answer == "A" || answer == "D" || answer == "C")
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
            Console.WriteLine("The main battle in this film takes place in this American City");
            Messages.LineBreak();
            Console.WriteLine("A. New York City");
            Console.WriteLine("B. Washington DC");
            Console.WriteLine("C. Los Angeles");
            Console.WriteLine("D. San Francisco");
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
                Question7();
            }
            else if (answer == "B" || answer == "D" || answer == "C")
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
            Console.WriteLine("Loki Opens Up a Wormhole above this building");
            Messages.LineBreak();
            Console.WriteLine("A. Empire State Building");
            Console.WriteLine("B. Chrysler Building");
            Console.WriteLine("C. Stark Tower");
            Console.WriteLine("D. Avengers Tower");
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
                Question8();
            }
            else if (answer == "A" || answer == "B" || answer == "D")
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
            Console.WriteLine("This Avenger Intercepts a Nuclear Missle and guides it through the warmhole to defeat the Chitauri fleet");
            Messages.LineBreak();
            Console.WriteLine("A. Captain America");
            Console.WriteLine("B. Hulk");
            Console.WriteLine("C. Iron Man");
            Console.WriteLine("D. Thor");
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
                Question9();
            }
            else if (answer == "B" || answer == "D" || answer == "A")
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
            Console.WriteLine("As of 7/13/2022, this is The Avengers Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 81%");
            Console.WriteLine("B. 86%");
            Console.WriteLine("C. 91%");
            Console.WriteLine("D. 96%");
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
            Console.WriteLine("This villian briefly appears in the mid-credits scene");
            Messages.LineBreak();
            Console.WriteLine("A. Gorr The God Butcher");
            Console.WriteLine("B. Malekith the Accursed");
            Console.WriteLine("C. The Mandarin");
            Console.WriteLine("D. Thanos");
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
                GameCompleted();
            }
            else if (answer == "A" || answer == "B" || answer == "C")
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
            AuditLog.WriteFiles(NameAndScore.Name, "The Avengers Trivia Game", NameAndScore.Score); 
            Messages.LineBreak();
            Messages.GameCompleted();

            Messages.LineBreak();
            Messages.NewGame();
        }
    }
}
