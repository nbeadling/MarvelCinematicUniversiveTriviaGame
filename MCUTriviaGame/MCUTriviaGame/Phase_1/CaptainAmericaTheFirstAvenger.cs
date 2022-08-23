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
            NameAndScore.MovieTitle = "Captain America: The First Avenger"; 
            Console.Clear();
            Messages.MovieChoice();
            DisplayMenu.StartTriviaGame(); 
            if (DisplayMenu.StartGame == "Y")
            {
                game.Question1();
            }
            else if (DisplayMenu.StartGame == "B")
            {
                Phase_1MainMenu.SelectAMoive();
            }
            else if (DisplayMenu.StartGame == "E")
            {
                DisplayMenu.EndGame();
            }
            else if (DisplayMenu.StartGame == "S")
            {
                DisplayMenu.DisplayScoreByGame(); 
                string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
                if (mainMenuOrCloseProgram == "B")
                {
                    CaptainAmericaTheFirstAvengerStartMenu();
                }
                else
                {
                    DisplayMenu.EndGame();
                }
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
                if (mainMenuOrCloseProgram == "B")
                {
                    CaptainAmericaTheFirstAvengerStartMenu(); 
                }
                else
                {
                    DisplayMenu.EndGame();
                }
            }
            else
            {
                Messages.NotAValidResponse();
                DisplayMenu.StartTriviaGame();  
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
            CorrectAnswers.CorrectAnswerA();
            Question2(); 
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine($"This person directed {NameAndScore.MovieTitle}");
            Messages.LineBreak();
            Console.WriteLine("A. Jon Favreau");
            Console.WriteLine("B. Joe Johnston");
            Console.WriteLine("C. Stan Lee");
            Console.WriteLine("D. Francis Ford Coppola");
            CorrectAnswers.CorrectAnswerB();
            Question3(); 
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
            CorrectAnswers.CorrectAnswerC();
            Question4(); 
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
            CorrectAnswers.CorrectAnswerD();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine($"{NameAndScore.MovieTitle} made this much at the Box Office");
            Messages.LineBreak();
            Console.WriteLine("A. 370.6 Million");
            Console.WriteLine("B. 380.6 Million");
            Console.WriteLine("C. 390.6 Million");
            Console.WriteLine("D. 400.6 Million");
            CorrectAnswers.CorrectAnswerA();
            Question6(); 
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
            CorrectAnswers.CorrectAnswerB();
            Question7(); 
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
            CorrectAnswers.CorrectAnswerC();
            Question8(); 
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
            CorrectAnswers.CorrectAnswerD();
            Question9(); 
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 7/12/2022, this is {NameAndScore.MovieTitle}'s Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 69%");
            Console.WriteLine("B. 79%");
            Console.WriteLine("C. 89%");
            Console.WriteLine("D. 99%");
            CorrectAnswers.CorrectAnswerB();
            Question10(); 
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
            CorrectAnswers.CorrectAnswerA();
            NameAndScore.GameCompleted(); 
        }    
    }
}
