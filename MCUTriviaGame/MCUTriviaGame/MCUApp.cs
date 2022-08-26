using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;
using MCUTriviaGame.Services;
using MCUTriviaGame; 

namespace MCUTriviaGame
{
    public class MCUApp
    {
        private readonly MCUTriviaGameConsoleService console = new MCUTriviaGameConsoleService();
        private readonly MCUApiService mcuAPIService;

        public static bool IsRegistered { get; set; }

        public MCUApp(string apiURL)
        {
            mcuAPIService = new MCUApiService(apiURL);
        }

        public MCUApp()
        {
        }
        public void Run()
        {
            IsRegistered = true;
            while (IsRegistered)
            {
               // The menu changes depending on whether the user is logged in or not
                if (mcuAPIService.IsLoggedIn)
                {
                    RunAuthenticated();
                }
                else // User is not yet logged in
                {
                    RunUnauthenticated();
                }
            }
        }
        private bool RunUnauthenticated()
        {
            console.PrintLoginMenu();
            int menuSelection = console.PromptForInteger("Please choose an option", 0, 2, 1);
            IsRegistered = true;
            while(IsRegistered)
            {
                if (menuSelection == 0)
                {
                    IsRegistered = false;
                    return IsRegistered;
                }

                if (menuSelection == 1)
                {
                    Login();
                    IsRegistered = true;
                    return IsRegistered;
                }

                if (menuSelection == 2)
                {
                    Register();
                    IsRegistered = true;
                    return IsRegistered;
                }
                console.PrintError("Invalid selection. Please choose an option.");
                console.Pause();
            }
            return IsRegistered;
        }

        private void RunAuthenticated()
        {
            console.PrintMainMenu(mcuAPIService.Username); 
        }

        private void Login()
        {
            LoginUser loginUser = console.PromptForLogin();
            if (loginUser == null)
            {
                return;
            }

            try
            {
                ApiUser user = mcuAPIService.Login(loginUser);
                if (user == null)
                {
                    console.PrintError("Login failed.");
                }
                else
                {
                    console.PrintSuccess("You are now logged in");
                }
            }
            catch (Exception)
            {
                console.PrintError("Login failed.");
            }
            console.Pause();
        }

        private void Register()
        {
            LoginUser registerUser = console.PromptForLogin();
            if (registerUser == null)
            {
                return;
            }
            try
            {
                bool isRegistered = mcuAPIService.Register(registerUser);
                if (isRegistered)
                {
                    console.PrintSuccess("Registration was successful. Please log in.");
                    //console.PrintLoginMenu();  
                }
                else
                {
                    console.PrintError("Registration was unsuccessful.");
                }
            }
            catch (Exception)
            {
                console.PrintError("Registration was unsuccessful.");
            }
            console.Pause();
        }

        public void SaveScore()
        {
            MCUApiService mcuAPIService = new MCUApiService();
            Score finalScore = new Score(NameAndScore.Score, NameAndScore.Name, NameAndScore.MovieTitle); //DateTime.Now);
            mcuAPIService.SaveScore(finalScore);
        }

        public void ViewPastScores()
        {
            MCUApiService mcuAPIService = new MCUApiService();
            Account account = new Account(); 
            List<Score> scores = mcuAPIService.GetScoreByUserId();
            int requestingAccountId = account.AccountId;

            console.DisplayUserScores(scores, requestingAccountId);
        }

        public void GetScoreByGame()
        {
           
            MCUApiService mcuAPIService = new MCUApiService();
            List<Score> scores = mcuAPIService.GetScoreByGame(NameAndScore.MovieTitle);

            console.DisplayScoresByGame(scores);
        }

        public void GetScoreForUserByGame()
        {
            MCUApiService mcuApiService = new MCUApiService();
            List<Score> score = mcuApiService.GetScoreForUserByGame(NameAndScore.Name, NameAndScore.MovieTitle);

            console.DisplayUserScoreForGame(score); 
        }

        public void GetMostRecentScoreForUser()
        {
            MCUApiService mCUApiService = new MCUApiService();

            Score score = mCUApiService.GetMostRecentScore(NameAndScore.Name);

            console.DisplayMostRecentScore(score); 
        }

        public void UpdateMostRecentScore()
        {
            MCUApiService mcuAPIService = new MCUApiService();
            Score score = new Score(NameAndScore.Score, NameAndScore.Name, NameAndScore.MovieTitle);
            mcuAPIService.UpdateMostRecentGame(score); 
        }

        public void SaveReview(string review)
        {
            MCUApiService mcuApiService = new MCUApiService(); 
            Reviews newReview = new Reviews(NameAndScore.Name, NameAndScore.MovieTitle, review); 
            mcuApiService.SaveReview(newReview); 
        }

        public void GetReviewByGame()
        {
            MCUApiService mcuApiService = new MCUApiService();
            List<Reviews> review = mcuApiService.GetReviewByMovie(NameAndScore.MovieTitle);

            console.DisplayReviewsByGame(review); 
        }
    }
}
