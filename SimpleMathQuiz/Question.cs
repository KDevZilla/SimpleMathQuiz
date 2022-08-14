using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathQuiz
{

    public class Question
    {
        public enum OpertorEn
        {
            Add=0,
            SubStract=1,
            Multiply=2,
            Divide=3
        }
        public int UserAnswerChoice { get;  set; }
        public int CorrectAnswerChoice { get; private set; }
        public OpertorEn oper { get; private set; }
        /*
        public int Choice1 { get; private set; }
        public int Choice2 { get; private set; }
        public int Choice3 { get; private set; }
        public int Choice4 { get; private set; }
        */

        //Just simple Choice1 to Choie4 is enough
        public int[] Choice { get; private set; }
        public int NumberFrom { get; set; }=20;
        public int NumberTo { get; set; }=100;

        public int Num1 { get; private set; }
        public int Num2 { get; private set; }
        public int Result { get; private set; }
        public bool IsAnswerCorrect { get; private set; } = false;
        public void CheckTheAnswer()
        {
            IsAnswerCorrect = false;
            if(UserAnswerChoice == CorrectAnswerChoice)
            {
                IsAnswerCorrect = true;
                return;
            }

        }
        private void CreateQuestion()
        {
            Num1 = Utility.GetRandomNumber(NumberFrom, NumberTo);
            Num2 = Utility.GetRandomNumber(NumberFrom, NumberTo);
            int NumTemp = 0;
            Result = 0;
            int OperatorNumber = Utility.GetRandomNumber(0, 4);
            oper = (OpertorEn)OperatorNumber;

            switch (oper)
            {
                case OpertorEn.Add:
                    Result = Num1 + Num2;
                    break;
                case OpertorEn.SubStract:
                    if (Num2 > Num1)
                    {
                        NumTemp = Num1;
                        Num1 = Num2;
                        Num2 = NumTemp;
                    }
                    Result = Num1 - Num2;
                    break;
                case OpertorEn.Multiply:
                    Num2 = Utility.GetRandomNumber(3, 9) * 10;
                    Result = Num1 * Num2;
                    break;
                case OpertorEn.Divide:
                    Num2 = Utility.GetRandomNumber(3, 9) * 10;
                    Result = Num1 * Num2;
                    NumTemp = Result;
                    Result = Num1;
                    Num1 = NumTemp;
                    break;
            }
        }
        private void CreateChoice()
        {
            this.CorrectAnswerChoice = Utility.GetRandomNumber(0, 4);


            int MinIncorrectValue = Result - 20;
            int MaxIncorrectValue = Result + 20;


            List<int> listUnCorrectAnswer = Utility.GetListofUniqueRandom(MinIncorrectValue,
                MaxIncorrectValue,
                3,
                Result);
            int i;
            int IndexUnCorrectAnswer = 0;
            for (i = 0; i <= 3; i++)
            {
                if (i == this.CorrectAnswerChoice)
                {
                    // switch 
                    Choice[i] = Result;
                    continue;
                }
                int IncorrectAnswer = listUnCorrectAnswer[IndexUnCorrectAnswer];
                Choice[i] = IncorrectAnswer;
                IndexUnCorrectAnswer++;
               
            }
            
        }
        public Question()
        {
            Choice = new int[4];
            CreateQuestion();
            CreateChoice();
        }
    }
}
