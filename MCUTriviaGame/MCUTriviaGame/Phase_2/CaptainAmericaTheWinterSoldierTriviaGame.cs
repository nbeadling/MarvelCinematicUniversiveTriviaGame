using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Services;
using MCUTriviaGame.Models;

namespace MCUTriviaGame.Phase_2
{
    public class CaptainAmericaTheWinterSoldierTriviaGame : IQuestions
    {
        public static void CaptainAmericaTheWinterSoldierStartMenu()
        {
            CaptainAmericaTheWinterSoldierTriviaGame game = new CaptainAmericaTheWinterSoldierTriviaGame();
            NameAndScore.MovieTitle = "Captain America: The Winter Soldier"; 
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
                DisplayMenu.DisplayScoreByGame();
                BackToCaptainAmericaTheWinterSoldierStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                BackToCaptainAmericaTheWinterSoldierStartMenu(); 
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

        public static void BackToCaptainAmericaTheWinterSoldierStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                CaptainAmericaTheWinterSoldierStartMenu(); 
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
            Console.WriteLine("Captain America The Winter Soldier begins with Steve Rogers doing is morning jog through this US city");
            Messages.LineBreak();
            Console.WriteLine("A. New York City");
            Console.WriteLine("B. Los Angeles");
            Console.WriteLine("C. Washington D.C.");
            Console.WriteLine("D. Philadelphia");
            CorrectAnswers.CorrectAnswerC();
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
            Console.WriteLine("This actor makes his MCU debut as Sam Wilson (A.K.A. Falcon)");
            Messages.LineBreak();
            Console.WriteLine("A. Anthony Mackie");
            Console.WriteLine("B. Don Cheadle");
            Console.WriteLine("C. Chadwick Boseman");
            Console.WriteLine("D. John Daid Washington");
            CorrectAnswers.CorrectAnswerA();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This Legendary actor plays Senior S.H.I.E.L.D. member of the World Security Council");
            Messages.LineBreak();
            Console.WriteLine("A. James Caan");
            Console.WriteLine("B. Robert De Niro");
            Console.WriteLine("C. Tom Hanks");
            Console.WriteLine("D. Robert Redford");
            CorrectAnswers.CorrectAnswerD();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine($"{NameAndScore.MovieTitle} made this much at the Box Office:");
            Messages.LineBreak();
            Console.WriteLine("A. 694.4 Million");
            Console.WriteLine("B. 704.4 Million");
            Console.WriteLine("C. 714.4 Million");
            Console.WriteLine("D. 724.4 Million");
            CorrectAnswers.CorrectAnswerC();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("This person is ambushed in the film and warns Rogers that S.H.I.E.L.D. has been infiltrated and eventually fakes their death");
            Messages.LineBreak();
            Console.WriteLine("A. Maria Hill");
            Console.WriteLine("B. Nick Fury");
            Console.WriteLine("C. Natasha Romanoff");
            Console.WriteLine("D. Sharon Carter");
            CorrectAnswers.CorrectAnswerB();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("This person is later to be revelaed as the Winter Soldier");
            Messages.LineBreak();
            Console.WriteLine("A. Peggy Carter");
            Console.WriteLine("B. Sharon Carter");
            Console.WriteLine("C. Bucky Barnes");
            Console.WriteLine("D. Brock Rumlow");
            CorrectAnswers.CorrectAnswerC();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("This organization has been secretly infiltrating S.H.I.E.L.D. and plan on using satelite-guided gusn to eliminate threats to them");
            Messages.LineBreak();
            Console.WriteLine("A. The Ten Rings");
            Console.WriteLine("B. Hydra");
            Console.WriteLine("C. Black Widows");
            Console.WriteLine("D. Tracksuit Mafia");
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
            Console.WriteLine("A. 85%");
            Console.WriteLine("B. 90%");
            Console.WriteLine("C. 95%");
            Console.WriteLine("D. 100%");
            CorrectAnswers.CorrectAnswerB();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the mid credits scene, these two people are shown in a Hydra Lab, who have been experimented on and have super powers");
            Messages.LineBreak();
            Console.WriteLine("A. Wolverine and Storm");
            Console.WriteLine("B. Professor X and Magneto");
            Console.WriteLine("C. Ant-Man and Dr. Strange");
            Console.WriteLine("D. Quicksilver and Scarlet Witch");
            CorrectAnswers.CorrectAnswerD();
            NameAndScore.GameCompleted();
        }
    }
}
