using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SimpleMathQuiz";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Boolean IsUserStillWouldliketoplay = true;
            Game game = new Game(50);
            while (IsUserStillWouldliketoplay)
            {
                
                game.Run();
                String Choice = CP.EnquieryWithChoice("Do you want to play again? (Y/N):", "Y", "N");
                IsUserStillWouldliketoplay = (Choice == "Y");
                game.ClearValue();

            }
            CP.WriteLine("Thank you for playing {0}.".FormatWith (game.Name));
            Console.ReadKey();

        }
    }
}
