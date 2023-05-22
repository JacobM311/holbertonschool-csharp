using System;
using System.Text.RegularExpressions;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            string input = Regex.Replace(s.ToLower(), "[^a-z]", "");

            char[] array = input.ToCharArray();
            Array.Reverse(array);

            return new string(array) == input;
        }
    }
}