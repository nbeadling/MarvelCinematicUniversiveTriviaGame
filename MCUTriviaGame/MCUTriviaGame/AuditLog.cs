using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MCUTriviaGame
{
    public class AuditLog
    {
        public static void WriteFiles(string name, string game, int score)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string newFileName = Path.Combine(directory, @"..\..\..\Logs\log.txt");
            string fullPath = Path.GetFullPath(newFileName);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss:} | Name: {name} | Game: {game} | Score: {score} out of 10");
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ReadTheAuditLog()
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string filename = Path.Combine(@"..\..\..\Logs\log.txt");
            string fullPath = Path.Combine(filename);

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        Console.WriteLine(line);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
