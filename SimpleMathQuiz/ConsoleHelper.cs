using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathQuiz
{
    public static class ConsoleHelper
    {
        public static  String Read()
        {
            return Console.ReadLine();
        }
        public static void Write(String value)
        {
            Console.Write(value);
        }
        public static void WriteLine(String value)
        {
            Console.WriteLine(value);
        }
        public static string Enquiery(String question, bool CanAnswerBeblank)
        {
            Boolean IsAnswerValid = false;
            String answer = "";
            while (!IsAnswerValid)
            {

                Write(question);
                answer = Read();
                IsAnswerValid = true;
                if(!CanAnswerBeblank && answer.Trim ().Length == 0)
                {
                    IsAnswerValid = false;

                }
               
                if (!IsAnswerValid)
                {
                    Write("Your answer is not valid, plesae try again");
                }
            
            }
            return answer;
        }
        public static string EnquieryWithChoice(String question, params string[] arrValidvalue)
        {
            Boolean IsAnswerValid = false;
            String answer = "";
            while (!IsAnswerValid)
            {

                Write(question);
                answer = Read();
                IsAnswerValid = arrValidvalue.Contains(answer);
                if (!IsAnswerValid)
                {
                    Write("Your answer is not valid, plesae try again");
                }
                /*
                foreach (string validvalud in arrValidvalue)
                {
                    if (answer.Equals(validvalud))
                    {
                        IsAnswerValid = true;
                        break;
                    }
                
                }
                */

            }
            return answer;

        }
    }
}
