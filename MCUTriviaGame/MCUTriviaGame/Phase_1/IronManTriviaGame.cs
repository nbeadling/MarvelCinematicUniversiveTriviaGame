using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Phase_1;

namespace MCUTriviaGame.Phase_1
{
    public class IronManTriviaGame : IQuestions
    {
        public static void IronManGameStartMenu()
        {
            IronManTriviaGame game = new IronManTriviaGame();   
            Console.Clear();
            Console.WriteLine("You have chosen to test your knowledge with Iron Man (2008)");
            Messages.LineBreak(); 
            Console.WriteLine("Are you ready to begin?");
            Messages.LineBreak(); 
            Console.WriteLine("(Y)es");
            Console.WriteLine("(B)ack to previous page");
            Console.WriteLine("(E)nd Program");
            Messages.LineBreak();
            Console.WriteLine("What is your choice?: ");
            string choice = Console.ReadLine().ToUpper();

            if(choice == "Y")
            {
                game.Question1(); 
            }
            else if(choice == "B")
            {
                Phase_1MainMenu.SelectAMoive(); 
            }
            else if(choice == "E")
            {
                DisplayMenu.EndGame(); 
            }
            else
            {
                Messages.NotAValidResponse();
            }
        }
        public void Question1()
        {
            IronManTriviaGame ironManTriviaGame = new IronManTriviaGame();
            Console.Clear();
            Console.WriteLine("Question 1");
            Messages.LineBreak();
            Console.WriteLine("This actor stars at the title character:");
            Messages.LineBreak();
            Console.WriteLine("A. Robert Downey Jr.");
            Console.WriteLine("B. Nicolas Cage");
            Console.WriteLine("C. Tom Cruise");
            Console.WriteLine("D. Rob Lowe");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question2(); 
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine("This actor directed Iron Man");
            Messages.LineBreak();
            Console.WriteLine("A. Vince Vaughn");
            Console.WriteLine("B. Jeremy Piven");
            Console.WriteLine("C. Ron Livingston");
            Console.WriteLine("D. Jon Favreau");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD(); 
            Question3(); 
        }

        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Jeff Bridges plays this main villian in the film");
            Messages.LineBreak();
            Console.WriteLine("A. Obadiah Stone");
            Console.WriteLine("B. Obadiah Crane");
            Console.WriteLine("C. Obadiah Stark");
            Console.WriteLine("D. Obadiah Stane");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question4(); 
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This actor played James \"Rhodey\" Rhodes, but would not return to the role in any other MCU movie");
            Messages.LineBreak();
            Console.WriteLine("A. Don Cheadle");
            Console.WriteLine("B. Terrence Howard");
            Console.WriteLine("C. Tim Meadows");
            Console.WriteLine("D. Cuba Gooding Jr.");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerB();
            Question5(); 
        }

        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine("Iron Man Made This Much at The Box Office");
            Messages.LineBreak();
            Console.WriteLine("A. 140.8 Million");
            Console.WriteLine("B. 580.8 Million");
            Console.WriteLine("C. 585.8 Million");
            Console.WriteLine("D. 600.8 Million");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question6(); 
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("The Group That Captures Tony at the beginning of the film goes by this name");
            Messages.LineBreak();
            Console.WriteLine("A. The Ten Rings");
            Console.WriteLine("B. The Five Rings");
            Console.WriteLine("C. The Fifteen Rings");
            Console.WriteLine("D. The Twenty Rings");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question7(); 
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("This AC/DC song is played at the beginning of the Film and this Black Sabbath Song Plays over the credits");
            Messages.LineBreak();
            Console.WriteLine("A. You shook me all Night Long and Iron Man");
            Console.WriteLine("B. Shoot To Thrill and Iron Man");
            Console.WriteLine("C. Back in Black and Iron Man");
            Console.WriteLine("D. Back in Black and Paranoid");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question8(); 
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("Tony Stark uses this to power his Iron Man Suit and to prevent shrapnel from reaching his heart");
            Messages.LineBreak();
            Console.WriteLine("A. Arch Reactor");
            Console.WriteLine("B. J.A.R.V.I.S.");
            Console.WriteLine("C. Nothing");
            Console.WriteLine("D. S.H.I.E.L.D.");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question9(); 
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine("As of 7/11/2022, this is Iron Man's Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 64%");
            Console.WriteLine("B. 74%");
            Console.WriteLine("C. 84%");
            Console.WriteLine("D. 94%");
            Messages.LineBreak();
            
            CorrectAnswers.CorrectAnswerD();
            Question10(); 
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the Post Credits Scene, this actor appears as S.H.I.E.L.D. Directory Nick Fury to discuss the Avengers Initiative");
            Messages.LineBreak();
            Console.WriteLine("A. Will Smith");
            Console.WriteLine("B. Eddie Murphy");
            Console.WriteLine("C. Denzel Washington");
            Console.WriteLine("D. Samuel L. Jackson");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            GameCompleted(); 
        }
        public static void GameCompleted()
        {
            AuditLog.WriteFiles(NameAndScore.Name, "Iron Man Trivia Game", NameAndScore.Score);
            Messages.LineBreak();
            Messages.GameCompleted(); 

            Messages.LineBreak();
            Messages.NewGame(); 
        }
    }
}
