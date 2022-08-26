using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;
using MCUTriviaGame.Services;

namespace MCUTriviaGame.Services
{
    public class MCUTriviaGameConsoleService : ConsoleService
    {
        /************************************************************
           Print methods
       ************************************************************/
        public void PrintLoginMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Welcome to the MCU Trivia Game!");
            Console.WriteLine("Created By: Nicholas Beadling");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: Register");
            Console.WriteLine("0: Exit");
            Console.WriteLine("---------");
        }

        public void PrintMainMenu(string username)
        {
            Console.Clear();
            Console.WriteLine($"Hello, {username}");

            DisplayMenu.MainMenu(); 
        }

        public LoginUser PromptForLogin()
        {
            string username = PromptForString("User name");
            if (String.IsNullOrWhiteSpace(username))
            {
                return null;
            }
            string password = PromptForHiddenString("Password");

            LoginUser loginUser = new LoginUser
            {
                Username = username,
                Password = password
            };
            return loginUser;
        }

        public void DisplayUserScores(List<Score> scores, int requestingAccountId)
        {
            Console.Clear(); 
            Console.WriteLine($"{NameAndScore.Name}'s past scores: ");
            Messages.LineBreak(); 
            foreach(Score score in scores)
            {
                Console.WriteLine($"Movie: {score.MovieName} | Score: {score.UserScore}");
            }
        }

        public void DisplayScoresByGame(List<Score> scores)
        {
            
            Console.Clear();
            Console.WriteLine($"Scores for {NameAndScore.MovieTitle} Trivia Game: ");
            Messages.LineBreak();
            foreach(Score score in scores)
            {
                Console.WriteLine($"Player: {score.Username} : {score.UserScore}");
            }
        }

        public void DisplayUserScoreForGame(List<Score> scores)
        {
            Console.Clear();
            Console.WriteLine($"Here are {NameAndScore.Name} scores for {NameAndScore.MovieTitle} Trivia Game: ");
            Messages.LineBreak();
            int game = 1; 
            foreach(Score score in scores)
            {
                Console.WriteLine($"Game {game}: {score.UserScore}");
                game++; 
            }
        }

        public void DisplayMostRecentScore(Score score)
        {
            Messages.LineBreak();
            Console.WriteLine($"Welcome back {NameAndScore.Name}!");
            Messages.LineBreak();
            if (score.MovieName == "")
            {
                Console.WriteLine("No Game Played Yet");
            }
            else
            {
                Console.WriteLine($"Most Recent Game Played: {score.MovieName} | Score: {score.UserScore}");
            }
            Messages.LineBreak(); 
        }

        public void DisplayReviewsByGame(List<Reviews> reviews)
        {
            Console.Clear();
            Console.WriteLine($"Reviews for {NameAndScore.MovieTitle} trivia game: ");
            Messages.LineBreak(); 
            foreach(Reviews review in reviews)
            {
                Console.WriteLine($"{review.Username} wrote: {review.Review}");
                Messages.LineBreak(); 
            }
        }
    }
}
