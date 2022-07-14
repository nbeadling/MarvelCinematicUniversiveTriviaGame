using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame
{
    public class DisplayMenu 
    {
        public static bool restart { get; set; }

        public static void MainMenu()
        {
            NameAndScore nameAndScore = new NameAndScore();
            restart = false;
            while (!restart)
            {
                Console.WriteLine("Welcome to the Marvel Cinematic Universive Trivia Game");
                Console.WriteLine("Select a MCU movie and test your knowledge of that movie with Ten Trivia Questions");
                Messages.LineBreak();
                Console.WriteLine("Created by Nicholas Beadling");

                Messages.LineBreak();

                try
                {
                    Console.WriteLine("Are you ready to begin?");
                    Console.WriteLine("(Y)es or (N)o: ");
                    string readyToBegin = Console.ReadLine().ToUpper();

                    if (readyToBegin == "Y")
                    {
                        Messages.LineBreak();
                        Console.WriteLine("Let's Begin!");
                        nameAndScore.GetName();
                        PhaseAndTVPresentations.SelectWhichPhaseOrTVShow(); 

                    }
                    else if (readyToBegin == "N")
                    {
                        Messages.LineBreak();
                        Console.WriteLine("GoodBye");
                        restart = true;
                    }
                    else if(readyToBegin == "99")
                    {
                        Messages.LineBreak(); 
                        AuditLog.ReadTheAuditLog();
                        Messages.LineBreak();

                        Console.Write("Press any button to close the program");
                        string enter = Console.ReadLine().ToUpper();

                        if(enter == "")
                        {
                            EndGame(); 
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
        }
        public static void EndGame()
        {
            restart = true;
        }
    }
}
