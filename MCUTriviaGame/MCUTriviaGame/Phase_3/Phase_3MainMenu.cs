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
            Console.WriteLine("1. Captain America: Civil War");
            Console.WriteLine("2. Doctor Strange");
            Console.WriteLine("3. Guardians of the Galaxy Vol. 2");
            Console.WriteLine("4. Spider-Man: Homecoming");
            Console.WriteLine("5. Thor: Ragnarok");
            Console.WriteLine("6. Black Panther");
            Console.WriteLine("7. Avengers: Infinity War");
            Console.WriteLine("8. Ant-Man and the Wasp");
            Console.WriteLine("9. Captain Marvel");
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
