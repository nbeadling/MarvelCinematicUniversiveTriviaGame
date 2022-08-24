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

        public List<Score> GetScoreByUser(int id)
        {
            List<Score> scoreByUser = new List<Score>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT u.username, u.movie_name, u.score " +
                    "FROM user_scores u JOIN mcutriviagame_user m ON m.username = u.username " +
                    "WHERE m.user_id = @user_id;", conn);
                cmd.Parameters.AddWithValue("@user_id", id); 

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Score score = CreateScoreFromReader(reader);
                    scoreByUser.Add(score);
                } 
            }
            return scoreByUser; 
        }
        public Score GetScoreByGameId(int id)
        {
            Score score = null; 
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM user_scores WHERE game_number = @game_number", conn);
                cmd.Parameters.AddWithValue("@game_number", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    score = CreateScoreFromReader(reader);
                }
            }
            return score;
        }

        public List<Score> GetScoreByTriviaGame(string game)
        {
            List<Score> scoreByGame = new List<Score>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT username, score, movie_name " +
                    "FROM user_scores " +
                    "WHERE movie_name = @movie_name;", conn);
                cmd.Parameters.AddWithValue("@movie_name", game);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Score score = CreateScoreFromReader(reader);
                    scoreByGame.Add(score);
                }
            }
            return scoreByGame;
        }
  
        public List<Score>GetUserScoreForTriviaGameByUserIDAndGameTitle(string name, string game)
        {
            List<Score> scoreByGame = new List<Score>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT username, score, movie_name " +
                    "FROM user_scores " +
                    "WHERE username = @username AND movie_name = @movie_name;", conn);
                cmd.Parameters.AddWithValue("@username", name);
                cmd.Parameters.AddWithValue("@movie_name", game);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Score score = CreateScoreFromReader(reader);
                    scoreByGame.Add(score);
                }
            }
            return scoreByGame;
        }
        public Score SaveScore(Score score)
        {
            int newScoreId = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO USER_SCORES (username, movie_name, score) " +
                                                "OUTPUT INSERTED.game_number " +
                                                "VALUES (@username, (Select movie_name FROM mcu_movies WHERE movie_name = @movieName), @userScore);", conn);
                cmd.Parameters.AddWithValue("@username", score.Username);
                cmd.Parameters.AddWithValue("@movieName", score.MovieName);
                cmd.Parameters.AddWithValue("@userScore", score.UserScore);
                //cmd.Parameters.AddWithValue("@dayOfGame", score.DateOfGame);

                newScoreId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return GetScoreByGameId(newScoreId);
        }
        
        public Score GetMostRecentScore(string username)
        {
            Score score = new Score();
            //Score scores = null; 
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT username, movie_name, score " +
                                                "FROM user_most_recent_score " +
                                                "WHERE username = @username;", conn);
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    score = CreateScoreFromReader(reader);
                }
            }
            return score; 
        }
        public Score UpdateScore(Score score)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE user_most_recent_score SET movie_name = @movie_name, score = @score " +
                                                "WHERE username = @username", conn);
                cmd.Parameters.AddWithValue("@username", score.Username);
                cmd.Parameters.AddWithValue("@movie_name", score.MovieName);
                cmd.Parameters.AddWithValue("@score", score.UserScore); 

                cmd.ExecuteNonQuery();
            }
            return score;  
        }

        private Score CreateScoreFromReader(SqlDataReader reader)
        {
            Score score = new Score();
            //score.GameNumber = Convert.ToInt32(reader["game_number"]);
            score.Username = Convert.ToString(reader["username"]);
            score.MovieName = Convert.ToString(reader["movie_name"]);
            score.UserScore = Convert.ToInt32(reader["score"]);
            //score.DateOfGame = Convert.ToDateTime(reader["date_time"]);

            return score; 
        }
    }
}
