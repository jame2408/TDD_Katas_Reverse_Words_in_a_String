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
            ReversedWordsShouldBe(words: "HELLO", expected: "HELLO");
        }

        [TestMethod]
        public void Input_two_words_are_HELLO_and_WORLD_should_return_WORLD_and_HELLO()
        {
            ReversedWordsShouldBe(words: "HELLO WORLD", expected: "WORLD HELLO");
        }

        [TestMethod]
        public void Input_words_but_head_and_tail_have_space_should_return_not_space()
        {
            ReversedWordsShouldBe(words: " HELLO WORLD  ", expected: "WORLD HELLO");
        }

        [TestMethod]
        public void Input_multi_space_between_word_and_word_should_return_one_space()
        {
            ReversedWordsShouldBe(words: "  HELLO   WORLD ", expected: "WORLD HELLO");
        }

        private void ReversedWordsShouldBe(string words, string expected)
        {
            var target = new ReverseWords();
            var actual = target.GetReverseWords(words);
            Assert.AreEqual(expected, actual);
        }
    }
}
