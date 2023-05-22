using System.Collections.Generic;
using System;

namespace Text
{
    public class Class1
    {
        int words = 1;

        public static int CamelCase(string s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if(Char.IsUpper(s[i]))
                {
                    words++;
                }

            }
        }
    }
}