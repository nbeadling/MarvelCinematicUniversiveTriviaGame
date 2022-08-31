using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_3
{
    public class ThorRagnarokTriviaGame : IQuestions
    {
        public static void ThorRagnarokStartMenu()
        {
            ThorRagnarokTriviaGame game  = new ThorRagnarokTriviaGame();
            NameAndScore.MovieTitle = "Thor: Ragnarok";
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
                NameAndScore.MovieTitle = "Thor Ragnarok";
                DisplayMenu.DisplayScoreByGame();
                game.BackToThorRagnarokStartMenu(); 
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                game.BackToThorRagnarokStartMenu(); 
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

        public void BackToThorRagnarokStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                ThorRagnarokStartMenu(); 
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
            Console.WriteLine("The film begins with Thor imprisoned by this fire demon who reveals that Ragnarok is incoming");
            Messages.LineBreak();
            Console.WriteLine("A. Thanos");
            Console.WriteLine("B. Gorr");
            Console.WriteLine("C. Apollo");
            Console.WriteLine("D. Surtur");
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
            Console.WriteLine("A. Kenneth Branagh");
            Console.WriteLine("B. Alan Taylor");
            Console.WriteLine("C. Taika Waititi");
            Console.WriteLine("D. James Gunn");
            CorrectAnswers.CorrectAnswerC();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Thor goes to Asgard and finds this person posing as Odin");
            Messages.LineBreak();
            Console.WriteLine("A. Heimdall");
            Console.WriteLine("B. Loki");
            Console.WriteLine("C. Skurge");
            Console.WriteLine("D. None of the Above");
            CorrectAnswers.CorrectAnswerB();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("Thor and Loki discover they have a sister Hela who is portrayed by this acclaimed actress");
            Messages.LineBreak();
            Console.WriteLine("A. Cate Blanchett");
            Console.WriteLine("B. Kate Winslet");
            Console.WriteLine("C. Amy Adams");
            Console.WriteLine("D. Hilary Swank");
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
            Console.WriteLine("A. 554 Million");
            Console.WriteLine("B. 654 Million");
            Console.WriteLine("C. 754 Million");
            Console.WriteLine("D. 854 Million");
            CorrectAnswers.CorrectAnswerD();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Hela Destroyes this weapon");
            Messages.LineBreak();
            Console.WriteLine("A. Mjolnir");
            Console.WriteLine("B. Thor's Helmet");
            Console.WriteLine("C. Thor's Cape");
            Console.WriteLine("D. Stormbreaker");
            CorrectAnswers.CorrectAnswerA();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Thor reunites with an old friend from work after the Grandmaster, who is portrayed by this actor, forces them to fight");
            Messages.LineBreak();
            Console.WriteLine("A. Captain America and Christian Bale");
            Console.WriteLine("B. Hulk and Jeff Goldblum");
            Console.WriteLine("C. Iron Man and Josh Brolin");
            Console.WriteLine("D. Vision and John C. Reilly");
            CorrectAnswers.CorrectAnswerB();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("With the help of Banner and Valkyrie (Played by this Actress), Thor realizes to stop Hela, Ragnarok needs to happen on this planet");
            Messages.LineBreak();
            Console.WriteLine("A. Zoe Saldana and Earth");
            Console.WriteLine("B. Tessa Thompson and Asgard");
            Console.WriteLine("C. Taraji P. Henson and Earth");
            Console.WriteLine("D. Janelle Monae and Asgard");
            CorrectAnswers.CorrectAnswerB();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/14/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 93%");
            Console.WriteLine("B. 83%");
            Console.WriteLine("C. 73%");
            Console.WriteLine("D. 63%");
            CorrectAnswers.CorrectAnswerA();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the mid-credits scene, the ship the surviving Asgardians are on is intercepted by a large spacecraft led by this person");
            Messages.LineBreak();
            Console.WriteLine("A. Gorr The God Butcher");
            Console.WriteLine("B. Thanos");
            Console.WriteLine("C. Kang The Conqueror");
            Console.WriteLine("D. Malekith");
            CorrectAnswers.CorrectAnswerB();
            NameAndScore.GameCompleted();
        }
    }
}
