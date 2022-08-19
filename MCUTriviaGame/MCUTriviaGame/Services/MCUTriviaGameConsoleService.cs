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
            //NameAndScore nameAndScore = new NameAndScore();
            //Account account = new Account(); 
            Console.Clear(); 
            Console.WriteLine($"{NameAndScore.Name}'s past scores: ");
            Messages.LineBreak(); 
            foreach(Score score in scores)
            {
                Console.WriteLine($"Movie: {score.MovieName} | Score: {score.UserScore}");
            }
        }
    }
}
