using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_it_practice
{
    internal class Palindrome
    {
        public string Word { get; private set; }

        public char[] Letters = new char[]{};
        public bool Result { get; private set; }

        public Palindrome(string word)
        {
            Word = word;
            Letters = Word.ToCharArray();
        }

        public void Check()
        {
            for (int i = 0; i < Letters.Length/2; i++)
            {
                if (Letters[i] == Letters[^(i+1)])
                {
                    Result = true;
                }
            }

            Console.WriteLine(Result);
        }

    }
}
