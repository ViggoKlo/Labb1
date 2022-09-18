using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    public static class Utils
    {
        public static List<char> StringChecker(string input)
        {
            char[] inputArray = input.ToCharArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                var substring = new List<char>();

                if (!IsNumber(inputArray[i]))
                {
                    continue;
                }

                for (int j = 0; j < inputArray.Length - i; j++)
                {
                    if (IsNumber(inputArray[i + j]))
                    {
                        substring.Add(inputArray[i + j]);
                    }
                    else
                    {
                        break;
                    }
                }

                if (SubstringChecker(substring))
                {
                    return substring;
                }

                else
                {
                    i = i + substring.Count;
                    
                }


            }
            return null;
        }

        public static bool SubstringChecker(List<char> substring)
        {
            var noFirstLast = substring.Skip(1).SkipLast(1).ToList();

            if (substring[0] == substring[substring.Count - 1] && substring.Count > 1 && !noFirstLast.Contains(substring[0]))
            {
                
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool IsNumber(char c)
        {
            return c >= '0' && c <= '9';
        }
    }
}
