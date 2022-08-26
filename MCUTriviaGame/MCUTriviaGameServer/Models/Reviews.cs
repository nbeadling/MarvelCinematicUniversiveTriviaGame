namespace MCUTriviaGameServer.Models
{
    public class Reviews
    {
        public int ReviewId { get; set; }

        public string Username { get; set; }

        public string MovieName { get; set; }   

        public string Review { get; set; }

        public Reviews()
        {

        }

        public Reviews(string username, string movieName, string review)
        {
            Username = username;
            MovieName = movieName;
            Review = review;
        }
    }
}
