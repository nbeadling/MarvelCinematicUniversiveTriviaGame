using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MCUTriviaGame.Services; 

namespace MCUTriviaGame
{
    public class Reviews
    {
        public string Username { get; set; }

        public string MovieName { get; set; }

        public string Review { get; set; }

        public Reviews(string username, string movieName, string review)
        {
            Username = username;
            MovieName = movieName;
            Review = review;
        }

        public Reviews()
        {

        }
        public static void WriteAReview(string name, string review)
        {
            Console.Clear(); 
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string newFileName = Path.Combine(directory, @"..\..\..\Reviews\review.txt");
            string fullPath = Path.GetFullPath(newFileName);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    sw.WriteLine($"{name} wrote: {review}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void WriteAReview()
        {
            Console.Clear(); 
            Console.WriteLine($"Do you want to write a review for {NameAndScore.MovieTitle} trivia game?");
            Messages.LineBreak(); 
            Console.WriteLine("Press Y for yes, press any button to go back to main menu?");
            Console.WriteLine($"Press R to see previous revies for {NameAndScore.MovieTitle}");
            Console.WriteLine($"Press D to delete your review(s) of {NameAndScore.MovieTitle}");
            string review = Console.ReadLine().ToUpper(); 
            MCUApp mcuApp = new MCUApp();
            if(review == "Y")
            {
                Console.Clear(); 
                Console.WriteLine("Write Your review: ");
                string userReview = Console.ReadLine();
                
                mcuApp.SaveReview(userReview);
                Console.WriteLine("Review Saved!");
                Messages.LineBreak();
                DisplayMenu.BackToDisplayMenu(); 
            }
            else if(review == "R")
            {
                mcuApp.GetReviewByGame();
                Messages.LineBreak();
                DisplayMenu.BackToDisplayMenu(); 
            }
            else if(review == "D")
            {
                MCUApiService mCUApiService = new MCUApiService();
                mCUApiService.DeleteReservation();
                Console.Clear();
                Console.WriteLine("Review Deleted!");
                Messages.LineBreak();
                DisplayMenu.BackToDisplayMenu(); 
            }
            else
            {
                DisplayMenu.MainMenu();
            }
        }
        public static void ReadTheReviews()
        {
            Console.Clear(); 
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string filename = Path.Combine(@"..\..\..\Reviews\review.txt");
            string fullPath = Path.Combine(filename);

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        Console.WriteLine(line);
                        Messages.LineBreak();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DoYouWantToWriteAReview()
        {
            Console.Clear(); 
            Console.WriteLine("Write a short review of the Marvel Cinematic Universive Trivia Game");
            Messages.LineBreak();
            string review = Console.ReadLine();
            WriteAReview(NameAndScore.Name, review); 
        }
    }
}
