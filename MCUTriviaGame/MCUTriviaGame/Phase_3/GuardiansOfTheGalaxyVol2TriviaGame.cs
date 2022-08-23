using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_3
{
    public class GuardiansOfTheGalaxyVol2TriviaGame : IQuestions
    {
        public static void GuardiansOfTheGalaxyVol2StartMenu()
        {
            GuardiansOfTheGalaxyVol2TriviaGame game = new GuardiansOfTheGalaxyVol2TriviaGame();
            NameAndScore.MovieTitle = "Guardians of the Galaxy Vol. 2";
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
                DisplayMenu.DisplayScoreByGame();
                BackToGuardiansOfTheGalaxyVol2StartMenu();
            }
            else if (DisplayMenu.StartGame == "U")
            {
                DisplayMenu.DisplayUserScoreBYGame();
                BackToGuardiansOfTheGalaxyVol2StartMenu(); 
            }
            else
            {
                Messages.NotAValidResponse();
                DisplayMenu.StartTriviaGame();
            }
        }

        public static void BackToGuardiansOfTheGalaxyVol2StartMenu()
        {
            string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
            if (mainMenuOrCloseProgram == "B")
            {
                GuardiansOfTheGalaxyVol2StartMenu(); 
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
            Console.WriteLine("The film starts with the Guardians in Battle with this song playing as Baby Groot Dances around the battlefield");
            Messages.LineBreak();
            Console.WriteLine("A. Fox on the Run by Sweet");
            Console.WriteLine("B. Mr. Blue Sky by Electric Light Orchestra");
            Console.WriteLine("C. The Chain by Fleetwood Mac");
            Console.WriteLine("D. My Sweet Lord by George Harrison");
            CorrectAnswers.CorrectAnswerB();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine($"This Person directed {NameAndScore.MovieTitle}");
            Messages.LineBreak();
            Console.WriteLine("A. James Gunn");
            Console.WriteLine("B. Billy Gunn");
            Console.WriteLine("C. Austin Gunn");
            Console.WriteLine("D. Danny Gunn");
            CorrectAnswers.CorrectAnswerA();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Ayesha, the leader of the Sovereign race, has the Guardians protect these valuables from Abilisk, an inter dimensional monster");
            Messages.LineBreak();
            Console.WriteLine("A. Gold");
            Console.WriteLine("B. Silver");
            Console.WriteLine("C. Batteries");
            Console.WriteLine("D. Vibranium");
            CorrectAnswers.CorrectAnswerC();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This Guardian ends up stealing some of the valuable and leads to the Sovereign attacking the Guardian's ship with a fleet of drones");
            Messages.LineBreak();
            Console.WriteLine("A. Peter Quill");
            Console.WriteLine("B. Drax");
            Console.WriteLine("C. Baby Groot");
            Console.WriteLine("D. Rocket");
            CorrectAnswers.CorrectAnswerD();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine($"{NameAndScore.MovieTitle} made this much at the box office:");
            Messages.LineBreak();
            Console.WriteLine("A. 663.8 Million");
            Console.WriteLine("B. 763.8 Million");
            Console.WriteLine("C. 863.8 Million");
            Console.WriteLine("D. 963.8 Million");
            CorrectAnswers.CorrectAnswerC();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("This person saves the Guardians from the drones and reveals himself to be Peter Quill's Father");
            Messages.LineBreak();
            Console.WriteLine("A. Ago");
            Console.WriteLine("B. Ego");
            Console.WriteLine("C. Id");
            Console.WriteLine("D. Yondu Udonta");
            CorrectAnswers.CorrectAnswerB();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("The planet Ego lives on, it is reveal this is at the planet's core");
            Messages.LineBreak();
            Console.WriteLine("A. Ego's Brain");
            Console.WriteLine("B. Ego's Heart");
            Console.WriteLine("C. Ego's Nervous System");
            Console.WriteLine("D. Ego's Stomach");
            CorrectAnswers.CorrectAnswerA();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("This person sacrifices himself to save Quill after a bomb explodes killing Ego");
            Messages.LineBreak();
            Console.WriteLine("A. Ego");
            Console.WriteLine("B. Drax the Destroyer");
            Console.WriteLine("C. Rocket");
            Console.WriteLine("D. Yondu Udonta");
            CorrectAnswers.CorrectAnswerD();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/11/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 80%");
            Console.WriteLine("B. 85%");
            Console.WriteLine("C. 90%");
            Console.WriteLine("D. 95%");
            CorrectAnswers.CorrectAnswerB();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In a mid-credits scene, Ayesha creates a new artifical being name this, with whom she plans to destroy the Guardians");
            Messages.LineBreak();
            Console.WriteLine("A. Adrian");
            Console.WriteLine("B. Adam");
            Console.WriteLine("C. Arthur");
            Console.WriteLine("D. Eros");
            CorrectAnswers.CorrectAnswerB();
            NameAndScore.GameCompleted();
        }
    }
}
