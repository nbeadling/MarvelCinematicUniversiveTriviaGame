using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Television
{
    public class TelevisionMainMenu
    {
        public static void SelectATelevisionShow()
        {
            Console.Clear();
            Console.WriteLine("MCU Television Shows");
            Messages.LineBreak();
            Console.WriteLine("1. WandaVision (Not Implemented Yet)");
            Console.WriteLine("2. The Falcon and the Winter Soldier (Not Implemented Yet)");
            Console.WriteLine("3. Loki (Not Implemented Yet)");
            Console.WriteLine("4. What If...? (Not Implemented Yet)");
            Console.WriteLine("5. Hawkeye (Not Implemented Yet)");
            Console.WriteLine("6. Moon Knight (Not Implemented Yet)");
            Console.WriteLine("7. Ms. Marvel (Not Implemented Yet)");
            Console.WriteLine("0. Back To Display Screen");
            Messages.LineBreak();
            Console.Write("Pick a number: ");
            string number = Console.ReadLine();
            int choice = int.Parse(number);

            if (choice > 7 || choice < 0)
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
