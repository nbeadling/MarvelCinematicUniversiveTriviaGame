using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_2
{
    public class ThorTheDarkWorldTriviaGame : IQuestions
    {
        public static void ThorTheDarkWorldStartMenu()
        {
            ThorTheDarkWorldTriviaGame game = new ThorTheDarkWorldTriviaGame();
            NameAndScore.MovieTitle = "Thor: The Dark World"; 
            Console.Clear();
            Messages.MovieChoice();
            DisplayMenu.StartTriviaGame();

            if (DisplayMenu.StartGame == "Y")
            {
                game.Question1();
            }
            else if (DisplayMenu.StartGame == "B")
            {
                Phase_2MainMenu.SelectAMoive();
            }
            else if (DisplayMenu.StartGame == "E")
            {
                DisplayMenu.EndGame();
            }
            else if (DisplayMenu.StartGame == "S")
            {
                NameAndScore.MovieTitle = "Thor The Dark World"; 
                DisplayMenu.DisplayScoreByGame();
                BackToThorTheDarkWorldStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                BackToThorTheDarkWorldStartMenu(); 
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

        public static void BackToThorTheDarkWorldStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                ThorTheDarkWorldStartMenu(); 
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
            Console.WriteLine("Thor The Dark World begins with the story of Bor, the father of Odin, defeating the Dark Elf Malekith, who seeks to unleash a weapon known as the Aether, which is the introduction to this infinity stone");
            Messages.LineBreak();
            Console.WriteLine("A. Power Stone");
            Console.WriteLine("B. Reality Stone");
            Console.WriteLine("C. Space Stone");
            Console.WriteLine("D. Mind Stone");
            CorrectAnswers.CorrectAnswerB();
            Question2(); 
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine($"This person directed {NameAndScore.MovieTitle}");
            Messages.LineBreak();
            Console.WriteLine("A. Alan Taylor");
            Console.WriteLine("B. David Chase");
            Console.WriteLine("C. David Simon");
            Console.WriteLine("D. Joss Whedon");
            CorrectAnswers.CorrectAnswerA();
            Question3(); 
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Thor leans of the Convergenace, which is the aligment of all the Realms, How many realms are there?");
            Messages.LineBreak();
            Console.WriteLine("A. Seven");
            Console.WriteLine("B. Eight");
            Console.WriteLine("C. Nine");
            Console.WriteLine("D. Ten");
            CorrectAnswers.CorrectAnswerC();
            Question4(); 
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This actor plays the main villian Malekith");
            Messages.LineBreak();
            Console.WriteLine("A. Zachary Levi");
            Console.WriteLine("B. Ray Stevenson");
            Console.WriteLine("C. Adewale Akinnuoye-Agbaje");
            Console.WriteLine("D. Christopher Eccleston");
            CorrectAnswers.CorrectAnswerD();
            Question5(); 
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine($"{NameAndScore.MovieTitle} made this much at the Box Office:");
            Messages.LineBreak();
            Console.WriteLine("A. 624.8 Million");
            Console.WriteLine("B. 634.8 Million");
            Console.WriteLine("C. 644.8 Million");
            Console.WriteLine("D. 654.8 Million");
            CorrectAnswers.CorrectAnswerC();
            Question6(); 
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("This human is taken to Asgard after absorbing the Aether");
            Messages.LineBreak();
            Console.WriteLine("A. Jane Foster");
            Console.WriteLine("B. Erik Selvig");
            Console.WriteLine("C. Kat Dennings");
            Console.WriteLine("D. Tony Stark");
            CorrectAnswers.CorrectAnswerA();
            Question7(); 
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Malekith Kills this person who is close to Thor");
            Messages.LineBreak();
            Console.WriteLine("A. Loki");
            Console.WriteLine("B. Jane Foster");
            Console.WriteLine("C. Frigga");
            Console.WriteLine("D. Odin");
            CorrectAnswers.CorrectAnswerC();
            Question8(); 
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("When Thor Declines the throne to Odin, it is revealed this person is impersonating Odin");
            Messages.LineBreak();
            Console.WriteLine("A. Thanos");
            Console.WriteLine("B. Loki");
            Console.WriteLine("C. Odin");
            Console.WriteLine("D. Erik Selvig");
            CorrectAnswers.CorrectAnswerB();
            Question9(); 
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/12/2022, this is {NameAndScore.MovieTitle}'s Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 46%");
            Console.WriteLine("B. 56%");
            Console.WriteLine("C. 66%");
            Console.WriteLine("D. 76%");
            CorrectAnswers.CorrectAnswerC();
            Question10(); 
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the mid credits scene, Volstagg and Sif entrust the Aether to this person");
            Messages.LineBreak();
            Console.WriteLine("A. The Collector");
            Console.WriteLine("B. Nick Fury");
            Console.WriteLine("C. Thanos");
            Console.WriteLine("D. Tony Stark");
            CorrectAnswers.CorrectAnswerA();
            NameAndScore.GameCompleted(); 
        }
    }
}
