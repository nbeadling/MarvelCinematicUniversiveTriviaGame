using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_4
{
    public class BlackWidowTriviaGame : IQuestions
    {
        public static void BlackWidowStartMenu()
        {
            BlackWidowTriviaGame game = new BlackWidowTriviaGame();
            NameAndScore.MovieTitle = "Black Widow";
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
                BackToBlackWidowStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                BackToBlackWidowStartMenu();
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

        public static void BackToBlackWidowStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                BlackWidowStartMenu(); 
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
            Console.WriteLine("What year and what state is super soldier Alexei Shostakov, Black Widow Melina Vostokoff are undercover agents posing as a family with Natasha Romanoff and Yelena Belova as their daughters?");
            Messages.LineBreak();
            Console.WriteLine("A. 1994 Michigan");
            Console.WriteLine("B. 1995 Ohio");
            Console.WriteLine("C. 1995 Michigan");
            Console.WriteLine("D. 1994 Ohio");
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
            Console.WriteLine("A. Cate Shortland");
            Console.WriteLine("B. Patty Jenkins");
            Console.WriteLine("C. Greta Gerwig");
            Console.WriteLine("D. Sofia Coppola");
            CorrectAnswers.CorrectAnswerA();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("The film takes place in this year after the events of this movie that has left Natasha Romanoff as a fugitive");
            Messages.LineBreak();
            Console.WriteLine("A. 2013 and Iron Man 3");
            Console.WriteLine("B. 2014 and Captain America: The Winter Soldier");
            Console.WriteLine("C. 2015 and Avengers: Age of Ultron");
            Console.WriteLine("D. 2016 and Captain America: Civil War");
            CorrectAnswers.CorrectAnswerD();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("Natasha Romanoff flees to a safehouse in this country");
            Messages.LineBreak();
            Console.WriteLine("A. Finland");
            Console.WriteLine("B. Iceland");
            Console.WriteLine("C. Norway");
            Console.WriteLine("D. Sweden");
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
            Console.WriteLine("A. 279.8 Million");
            Console.WriteLine("B. 379.8 Million");
            Console.WriteLine("C. 479.8 Million");
            Console.WriteLine("D. 579.8 Million");
            CorrectAnswers.CorrectAnswerB();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Yelena Belova discovers an antidote that frees the other Widows from the chemical mind-control from this place");
            Messages.LineBreak();
            Console.WriteLine("A. The Blue Room");
            Console.WriteLine("B. The White Room");
            Console.WriteLine("C. The Black Room");
            Console.WriteLine("D. The Red Room");
            CorrectAnswers.CorrectAnswerD();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Romanoff negates a pheromone lock by doing this, which allows her to attach Dreykov");
            Messages.LineBreak();
            Console.WriteLine("A. Breaks Her Nose");
            Console.WriteLine("B. Wears a nose plug");
            Console.WriteLine("C. Wears a mask");
            Console.WriteLine("D. Breaks Her Jaw");
            CorrectAnswers.CorrectAnswerA();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("At the end, Romanoff uses an antidote vial on this person and gives another to this person to free the remaining Black Widows across the world");
            Messages.LineBreak();
            Console.WriteLine("A. Yelena Belova and Alexei Shostakov");
            Console.WriteLine("B. Taskmaster and Dreykov");
            Console.WriteLine("C. Taskmaster and Yelena Belova");
            Console.WriteLine("D. Yelena Belova and Dreykov");
            CorrectAnswers.CorrectAnswerC();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/25/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 99%");
            Console.WriteLine("B. 89%");
            Console.WriteLine("C. 79%");
            Console.WriteLine("D. 69%");
            CorrectAnswers.CorrectAnswerC();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In a post-credits scene set after the evetns of Avengers: Endgame, this person meets with Yelena Belova");
            Messages.LineBreak();
            Console.WriteLine("A. Valentina Allegra de Fontaine");
            Console.WriteLine("B. Wanda Maximoff");
            Console.WriteLine("C. Kate Bishop");
            Console.WriteLine("D. Clint Barton");
            CorrectAnswers.CorrectAnswerA();
            NameAndScore.GameCompleted();
        }
    }
}
