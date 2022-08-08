using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_2
{
    public class Phase_2MainMenu
    {
        public static void SelectAMoive()
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
            string number = Console.ReadLine();
            int choice = int.Parse(number);

            if (choice > 6 || choice < 0)
            {
                Messages.NotAValidResponse();
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
