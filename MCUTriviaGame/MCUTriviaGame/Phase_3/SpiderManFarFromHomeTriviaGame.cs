using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_3
{
    public class SpiderManFarFromHomeTriviaGame
    {
        public static void SpiderManFarFromHomeStartMenu()
        {
            SpiderManFarFromHomeTriviaGame game = new SpiderManFarFromHomeTriviaGame();
            NameAndScore.MovieTitle = "Spider-Man: Far From Home";
            Console.Clear();
            Messages.MovieChoice();
            DisplayMenu.StartTriviaGame();

            if (DisplayMenu.StartGame == "Y")
            {
                game.Question1();
            }
            else if (DisplayMenu.StartGame == "B")
            {
                Phase_3MainMenu.SelectAMoive();
            }
            else if (DisplayMenu.StartGame == "E")
            {
                DisplayMenu.EndGame();
            }
            else if (DisplayMenu.StartGame == "S")
            {
                NameAndScore.MovieTitle = "Spider-Man Far From Home";
                DisplayMenu.DisplayScoreByGame();
                BackToSpiderManFarFromHomeStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                BackToSpiderManFarFromHomeStartMenu(); 
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

        public static void BackToSpiderManFarFromHomeStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                SpiderManFarFromHomeStartMenu(); 
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
            Console.WriteLine("Nick Fury and Maria HIll recruit this person saves them after they investiage an unatural storm and encounter the Earth Elemental");
            Messages.LineBreak();
            Console.WriteLine("A. Norman Osborn");
            Console.WriteLine("B. Quentin Beck");
            Console.WriteLine("C. Mac Gargan");
            Console.WriteLine("D. Otto Octavius");
            CorrectAnswers.CorrectAnswerB();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine($"This Person directed {NameAndScore.MovieTitle}");
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
            Console.WriteLine("Peter Parker goes with his fellow students on a trip to this Continent");
            Messages.LineBreak();
            Console.WriteLine("A. Africa");
            Console.WriteLine("B. Asia");
            Console.WriteLine("C. Europe");
            Console.WriteLine("D. South America");
            CorrectAnswers.CorrectAnswerC();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("Happy Hogan tells Peter that this person is going to contact him, but Peter ignores his call");
            Messages.LineBreak();
            Console.WriteLine("A. Maria Hill");
            Console.WriteLine("B. Nick Fury");
            Console.WriteLine("C. Steve Rogers");
            Console.WriteLine("D. Bruce Banner");
            CorrectAnswers.CorrectAnswerB();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine($"{NameAndScore.MovieTitle} made this much at the box office:");
            Messages.LineBreak();
            Console.WriteLine("A. 1.132 Billion");
            Console.WriteLine("B. 1.232 Billion");
            Console.WriteLine("C. 1.332 Billion");
            Console.WriteLine("D. 1.432 Billion");
            CorrectAnswers.CorrectAnswerA();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Fury gives parker these that enable him to communicate with and take command of the artifical intelligence E.D.I.T.H. which has access to Stark Industries' databases and commands a larger orbital weapons supply");
            Messages.LineBreak();
            Console.WriteLine("A. Phone");
            Console.WriteLine("B. Laptop");
            Console.WriteLine("C. Tablet");
            Console.WriteLine("D. Glasses");
            CorrectAnswers.CorrectAnswerD();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Quentin Beck portrays himself as Mysterio, who is a superhero from Earth-833 in the multiverse, However he is actually a former disgruntled employee from this company");
            Messages.LineBreak();
            Console.WriteLine("A. The Daily Bugle");
            Console.WriteLine("B. Pym Technologies");
            Console.WriteLine("C. Stark Industries");
            Console.WriteLine("D. Oscorp");
            CorrectAnswers.CorrectAnswerC();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("The final battle takes place in this city");
            Messages.LineBreak();
            Console.WriteLine("A. Barcelona");
            Console.WriteLine("B. London");
            Console.WriteLine("C. Paris");
            Console.WriteLine("D. Rome");
            CorrectAnswers.CorrectAnswerB();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/23/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 100%");
            Console.WriteLine("B. 90%");
            Console.WriteLine("C. 80%");
            Console.WriteLine("D. 70%");
            CorrectAnswers.CorrectAnswerB();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In a mid-credits scene, this person does a news report showing a video in which Mysterio reveals that Peter is Spider-Man");
            Messages.LineBreak();
            Console.WriteLine("A. Aunt May");
            Console.WriteLine("B. J. Jonah Jameson");
            Console.WriteLine("C. Ned");
            Console.WriteLine("D. Norman Osborne");
            CorrectAnswers.CorrectAnswerB();
            NameAndScore.GameCompleted();
        }
    }
}
