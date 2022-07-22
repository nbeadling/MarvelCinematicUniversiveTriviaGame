using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_2
{
    public class ThorTheDarkWorldTriviaGame : IQuestions
    {
        public static void ThorTheDarkWorldStartMenu()
        {
           ThorTheDarkWorldTriviaGame game = new ThorTheDarkWorldTriviaGame();

            Console.Clear();
            Console.WriteLine("You have chosen to test your knowledge on the film Thor The Dark World (2013)");
            Messages.LineBreak();
            Console.WriteLine("Are you ready to begin?");
            Messages.LineBreak();
            Console.WriteLine("(Y)es");
            Console.WriteLine("(B)ack to previous page");
            Console.WriteLine("(E)nd Program");
            Messages.LineBreak();
            Console.WriteLine("What is your choice?: ");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "Y")
            {
                game.Question1();
            }
            else if (choice == "B")
            {
                Phase_2MainMenu.SelectAMoive();
            }
            else if (choice == "E")
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
            Console.Clear();
            Console.WriteLine("Question 1");
            Messages.LineBreak();
            Console.WriteLine("Thor The Dark World begins with the story of Bor, the father of Odin, defeating the Dark Elf Malekith, who seeks to unleash a weapon known as the Aether, which is the introduction to this infinity stone");
            Messages.LineBreak();
            Console.WriteLine("A. Power Stone");
            Console.WriteLine("B. Reality Stone");
            Console.WriteLine("C. Space Stone");
            Console.WriteLine("D. Mind Stone");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerB();
            Question2(); 
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine("This person directed Thor The Dark World");
            Messages.LineBreak();
            Console.WriteLine("A. Alan Taylor");
            Console.WriteLine("B. David Chase");
            Console.WriteLine("C. David Simon");
            Console.WriteLine("D. Joss Whedon");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question3(); 
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Thor leans of the Convergenace, which is the aligment of all the Realms, How many realms are there?");
            Messages.LineBreak();
            Console.WriteLine("A. Seven");
            Console.WriteLine("B. Eight");
            Console.WriteLine("C. Nine");
            Console.WriteLine("D. Ten");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question4(); 
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This actor plays the main villian Malekith");
            Messages.LineBreak();
            Console.WriteLine("A. Zachary Levi");
            Console.WriteLine("B. Ray Stevenson");
            Console.WriteLine("C. Adewale Akinnuoye-Agbaje");
            Console.WriteLine("D. Christopher Eccleston");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question5(); 
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine("Thor The Dark World made this much at the Box Office:");
            Messages.LineBreak();
            Console.WriteLine("A. 624.8 Million");
            Console.WriteLine("B. 634.8 Billion");
            Console.WriteLine("C. 644.8 Billion");
            Console.WriteLine("D. 654.8 Billion");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question6(); 
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("This human is taken to Asgard after absorbing the Aether");
            Messages.LineBreak();
            Console.WriteLine("A. Jane Foster");
            Console.WriteLine("B. Erik Selvig");
            Console.WriteLine("C. Kat Dennings");
            Console.WriteLine("D. Tony Stark");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question7(); 
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Malekith Kills this person who is close to Thor");
            Messages.LineBreak();
            Console.WriteLine("A. Loki");
            Console.WriteLine("B. Jane Foster");
            Console.WriteLine("C. Frigga");
            Console.WriteLine("D. Odin");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question8(); 
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("When Thor Declines the throne to Odin, it is revealed this person is impersonating Odin");
            Messages.LineBreak();
            Console.WriteLine("A. Thanos");
            Console.WriteLine("B. Loki");
            Console.WriteLine("C. Odin");
            Console.WriteLine("D. Erik Selvig");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerB();
            Question9(); 
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine("As of 7/21/2022, this is Thor: The Dark World Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 46%");
            Console.WriteLine("B. 56%");
            Console.WriteLine("C. 66%");
            Console.WriteLine("D. 76%");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question10(); 
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the mid credits scene, Volstagg and Sif entrust the Aether to this person");
            Messages.LineBreak();
            Console.WriteLine("A. The Collector");
            Console.WriteLine("B. Nick Fury");
            Console.WriteLine("C. Thanos");
            Console.WriteLine("D. Tony Stark");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            GameCompleted(); 
        }
        public static void GameCompleted()
        {
            AuditLog.WriteFiles(NameAndScore.Name, "Thor: The Dark World", NameAndScore.Score);
            Messages.LineBreak();
            Messages.GameCompleted();

            Messages.LineBreak();
            Messages.NewGame();
        }
    }
}
