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
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("Press any key to continue");
            
            String Name = ConsoleHelper.Enquiery("What is your Name:", false);
            Console.ReadKey();

        }
    }
}
