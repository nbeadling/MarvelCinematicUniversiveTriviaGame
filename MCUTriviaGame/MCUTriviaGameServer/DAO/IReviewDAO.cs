using System;
using System.Collections.Generic;
using MCUTriviaGameServer.Models; 

namespace MCUTriviaGameServer.DAO
{
    public interface IReviewDAO
    {
        Reviews SaveReview(Reviews review);

        Reviews GetReviewByReviewId(int reviewId);

        List<Reviews> GetReviewByMovie(string movieName);
    }
}
