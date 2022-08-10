﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_2
{
    public class AntManTriviaGame : IQuestions
    {
        public static void AntManStartMenu()
        {
            AntManTriviaGame game = new AntManTriviaGame();
            NameAndScore.MovieTitle = "Ant-Man (2015)"; 
            Console.Clear();
            Messages.MovieChoice();
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
            Console.WriteLine("This Actor stars as the title character");
            Messages.LineBreak();
            Console.WriteLine("A. Seth Rogan");
            Console.WriteLine("B. Corey Stoll");
            Console.WriteLine("C. Paul Rudd");
            Console.WriteLine("D. Bobby Cannavale");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine("This person directed Ant-Man");
            Messages.LineBreak();
            Console.WriteLine("A. Peyton Reed");
            Console.WriteLine("B. Patty Jenkins");
            Console.WriteLine("C. David F. Sandberg");
            Console.WriteLine("D. Tim Story");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("This Legendary Actor Plays Hank Pym");
            Messages.LineBreak();
            Console.WriteLine("A. Robert Redford");
            Console.WriteLine("B. Kirk Douglas");
            Console.WriteLine("C. Dustin Hoffman");
            Console.WriteLine("D. Michael Douglas");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("Upon his release from prison, Scott Lang works at this restaurant chain");
            Messages.LineBreak();
            Console.WriteLine("A. Cinnabon");
            Console.WriteLine("B. Smoothie King");
            Console.WriteLine("C. Baskin-Robbins");
            Console.WriteLine("D. Cold Stone Creamery");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine("Ant-Man made this much at the box office:");
            Messages.LineBreak();
            Console.WriteLine("A. 519.3 Million");
            Console.WriteLine("B. 529.3 Million");
            Console.WriteLine("C. 539.3 Million");
            Console.WriteLine("D. 549.3 Million");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Corey Stoll plays this supervillian");
            Messages.LineBreak();
            Console.WriteLine("A. Ant-Man");
            Console.WriteLine("B. Yellowjacket");
            Console.WriteLine("C. Wasp");
            Console.WriteLine("D. Grasshopper");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerB();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("This Avenger Makes an appearance and is looking for Scott Lang at the end of the film");
            Messages.LineBreak();
            Console.WriteLine("A. Sam Wilson");
            Console.WriteLine("B. Steve Rogers");
            Console.WriteLine("C. Tony Stark");
            Console.WriteLine("D. Bruce Banner");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("Scott Lang Enters and returns from the");
            Messages.LineBreak();
            Console.WriteLine("A. Macroscopic World");
            Console.WriteLine("B. Multiverse");
            Console.WriteLine("C. Quantumania");
            Console.WriteLine("D. Quantum Realm");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine("As of 8/8/2022, this is Ant-Man Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 68%");
            Console.WriteLine("B. 73%");
            Console.WriteLine("C. 78%");
            Console.WriteLine("D. 83%");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the post credits scene, Steve Rogers and Sam Wilson have this person in custody but are unable to contact Tony Stark because of \"The Accords\"");
            Messages.LineBreak();
            Console.WriteLine("A. Bucky Barnes");
            Console.WriteLine("B. Scott Lang");
            Console.WriteLine("C. Thanos");
            Console.WriteLine("D. Baron Zemo");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            NameAndScore.GameCompleted();
        }
    }
}
