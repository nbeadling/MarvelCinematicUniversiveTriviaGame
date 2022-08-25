using System;
using System.Collections.Generic;
using System.Text;
using System.IO; 

namespace MCUTriviaGame
{
    public class Reviews
    {
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
