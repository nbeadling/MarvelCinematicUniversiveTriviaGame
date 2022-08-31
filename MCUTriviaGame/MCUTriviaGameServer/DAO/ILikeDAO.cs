using System;
using System.Collections.Generic;
using MCUTriviaGameServer.Models;


namespace MCUTriviaGameServer.DAO
{
    public interface ILikeDAO
    {
        Likes AddLike(Likes likes);

        Likes AddDisLike(Likes likes);

        Likes GetLikesByMovieName(string movieName); 

    }
}
