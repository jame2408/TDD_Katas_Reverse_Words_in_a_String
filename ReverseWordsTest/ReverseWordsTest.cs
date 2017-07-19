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
    }
}
