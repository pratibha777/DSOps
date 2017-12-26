using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Interview
{
    //1. Write a function that reverses the order of words of a sentence.
    public class Q1
    {
        //Method to reverse words in a sentence using inbuilt C# reverse function
        public string ReverseWords1(string s)
        {
            string reversedWords = string.Empty;
            if (s!= null & !string.IsNullOrEmpty(s))
            { 
                string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                reversedWords = string.Join(" ", s.Split(' ').Reverse());               
            }
            return reversedWords;
        }

        //Method to reverse words in a sentence 'without' using inbuilt C# reverse function
        public string ReverseWords2(string s)
        {
            StringBuilder reversedWords = new StringBuilder();
            if (s!=null & !string.IsNullOrEmpty(s))
            {
                string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = words.Length - 1; i > -1; i--)
                {
                    reversedWords.Append(words[i]);
                    if (i > 0)
                        reversedWords.Append(" ");
                }               
            }
            return reversedWords.ToString();
        }             
    }
}
