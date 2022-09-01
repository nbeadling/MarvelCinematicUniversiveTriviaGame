using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Phase_1;
using MCUTriviaGame.Phase_2;
using MCUTriviaGame.Phase_3;
using MCUTriviaGame.Phase_4;

namespace MCUTriviaGame
{
    public class DisplayMenu 
    {
        public static bool restart { get; set; }

        public static string StartGame { get; set; }

        MCUApp app = new MCUApp();

        public static void MainMenu()
        {
            NameAndScore nameAndScore = new NameAndScore();
            MCUApp apps = new MCUApp();

                Console.Clear(); 
                Console.WriteLine("Welcome to the Marvel Cinematic Universive Trivia Game");
                nameAndScore.GetName();
                apps.GetMostRecentScoreForUser(); 
                Console.WriteLine("Select a MCU movie and test your knowledge of that movie with Ten Trivia Questions");
                Messages.LineBreak();
                try
                {
                    Console.WriteLine("Are you ready to begin?");
                    Console.WriteLine("1. Press Y to begin");
                    Console.WriteLine("2. Press N to close the program");
                    Console.WriteLine("3. Press S to view all of your past scores");
                    Console.WriteLine("4. Press R To See Reviews of the Game");
                    Messages.LineBreak();
                    Console.WriteLine("What is your choice?"); 
                    string readyToBegin = Console.ReadLine().ToUpper();
                    
                    if (readyToBegin == "Y")
                    {
                        Messages.LineBreak();
                        Console.WriteLine("Let's Begin!");
                        PhaseAndTVPresentations.SelectWhichPhaseOrTVShow(); 

                    }
                    else if (readyToBegin == "N")
                    {
                        Messages.LineBreak();
                        Console.WriteLine("GoodBye");
                        EndGame(); 
                    }
                    else if(readyToBegin == "99")
                    {
                        if (NameAndScore.Name == "Nick")
                        {
                            Messages.Clear();
                            AuditLog.ReadTheAuditLog();
                            Messages.LineBreak();
                            Console.Write("Press E to close the program, press any button to go back to display screen");
                            string enter = Console.ReadLine().ToUpper();

                            if (enter == "E")
                            {
                                EndGame();
                            }
                            else
                            {
                                MainMenu(); 
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Not Authorized");
                            MainMenu(); 
                        }                    }
                    else if(readyToBegin == "S")
                    {  
                        MCUApp app = new MCUApp();
                        app.ViewPastScores();
                        Messages.LineBreak();
                        Console.WriteLine("Do you want to go (B)ack to the main menu or press any button to close the program");
                        string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
                        if(mainMenuOrCloseProgram == "B")
                        {
                            MainMenu(); 
                        }
                        else 
                        {
                            EndGame();
                        }
                    }
                    else if(readyToBegin == "R")
                    {
                        Reviews.ReadTheReviews();
                        Messages.LineBreak();
                        Console.WriteLine("Do you want to write your own review?");
                        Console.WriteLine("Press Y for yes, press any button to go back");
                        string writeAReviewOrGoBack = Console.ReadLine().ToUpper();
                        if (writeAReviewOrGoBack == "Y")
                        {
                            Reviews.DoYouWantToWriteAReview(); 
                        }
                        else
                        {
                            MainMenu(); 
                        }
                    }
                    else
                    {
                        Messages.LineBreak();
                        Messages.NotAValidResponse();
                    }
                }
                catch
                {
                    Messages.NotAValidResponse();
                }
        }
        public static void EndGame()
        {
            MCUApp.IsRegistered = false;
        }

        public static void StartTriviaGame()
        {
            Console.WriteLine("Are you ready to begin?");
            Messages.LineBreak();
            Console.WriteLine("Press Y to Begin");
            Console.WriteLine("Press B to go back to previous page");
            Console.WriteLine($"Press S to view all scores for {NameAndScore.MovieTitle}");
            Console.WriteLine($"Press U to view all of your scores for {NameAndScore.MovieTitle}");
            Console.WriteLine($"Press R to write a review for {NameAndScore.MovieTitle}");
            Console.WriteLine($"Press L to see how many users like or dislike {NameAndScore.MovieTitle}");
            Console.WriteLine("Press E to end the Program");
            Messages.LineBreak();
            Console.WriteLine("What is your choice?: ");
            StartGame = Console.ReadLine().ToUpper();
        }

        public static void DisplayScoreByGame()
        {
            MCUApp app = new MCUApp();
            app.GetScoreByGame();
            Messages.LineBreak();
            Messages.CloseProgramOrGoBackToTriviaMenu();
        }

        public static void DisplayUserScoreBYGame()
        {
            MCUApp app = new MCUApp();
            app.GetScoreForUserByGame();
            Messages.LineBreak();
            Messages.CloseProgramOrGoBackToTriviaMenu(); 
        }

        public static void Phase1MovieDisplay()
        {
            Console.Clear();
            Console.WriteLine("Phase 1 Movies");
            Messages.LineBreak();
            Console.WriteLine("1. Iron Man");
            Console.WriteLine("2. The Incredible Hulk");
            Console.WriteLine("3. Iron Man 2");
            Console.WriteLine("4. Thor");
            Console.WriteLine("5. Captain America The First Avenger");
            Console.WriteLine("6. The Avengers");
            Console.WriteLine("0. Back To Display Screen");
            Messages.LineBreak();
            Console.Write("Pick a number: ");
        }

        public static void Phase2MovieDisplay()
        {
            Console.Clear();
            Console.WriteLine("Phase 2 Movies");
            Messages.LineBreak();
            Console.WriteLine("1. Iron Man 3");
            Console.WriteLine("2. Thor: The Dark World");
            Console.WriteLine("3. Captain America: The Winter Soldier");
            Console.WriteLine("4. Guardians of the Galaxy");
            Console.WriteLine("5. Avengers: Age of Ultron");
            Console.WriteLine("6. Ant-Man");
            Console.WriteLine("0. Back To Display Screen");
            Messages.LineBreak();
            Console.Write("Pick a number: ");
        }

        public static void Phase3MovieDisplay()
        {
            Console.Clear();
            Console.WriteLine("Phase 3 Movies");
            Messages.LineBreak();
            Console.WriteLine("1. Captain America: Civil War");
            Console.WriteLine("2. Doctor Strange");
            Console.WriteLine("3. Guardians of the Galaxy Vol. 2");
            Console.WriteLine("4. Spider-Man: Homecoming");
            Console.WriteLine("5. Thor: Ragnarok");
            Console.WriteLine("6. Black Panther");
            Console.WriteLine("7. Avengers: Infinity War");
            Console.WriteLine("8. Ant-Man and the Wasp");
            Console.WriteLine("9. Captain Marvel");
            Console.WriteLine("10. Avengers: Endgame");
            Console.WriteLine("11. Spider-Man: Far From Home");
            Console.WriteLine("0. Back To Display Screen");
            Messages.LineBreak();
            Console.WriteLine("Pick a number: ");
        }

        public static void BackToDisplayMenu()
        {
            Console.WriteLine("Press any button to go back to the Game Menu");
            string backToMainMenu = Console.ReadLine().ToUpper();
            if (backToMainMenu == "B")
            {
                Console.Clear();
                BackToSpecificGameMenu(NameAndScore.MovieTitle);
            }
            else
            {
                Console.Clear();
                BackToSpecificGameMenu(NameAndScore.MovieTitle);
            }
        }

        private static void BackToSpecificGameMenu(string game)
        {
            if(game == "Iron Man")
            {
                IronManTriviaGame.IronManGameStartMenu();
            }

            if(game == "Captain America The First Avenger")
            {
                CaptainAmericaTheFirstAvenger.CaptainAmericaTheFirstAvengerStartMenu();
            }

            if(game == "Iron Man 2")
            {
                IronMan2TriviaGame.IronMan2StartMenu();
            }

            if(game == "The Avengers")
            {
                TheAvengersTriviaGame.TheAvengersStartMenu(); 
            }

            if(game == "The Incredible Hulk")
            {
                TheIncredibleHulkTriviaGame.TheIncredibleHulkStartMenu(); 
            }

            if(game == "Thor")
            {
                ThorTriviaGame.ThorStartMenu();
            }

            if(game == "Ant-Man")
            {
                AntManTriviaGame.AntManStartMenu();
            }

            if(game == "Avengers: Age of Ultron")
            {
                AvengersAgeOfUltronTriviaGame.AvengersAgeOfUltronStartMenu();
            }

            if(game == "Captain America: The Winter Soldier")
            {
                CaptainAmericaCivilWarTriviaGame.CaptainAmericaCivilWarStartMenu();
            }

            if(game == "Guardians of the Galaxy")
            {
                GuardiansofTheGalaxyTriviaGame.GuardiansOfTheGalaxyStartMenu();
            }

            if(game == "Iron Man 3")
            {
                IronMan3TriviaGame.IronMan3StartMenu();
            }

            if(game == "Thor: The Dark World")
            {
                ThorTheDarkWorldTriviaGame.ThorTheDarkWorldStartMenu(); 
            }

            if(game == "Ant-Man And The Wasp")
            {
                AntManAndTheWaspTriviaGame.AntManAndTheWaspStartMenu();
            }

            if(game == "Avengers: Endgame")
            {
                AvengersEndGameTriviaGame.AvengersEndGameStartMenu();
            }

            if(game == "Avengers: Infinity War")
            {
                AvengersInfinityWarTriviaGame.AvengersInfinityWarStartMenu();
            }

            if(game == "Black Panther")
            {
                BlackPantherTriviaGame.BlackPantherStartMenu();
            }

            if(game == "Captain America: Civil War")
            {
                CaptainAmericaCivilWarTriviaGame.CaptainAmericaCivilWarStartMenu();
            }

            if(game == "Captain Marvel")
            {
                CaptainMarvelTriviaGame.CaptainMarvelStartMenu();
            }

            if(game == "Doctor Strange")
            {
                DoctorStrangeTriviaGame.DoctorStrangeStartMenu();
            }

            if(game == "Guardians of the Galaxy Vol. 2")
            {
                GuardiansofTheGalaxyTriviaGame.GuardiansOfTheGalaxyStartMenu();
            }

            if(game == "Spider-Man: Far From Home")
            {
                SpiderManFarFromHomeTriviaGame.SpiderManFarFromHomeStartMenu();
            }

            if(game == "Spider-Man: No Way Home")
            {
                SpiderManNoWayHome.SpiderManNoWayHomeStartMenu();
            }

            if(game == "Spider-Man: Homecoming")
            {
                SpiderManHomecomingTriviaGame.SpiderManHomecomingStartMenu();
            }

            if(game == "Thor: Ragnarok")
            {
                ThorRagnarokTriviaGame.ThorRagnarokStartMenu();
            }

            if(game == "Black Widow")
            {
                BlackWidowTriviaGame.BlackWidowStartMenu();
            }

            if(game == "Doctor Strange in the Multiverse of Madness")
            {
                DoctorStrangeInTheMultiverseOfMadnessTriviaGame.DoctorStrangeInTheMultiverseOfMadnessStartMenu();
            }

            if(game == "Eternals")
            {
                EternalsTriviaGame.EternalsStartMenu();
            }

            if(game == "Shang-Chi and the Legend of the Ten Rings")
            {
                ShangChiAndTheLegend_OfTheTenRingsTriviaGame.ShangChiAndTheLegendOfTheTenRingsStartMenu();
            }

            if(game == "Thor: Love and Thunder")
            {
                ThorLoveAndThunderTriviaGame.ThorLoveAndThunderStartMenu();
            }
        }
    }
}
