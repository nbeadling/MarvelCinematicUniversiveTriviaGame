using System;
using System.Collections.Generic;
using MCUTriviaGameServer.Models; 

namespace MCUTriviaGameServer.DAO
{
    public interface IReviewDAO
    {
        Reviews SaveReview(Reviews review);
    }
}
