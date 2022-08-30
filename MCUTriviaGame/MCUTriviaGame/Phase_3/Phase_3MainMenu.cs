using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_3
{
    public class Phase_3MainMenu
    {
        public static void SelectAMoive()
        {
            DisplayMenu.Phase3MovieDisplay();
            string number = Console.ReadLine();
            int choice = int.Parse(number);

            if (choice > 11 || choice < 0)
            {
                Messages.NotAValidResponse();
                Messages.LineBreak(); 
                Messages.PressAnyButtonToContinue();
                DisplayMenu.Phase3MovieDisplay();
            }
            else if (choice == 1)
            {
                CaptainAmericaCivilWarTriviaGame.CaptainAmericaCivilWarStartMenu(); 
            }
            else if (choice == 2)
            {
                DoctorStrangeTriviaGame.DoctorStrangeStartMenu(); 
            }
            else if (choice == 3)
            {
                GuardiansOfTheGalaxyVol2TriviaGame.GuardiansOfTheGalaxyVol2StartMenu(); 
            }
            else if (choice == 4)
            {
                SpiderManHomecomingTriviaGame.SpiderManHomecomingStartMenu(); 
            }
            else if (choice == 5)
            {
                ThorRagnarokTriviaGame.ThorRagnarokStartMenu(); 
            }
            else if (choice == 6)
            {
                BlackPantherTriviaGame.BlackPantherStartMenu();
            }
            else if(choice == 7)
            {
                AvengersInfinityWarTriviaGame.AvengersInfinityWarStartMenu(); 
            }
            else if(choice == 8)
            {
                AntManAndTheWaspTriviaGame.AntManAndTheWaspStartMenu(); 
            }
            else if(choice == 9)
            {
                CaptainMarvelTriviaGame.CaptainMarvelStartMenu(); 
            }
            else if (choice == 10)
            {
                AvengersEndGameTriviaGame.AvengersEndGameStartMenu();
            }
            else if (choice == 11)
            {
                SpiderManFarFromHomeTriviaGame.SpiderManFarFromHomeStartMenu();
            }
            else
            {
                PhaseAndTVPresentations.SelectWhichPhaseOrTVShow();
            }
        }
    }
}
