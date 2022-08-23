using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_3
{
    public class AntManAndTheWaspTriviaGame : IQuestions
    {
        public static void AntManAndTheWaspStartMenu()
        {
            AntManAndTheWaspTriviaGame game = new AntManAndTheWaspTriviaGame();
            NameAndScore.MovieTitle = "Ant-Man and the Wasp";
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
                string mainMenuOrCloseProgram = Console.ReadLine().ToUpper();
                if (mainMenuOrCloseProgram == "B")
                {
                    AntManAndTheWaspStartMenu(); 
                }
                else
                {
                    DisplayMenu.EndGame();
                }
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
            Console.WriteLine("The film begins with Scott Lang under house arrest because of his involvement with the Avengers and in violation of the Sokovia Accords from this film");
            Messages.LineBreak();
            Console.WriteLine("A. Avengers: Infinity War");
            Console.WriteLine("B. Black Panther");
            Console.WriteLine("C. Captain America: Civil War");
            Console.WriteLine("D. Doctor Strange");
            CorrectAnswers.CorrectAnswerC();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Messages.DirectorQuestion(); 
            Messages.LineBreak();
            Console.WriteLine("A. Peyton Reed");
            Console.WriteLine("B. Patty Jenkins");
            Console.WriteLine("C. David F. Sandberg");
            Console.WriteLine("D. Tim Story");
            CorrectAnswers.CorrectAnswerA();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Hope and Hank Pym kidnap Lang after he contacts them about a message he may have received from this person who is believed to be stucked in the Quantum Realm");
            Messages.LineBreak();
            Console.WriteLine("A. Jasmine van Dyne");
            Console.WriteLine("B. Jessica van Dyne");
            Console.WriteLine("C. Janet van Dyne");
            Console.WriteLine("D. Jane van Dyne");
            CorrectAnswers.CorrectAnswerC();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("This person as taken on the role of the Wasp");
            Messages.LineBreak();
            Console.WriteLine("A. Luis");
            Console.WriteLine("B. Hope van Dyme");
            Console.WriteLine("C. Cassie Lang");
            Console.WriteLine("D. Maggie");
            CorrectAnswers.CorrectAnswerB();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Messages.BoxOfficeQuestion();
            Messages.LineBreak();
            Console.WriteLine("A. 322.7 Million");
            Console.WriteLine("B. 422.7 Million");
            Console.WriteLine("C. 522.7 Million");
            Console.WriteLine("D. 622.7 Million");
            CorrectAnswers.CorrectAnswerD();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Hank Takes Hope and Scott to visit his estranged partner Bill Foster who is played by this actor");
            Messages.LineBreak();
            Console.WriteLine("A. Laurence Fishburne");
            Console.WriteLine("B. Forest Whitaker");
            Console.WriteLine("C. Denzel Washington");
            Console.WriteLine("D. Will Smith");
            CorrectAnswers.CorrectAnswerA();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("The FBI is able to track down Hope and Hank after this person reveals the location after he was given truth serum");
            Messages.LineBreak();
            Console.WriteLine("A. Dave");
            Console.WriteLine("B. Kurt");
            Console.WriteLine("C. Luis");
            Console.WriteLine("D. Jim");
            CorrectAnswers.CorrectAnswerC();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("Janet van Dyne is rescued from the Quantum Realm and is played by this actress");
            Messages.LineBreak();
            Console.WriteLine("A. Michelle Pfeiffer");
            Console.WriteLine("B. Michelle Williams");
            Console.WriteLine("C. Michelle Trachtenberg");
            Console.WriteLine("D. Michelle Monaghan");
            CorrectAnswers.CorrectAnswerA();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine($"As of 8/18/2022, this is {NameAndScore.MovieTitle} Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 87%");
            Console.WriteLine("B. 77%");
            Console.WriteLine("C. 67%");
            Console.WriteLine("D. 57%");
            CorrectAnswers.CorrectAnswerA();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("At the end of the film, Hank, Janet, Hope, and Scott are harvesting quantum energy, which one doesn't turn into dust as a result of the snap");
            Messages.LineBreak();
            Console.WriteLine("A. Hank");
            Console.WriteLine("B. Hope");
            Console.WriteLine("C. Janet");
            Console.WriteLine("D. Scott");
            CorrectAnswers.CorrectAnswerD();
            NameAndScore.GameCompleted();
        }
    }
}
