using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_4
{
    public class ShangChiAndTheLegend_OfTheTenRingsTriviaGame : IQuestions
    {
        public static void ShangChiAndTheLegendOfTheTenRingsStartMenu()
        {
            ShangChiAndTheLegend_OfTheTenRingsTriviaGame game = new ShangChiAndTheLegend_OfTheTenRingsTriviaGame();
            NameAndScore.MovieTitle = "Shang-Chi and the Legend of the Ten Rings";
            Console.Clear();
            Messages.MovieChoice();
            DisplayMenu.StartTriviaGame();

            if (DisplayMenu.StartGame == "Y")
            {
                game.Question1();
            }
            else if (DisplayMenu.StartGame == "B")
            {
                Phase_4MainMenu.SelectAMoive();
            }
            else if (DisplayMenu.StartGame == "E")
            {
                DisplayMenu.EndGame();
            }
            else if (DisplayMenu.StartGame == "S")
            {
                DisplayMenu.DisplayScoreByGame();
                BackToShangChiAndTheLegendOfTheTenRingsStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                BackToShangChiAndTheLegendOfTheTenRingsStartMenu(); 
            }
            else if (DisplayMenu.StartGame == "R")
            {
                Reviews.WriteAReview();
            }
            else if (DisplayMenu.StartGame == "L")
            {
                Likes.GetLikes();
            }
            else
            {
                Messages.NotAValidResponse();
                DisplayMenu.StartTriviaGame();
            }
        }

        public static void BackToShangChiAndTheLegendOfTheTenRingsStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                ShangChiAndTheLegendOfTheTenRingsStartMenu();
            }
            else
            {
                DisplayMenu.EndGame();
            }
        }
        public void Question1()
        {
            Console.Clear();
            Console.WriteLine("Question 1");
            Messages.LineBreak();
            Console.WriteLine("This actor plays Shang-Chi");
            Messages.LineBreak();
            Console.WriteLine("A. Benedict Wong");
            Console.WriteLine("B. Tony Leung");
            Console.WriteLine("C. Simu Liu");
            Console.WriteLine("D. Ronny Chieng");
            CorrectAnswers.CorrectAnswerC();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Messages.DirectorQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. Jon M. Chu");
            Console.WriteLine("B. Lulu Wang");
            Console.WriteLine("C. Daniel Kwan");
            Console.WriteLine("D. Destin Daniel Cretton");
            CorrectAnswers.CorrectAnswerD();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("At what age does Shang-Chi's father make him begin his brutal training in martial arts after the death of his mother by the Iron Gang");
            Messages.LineBreak();
            Console.WriteLine("A. 7");
            Console.WriteLine("B. 10");
            Console.WriteLine("C. 13");
            Console.WriteLine("D. 16");
            CorrectAnswers.CorrectAnswerA();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("After Shang-Chi is forced to assasinate the Iron Gang's leader, he runs away to this California City and takes up the name Shaun");
            Messages.LineBreak();
            Console.WriteLine("A. Los Angeles");
            Console.WriteLine("B. San Diego");
            Console.WriteLine("C. San Francisco");
            Console.WriteLine("D. San Jose");
            CorrectAnswers.CorrectAnswerC();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Messages.BoxOfficeQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. 232.2 Million");
            Console.WriteLine("B. 332.2 Million");
            Console.WriteLine("C. 432.2 Million");
            Console.WriteLine("D. 532.2 Million");
            CorrectAnswers.CorrectAnswerC();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("The ten rings attach Shang-Chi and his best friend Katy on this, and steal a pendant that his mother had given to him");
            Messages.LineBreak();
            Console.WriteLine("A. Train");
            Console.WriteLine("B. Airplane");
            Console.WriteLine("C. Car");
            Console.WriteLine("D. Bus");
            CorrectAnswers.CorrectAnswerD();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("After reuniting with his sister, Shang-Chi is captured by the Ten Rings where he meets this person from Iron Man 3 who has been imprsoned by the Ten Rings");
            Messages.LineBreak();
            Console.WriteLine("A. Aldrich Killian");
            Console.WriteLine("B. Trevor Slattery");
            Console.WriteLine("C. Maya Hansen");
            Console.WriteLine("D. Eric Savin");
            CorrectAnswers.CorrectAnswerB();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("In the final battle, this person sacrifices themself and gives Shang-Chi the Ten Rings");
            Messages.LineBreak();
            Console.WriteLine("A. Xu Xialing");
            Console.WriteLine("B. Ying Li");
            Console.WriteLine("C. Xu Wenwu");
            Console.WriteLine("D. Razor Fist");
            CorrectAnswers.CorrectAnswerC();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/26/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 91%");
            Console.WriteLine("B. 81%");
            Console.WriteLine("C. 71%");
            Console.WriteLine("D. 61%");
            CorrectAnswers.CorrectAnswerA();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In a mid-credits scene, Shang-Chi and Katy are at Kamar-Taj, with three other people, which one is not there");
            Messages.LineBreak();
            Console.WriteLine("A. Wong");
            Console.WriteLine("B. Dr. Strange");
            Console.WriteLine("C. Carol Danvers");
            Console.WriteLine("D. Bruce Banner");
            CorrectAnswers.CorrectAnswerB();
            NameAndScore.GameCompleted();
        }
    }
}
