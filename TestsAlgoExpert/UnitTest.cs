using NUnit.Framework;
using ProblemsAlgoExpert;
using System;

namespace TestsAlgoExpert
{
    public class Tests
    {
        [Test]
        public void TwoNumberSumSolution1()
        {
            int[] output = TwoNumberSum.TwoNumberSumSolution1(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);
            Assert.True(output.Length == 2);
            Assert.True(Array.Exists(output, e => e == -1));
            Assert.True(Array.Exists(output, e => e == 11));
        }

        [Test]
        public void TwoNumberSumSolution2()
        {
            int[] output = TwoNumberSum.TwoNumberSumSolution2(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);
            Assert.True(output.Length == 2);
            Assert.True(Array.Exists(output, e => e == -1));
            Assert.True(Array.Exists(output, e => e == 11));
        }
    }
}