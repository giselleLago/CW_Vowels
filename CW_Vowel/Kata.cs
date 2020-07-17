using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_Vowel
{
    public class Kata
    {
        public int GetVowelCount(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }
    }
}
