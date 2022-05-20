using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProblemsAlgoExpert.Arrays;


namespace TestsAlgoExpert.Arrays
{
    public class IsValidSubsequenceTest
    {
        /// <summary>
        /// TypeCases.
        /// </summary>
        private static readonly (int[] array, int[] sequence, bool issubsequence)[] TypeCases =
        {
            (new int[] { 5, 1, 22, 25, 6, -1, 8, 10 },new int[] { 1, 6, -1, 10 }, true),
            (new int[] { 5, 1, 22, 25, 6, -1, 8, 10 },new int[] { 5, 1, 22, 25, 6, -1, 8, 10 }, true),
            (new int[] { 5, 1, 22, 25, 6, -1, 8, 10 },new int[] { 5, 1, 22, 6, -1, 8, 10 }, true),
            (new int[] { 5, 1, 22, 25, 6, -1, 8, 10 },new int[] { 22, 25, 6 }, true),
            (new int[] { 5, 1, 22, 25, 6, -1, 8, 10 },new int[] { 5, 1, 22, 25, 6, -1, 8, 10, 12 }, false),
            (new int[] { 5, 1, 22, 25, 6, -1, 8, 10 },new int[] { 4, 5, 1, 22, 25, 6, -1, 8, 10 }, false),
            (new int[] { 5, 1, 22, 25, 6, -1, 8, 10 },new int[] { 5, 1, 22, 23, 6, -1, 8, 10 }, false),
        };

        [Test]
        [TestCaseSource("TypeCases")]
        public void TwoNumberSumSolution1((int[] array, int[] sequence, bool isSubsequence) test)
        {
            bool output = IsValidSubsequence.IsValidSubsequenceSolution1(test.array.ToList(), test.sequence.ToList());
            Assert.True(output == test.isSubsequence);
        }


        [Test]
        [TestCaseSource("TypeCases")]
        public void TwoNumberSumSolution2((int[] array, int[] sequence, bool isSubsequence) test)
        {
            bool output = IsValidSubsequence.IsValidSubsequenceSolution2(test.array.ToList(), test.sequence.ToList());
            Assert.True(output == test.isSubsequence);
        }
    }
}
