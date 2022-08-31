using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame; 

namespace MCUTriviaGame.Models
{
    public class Likes
    {
        public string MovieName { get; set; }

        public int Like { get; set; }

        public int Dislike { get; set; }

        public Likes()
        {

        }

        public Likes(string movieName, int like, int dislike)
        {
            MovieName = movieName;
            Like = like;
            Dislike = dislike;
        }

        public Likes(string movieName)
        {
            MovieName = movieName;
        }
        public static void GetLikes()
        {
            MCUApp app = new MCUApp();
            app.GetLikesForGame();
            DisplayMenu.BackToDisplayMenu();
        }

        public static void AddLike()
        {
            MCUApp app = new MCUApp();
            app.AddLike();
            Messages.LineBreak(); 
            Console.WriteLine("Like has been added!");
            Messages.LineBreak();
            DisplayMenu.BackToDisplayMenu(); 
        }

        public static void AddDisLike()
        {
            MCUApp app = new MCUApp();
            app.AddDisLike(); 
            Messages.LineBreak();
            Console.WriteLine("We're sorry you didn't like the game");
            Messages.LineBreak();
            DisplayMenu.BackToDisplayMenu();
        }
    }
}
