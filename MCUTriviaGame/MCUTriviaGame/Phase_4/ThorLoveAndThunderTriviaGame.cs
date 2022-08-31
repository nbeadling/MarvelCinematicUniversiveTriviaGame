using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_4
{
    public class ThorLoveAndThunderTriviaGame : IQuestions
    {
        public static void ThorLoveAndThunderStartMenu()
        {
            ThorLoveAndThunderTriviaGame game = new ThorLoveAndThunderTriviaGame();
            NameAndScore.MovieTitle = "Thor: Love and Thunder";
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
                NameAndScore.MovieTitle = "Thor Love and Thunder";
                DisplayMenu.DisplayScoreByGame();
                game.BackToThorLoveAndThunderStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                game.BackToThorLoveAndThunderStartMenu(); 
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

        public void BackToThorLoveAndThunderStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                ThorLoveAndThunderStartMenu(); 
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
            Console.WriteLine("The film begins with Gorr and his daughter Love struggling in a desert, after Love dies this weapon calls to Gorr");
            Messages.LineBreak();
            Console.WriteLine("A. Stormbreaker");
            Console.WriteLine("B. Mjolnir");
            Console.WriteLine("C. Necrosword");
            Console.WriteLine("D. All of the above");
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
            Console.WriteLine("A. Kenneth Branagh");
            Console.WriteLine("B. Alan Taylor");
            Console.WriteLine("C. Taika Waititi");
            Console.WriteLine("D. James Gunn");
            CorrectAnswers.CorrectAnswerC();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("After learning the death of several Gods, Thor leaves this group to figure out what is going on");
            Messages.LineBreak();
            Console.WriteLine("A. The Avengers");
            Console.WriteLine("B. Guardians of the Galaxy");
            Console.WriteLine("C. Young Avengers");
            Console.WriteLine("D. X-Men");
            CorrectAnswers.CorrectAnswerB();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("Thor learns from Sif that this place is Gorr's next target");
            Messages.LineBreak();
            Console.WriteLine("A. New Asgard");
            Console.WriteLine("B. New York City");
            Console.WriteLine("C. New Amsterdam");
            Console.WriteLine("D. New Jersey");
            CorrectAnswers.CorrectAnswerA();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Messages.BoxOfficeQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. 446.9 Million");
            Console.WriteLine("B. 546.9 Million");
            Console.WriteLine("C. 646.9 Million");
            Console.WriteLine("D. 746.9 Million");
            CorrectAnswers.CorrectAnswerD();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Jane Foster returns and is now this superhero and wields Mjohlnir");
            Messages.LineBreak();
            Console.WriteLine("A. Thor");
            Console.WriteLine("B. Mighty Thor");
            Console.WriteLine("C. Lady Thor");
            Console.WriteLine("D. Super Jane");
            CorrectAnswers.CorrectAnswerB();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Russel Crowe plays this Greek God who Thor, Jane, and Valkyrie go to ask for help to fight Gorr");
            Messages.LineBreak();
            Console.WriteLine("A. Zeus");
            Console.WriteLine("B. Poseidon");
            Console.WriteLine("C. Hera");
            Console.WriteLine("D. Apollo");
            CorrectAnswers.CorrectAnswerA();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("What does Gorr wish for when he reaches Eternity's real?");
            Messages.LineBreak();
            Console.WriteLine("A. For all the God's to die");
            Console.WriteLine("B. For him to Be the Supreme God");
            Console.WriteLine("C. For Jane To live");
            Console.WriteLine("D. For Love to be revived");
            CorrectAnswers.CorrectAnswerD();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/30/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 55%");
            Console.WriteLine("B. 65%");
            Console.WriteLine("C. 75%");
            Console.WriteLine("D. 85%");
            CorrectAnswers.CorrectAnswerB();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the midd-credits scene, Zeus is talking to his son Hercules who is played by this Ted Lasso Actor");
            Messages.LineBreak();
            Console.WriteLine("A. Jason Sudeikis");
            Console.WriteLine("B. Jeremy Swift");
            Console.WriteLine("C. Brett Goldstein");
            Console.WriteLine("D. Brendan Hunt");
            CorrectAnswers.CorrectAnswerC();
            NameAndScore.GameCompleted();
        }
    }
}
