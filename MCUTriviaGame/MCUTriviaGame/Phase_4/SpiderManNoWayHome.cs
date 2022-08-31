using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_4
{
    public class SpiderManNoWayHome : IQuestions
    {
        public static void SpiderManNoWayHomeStartMenu()
        {
            SpiderManNoWayHome game = new SpiderManNoWayHome();
            NameAndScore.MovieTitle = "Spider-Man: No Way Home";
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
                NameAndScore.MovieTitle = "Spider Man No Way Home";
                DisplayMenu.DisplayScoreByGame();
                BackToSpiderManNoWayHomeStartMenu(); 
            }
            else if (DisplayMenu.StartGame == "U")
            {
                
                DisplayMenu.DisplayUserScoreBYGame();
                BackToSpiderManNoWayHomeStartMenu(); 
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

        public static void BackToSpiderManNoWayHomeStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                SpiderManNoWayHomeStartMenu();
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
            Console.WriteLine("After being framed for Quentin Beck's murder, Peter Parker has this lawyer get his charges dropped");
            Messages.LineBreak();
            Console.WriteLine("A. Jennifer Walters");
            Console.WriteLine("B. Matthew Murdock");
            Console.WriteLine("C. Robert Goldman");
            Console.WriteLine("D. James Madrox");
            CorrectAnswers.CorrectAnswerB();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Messages.DirectorQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. Jon Watts");
            Console.WriteLine("B. Sam Raimi");
            Console.WriteLine("C. Marc Webb");
            Console.WriteLine("D. Joss Whedon");
            CorrectAnswers.CorrectAnswerA();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Parker goes to this fellow Avenger to cast a spell in order for everyone to forget that he is Spiderman, but is corrupted when Parker repeatedly requests alterations to the spell");
            Messages.LineBreak();
            Console.WriteLine("A. Scarlet Witch");
            Console.WriteLine("B. Wong");
            Console.WriteLine("C. Dr. Strange");
            Console.WriteLine("D. Agatha Harkness");
            CorrectAnswers.CorrectAnswerC();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("Which of the below villians from the Sam Raimi Spiderman movies did not come back?");
            Messages.LineBreak();
            Console.WriteLine("A. Green Goblin");
            Console.WriteLine("B. Otto Octavius");
            Console.WriteLine("C. Sandman");
            Console.WriteLine("D. Venom");
            CorrectAnswers.CorrectAnswerD();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Messages.BoxOfficeQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. 1.601 Billion");
            Console.WriteLine("B. 1.701 Billion");
            Console.WriteLine("C. 1.801 Billion");
            Console.WriteLine("D. 1.901 Billion");
            CorrectAnswers.CorrectAnswerD();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Which two villians from the Marc Webb Amazing Spider-Man movies made a return?");
            Messages.LineBreak();
            Console.WriteLine("A. Green Goblin and Venom");
            Console.WriteLine("B. Electro and Lizard");
            Console.WriteLine("C. Sandman and Electro");
            Console.WriteLine("D. Rhino and Otto Octavius");
            CorrectAnswers.CorrectAnswerB();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("This person who is close to Peter is killed by the Green Goblin");
            Messages.LineBreak();
            Console.WriteLine("A. Aunt May");
            Console.WriteLine("B. MJ");
            Console.WriteLine("C. Ned");
            Console.WriteLine("D. Tony Stark");
            CorrectAnswers.CorrectAnswerA();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("These two actors make their returns as Spider-Man");
            Messages.LineBreak();
            Console.WriteLine("A. Leonardo DiCaprio and Jake Gyllenhaal");
            Console.WriteLine("B. Nat Wolff and Timothee Chalamet");
            Console.WriteLine("C. Andrew Garfield and Toby Maguire");
            Console.WriteLine("D. Tom Holland and Neil Patrick Harris");
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
            Console.WriteLine("A. 63%");
            Console.WriteLine("B. 73%");
            Console.WriteLine("C. 83%");
            Console.WriteLine("D. 93%");
            CorrectAnswers.CorrectAnswerD();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In a mid-credits scene, Eddie Brock after being transported from this film to the MCU is sent back to his universe");
            Messages.LineBreak();
            Console.WriteLine("A. Venom");
            Console.WriteLine("B. Venom: Let There Be Carnage");
            Console.WriteLine("C. Morbius");
            Console.WriteLine("D. Kraven the Hunter");
            CorrectAnswers.CorrectAnswerB();
            NameAndScore.GameCompleted();
        }
    }
}
