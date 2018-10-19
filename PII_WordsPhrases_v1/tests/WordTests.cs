using System;
using Xunit;

namespace WordsPhrases.Tests
{
    public class WordTests
    {
        [Fact]
        public void TestWord()
        {
            const string expected = "Test";
            Word word = new Word(expected);
            Assert.Equal(expected, word.Text);
        }

        [Fact]
        public void TestText()
        {
            const string expected = "Test";
            Word word = new Word("Other");
            word.Text = expected;
            Assert.Equal(expected, word.Text);
        }
    }
}
