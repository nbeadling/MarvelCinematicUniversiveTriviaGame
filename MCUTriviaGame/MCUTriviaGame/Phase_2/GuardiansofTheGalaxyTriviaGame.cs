using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_2
{
    public class GuardiansofTheGalaxyTriviaGame : IQuestions
    {
        public static void GuardiansOfTheGalaxyStartMenu()
        {
            GuardiansofTheGalaxyTriviaGame game = new GuardiansofTheGalaxyTriviaGame();
            NameAndScore.MovieTitle = "Guardians of the Galaxy"; 
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
            Console.WriteLine("This Parks and Rec actor plays Peter Quill / Star-Lord");
            Messages.LineBreak();
            Console.WriteLine("A. Nick Offerman");
            Console.WriteLine("B. Rob Lowe");
            Console.WriteLine("C. Adam Scott");
            Console.WriteLine("D. Chris Pratt");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine("This person directed Guardians of the Galaxy");
            Messages.LineBreak();
            Console.WriteLine("A. Sean Gunn");
            Console.WriteLine("B. James Gunn");
            Console.WriteLine("C. Billy Gunn");
            Console.WriteLine("D. Austin Gunn");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerB();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("This former WWE Wrestler plays Drax the Destroyer");
            Messages.LineBreak();
            Console.WriteLine("A. John Cena");
            Console.WriteLine("B. Hulk Hogan");
            Console.WriteLine("C. Dave Bautista");
            Console.WriteLine("D. The Rock");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("In the beginning of the film, Peter Quill steals an orb that leads to Yondu Udonta sending this assassin to retrieve the Orb");
            Messages.LineBreak();
            Console.WriteLine("A. Gamora");
            Console.WriteLine("B. Groot");
            Console.WriteLine("C. Rocket");
            Console.WriteLine("D. Ronan the Accuser");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine("Guardians of the Galaxy made this much at the Box Office:");
            Messages.LineBreak();
            Console.WriteLine("A. 772.8 Million");
            Console.WriteLine("B. 782.8 Million");
            Console.WriteLine("C. 792.8 Million");
            Console.WriteLine("D. 802.8 Million");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("Gamora's adoptive father is this person, who Ronan the accuser reveals her betrayel");
            Messages.LineBreak();
            Console.WriteLine("A. Yondu Udonta");
            Console.WriteLine("B. Korath");
            Console.WriteLine("C. Thanos");
            Console.WriteLine("D. Rhomann Dey");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("The Orb is revealed to be holding this infinity stone");
            Messages.LineBreak();
            Console.WriteLine("A. Power Stone");
            Console.WriteLine("B. Time Stone");
            Console.WriteLine("C. Soul Stone");
            Console.WriteLine("D. Reality Stone");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("This Guardian of the Galaxy sacrifices himself");
            Messages.LineBreak();
            Console.WriteLine("A. Star-Lord");
            Console.WriteLine("B. Groot");
            Console.WriteLine("C. Rocket");
            Console.WriteLine("D. Drax The Destroyer");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerB();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine("As of 7/23/2022, this is Guardians of the Galaxy Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 77%");
            Console.WriteLine("B. 82%");
            Console.WriteLine("C. 87%");
            Console.WriteLine("D. 92%");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("The Post-Credits Scene has this duck");
            Messages.LineBreak();
            Console.WriteLine("A. Donald Duck");
            Console.WriteLine("B. Howard The Duck");
            Console.WriteLine("C. Daffy Duck");
            Console.WriteLine("D. The Aflac Duck");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerB();
            NameAndScore.GameCompleted();
        }
    }
}
