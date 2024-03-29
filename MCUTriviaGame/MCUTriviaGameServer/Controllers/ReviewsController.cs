﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCUTriviaGameServer.DAO;
using MCUTriviaGameServer.Models;
using Microsoft.AspNetCore.Authorization;

namespace MCUTriviaGameServer.Controllers
{
    [Route("reviews")]
    [ApiController]
    [Authorize]
    public class ReviewsController : Controller
    {
        private IReviewDAO reviewDAO; 

        public ReviewsController(IReviewDAO reviewDAO)
        {
            this.reviewDAO = reviewDAO;
        }

        [HttpPost()]
        public ActionResult<Reviews> CreateReview(Reviews review)
        {
            string username = User.Identity.Name;
            review.Username = username;
            Reviews added = reviewDAO.SaveReview(review);
            return Created($"/reviews/{added.Review}", added);
        }

        [HttpGet("/{game}/reviews")]
        public List<Reviews> GetReviewsByGame(string game)
        {
            game = MovieNameChange(game); 
            return reviewDAO.GetReviewByMovie(game);
        }

        [HttpDelete("/reviews/{game}")]
        public ActionResult DeleteReview(string game)
        {
            string username = User.Identity.Name;
            game = MovieNameChange(game); 

            List<Reviews> existingReviews = reviewDAO.GetReviewByMovie(game); 
            if(existingReviews == null)
            {
                return NotFound(); 
            }
            bool result = reviewDAO.Delete(username, game);
            if (result)
            {
                return NoContent(); 
            }
            return StatusCode(500); 
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
