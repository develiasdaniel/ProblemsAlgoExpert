using NUnit.Framework;
using ProblemsAlgoExpert.Strings;

namespace TestsAlgoExpert.Strings
{
    public class CaesarCypherEncryptorTest
    {
        /// <summary>
        /// TypeCases.
        /// </summary>
        private static readonly (string str, int key, string result)[] TypeCases =
        {
            ( "xyz", 2, "zab"),
            ( "abc", 0, "abc"),
            ( "abc", 3, "def"),
            ( "xyz", 5, "cde"),
            ( "abc", 26, "abc"),
            ( "abc", 52, "abc"),
            ( "abc", 57, "fgh"),
            ( "xyz", 25, "wxy"),
            ( "iwufqnkqkqoolxzzlzihqfm", 25, "hvtepmjpjpnnkwyykyhgpel"),
            ( "ovmqkwtujqmfkao", 52, "ovmqkwtujqmfkao"),
            ( "mvklahvjcnbwqvtutmfafkwiuagjkzmzwgf", 7, "tcrshocqjuidxcabatmhmrdpbhnqrgtgdnm"),
            ( "kjwmntauvjjnmsagwgawkagfuaugjhawgnawgjhawjgawbfawghesh", 15, "zylbcipjkyycbhpvlvplzpvujpjvywplvcplvywplyvplquplvwthw"),
        };

        [Test]
        [TestCaseSource("TypeCases")]
        public void CaesarCypherEncryptorSolution1((string str, int key, string result) test)
        {
            string output = CaesarCypherEncryptor.CaesarCypherEncryptorSolution1(test.str, test.key);
            Assert.True(output == test.result);
        }
        [Test]
        [TestCaseSource("TypeCases")]
        public void CaesarCypherEncryptorSolution2((string str, int key, string result) test)
        {
            string output = CaesarCypherEncryptor.CaesarCypherEncryptorSolution2(test.str, test.key);
            Assert.True(output == test.result);
        }
        [Test]
        [TestCaseSource("TypeCases")]
        public void CaesarCypherEncryptorSolution3((string str, int key, string result) test)
        {
            string output = CaesarCypherEncryptor.CaesarCypherEncryptorSolution3(test.str, test.key);
            Assert.True(output == test.result);
        }
        [Test]
        [TestCaseSource("TypeCases")]
        public void CaesarCypherEncryptorSolution4((string str, int key, string result) test)
        {
            string output = CaesarCypherEncryptor.CaesarCypherEncryptorSolution4(test.str, test.key);
            Assert.True(output == test.result);
        }
    }
}
