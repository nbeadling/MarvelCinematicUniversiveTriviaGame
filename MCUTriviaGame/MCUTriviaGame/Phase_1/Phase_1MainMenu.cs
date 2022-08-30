using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_1
{
    public class Phase_1MainMenu
    {
        public static void SelectAMoive()
        {
            DisplayMenu.Phase1MovieDisplay(); 
            string number = Console.ReadLine();
            int choice = int.Parse(number);

            if (choice > 6 || choice < 0)
            {
                Messages.NotAValidResponse();
                Messages.LineBreak(); 
                Messages.PressAnyButtonToContinue();
                SelectAMoive();
            }
            else if(choice == 1)
            {
                IronManTriviaGame.IronManGameStartMenu(); 
            }
            else if (choice == 2)
            {
                TheIncredibleHulkTriviaGame.TheIncredibleHulkStartMenu();
            }
            else if (choice == 3)
            {
                IronMan2TriviaGame.IronMan2StartMenu(); 
            }
            else if (choice == 4)
            {
                ThorTriviaGame.ThorStartMenu(); 
            }
            else if (choice == 5)
            {
                CaptainAmericaTheFirstAvenger.CaptainAmericaTheFirstAvengerStartMenu();
            }
            else if (choice == 6)
            {
                TheAvengersTriviaGame.TheAvengersStartMenu(); 
            }
            else
            {
                PhaseAndTVPresentations.SelectWhichPhaseOrTVShow(); 
            }
        }
    }
}
