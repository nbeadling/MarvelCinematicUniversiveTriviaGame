using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_3
{
    public class Phase_3MainMenu
    {
        public static void SelectAMoive()
        {
            Console.Clear();
            Console.WriteLine("Phase 3 Movies");
            Messages.LineBreak();
            Console.WriteLine("1. Captain America: Civil War (Not Implemented Yet)");
            Console.WriteLine("2. Doctor Strange (Not Implemented Yet)");
            Console.WriteLine("3. Guardians of the Galaxy Vol. 2 (Not Implemented Yet)");
            Console.WriteLine("4. Spider-Man: Homecoming (Not Implemented Yet)");
            Console.WriteLine("5. Thor: Ragnarok (Not Implemented Yet)");
            Console.WriteLine("6. Black Panther (Not Implemented Yet)");
            Console.WriteLine("7. Avengers: Infinity War (Not Implemented Yet)");
            Console.WriteLine("8. Ant-Man and the Wasp (Not Implemented Yet)");
            Console.WriteLine("9. Captain Marvel (Not Implemented Yet)");
            Console.WriteLine("10. Avengers: Endgame (Not Implemented Yet)");
            Console.WriteLine("11. Spider-Man: Far From Home (Not Implemented Yet)");
            Console.WriteLine("0. Back To Display Screen");
            Messages.LineBreak();
            Console.Write("Pick a number: ");
            string number = Console.ReadLine();
            int choice = int.Parse(number);

            if (choice > 11 || choice < 0)
            {
                Messages.NotAValidResponse();
            }
            else if (choice == 1)
            {

            }
            else if (choice == 2)
            {

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
            else if(choice == 7)
            {

            }
            else if(choice == 8)
            {

            }
            else if(choice == 9)
            {

            }
            else if (choice == 10)
            {

            }
            else if (choice == 11)
            {

            }
            else
            {
                PhaseAndTVPresentations.SelectWhichPhaseOrTVShow();
            }

        }
    }
}
