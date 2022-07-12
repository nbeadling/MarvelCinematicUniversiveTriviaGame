using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Phase_1;
using MCUTriviaGame.Phase_2;
using MCUTriviaGame.Phase_3;
using MCUTriviaGame.Phase_4;
using MCUTriviaGame.Television;

namespace MCUTriviaGame
{
    public class PhaseAndTVPresentations
    {
        public static void SelectWhichPhaseOrTVShow()
        {

            Console.Clear();
            Console.WriteLine("Select A Number");
            Console.WriteLine("1. Phase 1");
            Console.WriteLine("2. Phase 2");
            Console.WriteLine("3. Phase 3");
            Console.WriteLine("4. Phase 4");
            Console.WriteLine("5. Television");
            Console.WriteLine("0. Close Program"); 
            Messages.LineBreak();
            Console.Write("What is your option?: "); 
            string selection1 = Console.ReadLine();
            int selection2 = int.Parse(selection1);

            if (selection2 > 5 || selection2 < 0)
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
            }
            else if(selection2 == 1)
            {
                Phase_1MainMenu.SelectAMoive(); 
            }
            else if(selection2 == 2)
            {
                Phase_2MainMenu.SelectAMoive(); 
            }
            else if(selection2 == 3)
            {
                Phase_3MainMenu.SelectAMoive(); 
            }
            else if (selection2 == 4)
            {
                Phase_4MainMenu.SelectAMoive(); 
            }
            else if(selection2 == 5)
            {
                TelevisionMainMenu.SelectATelevisionShow(); 
            }
            else
            {
                Messages.LineBreak(); 
                DisplayMenu.EndGame(); 
            }
        }
    }
}
