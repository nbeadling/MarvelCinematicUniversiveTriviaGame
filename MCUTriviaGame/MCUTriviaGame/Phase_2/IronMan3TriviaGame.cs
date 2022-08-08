﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_2
{
    public class IronMan3TriviaGame : IQuestions
    {
        public static void IronMan3StartMenu()
        {
            IronMan3TriviaGame game = new IronMan3TriviaGame();

            Console.Clear();
            Console.WriteLine("You have chosen to test your knowledge on the film Iron Man 3 (2013)");
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
            Console.WriteLine("Iron Man 3 starts in 1999 on this holiday, with this cheesey one hit wonder");
            Messages.LineBreak();
            Console.WriteLine("A. Christmas and All-Star by Smash Mouth");
            Console.WriteLine("B. July 4th and Mambo No. 5 by Lou Bega");
            Console.WriteLine("C. Valentine's Day and Ice Ice Baby by Vanilla Ice");
            Console.WriteLine("D. New Years Eve and Blue by Eiffel 65");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question2(); 
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine("This person directed Iron Man 3");
            Messages.LineBreak();
            Console.WriteLine("A. Shane Black");
            Console.WriteLine("B. Jon Favreau");
            Console.WriteLine("C. John Carpetner");
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
            Console.WriteLine("Rebecca Hall plays scientist Maya Hansen who created this experimental regenerative treatment that allows recovery from crippling injuries");
            Messages.LineBreak();
            Console.WriteLine("A. Axis");
            Console.WriteLine("B. Regenerates");
            Console.WriteLine("C. Extremis");
            Console.WriteLine("D. GrowBack");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question4(); 
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This actor plays the main villian Aldrich Killian who runs this company, which goes by A.I.M.");
            Messages.LineBreak();
            Console.WriteLine("A. Robert De Niro and Advanced Innovation Mechanics");
            Console.WriteLine("B. Val Kilmer and Advanced Inventions Mechanics");
            Console.WriteLine("C. Jeffrey Donovan and Advanced Integration Mechanics");
            Console.WriteLine("D. Guy Pearce and Advanced Idea Mechanics");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question5(); 
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine("Iron Man 3 made this much at the Box Office:");
            Messages.LineBreak();
            Console.WriteLine("A. 900.2 Million");
            Console.WriteLine("B. 1.115 Billion");
            Console.WriteLine("C. 1.215 Billion");
            Console.WriteLine("D. 1.315 Billion");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question6(); 
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Tony Stark ends up in this state at one point");
            Messages.LineBreak();
            Console.WriteLine("A. Alabama");
            Console.WriteLine("B. Arkansas");
            Console.WriteLine("C. Georgia");
            Console.WriteLine("D. Tennessee");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question7(); 
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("The Mandarin is portrayed by Ben Kingsley, but is later revelaed to be this British Actor who is acting as the The Mandarin");
            Messages.LineBreak();
            Console.WriteLine("A. Happy Hogan");
            Console.WriteLine("B. Trevor Slattery");
            Console.WriteLine("C. Harley Keener");
            Console.WriteLine("D. Eric Savin");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerB();
            Question8(); 
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("Where does Aldrin Killian plan to attack the President?");
            Messages.LineBreak();
            Console.WriteLine("A. Air Force One");
            Console.WriteLine("B. The White House");
            Console.WriteLine("C. Camp David");
            Console.WriteLine("D. Fort Knox");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question9(); 
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine("As of 7/16/2022, this is The Avengers Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 74%");
            Console.WriteLine("B. 79%");
            Console.WriteLine("C. 84%");
            Console.WriteLine("D. 89%");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerB();
            Question10(); 
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the Post Credits Scene, Tony Stark is doing a therapy session with this person, recounting the entire story of Iron Man 3");
            Messages.LineBreak();
            Console.WriteLine("A. Steve Rogers");
            Console.WriteLine("B. Nick Fury");
            Console.WriteLine("C. Bruce Banner");
            Console.WriteLine("D. Natasha Romanoff");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            GameCompleted(); 
        }
        public static void GameCompleted()
        {
            AuditLog.WriteFiles(NameAndScore.Name, "Iron Man 3 Trivia Game", NameAndScore.Score);
            Messages.LineBreak();
            Messages.GameCompleted();

            Messages.LineBreak();
            Messages.NewGame();
        }
    }
}
