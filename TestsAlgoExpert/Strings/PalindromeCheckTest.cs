using NUnit.Framework;
using ProblemsAlgoExpert.Strings;

namespace TestsAlgoExpert.Strings
{
    public class PalindromeCheckTest
    {
        /// <summary>
        /// TypeCases.
        /// </summary>
        private static readonly (string str, bool result)[] TypeCases =
        {
            ( "abcdcba", true),
            ( "a", true),
            ( "ab", false),
            ( "aba", true),
            ( "abb", false),
            ( "abba", true),
            ( "abcdefghhgfedcba", true),
            ( "abcdefghihgfedcba", true),
            ( "abcdefghihgfeddcba", false),
        };

        [Test]
        [TestCaseSource("TypeCases")]
        public void IsPalindrome((string str, bool result) test)
        {
            bool output = PalindromeCheck.IsPalindrome(test.str);
            Assert.True(output == test.result);
        }

        [Test]
        [TestCaseSource("TypeCases")]
        public void IsPalindrome2((string str, bool result) test)
        {
            bool output = PalindromeCheck.IsPalindrome2(test.str);
            Assert.True(output == test.result);
        }

        [Test]
        [TestCaseSource("TypeCases")]
        public void IsPalindrome3((string str, bool result) test)
        {
            bool output = PalindromeCheck.IsPalindrome3(test.str);
            Assert.True(output == test.result);
        }

        [Test]
        [TestCaseSource("TypeCases")]
        public void IsPalindrome4((string str, bool result) test)
        {
            bool output = PalindromeCheck.IsPalindrome4(test.str);
            Assert.True(output == test.result);
        }
    }
}
