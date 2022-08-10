using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;
using MCUTriviaGame.Services;

namespace MCUTriviaGame
{
    public class NameAndScore
    {
        public static string Name { get; set; }

        public static int Score { get; set; } = 0;

        public static string MovieTitle { get; set; }

        public void GetName()
        {
            MCUApiService mcuAPIService = new MCUApiService(Name);
            Name = mcuAPIService.Username;
        }
        public static void DisplayNameAndScore()
        {
            Console.WriteLine($"Player: {Name} | Score: {Score}");
        }
        public static void CorrectAnswerAddPoint()
        {
            Score++;
        }

        public static void Reset()
        {
            Score = 0;
        }

        public static void GameCompleted()
        {
            AuditLog.WriteFiles(Name, MovieTitle, Score);
            Messages.LineBreak();
            Messages.GameCompleted();

            Messages.LineBreak();
            Messages.NewGame();
        }
    }
}
