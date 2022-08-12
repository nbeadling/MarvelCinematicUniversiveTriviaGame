using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Phase_3
{
    public class CaptainAmericaCivilWarTriviaGame : IQuestions
    {
        public static void CaptainAmericaCivilWarStartMenu()
        {
            CaptainAmericaCivilWarTriviaGame game = new CaptainAmericaCivilWarTriviaGame();
            NameAndScore.MovieTitle = "Captain America: Civil War"; 
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
            Console.WriteLine("This Avenger accidentally diverts an explosion and accidentally destroys a nearby building and kills Wakandan humanitarian workers");
            Messages.LineBreak();
            Console.WriteLine("A. Steve Rogers");
            Console.WriteLine("B. Natasha Romanoff");
            Console.WriteLine("C. Sam Wilson");
            Console.WriteLine("D. Wanda Maximoff");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question2();
        }
        public void Question2()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 2");
            Messages.LineBreak();
            Console.WriteLine("This brother duo directed Captain America: Civil War");
            Messages.LineBreak();
            Console.WriteLine("A. The Cohen Brothers (Joel and Ethan)");
            Console.WriteLine("B. The Russo Brothers (Anthony and Joe)");
            Console.WriteLine("C. The Duffer Brothers (Matt and Ross)");
            Console.WriteLine("D. The Skylar Brothers (Randy and Jason)");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerB();
            Question3();
        }
        public void Question3()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 3");
            Messages.LineBreak();
            Console.WriteLine("Thaddeus Ross informs the Avengers that the United Nations is preparing to pass these Accords, which will establish a UN panel to oversee and control the team");
            Messages.LineBreak();
            Console.WriteLine("A. Slovenia Accords");
            Console.WriteLine("B. Siberia Accords");
            Console.WriteLine("C. Sokovia Accords");
            Console.WriteLine("D. Serbia Accords");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question4();
        }
        public void Question4()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 4");
            Messages.LineBreak();
            Console.WriteLine("These are the two leaders of the different factions");
            Messages.LineBreak();
            Console.WriteLine("A. Tony Stark and Steve Rogers");
            Console.WriteLine("B. Bruce Banner and Steve Rogers");
            Console.WriteLine("C. Tony Stark and Sam Wilson");
            Console.WriteLine("D. Bruce Banner and Sam Wilson");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question5();
        }
        public void Question5()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 5");
            Messages.LineBreak();
            Console.WriteLine("Captain America: Civil War made this much at the box office:");
            Messages.LineBreak();
            Console.WriteLine("A. 1.123 Billion");
            Console.WriteLine("B. 1.133 Billion");
            Console.WriteLine("C. 1.143 Billion");
            Console.WriteLine("D. 1.153 Billion");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question6();
        }
        public void Question6()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 6");
            Messages.LineBreak();
            Console.WriteLine("This is person steals the book that activates Bucky Barnes Brainwashing and uses it to cause the discord within the Avengers");
            Messages.LineBreak();
            Console.WriteLine("A. Thanos");
            Console.WriteLine("B. Loki");
            Console.WriteLine("C. Helmut Zemo");
            Console.WriteLine("D. Kang The Conqueror");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question7();
        }
        public void Question7()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 7");
            Messages.LineBreak();
            Console.WriteLine("This SuperHero makes his MCU debut in this film");
            Messages.LineBreak();
            Console.WriteLine("A. Wolverine");
            Console.WriteLine("B. Reed Richards");
            Console.WriteLine("C. Spiderman");
            Console.WriteLine("D. Ghost Rider");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            Question8();
        }
        public void Question8()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 8");
            Messages.LineBreak();
            Console.WriteLine("Helmut Zemo has Tony Stark watch a tape that reveals his parents death and shows this person responsible for their crash and murder");
            Messages.LineBreak();
            Console.WriteLine("A. The Winter Soldier");
            Console.WriteLine("B. Obadiah Stane");
            Console.WriteLine("C. The Mandarin");
            Console.WriteLine("D. Whiplash");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerA();
            Question9();
        }
        public void Question9()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 9");
            Messages.LineBreak();
            Console.WriteLine("As of 8/9/2022, this is Captain America : Civil War Rotten Tomatoes Score");
            Messages.LineBreak();
            Console.WriteLine("A. 75%");
            Console.WriteLine("B. 80%");
            Console.WriteLine("C. 85%");
            Console.WriteLine("D. 90%");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerD();
            Question10();
        }
        public void Question10()
        {
            Messages.LineBreak();
            Console.WriteLine("Question 10");
            Messages.LineBreak();
            Console.WriteLine("In the mid-credits scene, Stan Lee is a FedEx delievery driver with a package for:");
            Messages.LineBreak();
            Console.WriteLine("A. Tony Stone");
            Console.WriteLine("B. Anthony Stone");
            Console.WriteLine("C. Tony Stank");
            Console.WriteLine("D. Tony Downey");
            Messages.LineBreak();

            CorrectAnswers.CorrectAnswerC();
            NameAndScore.GameCompleted();
        }
    }
}
