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

        [HttpPost()]

        public ActionResult<Score> SaveScore(Score score)
        {
            Score added = scoreDAO.SaveScore(score);
            return Created($"/scores/{added.UserScore}", added);
        }
       
       
    }
}
