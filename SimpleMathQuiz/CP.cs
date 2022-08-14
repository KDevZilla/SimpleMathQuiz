using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathQuiz
{
    //CP in this case stand for ConsoleHelper
    public static class CP
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
        public static void WriteLineWithDelay(String value)
        {
            WriteLineWithDelay(value, 5);
        }
       public static void WriteLineWithDelay(String value,int numberofMilisecondTodelay)
        {
            int i;
            for (i = 0; i < value.Length; i++)
            {
                Console.Write(value.Substring(i, 1));
                System.Threading.Thread.Sleep(numberofMilisecondTodelay);
               
            }
            Console.WriteLine();
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
                    WriteLine("Your answer is not valid, plesae try again");
                }
            
            }
            return answer;
        }
        public static string EnquieryWithChoice(String question,int numberofMilisecondTodelay, params string[] arrValidvalue)
        {
            Boolean IsAnswerValid = false;
            String answer = "";
            while (!IsAnswerValid)
            {
                if (numberofMilisecondTodelay > 0)
                {
                    WriteLineWithDelay(question, numberofMilisecondTodelay);
                }
                else
                {
                    Write(question);
                }
                answer = Read();
                IsAnswerValid = arrValidvalue.Contains(answer);
                if (!IsAnswerValid)
                {
                    WriteLine("Your answer is not valid, plesae try again");
                }


            }
            return answer;
        }
        public static string EnquieryWithChoice(String question, params string[] arrValidvalue)
        {
            return EnquieryWithChoice(question, 0, arrValidvalue);

           

        }
    }
}
