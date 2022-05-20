using NUnit.Framework;
using ProblemsAlgoExpert.Arrays;
using System;

namespace TestsAlgoExpert.Arrays
{
    public class TestsTwoNumberSum
    {
        /// <summary>
        /// TypeCases.
        /// </summary>
        private static readonly (int[] array, int targetSum)[] TypeCases =
        {
            (new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10),
        };

        [Test]
        [TestCaseSource("TypeCases")]
        public void TwoNumberSumSolution1((int[] array, int targetSum) test)
        {
            int[] output = TwoNumberSum.TwoNumberSumSolution1(test.array, test.targetSum);
            Assert.True(output.Length == 2);
            Assert.True(Array.Exists(output, e => e == -1));
            Assert.True(Array.Exists(output, e => e == 11));
        }

        [Test]
        [TestCaseSource("TypeCases")]
        public void TwoNumberSumSolution2((int[] array, int targetSum) test)
        {
            int[] output = TwoNumberSum.TwoNumberSumSolution2(test.array, test.targetSum);
            Assert.True(output.Length == 2);
            Assert.True(Array.Exists(output, e => e == -1));
            Assert.True(Array.Exists(output, e => e == 11));
        }
    }
}