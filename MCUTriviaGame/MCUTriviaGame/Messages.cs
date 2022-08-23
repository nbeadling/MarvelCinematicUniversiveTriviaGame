using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame
{
    public class Messages
    {
        public static void LineBreak()
        {
            Console.WriteLine("\n");
        }

        public static void NotAValidResponse()
        {
            Console.WriteLine("Not A Valid Response, Try Again!"); 
        }

        public static void Correct()
        {
            Console.WriteLine("Correct!");
        }

        public static void Wrong()
        {
            Console.WriteLine("Wrong!");
        }

        public static void GameCompleted()
        {
            Console.WriteLine($"Congrats {NameAndScore.Name} on Finishing the Game");
            Console.WriteLine($"Your Final Score is {NameAndScore.Score} out of 10");
        }

        public static void MovieChoice()
        {
            Console.WriteLine($"You have chosen to test your knowledge on the film {NameAndScore.MovieTitle}");
            LineBreak(); 
        }

        public static void DirectorQuestion()
        {
            Console.WriteLine($"This Person directed {NameAndScore.MovieTitle}");
        }

        public static void BoxOfficeQuestion()
        {
            Console.WriteLine($"{NameAndScore.MovieTitle} made this much at the box office:");
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void NewGame()
        {
            Console.WriteLine("Do you want to try another game or end the program");
            Console.WriteLine("(Y)es or (N)o: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                NameAndScore.Reset();
                PhaseAndTVPresentations.SelectWhichPhaseOrTVShow();
            }
            else
            {
                DisplayMenu.EndGame();
            }
        }

        public static void CloseProgramOrGoBackToTriviaMenu()
        {
            Console.WriteLine("Do you want to go (B)ack to the main menu or press any button to close the program");
        }
    }
}
