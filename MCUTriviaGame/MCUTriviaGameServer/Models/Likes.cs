namespace MCUTriviaGameServer.Models
{
    public class Likes
    {
        public string MovieName { get; set; }

        public int Like { get; set; }

        public int Dislike { get; set; }

        public Likes()
        {

        }

        public Likes(string movieName, int like, int dislike)
        {
            MovieName = movieName;
            Like = like;
            Dislike = dislike;
        }
    }
}
