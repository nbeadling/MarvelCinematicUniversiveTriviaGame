using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCUTriviaGameServer.Models;
using System.Data.SqlClient;

namespace MCUTriviaGameServer.DAO
{
    public class LikesSqlDAO : ILikeDAO
    {
        private readonly string connectionString;

        public LikesSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public Likes AddLike(Likes likes)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE likes SET liked = @liked " +
                                                "WHERE movie_name = @movie_name", conn);
                cmd.Parameters.AddWithValue("@movie_name", likes.MovieName);
                cmd.Parameters.AddWithValue("@liked", likes.Like);

                cmd.ExecuteNonQuery();
            }
            return likes;
        }

        public Likes AddDisLike(Likes likes)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE likes SET disliked = @disliked " +
                                                "WHERE movie_name = @movie_name", conn);
                cmd.Parameters.AddWithValue("@movie_name", likes.MovieName);
                cmd.Parameters.AddWithValue("@disliked", likes.Dislike);

                cmd.ExecuteNonQuery();
            }
            return likes;
        }

        public Likes GetLikesByMovieName(string movieName)
        {
            Likes like = new Likes();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM likes WHERE movie_name = @movie_name", conn);
                cmd.Parameters.AddWithValue("@movie_name", movieName); 

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    like = CreateLikeFromReader(reader);  
                }
            }
            return like; 
        }

        private Likes CreateLikeFromReader(SqlDataReader reader)
        {
            Likes likes = new Likes();
            likes.MovieName = Convert.ToString(reader["movie_name"]);
            likes.Like = Convert.ToInt32(reader["liked"]);
            likes.Dislike = Convert.ToInt32(reader["disliked"]);

            return likes; 

        }
    }
}
