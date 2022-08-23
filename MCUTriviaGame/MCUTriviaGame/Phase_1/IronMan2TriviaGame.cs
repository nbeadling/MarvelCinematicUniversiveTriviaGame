using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame;

namespace MCUTriviaGame.Phase_1
{
    public class IronMan2TriviaGame : IQuestions
    {
        public static void IronMan2StartMenu()
        {
            IronMan2TriviaGame game = new IronMan2TriviaGame();
            NameAndScore.MovieTitle = "Iron Man 2"; 
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
                    IronMan2StartMenu(); 
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
                    IronMan2StartMenu();
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
            Console.WriteLine("Iron Man 2 is the debut of this famous character and future Avenger");
            Messages.LineBreak();
            Console.WriteLine("A. Hawkeye");
            Console.WriteLine("B. Black Widow");
            Console.WriteLine("C. Scarlett Witch");
            Console.WriteLine("D. Loki");
            CorrectAnswers.CorrectAnswerB();
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
            Console.WriteLine("B. Sam Raimi");
            Console.WriteLine("C. Martin Scorsese");
            Console.WriteLine("D. Patty Jenkins");
            CorrectAnswers.CorrectAnswerA();
            Question3(); 
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Mickey Rourke plays this main villian in the film");
            Messages.LineBreak();
            Console.WriteLine("A. The Mandarin");
            Console.WriteLine("B. Obadiah Stane");
            Console.WriteLine("C. Justin Hammer");
            Console.WriteLine("D. Whiplash");
            CorrectAnswers.CorrectAnswerD();
            Question4(); 
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("Tony Stark competes in this race during the film");
            Messages.LineBreak();
            Console.WriteLine("A. Daytona 500");
            Console.WriteLine("B. Indianapolis 500");
            Console.WriteLine("C. Monaco Historic Grand Prix");
            Console.WriteLine("D. 24 Hours of Le Mans");
            Messages.LineBreak();
            CorrectAnswers.CorrectAnswerC();
            Question5(); 
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine($"{NameAndScore.MovieTitle} made this much at the Box Office");
            Messages.LineBreak();
            Console.WriteLine("A. 603.9 Million");
            Console.WriteLine("B. 623.9 Million");
            Console.WriteLine("C. 643.9 Million");
            Console.WriteLine("D. 663.9 Million");
            CorrectAnswers.CorrectAnswerC();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("This Actor replaces Terrence Howard as James \"Rhodey\" Rhodes and becomes this superhero");
            Messages.LineBreak();
            Console.WriteLine("A. Cuba Gooding Jr. and War Machine");
            Console.WriteLine("B. Chadwick Boseman and Black Panther");
            Console.WriteLine("C. Don Cheadle and War Machine");
            Console.WriteLine("D. Anthony Mackie and Falcon ");
            CorrectAnswers.CorrectAnswerC();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("The Stark Expo takes place in this New York City Borough");
            Messages.LineBreak();
            Console.WriteLine("A. Bronx");
            Console.WriteLine("B. Staten Island");
            Console.WriteLine("C. Brooklyn");
            Console.WriteLine("D. Queens");
            CorrectAnswers.CorrectAnswerD();
            Question8(); 
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("Sam Rockwell plays this character who is Tony Stark's business rival");
            Messages.LineBreak();
            Console.WriteLine("A. Howard Stark");
            Console.WriteLine("B. Donald Blake");
            Console.WriteLine("C. Arthur Fleck");
            Console.WriteLine("D. Justin Hammer");
            CorrectAnswers.CorrectAnswerD();
            Question9(); 
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/12/2022, this is {NameAndScore.MovieTitle}'s Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 52%");
            Console.WriteLine("B. 62%");
            Console.WriteLine("C. 72%");
            Console.WriteLine("D. 82%");
            CorrectAnswers.CorrectAnswerC();
            Question10(); 
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the Post Credits Scene, S.H.I.E.L.D. agent Phil Coulson reports the discovery of this");
            Messages.LineBreak();
            Console.WriteLine("A. Captain America is Frozen in Ice");
            Console.WriteLine("B. Mjolnir");
            Console.WriteLine("C. Tesseract");
            Console.WriteLine("D. Vibranium");
            CorrectAnswers.CorrectAnswerB();
            NameAndScore.GameCompleted(); 
        }
    }
}

