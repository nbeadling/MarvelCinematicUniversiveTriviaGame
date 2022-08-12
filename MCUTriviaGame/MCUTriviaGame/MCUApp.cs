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

        public MCUApp(string apiURL)
        {
            mcuAPIService = new MCUApiService(apiURL);
        }

        public MCUApp()
        {

        }

        public void Run()
        {
            //bool keepGoing = true;
            //while (keepGoing)
            //{
                // The menu changes depending on whether the user is logged in or not
                if (mcuAPIService.IsLoggedIn)
                {
                    RunAuthenticated(); 
                }
                else // User is not yet logged in
                {
                    RunUnauthenticated();

                }
            //}
        }

        private bool RunUnauthenticated()
        {
            console.PrintLoginMenu();
            int menuSelection = console.PromptForInteger("Please choose an option", 0, 2, 1);
            while (true)
            {
                if (menuSelection == 0)
                {
                    return false;   // Exit the main menu loop
                }

                if (menuSelection == 1)
                {
                    // Log in
                    Login();
                    return true;    // Keep the main menu loop going
                }

                if (menuSelection == 2)
                {
                    // Register a new user
                    Register();
                    return false;    // Keep the main menu loop going
                }
                console.PrintError("Invalid selection. Please choose an option.");
                console.Pause();
            }
        }

        private void RunAuthenticated()
        {
            console.PrintMainMenu(mcuAPIService.Username); 
            DisplayMenu.MainMenu(); 
 
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
                    DisplayMenu.MainMenu(); 
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
