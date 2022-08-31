using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_3
{
    public class CaptainMarvelTriviaGame : IQuestions
    {
        public static void CaptainMarvelStartMenu()
        {
            CaptainMarvelTriviaGame game = new CaptainMarvelTriviaGame();
            NameAndScore.MovieTitle = "Captain Marvel";
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
            else if (DisplayMenu.StartGame == "S")
            {
                DisplayMenu.DisplayScoreByGame();
                game.BackToCaptainMarvelStartMenu(); 
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                game.BackToCaptainMarvelStartMenu(); 
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

        public void BackToCaptainMarvelStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                CaptainMarvelStartMenu(); 
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
            Console.WriteLine("Captain Marvel takes place in this year");
            Messages.LineBreak();
            Console.WriteLine("A. 1992");
            Console.WriteLine("B. 1993");
            Console.WriteLine("C. 1994");
            Console.WriteLine("D. 1995");
            CorrectAnswers.CorrectAnswerD();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine("Captain Marvel is directed by this film duo");
            Messages.LineBreak();
            Console.WriteLine("A. Anna Boden & Ryan Fleck");
            Console.WriteLine("B. Joel Coen & Ethan Coen");
            Console.WriteLine("C. Joe Berlinger & Bruce Sinofsky");
            Console.WriteLine("D. Phil Lord & Chris Miller");
            CorrectAnswers.CorrectAnswerA();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Captain Marvel is on this species capital planet of Hala");
            Messages.LineBreak();
            Console.WriteLine("A. Kree");
            Console.WriteLine("B. Skrull");
            Console.WriteLine("C. Chitauri");
            Console.WriteLine("D. Celestials");
            CorrectAnswers.CorrectAnswerA();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("Captain Marvel crash-lands on Earth in Los Angeles in a store of this defunct business");
            Messages.LineBreak();
            Console.WriteLine("A. BlockBuster");
            Console.WriteLine("B. Circuit City");
            Console.WriteLine("C. Sports Authority");
            Console.WriteLine("D. Tower Records");
            CorrectAnswers.CorrectAnswerA();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Messages.BoxOfficeQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. 1.028 Billion");
            Console.WriteLine("B. 1.128 Billion");
            Console.WriteLine("C. 1.228 Billion");
            Console.WriteLine("D. 1.328 Billion");
            CorrectAnswers.CorrectAnswerB();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Captain Marvel discovers that she was a part of this military branch and died in a training accident in 1989");
            Messages.LineBreak();
            Console.WriteLine("A. Navy");
            Console.WriteLine("B. Marines");
            Console.WriteLine("C. Air Force");
            Console.WriteLine("D. Army");
            CorrectAnswers.CorrectAnswerC();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Captain Marvel learns her real name is Carol Danvers after going to Louisiana and reuniting with this person");
            Messages.LineBreak();
            Console.WriteLine("A. Wendy Lawson");
            Console.WriteLine("B. Monica Rambeau");
            Console.WriteLine("C. Maria Rambeau");
            Console.WriteLine("D. Goose");
            CorrectAnswers.CorrectAnswerC();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("The final battle involves this item that holds an Infinity Stone and a villian from a previous movie");
            Messages.LineBreak();
            Console.WriteLine("A. Thanos and the Infinity Gauntlet");
            Console.WriteLine("B. Malekith and Aether");
            Console.WriteLine("C. Ultron and Vision");
            Console.WriteLine("D. Ronan the Accuser and the Tesseract");
            CorrectAnswers.CorrectAnswerD();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/18/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 89%");
            Console.WriteLine("B. 79%");
            Console.WriteLine("C. 69%");
            Console.WriteLine("D. 59%");
            CorrectAnswers.CorrectAnswerB();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("At the End of the film, Captain Marvel gives Nick Fury this to contact her in the case of an emergency, which then leads to the mid credits scene where the Avengers are monitoring it after Fury activates it after the snap from Avengers: Infinity War");
            Messages.LineBreak();
            Console.WriteLine("A. Cell Phone");
            Console.WriteLine("B. Fax Machine");
            Console.WriteLine("C. Pager");
            Console.WriteLine("D. Nothing");
            CorrectAnswers.CorrectAnswerC();
            NameAndScore.GameCompleted();
        }
    }
}
