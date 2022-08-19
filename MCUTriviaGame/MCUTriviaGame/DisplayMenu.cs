using System;
using System.Collections.Generic;
using System.Text;

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

                Console.Clear(); 
                Console.WriteLine("Welcome to the Marvel Cinematic Universive Trivia Game");
                Console.WriteLine("Select a MCU movie and test your knowledge of that movie with Ten Trivia Questions");
                Messages.LineBreak();
                try
                {
                    Console.WriteLine("Are you ready to begin?");
                    Console.WriteLine("1. Press Y to begin");
                    Console.WriteLine("2. Press N to close the program");
                    Console.WriteLine("3. Press S to view past scores");
                    Messages.LineBreak();
                    Console.WriteLine("What is your choice?"); 
                    string readyToBegin = Console.ReadLine().ToUpper();
                    nameAndScore.GetName();
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
            Console.WriteLine("(Y)es");
            Console.WriteLine("(B)ack to previous page");
            Console.WriteLine("(E)nd Program");
            Messages.LineBreak();
            Console.WriteLine("What is your choice?: ");
            StartGame = Console.ReadLine().ToUpper();
        }
    }
}
