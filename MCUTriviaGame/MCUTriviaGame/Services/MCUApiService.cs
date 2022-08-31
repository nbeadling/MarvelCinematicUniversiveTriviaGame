using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;
using MCUTriviaGame.Services;

namespace MCUTriviaGame.Services
{
    public class MCUApiService : AuthenticatedApiService
    {
        public readonly string ApiUrl;

        public MCUApiService()
        {

        }

        public MCUApiService(string apiUrl) : base(apiUrl) { }

        // Add methods to call api here...
        public List<Account> GetAccounts()
        {
            RestRequest request = new RestRequest("accounts");
            IRestResponse<List<Account>> response = client.Get<List<Account>>(request);

            CheckForError(response);
            return response.Data;

        }

        public Account GetMyAccount()
        {
            RestRequest request = new RestRequest("/accounts/myaccount");
            IRestResponse<Account> response = client.Get<Account>(request);

            CheckForError(response);
            return response.Data;
        }

        public Account GetAccountByUserId(int id)
        {
            RestRequest request = new RestRequest($"/accounts/users/{id}");
            IRestResponse<Account> response = client.Get<Account>(request);

            CheckForError(response);
            return response.Data;
        }
        public List<Users> GetAllUsers()
        {
            RestRequest request = new RestRequest("users");
            IRestResponse<List<Users>> response = client.Get<List<Users>>(request);

            CheckForError(response);
            return response.Data;
        }

        public Score SaveScore(Score newScore)
        {
            RestRequest request = new RestRequest("scores");
            request.AddJsonBody(newScore);
            IRestResponse<Score> response = client.Post<Score>(request);

            CheckForError(response);
            return response.Data;
        }

        public List<Score> GetScoreByUserId()
        {
            RestRequest request = new RestRequest($"users/scores");
            IRestResponse<List<Score>> response = client.Get<List<Score>>(request);

            CheckForError(response);
            return response.Data;
        }

        public List<Score> GetScoreByGame(string game)
        {
            RestRequest request = new RestRequest($"{game}/scores");
            IRestResponse<List<Score>> response = client.Get<List<Score>>(request);

            CheckForError(response);
            return response.Data;
        }

        public List<Score> GetScoreForUserByGame(string users, string game)
        {
            RestRequest request = new RestRequest($"{users}/{game}/scores");
            IRestResponse<List<Score>> response = client.Get<List<Score>>(request);

            CheckForError(response);
            return response.Data; 
        }

        //public ApiUser Login(LoginUser loginUser)
        //{
        //    RestRequest request = new RestRequest("login");
        //    request.AddJsonBody(loginUser);
        //    IRestResponse<ApiUser> response = client.Post<ApiUser>(request);

        //    CheckForError(response);
        //    user = response.Data;
        //    client.Authenticator = new JwtAuthenticator(user.Token);
        //    return response.Data;
        //}

        public Score GetScoreByGameId(int gameId)
        {
            RestRequest request = new RestRequest($"scores/{gameId}");
            IRestResponse<Score> response = client.Get<Score>(request);

            CheckForError(response);
            return response.Data;
        }

        public Score UpdateMostRecentGame(Score score)
        {
            RestRequest request = new RestRequest($"{score.Username}");
            request.AddJsonBody(score);
            IRestResponse<Score> response = client.Put<Score>(request);

            CheckForError(response);
            return response.Data; 
        }

        public Likes AddLike(Likes like)
        {
            string movieName = ChangeMovieNameSoItGoesToTheServer(NameAndScore.MovieTitle);
            RestRequest request = new RestRequest($"{movieName}/likes");
            IRestResponse<Likes> response = client.Put<Likes>(request);

            CheckForError(response);
            return response.Data;
        }

        public Likes AddDisLike(Likes like)
        {
            string movieName = ChangeMovieNameSoItGoesToTheServer(NameAndScore.MovieTitle);
            RestRequest request = new RestRequest($"{movieName}/dislikes");
            IRestResponse<Likes> response = client.Put<Likes>(request);

            CheckForError(response);
            return response.Data;
        }
        public Score GetMostRecentScore(string users)
        {
            
            //string users = score.Username;
            RestRequest request = new RestRequest($"{users}");
            IRestResponse<Score> response = client.Get<Score>(request);

            CheckForError(response);
            return response.Data; 
        }

        public Reviews SaveReview(Reviews review)
        {
            RestRequest request = new RestRequest("reviews"); 
            request.AddJsonBody(review);
            IRestResponse<Reviews> response = client.Post<Reviews>(request);

            CheckForError(response);
            return response.Data; 
        }

        public List<Reviews> GetReviewByMovie(string game)
        {
            if (game == "Avengers: Endgame")
            {
                game = "Avengers Endgame"; 
            }

            if(game == "Thor: The Dark World")
            {
                game = "Thor The Dark World"; 
            }

            if(game == "Avengers: Age of Ultron")
            {
                game = "Avengers Age of Ultron"; 
            }

            if(game == "Spider-Man: Homecoming")
            {
                game = "Spider-Man Homecoming"; 
            }

            if(game == "Thor: Ragnarok")
            {
                game = "Thor Ragnarok"; 
            }

            if(game == "Avengers: Infinity War")
            {
                game = "Avengers Infinity War"; 
            }

            if(game == "Spider-Man: Far From Home")
            {
                game = "Spider-Man Far From Home"; 
            }

            if(game == "Spider-Man: No Way Home")
            {
                game = "Spider-Man No Way Home"; 
            }

            if(game == "Thor: Love and Thunder")
            {
                game = "Thor Love and Thunder"; 
            }

            RestRequest request = new RestRequest($"{game}/reviews");
            IRestResponse<List<Reviews>> response = client.Get<List<Reviews>>(request);

            CheckForError(response);
            return response.Data; 
        }

        public bool DeleteReservation()
        {
            //string username = NameAndScore.Name; 
            string game = ChangeMovieNameSoItGoesToTheServer(NameAndScore.MovieTitle); 
            RestRequest request = new RestRequest($"/reviews/{game}");
            IRestResponse response = client.Delete(request);

            CheckForError(response);
            return true; 
        }

        public Likes GetLikesForGame()
        {
            string movieName = ChangeMovieNameSoItGoesToTheServer(NameAndScore.MovieTitle);
            RestRequest request = new RestRequest($"{movieName}/likes");
            IRestResponse<Likes> response = client.Get<Likes>(request);
            CheckForError(response);
            return response.Data;
        }

        public string ChangeMovieNameSoItGoesToTheServer(string game)
        {
            if (game == "Avengers: Endgame")
            {
                game = "Avengers Endgame";
            }

            if (game == "Thor: The Dark World")
            {
                game = "Thor The Dark World";
            }

            if (game == "Avengers: Age of Ultron")
            {
                game = "Avengers Age of Ultron";
            }

            if (game == "Spider-Man: Homecoming")
            {
                game = "Spider-Man Homecoming";
            }

            if (game == "Thor: Ragnarok")
            {
                game = "Thor Ragnarok";
            }

            if (game == "Avengers: Infinity War")
            {
                game = "Avengers Infinity War";
            }

            if (game == "Spider-Man: Far From Home")
            {
                game = "Spider-Man Far From Home";
            }

            if (game == "Spider-Man: No Way Home")
            {
                game = "Spider-Man No Way Home";
            }

            if (game == "Thor: Love and Thunder")
            {
                game = "Thor Love and Thunder";
            }

            return game; 
        }
    }

}

