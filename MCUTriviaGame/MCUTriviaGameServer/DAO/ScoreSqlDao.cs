using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCUTriviaGameServer.Models;
using System.Data.SqlClient; 

namespace MCUTriviaGameServer.DAO
{
    public class ScoreSqlDao : IScoreDAO
    {
        private readonly string connectionString;

        public ScoreSqlDao(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public int SaveScoreByCreatingANewGame(string username, string movieName, int userScore, DateTime dayOfGame)
        {
            int newGameId = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO USER_SCORES (username, movie_name, score, date_time) " +
                                                "OUTPUT INSERTED.game_number " +
                                                "VALUES (@username, @movieName, @userScore, @dayOfGame);", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@movieName", movieName);
                cmd.Parameters.AddWithValue("@userScore", userScore);
                cmd.Parameters.AddWithValue("@dayOfGame", dayOfGame); 

                newGameId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return newGameId; 
        }
    }
}
