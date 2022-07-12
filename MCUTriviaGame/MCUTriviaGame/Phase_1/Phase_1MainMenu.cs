using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_1
{
    public class Phase_1MainMenu
    {
        public static void SelectAMoive()
        {
            Console.Clear();
            Console.WriteLine("Phase 1 Movies");
            Messages.LineBreak();
            Console.WriteLine("1. Iron Man");
            Console.WriteLine("2. The Incredible Hulk");
            Console.WriteLine("3. Iron Man 2 (Not Implemented Yet)");
            Console.WriteLine("4. Thor (Not Implemented Yet)");
            Console.WriteLine("5. Captain America The First Avenger (Not Implemented Yet)");
            Console.WriteLine("6. The Avengers (Not Implemented Yet)");
            Console.WriteLine("0. Back To Display Screen (Not Implemented Yet)");
            Messages.LineBreak();
            Console.Write("Pick a number: ");
            string number = Console.ReadLine();
            int choice = int.Parse(number);

            if (choice > 6 || choice < 0)
            {
                Messages.NotAValidResponse(); 
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

            }
            else if (choice == 4)
            {

            }
            else if (choice == 5)
            {

            }
            else if (choice == 6)
            {

            }
            else
            {
                PhaseAndTVPresentations.SelectWhichPhaseOrTVShow(); 
            }

        }

    }
}
