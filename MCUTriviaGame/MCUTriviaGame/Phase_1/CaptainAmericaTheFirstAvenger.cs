using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_1
{
    public class CaptainAmericaTheFirstAvenger : IQuestions
    {
        public static void CaptainAmericaTheFirstAvengerStartMenu()
        {
            CaptainAmericaTheFirstAvenger game = new CaptainAmericaTheFirstAvenger();

            Console.Clear();
            Console.WriteLine("You have chosen to test your knowledge on the film Captain America The First Avenger (2011)");
            Messages.LineBreak();
            Console.WriteLine("Are you ready to begin?");
            Messages.LineBreak();
            Console.WriteLine("(Y)es");
            Console.WriteLine("(B)ack to previous page");
            Console.WriteLine("(E)nd Program");
            Messages.LineBreak();
            Console.WriteLine("Waht is your choice?: ");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "Y")
            {
                game.Question1();
            }
            else if (choice == "B")
            {
                Phase_1MainMenu.SelectAMoive();
            }
            else if (choice == "E")
            {
                DisplayMenu.EndGame();
            }
            else
            {
                Messages.NotAValidResponse();
            }
        }
        public void Question1()
        {
            Console.Clear();
            Console.WriteLine("Question 1");
            Messages.LineBreak();
            Console.WriteLine("Steve Rogers (Captain America) is portrayed by this Actor");
            Messages.LineBreak();
            Console.WriteLine("A. Chris Evans");
            Console.WriteLine("B. Chris Hemsworth");
            Console.WriteLine("C. Chris Pine");
            Console.WriteLine("D. Chris Pratt");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "A")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Messages.LineBreak();
                Question2();
            }
            else if (answer == "C" || answer == "B" || answer == "D")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Messages.LineBreak();
                Question2();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question1();
            }
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine("This person directed Captain America");
            Messages.LineBreak();
            Console.WriteLine("A. Jon Favreau");
            Console.WriteLine("B. Joe Johnston");
            Console.WriteLine("C. Stan Lee");
            Console.WriteLine("D. Francis Ford Coppola");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "B")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question3();
            }
            else if (answer == "D" || answer == "A" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question3();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question2();
            }
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("This is main villian in the film");
            Messages.LineBreak();
            Console.WriteLine("A. White Skull");
            Console.WriteLine("B. Black Skull");
            Console.WriteLine("C. Red Skull");
            Console.WriteLine("D. Blue Skull");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question4();
            }
            else if (answer == "A" || answer == "B" || answer == "D")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question4();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question3();
            }
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("Steve Rogers Takes Part in This Experitment");
            Messages.LineBreak();
            Console.WriteLine("A. Alpha Solider");
            Console.WriteLine("B. Winter Solider");
            Console.WriteLine("C. Summer Soldier");
            Console.WriteLine("D. Super Soldier");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "D")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question5();
            }
            else if (answer == "B" || answer == "C" || answer == "A")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question5();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question4();
            }
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine("Captain America The First Avenger made this much at the Box Office");
            Messages.LineBreak();
            Console.WriteLine("A. 370.6 Million");
            Console.WriteLine("B. 380.6 Million");
            Console.WriteLine("C. 390.6 Million");
            Console.WriteLine("D. 400.6 Million");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "A")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question6();
            }
            else if (answer == "C" || answer == "D" || answer == "B")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question6();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question5();
            }
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Red Skull is the leader of this Organization");
            Messages.LineBreak();
            Console.WriteLine("A. The Avengers");
            Console.WriteLine("B. Hydra");
            Console.WriteLine("C. Helga");
            Console.WriteLine("D. The ThunderBolts");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "B")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question7();
            }
            else if (answer == "C" || answer == "D" || answer == "A")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question7();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question6();
            }
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Haley Atwell Plays This S.H.I.E.L.D. Agent and Steve Rogers Love interest");
            Messages.LineBreak();
            Console.WriteLine("A. Sharon Carter");
            Console.WriteLine("B. Maria Hill");
            Console.WriteLine("C. Peggy Carter");
            Console.WriteLine("D. Jessica Drew");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "C")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question8();
            }
            else if (answer == "A" || answer == "B" || answer == "D")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question8();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question7();
            }
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("When Steve Rogers wakes up in the Hospital, The radio is playing a Brooklyn Dodgers game, who are they playing?");
            Messages.LineBreak();
            Console.WriteLine("A. New York Giants");
            Console.WriteLine("B. New York Yankees");
            Console.WriteLine("C. Boston Red Sox");
            Console.WriteLine("D. Philadelphia Phillies");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "D")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question9();
            }
            else if (answer == "B" || answer == "C" || answer == "A")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question9();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question8();
            }
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine("As of 7/12/2022, this is Captain America The First Avenger's Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 69%");
            Console.WriteLine("B. 79%");
            Console.WriteLine("C. 89%");
            Console.WriteLine("D. 99%");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "B")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question10();
            }
            else if (answer == "A" || answer == "D" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                Question10();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question9();
            }
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("There is a teaser for this film in the Post Credits");
            Messages.LineBreak();
            Console.WriteLine("A. The Avengers");
            Console.WriteLine("B. Captain America The Winter Soldier");
            Console.WriteLine("C. The Dark Knight Rises");
            Console.WriteLine("D. Captain America Civil War");
            Messages.LineBreak();
            Console.Write("Your Answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "A")
            {
                Messages.LineBreak();
                Messages.Correct();
                NameAndScore.CorrectAnswerAddPoint();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                GameCompleted();
            }
            else if (answer == "A" || answer == "B" || answer == "C")
            {
                Messages.LineBreak();
                Messages.Wrong();
                Messages.LineBreak();
                NameAndScore.DisplayNameAndScore();
                GameCompleted();
            }
            else
            {
                Messages.LineBreak();
                Messages.NotAValidResponse();
                Messages.LineBreak();
                Question10();
            }
        }
        public static void GameCompleted()
        {
            Messages.LineBreak();
            Messages.GameCompleted();

            Messages.LineBreak();
            Messages.NewGame();
        }

    }
}
