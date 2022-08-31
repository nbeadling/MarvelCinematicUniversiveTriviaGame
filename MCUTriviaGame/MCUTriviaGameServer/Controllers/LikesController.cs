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
    [Route("likes")]
    [ApiController]
    [Authorize]
    public class LikesController : ControllerBase
    {
        private ILikeDAO likeDAO; 

        public LikesController(ILikeDAO ilikeDAO)
        {
            this.likeDAO = ilikeDAO;
        }

        [HttpGet("/{game}/likes")]
        public Likes GetLikesByGame(string game)
        {
            game = MovieNameChange(game);
            return likeDAO.GetLikesByMovieName(game);
        }

        [HttpPut("/{game}/likes")]
        public ActionResult<Likes> AddLike(string game, int like)
        {
            like = 1;
            game = MovieNameChange(game);
            Likes likes = likeDAO.GetLikesByMovieName(game);
            likes.Like = likes.Like + like; 
            return likeDAO.AddLike(likes);
        }

        [HttpPut("/{game}/dislikes")]
        public ActionResult<Likes> AddDislike(string game)
        {
            int dislike = 1;
            game = MovieNameChange(game);
            Likes likes = likeDAO.GetLikesByMovieName(game); 
            likes.Dislike = likes.Dislike + dislike;
            return likeDAO.AddDisLike(likes);
        }
        private string MovieNameChange(string game)
        {
            if (game == "Avengers Endgame")
            {
                game = "Avengers: Endgame";
            }
            if (game == "Thor The Dark World")
            {
                game = "Thor: The Dark World";
            }
            if (game == "Avengers Age of Ultron")
            {
                game = "Avengers: Age of Ultron";
            }
            if (game == "Spider-Man Homecoming")
            {
                game = "Spider-Man: Homecoming";
            }
            if (game == "Thor Ragnarok")
            {
                game = "Thor: Ragnarok";
            }
            if (game == "Avengers Infinity War")
            {
                game = "Avengers: Infinity War";
            }
            if (game == "Spider-Man Far From Home")
            {
                game = "Spider-Man: Far From Home";
            }
            if (game == "Spider-Man No Way Home")
            {
                game = "Spider-Man: No Way Home";
            }

            if (game == "Thor Love and Thunder")
            {
                game = "Thor: Love and Thunder";
            }

            return game;
        }
    }
}
