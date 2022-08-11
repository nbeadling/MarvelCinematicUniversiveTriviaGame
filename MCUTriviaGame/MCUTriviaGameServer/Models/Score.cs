using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCUTriviaGameServer.Models
{
    public class Score
    {
       // public int GameNumber { get; set; }

        public string Username { get; set; }

        public string MovieName { get; set; }

        public int UserScore { get; set; }

        public DateTime DateOfGame {get; set;}

        public Score(/*int gameNumber,*/string username, string movieName, int userScore, DateTime dateOfGame)
        {
            //GameNumber = gameNumber;
            Username = username;
            MovieName = movieName;
            UserScore = userScore;
            DateOfGame = dateOfGame;
        }

        public Score()
        {

        }
    }
}
