using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_3
{
    public class AvengersInfinityWarTriviaGame : IQuestions
    {
        public static void AvengersInfinityWarStartMenu()
        {
            AvengersInfinityWarTriviaGame game = new AvengersInfinityWarTriviaGame();
            NameAndScore.MovieTitle = "Avengers: Infinity War";
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
                NameAndScore.MovieTitle = "Avengers Infinity War"; 
                DisplayMenu.DisplayScoreByGame();
                BackToAvengersInfinityWarStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                BackToAvengersInfinityWarStartMenu(); 
            }
            else
            {
                Messages.NotAValidResponse();
                DisplayMenu.StartTriviaGame();
            }
        }

        public static void BackToAvengersInfinityWarStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                AvengersInfinityWarStartMenu(); 
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
            Console.WriteLine("The film begins with Thanos extracting the Space Stone from the Tesseract and killing these two people");
            Messages.LineBreak();
            Console.WriteLine("A. Thor and Hulk");
            Console.WriteLine("B. Thor and Loki");
            Console.WriteLine("C. Hulk and Heimdall");
            Console.WriteLine("D. Loki and Heimdall");
            CorrectAnswers.CorrectAnswerD();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine($"This brother duo directed {NameAndScore.MovieTitle}");
            Messages.LineBreak();
            Console.WriteLine("A. The Cohen Brothers (Joel and Ethan)");
            Console.WriteLine("B. The Russo Brothers (Anthony and Joe)");
            Console.WriteLine("C. The Duffer Brothers (Matt and Ross)");
            Console.WriteLine("D. The Skylar Brothers (Randy and Jason)");
            CorrectAnswers.CorrectAnswerB();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Hulk crashes into the Sanctum Sanctorum and warnes these two people that Thanos is coming");
            Messages.LineBreak();
            Console.WriteLine("A. The Ancient One and Dr. Strange");
            Console.WriteLine("B. Wong and Mordo");
            Console.WriteLine("C. Dr. Strange and Wong");
            Console.WriteLine("D. The Ancient One and Mordo");
            CorrectAnswers.CorrectAnswerC();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("The Guardians of the Galaxy pickup this Avenger who has been floating in space");
            Messages.LineBreak();
            Console.WriteLine("A. Captain America");
            Console.WriteLine("B. Hawkeye");
            Console.WriteLine("C. Iron Man");
            Console.WriteLine("D. Thor");
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
            Console.WriteLine("A. 2.04 Billion");
            Console.WriteLine("B. 2.14 Billion");
            Console.WriteLine("C. 2.24 Billion");
            Console.WriteLine("D. 2.34 Billion");
            CorrectAnswers.CorrectAnswerA();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("In order to retrieve the soul stone, Thanos sacrifices this person");
            Messages.LineBreak();
            Console.WriteLine("A. Ebony Maw");
            Console.WriteLine("B. Nebula");
            Console.WriteLine("C. Gamora");
            Console.WriteLine("D. Proxima Midnight");
            CorrectAnswers.CorrectAnswerC();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Thanos attacks this country in order to get the Mind Stone");
            Messages.LineBreak();
            Console.WriteLine("A. Germany");
            Console.WriteLine("B. Sokovia");
            Console.WriteLine("C. United States of America");
            Console.WriteLine("D. Wakanda");
            CorrectAnswers.CorrectAnswerD();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("This Avenger should have gone for the head");
            Messages.LineBreak();
            Console.WriteLine("A. Black Widow");
            Console.WriteLine("B. Captain America");
            Console.WriteLine("C. Iron Man");
            Console.WriteLine("D. Thor");
            CorrectAnswers.CorrectAnswerD();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/17/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 85%");
            Console.WriteLine("B. 75%");
            Console.WriteLine("C. 65%");
            Console.WriteLine("D. 55%");
            CorrectAnswers.CorrectAnswerA();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("Before he disappears, Nick Fury uses a pager to send a signal to this super hero");
            Messages.LineBreak();
            Console.WriteLine("A. Captain Marvel");
            Console.WriteLine("B. Ms. Marvel");
            Console.WriteLine("C. Monica Rambeau");
            Console.WriteLine("D. Scarlet Witch");
            CorrectAnswers.CorrectAnswerA();
            NameAndScore.GameCompleted();
        }
    }
}
