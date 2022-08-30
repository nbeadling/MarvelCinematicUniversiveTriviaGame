using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_4
{
    public class DoctorStrangeInTheMultiverseOfMadnessTriviaGame : IQuestions
    {
        public static void DoctorStrangeInTheMultiverseOfMadnessStartMenu()
        {
            DoctorStrangeInTheMultiverseOfMadnessTriviaGame game = new DoctorStrangeInTheMultiverseOfMadnessTriviaGame();
            NameAndScore.MovieTitle = "Doctor Strange in the Multiverse of Madness";
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
                BackToDoctorStrangeInTheMultiverseOfMadnessStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                BackToDoctorStrangeInTheMultiverseOfMadnessStartMenu(); 
            }
            else if (DisplayMenu.StartGame == "R")
            {
                Reviews.WriteAReview();
            }
            else
            {
                Messages.NotAValidResponse();
                DisplayMenu.StartTriviaGame();
            }
        }

        public static void BackToDoctorStrangeInTheMultiverseOfMadnessStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                DoctorStrangeInTheMultiverseOfMadnessStartMenu(); 
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
            Console.WriteLine("This superhero is introdcued to the MCU and is played by Xochitl Gomez");
            Messages.LineBreak();
            Console.WriteLine("A. America Chavez");
            Console.WriteLine("B. Kate Bishop");
            Console.WriteLine("C. Ms. Marvel");
            Console.WriteLine("D. Stature");
            CorrectAnswers.CorrectAnswerA();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Messages.DirectorQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. Jon Watts");
            Console.WriteLine("B. Sam Raimi");
            Console.WriteLine("C. Marc Webb");
            Console.WriteLine("D. Joss Whedon");
            CorrectAnswers.CorrectAnswerB();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Strange tries to get help from this person, but realizes that this person has been corrupted by the Darkhold and is responsible for the attackes on Chavez");
            Messages.LineBreak();
            Console.WriteLine("A. Black Widow");
            Console.WriteLine("B. Captain Marvel");
            Console.WriteLine("C. Gamora");
            Console.WriteLine("D. Scarlet Witch");
            CorrectAnswers.CorrectAnswerD();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("By controlling Chavez powers, Maximoff believes she can reunite with her kids named:");
            Messages.LineBreak();
            Console.WriteLine("A. Nick and Anthony");
            Console.WriteLine("B. Bob and Rob");
            Console.WriteLine("C. Billy and Tommy");
            Console.WriteLine("D. Tommy and Chucky");
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
            Console.WriteLine("A. 655.2 Million");
            Console.WriteLine("B. 755.2 Million");
            Console.WriteLine("C. 855.2 Million");
            Console.WriteLine("D. 955.2 Million");
            CorrectAnswers.CorrectAnswerD();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Chavez and Strange end up on this Earth");
            Messages.LineBreak();
            Console.WriteLine("A. Earth 616");
            Console.WriteLine("B. Earth 99");
            Console.WriteLine("C. Earth 838");
            Console.WriteLine("D. Earth 100");
            CorrectAnswers.CorrectAnswerC();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Patrick Stewart reprises this role for the first time in the MCU");
            Messages.LineBreak();
            Console.WriteLine("A. Charles Xavier");
            Console.WriteLine("B. Magneto");
            Console.WriteLine("C. Wolverine");
            Console.WriteLine("D. Cyclops");
            CorrectAnswers.CorrectAnswerA();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("Dr. Strange does this from a different Earth to go to Mount Wundagore and with the help of Chavez and Wong show Wanda the error of her ways");
            Messages.LineBreak();
            Console.WriteLine("A. Daywalk");
            Console.WriteLine("B. Dreamwalk");
            Console.WriteLine("C. Nightwalk");
            Console.WriteLine("D. Nowalk");
            CorrectAnswers.CorrectAnswerB();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/30/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 94%");
            Console.WriteLine("B. 84%");
            Console.WriteLine("C. 74%");
            Console.WriteLine("D. 64%");
            CorrectAnswers.CorrectAnswerC();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In a mid-credits scene, Dr. Strange Develops this as a result of using the Darkhold");
            Messages.LineBreak();
            Console.WriteLine("A. Third Arm");
            Console.WriteLine("B. Third Ear");
            Console.WriteLine("C. Third Eye");
            Console.WriteLine("D. Third Leg");
            CorrectAnswers.CorrectAnswerC();
            NameAndScore.GameCompleted();
        }
    }
}
