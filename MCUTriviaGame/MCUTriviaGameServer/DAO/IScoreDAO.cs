using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCUTriviaGameServer.Models;

namespace MCUTriviaGameServer.DAO
{
    public interface IScoreDAO
    {
       Score SaveScore(Score score);

       Score GetScoreByGameId(int id);

       List<Score> GetScoreByUser(int id);

        List<Score> GetScoreByTriviaGame(string name);
    }
}
