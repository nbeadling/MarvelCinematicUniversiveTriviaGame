using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_3
{
    public class DoctorStrangeTriviaGame : IQuestions
    {
        public static void DoctorStrangeStartMenu()
        {
            DoctorStrangeTriviaGame game = new DoctorStrangeTriviaGame();
            NameAndScore.MovieTitle = "Doctor Strange";
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
            else
            {
                Messages.NotAValidResponse();
                DisplayMenu.StartTriviaGame();
            }
        }
        public void Question1()
        {
            Console.Clear();
            Console.WriteLine("Question 1");
            Messages.LineBreak();
            Console.WriteLine("This Actor plays Stephan Strange");
            Messages.LineBreak();
            Console.WriteLine("A. Tyler Michell");
            Console.WriteLine("B. Tom Cruise");
            Console.WriteLine("C. Benedict Cumberbatch");
            Console.WriteLine("D. Chris Pine");
            CorrectAnswers.CorrectAnswerC();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine($"This Person directed {NameAndScore.MovieTitle}");
            Messages.LineBreak();
            Console.WriteLine("A. Scott Derrickson");
            Console.WriteLine("B. Sam Raimi");
            Console.WriteLine("C. John Carpenter");
            Console.WriteLine("D. Jordan Peele");
            CorrectAnswers.CorrectAnswerA();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Stephen Strange is this type of Doctor");
            Messages.LineBreak();
            Console.WriteLine("A. Radiologist");
            Console.WriteLine("B. Anesthesiologist");
            Console.WriteLine("C. Pediatrician");
            Console.WriteLine("D. Neurosurgeon");
            CorrectAnswers.CorrectAnswerD();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This is how Dr. Strange hurts his hands");
            Messages.LineBreak();
            Console.WriteLine("A. Fist Fight");
            Console.WriteLine("B. Car Accident");
            Console.WriteLine("C. Working Out");
            Console.WriteLine("D. Punching a Wall");
            CorrectAnswers.CorrectAnswerB();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine($"{NameAndScore.MovieTitle} made this much at the box office:");
            Messages.LineBreak();
            Console.WriteLine("A. 377.8 Million");
            Console.WriteLine("B. 477.8 Million");
            Console.WriteLine("C. 577.8 Million");
            Console.WriteLine("D. 677.8 Million");
            CorrectAnswers.CorrectAnswerD();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Strange goes to Kamar-Taj and meets Mordo who introduces him to this person who agrees to allow him to train as a sorcerer");
            Messages.LineBreak();
            Console.WriteLine("A. Ancient One");
            Console.WriteLine("B. Merlin");
            Console.WriteLine("C. Wong");
            Console.WriteLine("D. Gandalf");
            CorrectAnswers.CorrectAnswerA();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("The film begins with Kaecilius stealing pages from a book belongin to the Ancient One, and uses these pages to summon this entity from the Dark Dimension");
            Messages.LineBreak();
            Console.WriteLine("A. Umar");
            Console.WriteLine("B. Clea");
            Console.WriteLine("C. Dormammu");
            Console.WriteLine("D. Orini");
            CorrectAnswers.CorrectAnswerC();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("Dr. Starnge gets help from this piece of clothing");
            Messages.LineBreak();
            Console.WriteLine("A. Cloak of Hats");
            Console.WriteLine("B. Cloak of Levitation");
            Console.WriteLine("C. Cloak of Jacket");
            Console.WriteLine("D. Cloak of Jumping");
            CorrectAnswers.CorrectAnswerB();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/10/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 84%");
            Console.WriteLine("B. 89%");
            Console.WriteLine("C. 94%");
            Console.WriteLine("D. 99%");
            CorrectAnswers.CorrectAnswerB();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the mid-credits scene, Strange helps this Avenger search for his father");
            Messages.LineBreak();
            Console.WriteLine("A. Bruce Banner");
            Console.WriteLine("B. Tony Stark");
            Console.WriteLine("C. Thor");
            Console.WriteLine("D. Hawkeye");
            CorrectAnswers.CorrectAnswerC();
            NameAndScore.GameCompleted();
        }
    }
}
