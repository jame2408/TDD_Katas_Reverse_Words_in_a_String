using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseWordsTest
{
    [TestClass]
    public class ReverseWordsTest
    {
        [TestMethod]
        public void Input_one_word_is_HELLO_should_return_HELLO()
        {
            var words = "HELLO";
            var target = new ReverseWords();
            var actual = target.GetReverseWords(words);
            Assert.AreEqual("HELLO", actual);
        }

        [TestMethod]
        public void Input_two_words_are_HELLO_and_WORLD_should_return_WORLD_and_HELLO()
        {
            var words = "HELLO WORLD";
            var target = new ReverseWords();
            var actual = target.GetReverseWords(words);
            Assert.AreEqual("WORLD HELLO", actual);
        }
    }
}
