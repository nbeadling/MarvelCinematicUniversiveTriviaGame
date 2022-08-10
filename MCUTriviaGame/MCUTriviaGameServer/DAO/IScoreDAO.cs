using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCUTriviaGameServer.Models;

namespace MCUTriviaGameServer.DAO
{
    public interface IScoreDAO
    {
        int SaveScoreByCreatingANewGame(string username, string movieName, int userScore, DateTime dayOfGame);
    }
}
