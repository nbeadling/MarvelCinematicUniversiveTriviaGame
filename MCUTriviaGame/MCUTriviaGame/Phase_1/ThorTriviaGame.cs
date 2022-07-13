﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_1
{
    public class ThorTriviaGame : IQuestions
    {
        public static void ThorStartMenu()
        {
            ThorTriviaGame game = new ThorTriviaGame();

            Console.Clear();
            Console.WriteLine("You have chosen to test your knowledge on the film Thor (2011)");
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
            Console.WriteLine("This Hemsworth portrays the God of Thunder");
            Messages.LineBreak();
            Console.WriteLine("A. Luke Hemsworth");
            Console.WriteLine("B. Liam Hemsworth");
            Console.WriteLine("C. Craig Hemsworth");
            Console.WriteLine("D. Chris Hemsworth");
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
                Messages.LineBreak();
                Question2();
            }
            else if (answer == "C" || answer == "A" || answer == "B")
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
            Console.WriteLine("This person directed Thor");
            Messages.LineBreak();
            Console.WriteLine("A. Jon Favreau");
            Console.WriteLine("B. Sam Raimi");
            Console.WriteLine("C. Martin Scorsese");
            Console.WriteLine("D. Kenneth Branagh");
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
            Console.WriteLine("This Actor stars as Loki");
            Messages.LineBreak();
            Console.WriteLine("A. Tom Hiddleston");
            Console.WriteLine("B. Stellan Skarsgard");
            Console.WriteLine("C. Idris Elba");
            Console.WriteLine("D. Anthony Hopkins");
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
                Question4();
            }
            else if (answer == "D" || answer == "B" || answer == "C")
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
            Console.WriteLine("Thor lands on Earth in this state");
            Messages.LineBreak();
            Console.WriteLine("A. Arizona");
            Console.WriteLine("B. Texas");
            Console.WriteLine("C. New Mexico");
            Console.WriteLine("D. Nevada");
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
            Console.WriteLine("Thor made this much at the Box Office:");
            Messages.LineBreak();
            Console.WriteLine("A. 439.3 Million");
            Console.WriteLine("B. 449.3 Million");
            Console.WriteLine("C. 459.3 Million");
            Console.WriteLine("D. 469.3 Million");
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
            Console.WriteLine("This Actress portrays Thor's Love Interest Dr. Jane Foster");
            Messages.LineBreak();
            Console.WriteLine("A. Kat Dennings");
            Console.WriteLine("B. Rene Russo");
            Console.WriteLine("C. Natalie Portman");
            Console.WriteLine("D. Mila Kunis");
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
            Console.WriteLine("In the film, Loki discovers that he is adopted and this is his actual father");
            Messages.LineBreak();
            Console.WriteLine("A. Laufey");
            Console.WriteLine("B. Gorr The God Butcher");
            Console.WriteLine("C. Malektith");
            Console.WriteLine("D. Enchantress");
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
                Question8();
            }
            else if (answer == "D" || answer == "B" || answer == "C")
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
            Console.WriteLine("Which one of the below is not a part of the Warriors Three");
            Messages.LineBreak();
            Console.WriteLine("A. Sif");
            Console.WriteLine("B. Volstagg");
            Console.WriteLine("C. Fandral");
            Console.WriteLine("D. Hogun");
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
                Question9();
            }
            else if (answer == "B" || answer == "C" || answer == "D")
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
            Console.WriteLine("As of 7/13/2022, this is Thor's Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 57%");
            Console.WriteLine("B. 67%");
            Console.WriteLine("C. 77%");
            Console.WriteLine("D. 87%");
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
            Console.WriteLine("In the Post Credits Scene, Nick Fury shows this person The Tesseract, however unknown to Fury, this person is being controlled by Loki");
            Messages.LineBreak();
            Console.WriteLine("A. Dr. Jane Foster");
            Console.WriteLine("B. Erik Selvig");
            Console.WriteLine("C. Darcy Lewis");
            Console.WriteLine("D. Phil Coulson");
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
            Messages.LineBreak();
            Messages.GameCompleted();

            Messages.LineBreak();
            Messages.NewGame();
        }
    }
}
