using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;
using MCUTriviaGame.Services;

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
    }
}
