using System.Linq;

namespace ReverseWordsTest
{
    internal class ReverseWords
    {
        public string GetReverseWords(string words)
        {
            return string.Join(" ", words.Split(' ').Reverse());
        }
    }
}