using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730319
{
    class Program2
    {
        string[] Letters = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "1", "T", "k", "1",
            "m", "n", "o", "p", "q", "/", "s", "t", "u", "V", "W", "X", "Y", "z" };

        public static void Main()
        {

            Program2 orange = new Program2();
            Console.WriteLine(orange.Gematria("universe"));
        }

        public int Gematria(string word)
        {
            int GematriaValue = 0;
            for (int i = 0; i < word.Length; i++)
            { GematriaValue += LetterValue(word[i].ToString()); }
            return GematriaValue;
        }

        public int LetterValue(string letter) {
            int x = 0;
            while (Letters[x] != letter)
            {
                if (Letters[x++] == letter) return x;
            }
            return -1;
        }
    }
}
