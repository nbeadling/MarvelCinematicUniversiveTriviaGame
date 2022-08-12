using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_1
{
    public class TheIncredibleHulkTriviaGame : IQuestions
    {
        public static void TheIncredibleHulkStartMenu()
        {
            TheIncredibleHulkTriviaGame game = new TheIncredibleHulkTriviaGame();
            NameAndScore.MovieTitle = "The Incredible Hulk"; 
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
            Console.WriteLine("This actor plays the Hulk, but is replaced in future films:");
            Messages.LineBreak();
            Console.WriteLine("A. Mark Ruffalo");
            Console.WriteLine("B. Eric Bana");
            Console.WriteLine("C. Edward Norton");
            Console.WriteLine("D. Lou Ferrigno");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question2(); 
        }
        public void Question2()
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

            CorrectAnswers.CorrectAnswerA();
            Question3(); 
        }
        public void Question3()
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

            CorrectAnswers.CorrectAnswerB();
            Question4(); 
        }
        public void Question4()
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

            CorrectAnswers.CorrectAnswerA();
            Question5(); 
        }
        public void Question5()
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

            CorrectAnswers.CorrectAnswerC();
            Question6(); 
        }
        public void Question6()
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

            CorrectAnswers.CorrectAnswerC();
            Question7(); 
        }
        public void Question7()
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

            CorrectAnswers.CorrectAnswerB();
            Question8(); 
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("This is the radiation that resulted in the accident that led to Dr. Bruce Banner becoming the Hulk:");
            Messages.LineBreak();
            Console.WriteLine("A. alpha radiation");
            Console.WriteLine("B. beta radiation");
            Console.WriteLine("C. gamma radiation");
            Console.WriteLine("D. neutron radiation");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question9(); 
        }
        public void Question9()
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

            CorrectAnswers.CorrectAnswerB();
            Question10(); 
        }
        public void Question10()
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

            CorrectAnswers.CorrectAnswerC();
            NameAndScore.GameCompleted(); 
        }
    }
}

