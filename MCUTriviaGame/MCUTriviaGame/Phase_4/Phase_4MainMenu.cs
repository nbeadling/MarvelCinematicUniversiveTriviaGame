using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_4
{
    public class Phase_4MainMenu
    {
        public static void SelectAMoive()
        {
            Console.Clear();
            Console.WriteLine("Phase 4 Movies");
            Messages.LineBreak();
            Console.WriteLine("1. Black Widow");
            Console.WriteLine("2. Shang-Chi and the Legend of the Ten Rings");
            Console.WriteLine("3. Eternals");
            Console.WriteLine("4. Spider-Man: No Way Home");
            Console.WriteLine("5. Doctor Strange in the Multiverse of Madness");
            Console.WriteLine("6. Thor: Love and Thunder");
            Console.WriteLine("7. Black Panther: Wakanda Forever (Not Implemented Yet)");
            Console.WriteLine("0. Back To Display Screen");
            Messages.LineBreak();
            Console.Write("Pick a number: ");
            string number = Console.ReadLine();
            int choice = int.Parse(number);

            if (choice > 6 || choice < 0)
            {
                Messages.NotAValidResponse();
                Messages.LineBreak(); 
                Messages.PressAnyButtonToContinue(); 
                SelectAMoive(); 
            }
            else if (choice == 1)
            {
                BlackWidowTriviaGame.BlackWidowStartMenu();
            }
            else if (choice == 2)
            {
                ShangChiAndTheLegend_OfTheTenRingsTriviaGame.ShangChiAndTheLegendOfTheTenRingsStartMenu(); 
            }
            else if (choice == 3)
            {
                EternalsTriviaGame.EternalsStartMenu(); 
            }
            else if (choice == 4)
            {
                SpiderManNoWayHome.SpiderManNoWayHomeStartMenu(); 
            }
            else if (choice == 5)
            {
                DoctorStrangeInTheMultiverseOfMadnessTriviaGame.DoctorStrangeInTheMultiverseOfMadnessStartMenu();
            }
            else if (choice == 6)
            {
                ThorLoveAndThunderTriviaGame.ThorLoveAndThunderStartMenu(); 
            }
            else if (choice == 7)
            {

            }
            else
            {
                PhaseAndTVPresentations.SelectWhichPhaseOrTVShow();
            }

        }
    }
}
