using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private Timer _timer = null;

        public Game(int NumberofSeconds)
        {
            this.NumberofSeconds = NumberofSeconds;
            
        }
        public int Score { get; private set; } = 0;
        private void AddScore()
        {
            Score++;
        }
        private void SubstractScore()
        {
            Score--;
        }
        private string StringOperator(Question.OpertorEn op)
        {
            switch (op)
            {
                case Question.OpertorEn.Add:
                    return "+";
                case Question.OpertorEn.SubStract:
                    return "-";
                case Question.OpertorEn.Multiply:
                    return "×";
                case Question.OpertorEn.Divide:
                    return "÷";
                default:
                    throw new Exception("op is incorrect " + op);
            }
        }
        private void WriteQuestion(int NumberofQuestion, Question Q)
        {
            String Caption = "Question {0} \n   {1} {2} {3} = ?".FormatWith(NumberofQuestion,
                Q.Num1,
                StringOperator(Q.oper),
                Q.Num2);
            CP.WriteLine(Caption);
            int i;
            for (i = 0; i < Q.Choice.Length; i++)
            {
                CP.WriteLine("     {0}. {1}".FormatWith(i + 1, Q.Choice[i]));
            }
            //ConsoleHelper.WriteLine("Correct Answer is::" + Q.CorrectAnswerChoice);



           

        }
        private void GetAnswerFromUser(Question Q)
        {
            String Choice = CP.EnquieryWithChoice("Please type your question [1 to 4]::", "1", "2", "3", "4");
            int intChoice = int.Parse(Choice);
            int arrayIndexChoice = intChoice - 1;
            Q.UserAnswerChoice = arrayIndexChoice;
        }
        private void DisplayScore()
        {

            CP.WriteLine("Your current score is {0}".FormatWith(this.Score));
            CP.WriteLine("");
           

        }
        private void CheckTheAnswer(Question Q)
        {
            Q.CheckTheAnswer();
            if (Q.IsAnswerCorrect)
            {
                
                AddScore();
            } else
            {
                SubstractScore();
            }


        }
      
        Boolean IsEndTime = false;
        private void ClearScreen()
        {
            Console.Clear();
        }
        public String Name { get; private set; }
        public void ClearValue()
        {
            Score = 0;
        }
        public void Run()
        {

            if (String.IsNullOrWhiteSpace(Name))
            {
                Name = CP.Enquiery("What is your Name:", false);
                CP.WriteLineWithDelay("Hello {0}, I would like to test your math skill.".FormatWith(Name));
                CP.WriteLineWithDelay("SimpleMathQuiz is the name of the game.");
                CP.WriteLineWithDelay("The rule is you have {0} seconds to answer thse mathmetic questions.".FormatWith(NumberofSeconds));
                CP.WriteLineWithDelay("You can choose choice 1-4.");
                CP.WriteLineWithDelay("You choose correctly you earn 1 score.");
                CP.WriteLineWithDelay("You choose incorrectly you score will be deducted by 1.");
                CP.EnquieryWithChoice("If you are ready please type Y::",0, "Y");
            }

            IsEndTime = false;

            System.Timers.Timer t = new System.Timers.Timer (NumberofSeconds * 1000);

            t.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => {
                IsEndTime = true;
                t.Stop();
            };
            t.Start();



            int NumberofQuestion = 1;
          
            while (!IsEndTime )
            {
                Question Q = new Question();
                ClearScreen();
                DisplayScore();
                WriteQuestion(NumberofQuestion, Q);
                GetAnswerFromUser(Q);
                CheckTheAnswer(Q);
                //DisplayScore();

                NumberofQuestion++;
            }
            CP.WriteLineWithDelay("Game over.",100);
            CP.WriteLineWithDelay("Your Score is {0}".FormatWith(this.Score),200);




        }


    }
}
