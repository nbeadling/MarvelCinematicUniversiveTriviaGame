using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_3
{
    public class SpiderManHomecomingTriviaGame : IQuestions
    {
        public static void SpiderManHomecomingStartMenu()
        {
            SpiderManHomecomingTriviaGame game = new SpiderManHomecomingTriviaGame();
            NameAndScore.MovieTitle = "Spider-Man: Homecoming";
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
                NameAndScore.MovieTitle = "Spider-Man Homecoming"; 
                DisplayMenu.DisplayScoreByGame();
                game.BackToSpiderManHomecomingStartMenu(); 
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                game.BackToSpiderManHomecomingStartMenu(); 
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

        public void BackToSpiderManHomecomingStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                SpiderManHomecomingStartMenu(); 
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
            Console.WriteLine("The film starts with Adrian Toomes and his salvage company cleaning up New York City after the battle from this movie");
            Messages.LineBreak();
            Console.WriteLine("A. The Avengers");
            Console.WriteLine("B. Iron Man 2");
            Console.WriteLine("C. Captain America: The Winter Soldier");
            Console.WriteLine("D. Ant-Man");
            CorrectAnswers.CorrectAnswerA();
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
            Console.WriteLine("After the Department of Damage Control and the Government take over the cleaning operations, Toomes and his employees keep the Chitauri technology and use it to create and sell adanced weapons, while Toomes becomes this villian");
            Messages.LineBreak();
            Console.WriteLine("A. Falcon");
            Console.WriteLine("B. Raven");
            Console.WriteLine("C. Vulture");
            Console.WriteLine("D. Eagle");
            CorrectAnswers.CorrectAnswerC();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This is the first person to discover that Peter Parker is Spider-Man");
            Messages.LineBreak();
            Console.WriteLine("A. Aunt May");
            Console.WriteLine("B. Ned");
            Console.WriteLine("C. MJ");
            Console.WriteLine("D. Flash");
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
            Console.WriteLine("A. 660.2 Million");
            Console.WriteLine("B. 760.2 Million");
            Console.WriteLine("C. 860.2 Million");
            Console.WriteLine("D. 960.2 Million");
            CorrectAnswers.CorrectAnswerC();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Parker first becomes aware of Toomes after coming across this Toomes associate");
            Messages.LineBreak();
            Console.WriteLine("A. Aaron Davis");
            Console.WriteLine("B. Mac Gargan");
            Console.WriteLine("C. Toomes");
            Console.WriteLine("D. Shocker");
            CorrectAnswers.CorrectAnswerD();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Peter Parker Decathlon team go to DC where Peter must save his team at this place");
            Messages.LineBreak();
            Console.WriteLine("A. Lincoln Memorial");
            Console.WriteLine("B. Thomas Jefferson Memorial");
            Console.WriteLine("C. Vietnam Wall");
            Console.WriteLine("D. Washington Monument");
            CorrectAnswers.CorrectAnswerD();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("The Final Battle with Toomes takes place while Happy Hogan is helping transport weapons from Avenger's Tower by this transportation method");
            Messages.LineBreak();
            Console.WriteLine("A. Boat");
            Console.WriteLine("B. Truck");
            Console.WriteLine("C. Plane");
            Console.WriteLine("D. Train");
            CorrectAnswers.CorrectAnswerC();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/12/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 92%");
            Console.WriteLine("B. 82%");
            Console.WriteLine("C. 72%");
            Console.WriteLine("D. 62%");
            CorrectAnswers.CorrectAnswerA();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("Right before the credits begin, this person discovers that Peter is Spider-Man");
            Messages.LineBreak();
            Console.WriteLine("A. Ned");
            Console.WriteLine("B. MJ");
            Console.WriteLine("C. Aunt May");
            Console.WriteLine("D. Flash");
            CorrectAnswers.CorrectAnswerC();
            NameAndScore.GameCompleted();
        }
    }
}
