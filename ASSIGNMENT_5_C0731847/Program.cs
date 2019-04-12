using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_5_C0731847
{//Gagandeep Kaur Waraich
    //C0731847
    class Program
    {
        string[] Letters = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public static void Main()
        {
            Program orange = new Program();
            Console.WriteLine(orange.Gematria("universe"));

        }
        public int Gematria(string word)
        {
            int GematriaValue = 0;
            for (int i = 0; i < word.Length; i++)
            {
                GematriaValue += LetterValue(word[i].ToString());
            }
            return GematriaValue;
        }
        public int LetterValue(string letter)
        {
            int x = 0;
            while(Letters[x] != letter)
            {
                if (Letters[x++] == letter) return x;
            }
            return -1;
        }
    }
}
