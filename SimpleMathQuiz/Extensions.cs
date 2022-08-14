using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathQuiz
{
    public static class Extensions
    {
        public static string FormatWith(this string value, params object[] args)
        {
            return String.Format(value, args);
        }
    }
}
