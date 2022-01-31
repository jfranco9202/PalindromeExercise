using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //Reversing the word
            var Reversed = "";
            for (int i = word.Length -1; i >= 0; i--)
            {
                Reversed += word.ToLower()[i];
            }

            //comparing the original with the reversed
            if(Reversed==word)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
