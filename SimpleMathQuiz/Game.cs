using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathQuiz
{
    public class Game
    {
       // int NumberofQuestion { get; set; }
        int NumberofSeconds { get; set; }
        private String Read()
        {
            return Console.ReadLine();
        }
        public Game(int NumberofSeconds)
        {
            this.NumberofSeconds = NumberofSeconds;
            
        }


        public void Run()
        {
            String Name = ConsoleHelper.Enquiery("What is your Name:", false);
            ConsoleHelper.WriteLine("Hello {0}, I would like to test your math skill.".FormatWith ( Name));
            ConsoleHelper.WriteLine("SimpleMathQuiz is the name of the game.");
            ConsoleHelper.WriteLine("The rule is you have {0} seconds to answer thse mathmetic questions.".FormatWith (NumberofSeconds));            
            ConsoleHelper.WriteLine("You can choose 1-4 choice to mathematic the question");
            ConsoleHelper.EnquieryWithChoice("If you are ready please type 1", "1");



        }
    }
}
