using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_3
{
    public class AvengersEndGameTriviaGame : IQuestions
    {
        public static void AvengersEndGameStartMenu()
        {
            AvengersEndGameTriviaGame game = new AvengersEndGameTriviaGame(); 
            NameAndScore.MovieTitle = "Avengers: Endgame";
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
                NameAndScore.MovieTitle = "Avengers Endgame"; 
                DisplayMenu.DisplayScoreByGame();
                game.BackToAvengersEndGameStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                game.BackToAvengersEndGameStartMenu(); 
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

        public void BackToAvengersEndGameStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                AvengersEndGameStartMenu(); 
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
            Console.WriteLine("Twenty-Three Days after the snap, this person rescues Tony Stark and Nebula from deep space and reunite with the remaining Avengers");
            Messages.LineBreak();
            Console.WriteLine("A. Thor");
            Console.WriteLine("B. Captain Marvel");
            Console.WriteLine("C. Rocket");
            Console.WriteLine("D. Ant-Man");
            CorrectAnswers.CorrectAnswerB();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine($"This brother duo directed {NameAndScore.MovieTitle}");
            Messages.LineBreak();
            Console.WriteLine("A. The Russo Brothers (Anthony and Joe)");
            Console.WriteLine("B. The Cohen Brothers (Joel and Ethan)");
            Console.WriteLine("C. The Duffer Brothers (Matt and Ross)");
            Console.WriteLine("D. The Skylar Brothers (Randy and Jason)");
            CorrectAnswers.CorrectAnswerA();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("In 2023, this person escaptes the Quantum Realm and goes to the Avengers Compound explaining he experienced only five hours while trapped. Thus leading to the theory that the Quantum Realm allows time travel");
            Messages.LineBreak();
            Console.WriteLine("A. Hank Pym");
            Console.WriteLine("B. Hope Pym");
            Console.WriteLine("C. Janet van Dyne");
            Console.WriteLine("D. Scott Lang");
            CorrectAnswers.CorrectAnswerD();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("These two former Avengers need to be recruited by the remaining Avengers. One is overweight and despondent and the other is a vigilante");
            Messages.LineBreak();
            Console.WriteLine("A. Iron Man and Black Widow");
            Console.WriteLine("B. Thor and Hawkeye");
            Console.WriteLine("C. Hulk and Steve Rogers");
            Console.WriteLine("D. Ant-Man and Captain Marvel");
            CorrectAnswers.CorrectAnswerB();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Messages.BoxOfficeQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. 2.498 Billion");
            Console.WriteLine("B. 2.598 Billion");
            Console.WriteLine("C. 2.698 Billion");
            Console.WriteLine("D. 2.798 Billion");
            CorrectAnswers.CorrectAnswerD();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("This person sacrifices themself on Vormir in order for this person to obtain the soul stone");
            Messages.LineBreak();
            Console.WriteLine("A. Tony Stark and Black Widow");
            Console.WriteLine("B. Hawkeye and Tony Stark");
            Console.WriteLine("C. Black Widow and Hawkeye");
            Console.WriteLine("D. Tony Stark and Hawkeye");
            CorrectAnswers.CorrectAnswerC();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("This Avenger reverses the snap with a gauntlet that was built by Tony Stark to hold all the Infinity Stones");
            Messages.LineBreak();
            Console.WriteLine("A. Tony Stark");
            Console.WriteLine("B. Hulk");
            Console.WriteLine("C. Steve Rogers");
            Console.WriteLine("D. Ant-Man");
            CorrectAnswers.CorrectAnswerB();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("In the final battle with Thanos, this Avenger steals the stones, uses them to disintegrate Thanos and his army, but at the cost of his life");
            Messages.LineBreak();
            Console.WriteLine("A. Captain America");
            Console.WriteLine("B. Hulk");
            Console.WriteLine("C. Iron Man");
            Console.WriteLine("D. Thor");
            CorrectAnswers.CorrectAnswerC();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/18/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 94%");
            Console.WriteLine("B. 84%");
            Console.WriteLine("C. 74%");
            Console.WriteLine("D. 64%");
            CorrectAnswers.CorrectAnswerA();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("At the end of the film Steve Rogers passes his shield to this person");
            Messages.LineBreak();
            Console.WriteLine("A. Bucky Barnes");
            Console.WriteLine("B. Clint Barton");
            Console.WriteLine("C. Sam Wilson");
            Console.WriteLine("D. Scot Lang");
            CorrectAnswers.CorrectAnswerC();
            NameAndScore.GameCompleted();
        }
    }
}
