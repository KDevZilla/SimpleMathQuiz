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
        public int CorrectAnswerChoie { get; private set; }
        public int Choice1 { get; private set; }
        public int Choice2 { get; private set; }
        public int Choice3 { get; private set; }
        public int Choice4 { get; private set; }


        public Question()
        {
            int Num1 = Utility.GetRandomNumber(20, 100);
            int Num2 = Utility.GetRandomNumber(20, 100);
            int NumTemp = 0;
            int Result = 0;
            int OperatorNumber = Utility.GetRandomNumber(0, 4);
            OpertorEn oper=(OpertorEn) OperatorNumber;

            switch (oper)
            {
                case OpertorEn.Add:
                    Result = Num1 + Num2;
                    break;
                case OpertorEn.SubStract:
                    if(Num2 > Num1)
                    {
                        NumTemp = Num1;
                        Num1 = Num2;
                        Num2 = NumTemp;
                    }
                    Result = Num1 - Num2;
                    break;
                case OpertorEn.Multiply:
                    Result = Num1 * Num2;
                    break;
                case OpertorEn.Divide:
                    Result = Num1 * Num2;
                    NumTemp = Result;
                    Result = Num1;
                    Num1 = NumTemp;
                    break;
            }

        }
    }
}
