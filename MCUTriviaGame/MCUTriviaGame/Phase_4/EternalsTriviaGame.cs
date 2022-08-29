using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_4
{
    public class EternalsTriviaGame : IQuestions
    {
        public static void EternalsStartMenu()
        {
            EternalsTriviaGame game = new EternalsTriviaGame();
            NameAndScore.MovieTitle = "Eternals";
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
                BackToEternalsStartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                BackToEternalsStartMenu(); 
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

        public static void BackToEternalsStartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                EternalsStartMenu(); 
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
            Console.WriteLine("The Eternals are sent to earth by the Celestial Arishem in this year");
            Messages.LineBreak();
            Console.WriteLine("A. 20,000 BC");
            Console.WriteLine("B. 15,000 BC");
            Console.WriteLine("C. 10,000 BC");
            Console.WriteLine("D. 5,000 BC");
            CorrectAnswers.CorrectAnswerD();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Messages.DirectorQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. Jane Campion");
            Console.WriteLine("B. Alfonso Cuaron");
            Console.WriteLine("C. Bong Joon-ho");
            Console.WriteLine("D. Chloe Zhao");
            CorrectAnswers.CorrectAnswerD();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("The Eternals defeat the final deviant in this year and then go their own way");
            Messages.LineBreak();
            Console.WriteLine("A. 1321");
            Console.WriteLine("B. 1421");
            Console.WriteLine("C. 1521");
            Console.WriteLine("D. 1621");
            CorrectAnswers.CorrectAnswerC();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("In the present day, Sersi and Sprite are attacked by a deviant in this city");
            Messages.LineBreak();
            Console.WriteLine("A. London");
            Console.WriteLine("B. New York City");
            Console.WriteLine("C. Paris");
            Console.WriteLine("D. Sydney");
            CorrectAnswers.CorrectAnswerA();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Messages.BoxOfficeQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. 302.1 Million");
            Console.WriteLine("B. 402.1 Million");
            Console.WriteLine("C. 502.1 Million");
            Console.WriteLine("D. 602.1 Million");
            CorrectAnswers.CorrectAnswerB();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Sersi, Sprite, and Ikaris go to this US State to reunite with their leader Ajax, only to find her death, resulting in Sersi being posthumously chosen as her successor");
            Messages.LineBreak();
            Console.WriteLine("A. Montana");
            Console.WriteLine("B. North Dakota");
            Console.WriteLine("C. South Daktoa");
            Console.WriteLine("D. Wyoming");
            CorrectAnswers.CorrectAnswerC();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("Sersi learns the mission of the Eternals is to prepare Earth for this event, a birth of a Celestial");
            Messages.LineBreak();
            Console.WriteLine("A. Emergence");
            Console.WriteLine("B. Judgment Day");
            Console.WriteLine("C. Ragnarok");
            Console.WriteLine("D. Secret Wars");
            CorrectAnswers.CorrectAnswerA();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("In the final battle, this person who killed Ajax, and wants to stop the Eternals from preventing the birth of the Celestial, finds himself guilt ridden and flies himself into the sun");
            Messages.LineBreak();
            Console.WriteLine("A. Kingo");
            Console.WriteLine("B. Phastos");
            Console.WriteLine("C. Druig");
            Console.WriteLine("D. Ikaris");
            CorrectAnswers.CorrectAnswerD();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/26/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 47%");
            Console.WriteLine("B. 57%");
            Console.WriteLine("C. 67%");
            Console.WriteLine("D. 77%");
            CorrectAnswers.CorrectAnswerA();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In a mid-credits scene, this famous musician makes his MCU debut as Eros, the brother of Thanos");
            Messages.LineBreak();
            Console.WriteLine("A. Justin Bieber");
            Console.WriteLine("B. Harry Styles");
            Console.WriteLine("C. The Weeknd");
            Console.WriteLine("D. Drake");
            CorrectAnswers.CorrectAnswerB();
            NameAndScore.GameCompleted();
        }
    }
}
