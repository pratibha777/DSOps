using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    //3. Write a function f(a, b) which takes two character string arguments and returns a string containing 
    //only the characters found in both strings.

    public class Q3
    {     
        public string GetStringWithCommonChars1(char[] ch1, char[] ch2)
        {
            char[] newString;
            if (ch1 != null && ch2 != null)
            {
                newString = ch1.Intersect<char>(ch2).ToArray();
            }
            else
                newString=string.Empty.ToCharArray();

            return new string(newString);
        }

        public string GetStringWithCommonChars2(char[] ch1, char[] ch2)
        {
            StringBuilder newString = new StringBuilder();
            if (ch1 != null && ch2 != null)
            {
                foreach (char c in ch1)
                {
                    if (!newString.ToString().Contains(c) && ch2.Contains(c))
                        newString.Append(c);
                }
            }
            else
                newString.Append(string.Empty);

            return newString.ToString();
        }
    }
}
