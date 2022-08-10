using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCUTriviaGameServer.DAO;
using MCUTriviaGameServer.Models;
using Microsoft.AspNetCore.Authorization;

namespace MCUTriviaGameServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private IScoreDAO scoreDAO; 
       
        public ScoreController(IScoreDAO scoreDAO)
        {
            this.scoreDAO = scoreDAO;
        }

        [HttpPost("create")]

        public int SaveScoreByCreatingANewGame(Score score)
        {
            //int gameNumber = score.GameNumber;
            string username = score.Username;
            string moviename = score.MovieName;
            int userScore = score.UserScore;
            DateTime timeOfGame = score.DateOfGame;

            int gameNumber = scoreDAO.SaveScoreByCreatingANewGame(username, moviename, userScore, timeOfGame);

            return gameNumber; 
        }
    }
}
