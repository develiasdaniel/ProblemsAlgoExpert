using NUnit.Framework;
using ProblemsAlgoExpert.Strings;

namespace TestsAlgoExpert.Strings
{
    public class GenerateDocumentTest
    {
        /// <summary>
        /// TypeCases.
        /// </summary>
        private static readonly (string character, string document, bool expected)[] TypeCases =
        {
            ( "Bste!hetsi ogEAxpelrt x ", "AlgoExpert is the Best!", true),
            ( "A", "a", false),
            ( "a", "a", true),
            ( "a hsgalhsa sanbjksbdkjba kjx", "", true),
            ( " ", "hello", false),
            ( "     ", "     ", true),
            ( "aheaollabbhb", "hello", true),
            ( "aheaolabbhb", "hello", false),
            ( "estssa", "testing", false),
            ( "Bste!hetsi ogEAxpert", "AlgoExpert is the Best!", false),
            ( "helloworld ", "hello wOrld", false),
            ( "helloworldO", "hello wOrld", false),
            ( "helloworldO ", "hello wOrld", true),
            ( "&*&you^a%^&8766 _=-09     docanCMakemthisdocument", "Can you make this document &", true),
            ( "abcabcabcacbcdaabc", "bacaccadac", true),
        };

        [Test]
        [TestCaseSource("TypeCases")]
        public void GenerateDocumentSolution((string character, string document, bool expected) test)
        {
            bool output = GenerateDocument.GenerateDocumentSolution(test.character, test.document);
            Assert.True(output == test.expected);
        }

        [Test]
        [TestCaseSource("TypeCases")]
        public void GenerateDocumentSolution2((string character, string document, bool expected) test)
        {
            bool output = GenerateDocument.GenerateDocumentSolution2(test.character, test.document);
            Assert.True(output == test.expected);
        }

        [Test]
        [TestCaseSource("TypeCases")]
        public void GenerateDocumentSolution3((string character, string document, bool expected) test)
        {
            bool output = GenerateDocument.GenerateDocumentSolution3(test.character, test.document);
            Assert.True(output == test.expected);
        }
    }
}
