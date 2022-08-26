using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCUTriviaGameServer.Models;
using System.Data.SqlClient;

namespace MCUTriviaGameServer.DAO
{
    public class ReviewsSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewsSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public Reviews SaveReview(Reviews review)
        {
            int newReviewId = 0; 
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO reviews (username, movie_name, review) " +
                                                "OUTPUT INSERTED.review_id " +
                                                "Values (@username, (SELECT movie_name FROM mcu_movies WHERE movie_name = @movieName), @review);", conn);
                cmd.Parameters.AddWithValue("@username", review.Username);
                cmd.Parameters.AddWithValue("@movieName", review.MovieName);
                cmd.Parameters.AddWithValue("@review", review.Review); 

                newReviewId = Convert.ToInt32(cmd.ExecuteScalar()); 
            }
            return GetReviewByReviewId(newReviewId); 
        }

        public Reviews GetReviewByReviewId(int id)
        {
            Reviews reviews = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From reviews WHERE review_id = @review_id", conn);
                cmd.Parameters.AddWithValue("@review_id", id); 

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reviews = CreateReviewsFromReader(reader); 
                }
            }
            return reviews;
        }

        public List<Reviews> GetReviewByMovie(string movie)
        {
            List<Reviews> reviewByMovieName = new List<Reviews>(); 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT username, movie_name, review " +
                                                "FROM reviews " +
                                                "WHERE movie_name = @movie_name", conn);
                cmd.Parameters.AddWithValue("@movie_name", movie);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Reviews review = CreateReviewsFromReader(reader);
                    reviewByMovieName.Add(review);
                }
            }
            return reviewByMovieName; 
        }
        private Reviews CreateReviewsFromReader(SqlDataReader reader)
        {
            Reviews review = new Reviews();
            review.Username = Convert.ToString(reader["username"]);
            review.MovieName = Convert.ToString(reader["movie_name"]);
            review.Review = Convert.ToString(reader["review"]);

            return review; 
        }
    }
}
