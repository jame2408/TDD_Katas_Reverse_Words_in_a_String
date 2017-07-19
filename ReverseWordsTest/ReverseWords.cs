using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReverseWordsTest
{
    internal class ReverseWords
    {
        public ReverseWords()
        {
        }

        public string GetReverseWords(string words)
        {
            var splitedWords = words.Split(' ');

            return string.Join(" ", splitedWords.Reverse());
        }
    }
}