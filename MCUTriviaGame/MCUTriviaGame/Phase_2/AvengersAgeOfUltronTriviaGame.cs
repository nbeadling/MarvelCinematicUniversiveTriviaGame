using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models; 

namespace MCUTriviaGame.Phase_2
{
    public class AvengersAgeOfUltronTriviaGame : IQuestions
    {
        public static void AvengersAgeOfUltronStartMenu()
        {
            AvengersAgeOfUltronTriviaGame game = new AvengersAgeOfUltronTriviaGame();
            NameAndScore.MovieTitle = "Avengers: Age of Ultron"; 
            Console.Clear();
            Messages.MovieChoice();
            DisplayMenu.StartTriviaGame(); 

            if (DisplayMenu.StartGame == "Y")
            {
                game.Question1();
            }
            else if (DisplayMenu.StartGame == "B")
            {
                Phase_2MainMenu.SelectAMoive();
            }
            else if (DisplayMenu.StartGame == "E")
            {
                DisplayMenu.EndGame();
            }
            else if (DisplayMenu.StartGame == "S")
            {
                NameAndScore.MovieTitle = "Avengers Age of Ultron"; 
                DisplayMenu.DisplayScoreByGame();
                game.BackToAvengersAgeOfUltronStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                game.BackToAvengersAgeOfUltronStartMenu(); 
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

        public void BackToAvengersAgeOfUltronStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                AvengersAgeOfUltronStartMenu(); 
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
            Console.WriteLine("The film begins with the Avengers in the Eastern European Country of Sokovia, rading this villianous group facility");
            Messages.LineBreak();
            Console.WriteLine("A. Hydra");
            Console.WriteLine("B. The Ten Rings");
            Console.WriteLine("C. The Sinister Six");
            Console.WriteLine("D. The Thunderbolts");
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
            Console.WriteLine("A. Anthony Russo");
            Console.WriteLine("B. Matt Duffer");
            Console.WriteLine("C. Joss Whedon");
            Console.WriteLine("D. Zack Snyder");
            CorrectAnswers.CorrectAnswerC();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("These two Avengers Create Ultron through the scepter's gem");
            Messages.LineBreak();
            Console.WriteLine("A. Iron Man and Captain America");
            Console.WriteLine("B. Thor and Captain America");
            Console.WriteLine("C. Dr. Bruce Banner and Thor");
            Console.WriteLine("D. Iron Man and Dr. Bruce Banner");
            CorrectAnswers.CorrectAnswerD();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This Legendary actor voices Ultron");
            Messages.LineBreak();
            Console.WriteLine("A. James Caan");
            Console.WriteLine("B. James Spader");
            Console.WriteLine("C. James McAvoy");
            Console.WriteLine("D. James Franco");
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
            Console.WriteLine("A. 1.303 Billion");
            Console.WriteLine("B. 1.403 Billion");
            Console.WriteLine("C. 1.503 Billion");
            Console.WriteLine("D. 1.603 Billion");
            CorrectAnswers.CorrectAnswerB();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Ultron Recruits These Two People to Join Him");
            Messages.LineBreak();
            Console.WriteLine("A. Iron Man and Thor");
            Console.WriteLine("B. Bruce Banner and Black Widow");
            Console.WriteLine("C. Loki and Red Skull");
            Console.WriteLine("D. Pietro Maximoff and Wanda Maximoff");
            CorrectAnswers.CorrectAnswerD();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Ultron Lifts the Capital City of This Eastern European Country to Have it crash back down into the earth and crash into the Ground to cause a mass extinction");
            Messages.LineBreak();
            Console.WriteLine("A. Sokovia");
            Console.WriteLine("B. Slovakia");
            Console.WriteLine("C. Belarus");
            Console.WriteLine("D. Bulgaria");
            CorrectAnswers.CorrectAnswerA();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("This person dies during the final battle");
            Messages.LineBreak();
            Console.WriteLine("A. Iron Man");
            Console.WriteLine("B. Pietro Maximoff");
            Console.WriteLine("C. Wanda Maximoff");
            Console.WriteLine("D. Black Widow");
            CorrectAnswers.CorrectAnswerB();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/12/2022, this is {NameAndScore.MovieTitle}'s Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 66%");
            Console.WriteLine("B. 71%");
            Console.WriteLine("C. 76%");
            Console.WriteLine("D. 81%");
            CorrectAnswers.CorrectAnswerC();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the mid credits scene, this person dons a gauntlet and vows to retrieve the Infinity Stones himself");
            Messages.LineBreak();
            Console.WriteLine("A. Loki");
            Console.WriteLine("B. Kang The Conqueror");
            Console.WriteLine("C. Ultron");
            Console.WriteLine("D. Thanos");
            CorrectAnswers.CorrectAnswerD();
            NameAndScore.GameCompleted();
        }
    }
}
