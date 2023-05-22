using System.Collections.Generic;
using System;

namespace Text
{
    public class Str
    {

        public static int CamelCase(string s)
        {
            int words = 1;

            if(s.Length == 0)
            {
                return 0;
            }
            else
            {
                for(int i = 0; i < s.Length; i++)
                {
                    if(Char.IsUpper(s[i]))
                    {
                        words++;
                    }

                }
            }
            return words;
        }
    }
}