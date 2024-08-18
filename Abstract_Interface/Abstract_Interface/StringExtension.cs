using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    static class StringExtension
    {
        public static bool HasUpper(this string text)
        {
            foreach (var letter in text)
            {
                if (Char.IsUpper(letter))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
