using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_1
{
    public class TheIncredibleHulkTriviaGame
    {
        public static void TheIncredibleHulkStartMenu()
        {

            Console.Clear();
            Console.WriteLine("You have chosen to test your knowledge with The Incredible Hulk (2008)");
            Messages.LineBreak();
            Console.WriteLine("Are you ready to begin?");
            Messages.LineBreak();
            Console.WriteLine("(Y)es");
            Console.WriteLine("(B)ack to previous page");
            Console.WriteLine("(E)nd Program");
            Messages.LineBreak();
            Console.WriteLine("Waht is your choice?: ");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "Y")
            {
                Question1();
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
        public static void Question1()
        {
            Console.Clear();
            Console.WriteLine("Question 1");
            Messages.LineBreak();
            Console.WriteLine("This actor plays the Hulk, but is replaced in future films:");
            Messages.LineBreak();
            Console.WriteLine("A. Mark Ruffalo");
            Console.WriteLine("B. Eric Bana");
            Console.WriteLine("C. Edward Norton");
            Console.WriteLine("D. Lou Ferrigno");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
                Messages.LineBreak();
                Question2();
            }
            else if (answer == "B" || answer == "A" || answer == "D")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
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
        public static void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine("This person directed The Incredible Hulk");
            Messages.LineBreak();
            Console.WriteLine("A. Louis Leterrier");
            Console.WriteLine("B. Ang Lee");
            Console.WriteLine("C. Martin Scorsese");
            Console.WriteLine("D. Jon Favreau");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "A")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
                Question3();
            }
            else if (answer == "D" || answer == "B" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
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
        public static void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Tim Roth plays this main villian in the film");
            Messages.LineBreak();
            Console.WriteLine("A. The Thing");
            Console.WriteLine("B. The Abomination");
            Console.WriteLine("C. The Warlock");
            Console.WriteLine("D. The Anti-Hulk");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            Messages.LineBreak();

            string answer = Console.ReadLine().ToUpper();

            if (answer == "B")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
                Question4();
            }
            else if (answer == "A" || answer == "D" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
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
        public static void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This is the University that Dr. Bruce Banner (Hulk) used to work at:");
            Messages.LineBreak();
            Console.WriteLine("A. Culver Vniversity");
            Console.WriteLine("B. University of Virginia");
            Console.WriteLine("C. Virginia Commonwealth University");
            Console.WriteLine("D. Virginia Tech");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "A")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
                Question5();
            }
            else if (answer == "B" || answer == "D" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
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
        public static void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine("The Incredible Hulk made this much at the Box Office:");
            Messages.LineBreak(); 
            Console.WriteLine("A. 204.8 Million");
            Console.WriteLine("B. 234.8 Million");
            Console.WriteLine("C. 264.8 Million");
            Console.WriteLine("D. 294.8 Million");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
                Question6();
            }
            else if (answer == "A" || answer == "D" || answer == "B")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
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
        public static void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("This Actor Plays Thaddeus \"Thunderbolt\" Ross and will appear in later MCU films:");
            Messages.LineBreak();
            Console.WriteLine("A. Jeff Bridges");
            Console.WriteLine("B. John Goodman");
            Console.WriteLine("C. William Hurt");
            Console.WriteLine("D. Sylvester Stallone");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
                Question7();
            }
            else if (answer == "B" || answer == "D" || answer == "A")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
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
        public static void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("These are the codenames that Dr. Banner and Dr. Samuel Sterns went by when communicating with each other");
            Messages.LineBreak();
            Console.WriteLine("A. Mr. White and Mr. Black");
            Console.WriteLine("B. Mr. Green and Mr. Blue");
            Console.WriteLine("C. Mr. Red and Mr. Yellow");
            Console.WriteLine("D. Mr. Red and Mr. White");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "B")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
                Question8();
            }
            else if (answer == "A" || answer == "D" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
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
        public static void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("This is they radiation that resulted in the accident that led to Dr. Bruce Banner becoming the Hulk:");
            Messages.LineBreak();
            Console.WriteLine("A. alpha radiation");
            Console.WriteLine("B. beta radiation");
            Console.WriteLine("C. gamma radiation");
            Console.WriteLine("D. neutron radiation");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
                Question9();
            }
            else if (answer == "B" || answer == "D" || answer == "A")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
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
        public static void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine("As of 7/12/2022, this is The Incredible Hulk's Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 57%");
            Console.WriteLine("B. 67%");
            Console.WriteLine("C. 77%");
            Console.WriteLine("D. 87%");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "B")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
                Question10();
            }
            else if (answer == "A" || answer == "D" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
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
        public static void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the Post Credits Scene, this person approaches Thaddeus \"Thunderbolt\" Ross and informs him that a team is being put together:");
            Messages.LineBreak();
            Console.WriteLine("A. Steve Rogers");
            Console.WriteLine("B. Nick Fury");
            Console.WriteLine("C. Tony Stark");
            Console.WriteLine("D. Phil Coulson");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
                GameCompleted();
            }
            else if (answer == "A" || answer == "B" || answer == "D")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore(NameAndScore.Name, NameAndScore.Score);
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
            Messages.LineBreak();
            Console.WriteLine($"Congrats {NameAndScore.Name} on Finishing the Game");
            Console.WriteLine($"Your Final Score is {NameAndScore.Score} out of 10");

            Messages.LineBreak();
            Console.WriteLine("Do you want to try another game or end the program");
            Console.WriteLine("(Y)es or (N)o: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                NameAndScore.Reset();
                PhaseAndTVPresentations.SelectWhichPhaseOrTVShow();
            }
            else
            {
                DisplayMenu.EndGame();
            }
        }
    }
}

