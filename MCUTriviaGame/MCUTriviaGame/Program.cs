using System;

namespace MCUTriviaGame
{
    internal class Program
    {
        private const string apiUrl = "https://localhost:44305/";
        static void Main(string[] args)
        {
            //DisplayMenu.MainMenu(); ]

            MCUApp app = new MCUApp(apiUrl); 
            app.Run();
            
        }
    }
}
