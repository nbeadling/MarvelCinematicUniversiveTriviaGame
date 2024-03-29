﻿using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Phase_1;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_1
{
    public class IronManTriviaGame : IQuestions
    {
        public static void IronManGameStartMenu()
        {
            IronManTriviaGame game = new IronManTriviaGame();
            NameAndScore.MovieTitle = "Iron Man"; 
            Console.Clear();
            Messages.MovieChoice();
            DisplayMenu.StartTriviaGame(); 

            if(DisplayMenu.StartGame == "Y")
            {
                game.Question1(); 
            }
            else if(DisplayMenu.StartGame == "B")
            {
                Phase_1MainMenu.SelectAMoive(); 
            }
            else if(DisplayMenu.StartGame == "E")
            {
                DisplayMenu.EndGame(); 
            }
            else if(DisplayMenu.StartGame == "S")
            {
                DisplayMenu.DisplayScoreByGame();
                game.BackToIronManStartMenu(); 
            }
            else if(DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                game.BackToIronManStartMenu();
            }
            else if(DisplayMenu.StartGame == "R")
            {
                Reviews.WriteAReview(); 
            }
            else if(DisplayMenu.StartGame == "L")
            {
                Likes.GetLikes(); 
            }
            else
            {
                Messages.NotAValidResponse();
                DisplayMenu.StartTriviaGame(); 
            }
        }

        public void BackToIronManStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                IronManGameStartMenu(); 
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
            Console.WriteLine("This actor stars at the title character:");
            Messages.LineBreak();
            Console.WriteLine("A. Robert Downey Jr.");
            Console.WriteLine("B. Nicolas Cage");
            Console.WriteLine("C. Tom Cruise");
            Console.WriteLine("D. Rob Lowe");
            CorrectAnswers.CorrectAnswerA();
            Question2(); 
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine($"This actor directed {NameAndScore.MovieTitle}");
            Messages.LineBreak();
            Console.WriteLine("A. Vince Vaughn");
            Console.WriteLine("B. Jeremy Piven");
            Console.WriteLine("C. Ron Livingston");
            Console.WriteLine("D. Jon Favreau");
            CorrectAnswers.CorrectAnswerD(); 
            Question3(); 
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Jeff Bridges plays this main villian in the film");
            Messages.LineBreak();
            Console.WriteLine("A. Obadiah Stone");
            Console.WriteLine("B. Obadiah Crane");
            Console.WriteLine("C. Obadiah Stark");
            Console.WriteLine("D. Obadiah Stane");
            CorrectAnswers.CorrectAnswerD();
            Question4(); 
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This actor played James \"Rhodey\" Rhodes, but would not return to the role in any other MCU movie");
            Messages.LineBreak();
            Console.WriteLine("A. Don Cheadle");
            Console.WriteLine("B. Terrence Howard");
            Console.WriteLine("C. Tim Meadows");
            Console.WriteLine("D. Cuba Gooding Jr.");
            CorrectAnswers.CorrectAnswerB();
            Question5(); 
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine($"{NameAndScore.MovieTitle} Made This Much at The Box Office");
            Messages.LineBreak();
            Console.WriteLine("A. 140.8 Million");
            Console.WriteLine("B. 580.8 Million");
            Console.WriteLine("C. 585.8 Million");
            Console.WriteLine("D. 600.8 Million");
            CorrectAnswers.CorrectAnswerC();
            Question6(); 
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("The Group That Captures Tony at the beginning of the film goes by this name");
            Messages.LineBreak();
            Console.WriteLine("A. The Ten Rings");
            Console.WriteLine("B. The Five Rings");
            Console.WriteLine("C. The Fifteen Rings");
            Console.WriteLine("D. The Twenty Rings");
            CorrectAnswers.CorrectAnswerA();
            Question7(); 
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("This AC/DC song is played at the beginning of the Film and this Black Sabbath Song Plays over the credits");
            Messages.LineBreak();
            Console.WriteLine("A. You shook me all Night Long and Iron Man");
            Console.WriteLine("B. Shoot To Thrill and Iron Man");
            Console.WriteLine("C. Back in Black and Iron Man");
            Console.WriteLine("D. Back in Black and Paranoid");
            CorrectAnswers.CorrectAnswerC();
            Question8(); 
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("Tony Stark uses this to power his Iron Man Suit and to prevent shrapnel from reaching his heart");
            Messages.LineBreak();
            Console.WriteLine("A. Arch Reactor");
            Console.WriteLine("B. J.A.R.V.I.S.");
            Console.WriteLine("C. Nothing");
            Console.WriteLine("D. S.H.I.E.L.D.");
            CorrectAnswers.CorrectAnswerA();
            Question9(); 
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/11/2022, this is {NameAndScore.MovieTitle}'s Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 64%");
            Console.WriteLine("B. 74%");
            Console.WriteLine("C. 84%");
            Console.WriteLine("D. 94%");
            CorrectAnswers.CorrectAnswerD();
            Question10(); 
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the Post Credits Scene, this actor appears as S.H.I.E.L.D. Directory Nick Fury to discuss the Avengers Initiative");
            Messages.LineBreak();
            Console.WriteLine("A. Will Smith");
            Console.WriteLine("B. Eddie Murphy");
            Console.WriteLine("C. Denzel Washington");
            Console.WriteLine("D. Samuel L. Jackson");
            CorrectAnswers.CorrectAnswerD();
            NameAndScore.GameCompleted(); 
        }
    }
}
