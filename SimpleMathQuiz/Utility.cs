using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathQuiz
{
    public class Utility
    {
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
        public static List<int> GetListofUniqueRandom(int min, int max, int NumberofRandom)
        {
           // List<int> listResult = new List<int>();
            int CountLoop = 0;
            int MaxCountLoop = 1000000;
            HashSet<int> hashUnique = new HashSet<int>();

            while(hashUnique.Count < NumberofRandom)
            {
                int RandomNumber = Utility.GetRandomNumber(min, max);
                if(!hashUnique.Contains(RandomNumber))
                {
                    hashUnique.Add(RandomNumber);
                   
                }
                CountLoop++;
                if(CountLoop > MaxCountLoop)
                {
                    throw new Exception("GetListofUniqueRandom attempt {0} times but still cannot get the result. Please check the parameter".FormatWith(MaxCountLoop));
                }
            }
            return hashUnique.ToList();
            //return listResult;
        }
    }
}
