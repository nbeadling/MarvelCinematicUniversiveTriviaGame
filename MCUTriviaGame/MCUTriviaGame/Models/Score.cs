using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Models
{
    public class Score
    {
       // public int GameNumber { get; set; }

        public int UserScore { get; set; }  

        public string Username { get; set; }

        public string Moviename { get; set; }

        public DateTime TimeOfGame { get; set; }

        public Score()
        {

        }

        public Score(int userScore, string username, string moviename, DateTime timeOfGame)
        {
           //ameNumber = gameNumber;
            UserScore = userScore;
            Username = username;
            Moviename = moviename;
            TimeOfGame = timeOfGame;
        }
    }
}
