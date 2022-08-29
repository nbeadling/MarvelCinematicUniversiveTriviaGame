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
    [Route("scores")]
    [ApiController]
    [Authorize]
    public class ScoreController : ControllerBase
    {
        private IScoreDAO scoreDAO;

        public ScoreController(IScoreDAO scoreDAO)
        {
            this.scoreDAO = scoreDAO;
        }

        [HttpGet("{id}")]
        public Score GetScore(int id)
        {
            return scoreDAO.GetScoreByGameId(id); 
        }

        [HttpGet("/users/scores")]
        public ActionResult<List<Score>> GetScoreByUserId()
        {
            string userId = User.FindFirst("sub")?.Value;

            int userIdNumber = Convert.ToInt32(userId);

            return scoreDAO.GetScoreByUser(userIdNumber); 
        }

        [HttpGet("/{users}/{game}/scores")]

        public List<Score> GetUserScoreForTriviaGameByUserIDAndGameTitle(string name, string game)
        {
            name = User.Identity.Name; 
            return scoreDAO.GetUserScoreForTriviaGameByUserIDAndGameTitle(name, game); 
        }


        [HttpGet("/{game}/scores")]
        public List<Score> GetScoreByGame(string game)
        {
            if(game == "Avengers Endgame")
            {
                game = "Avengers: Endgame"; 
            }
            if(game == "Thor The Dark World")
            {
                game = "Thor: The Dark World"; 
            }
            if(game == "Avengers Age of Ultron")
            {
                game = "Avengers: Age of Ultron";
            }
            if(game == "Spider-Man Homecoming")
            {
                game = "Spider-Man: Homecoming"; 
            }
            if(game == "Thor Ragnarok")
            {
                game = "Thor: Ragnarok";
            }
            if(game == "Avengers Infinity War")
            {
                game = "Avengers: Infinity War"; 
            }
            if(game == "Spider-Man Far From Home")
            {
                game = "Spider-Man: Far From Home";
            }
            if(game == "Spider Man No Way Home")
            {
                game = "Spider-Man: No Way Home"; 
            }
            return scoreDAO.GetScoreByTriviaGame(game);
        }

        [HttpPost()]

        public ActionResult<Score> SaveScore(Score score)
        {
            Score added = scoreDAO.SaveScore(score);
            return Created($"/scores/{added.UserScore}", added);
        }

        [HttpPut("/{users}")]
        public ActionResult<Score> UpdateMostRecentScore(Score score)
        {
            score.Username = User.Identity.Name;

            scoreDAO.UpdateScore(score);
            return Ok(score);   
        }
       
        [HttpGet("/{users}")]
        public ActionResult<Score> GetMostRecentScore(string username)
        {
           
            username = User.Identity.Name; 

            Score score = scoreDAO.GetMostRecentScore(username);
            return Ok(score); 
        }
       
    }
}
