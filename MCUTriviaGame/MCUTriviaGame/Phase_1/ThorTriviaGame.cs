﻿using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_1
{
    public class ThorTriviaGame : IQuestions
    {
        public static void ThorStartMenu()
        {
            ThorTriviaGame game = new ThorTriviaGame();
            NameAndScore.MovieTitle = "Thor"; 
            Console.Clear();
            Messages.MovieChoice();
            DisplayMenu.StartTriviaGame(); 

            if (DisplayMenu.StartGame == "Y")
            {
                game.Question1();
            }
            else if (DisplayMenu.StartGame == "B")
            {
                Phase_1MainMenu.SelectAMoive();
            }
            else if (DisplayMenu.StartGame == "E")
            {
                DisplayMenu.EndGame();
            }
            else if (DisplayMenu.StartGame == "S")
            {
                DisplayMenu.DisplayScoreByGame();
                game.BackToThorStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                game.BackToThorStartMenu();
            }
            else if (DisplayMenu.StartGame == "R")
            {
                Reviews.WriteAReview();
            }
            else if (DisplayMenu.StartGame == "L")
            {
                Likes.GetLikes();
            }
            else
            {
                Messages.NotAValidResponse();
                DisplayMenu.StartTriviaGame(); 
            }
        }

        public void BackToThorStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                ThorStartMenu(); 
            }
            else
            {
                DisplayMenu.EndGame();
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
            CorrectAnswers.CorrectAnswerD();
            Question2(); 
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine($"This person directed {NameAndScore.MovieTitle}");
            Messages.LineBreak();
            Console.WriteLine("A. Jon Favreau");
            Console.WriteLine("B. Sam Raimi");
            Console.WriteLine("C. Martin Scorsese");
            Console.WriteLine("D. Kenneth Branagh");
            CorrectAnswers.CorrectAnswerD();
            Question3(); 
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
            CorrectAnswers.CorrectAnswerA();
            Question4(); 
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
            CorrectAnswers.CorrectAnswerC();
            Question5(); 
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine($"{NameAndScore.MovieTitle} made this much at the Box Office");
            Messages.LineBreak();
            Console.WriteLine("A. 439.3 Million");
            Console.WriteLine("B. 449.3 Million");
            Console.WriteLine("C. 459.3 Million");
            Console.WriteLine("D. 469.3 Million");
            CorrectAnswers.CorrectAnswerB();
            Question6(); 
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
            CorrectAnswers.CorrectAnswerC();
            Question7(); 
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
            CorrectAnswers.CorrectAnswerA();
            Question8(); 
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
            CorrectAnswers.CorrectAnswerA();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/12/2022, this is {NameAndScore.MovieTitle}'s Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 57%");
            Console.WriteLine("B. 67%");
            Console.WriteLine("C. 77%");
            Console.WriteLine("D. 87%");
            CorrectAnswers.CorrectAnswerC();
            Question10(); 
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
            CorrectAnswers.CorrectAnswerB();
            NameAndScore.GameCompleted(); 
        }
    }
}
