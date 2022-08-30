using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_2
{
    public class Phase_2MainMenu
    {
        public static void SelectAMoive()
        {
            DisplayMenu.Phase2MovieDisplay(); 
            string number = Console.ReadLine();
            int choice = int.Parse(number);

            if (choice > 6 || choice < 0)
            {
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Messages.PressAnyButtonToContinue();
                DisplayMenu.Phase2MovieDisplay();
            }
            else if (choice == 1)
            {
                IronMan3TriviaGame.IronMan3StartMenu(); 
            }
            else if (choice == 2)
            {
                ThorTheDarkWorldTriviaGame.ThorTheDarkWorldStartMenu(); 
            }
            else if (choice == 3)
            {
                CaptainAmericaTheWinterSoldierTriviaGame.CaptainAmericaTheWinterSoldierStartMenu(); 
            }
            else if (choice == 4)
            {
                GuardiansofTheGalaxyTriviaGame.GuardiansOfTheGalaxyStartMenu(); 
            }
            else if (choice == 5)
            {
                AvengersAgeOfUltronTriviaGame.AvengersAgeOfUltronStartMenu(); 
            }
            else if (choice == 6)
            {
                AntManTriviaGame.AntManStartMenu(); 
            }
            else
            {
                PhaseAndTVPresentations.SelectWhichPhaseOrTVShow();
            }
        }
    }
}
