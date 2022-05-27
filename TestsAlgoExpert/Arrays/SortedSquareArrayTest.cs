using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemsAlgoExpert.Arrays;

namespace TestsAlgoExpert.Arrays
{
    public class SortedSquareArrayTest
    {
        /// <summary>
        /// TypeCases.
        /// </summary>
        private static readonly (int[] input, int []expected)[] TypeCases =
        {
            (new int[] { 1, 2, 3, 5, 6, 8, 9 }, new int[]{ 1, 4, 9, 25, 36, 64, 81 }),
            (new int[] { 1 }, new int[]{ 1 }),
            (new int[] { 1, 2 }, new int[]{ 1, 4 }),
            (new int[] { 1, 2, 3, 4, 5 }, new int[]{ 1, 4, 9, 16, 25 }),
            (new int[] { 10 }, new int[]{ 100 }),
            (new int[] { -1 }, new int[]{ 1 }),
            (new int[] { -2, -1 }, new int[]{ 1, 4 }),
            (new int[] { -5, -4, -3, -2, -1 }, new int[]{ 1, 4, 9, 16, 25 }),
            (new int[] { -10 }, new int[]{ 100 }),
            (new int[] { -10, -5, 0, 5, 10 }, new int[]{ 0, 25, 25, 100, 100 }),
            (new int[] { -7, -3, 1, 9, 22, 30 }, new int[]{ 1, 9, 49, 81, 484, 900 }),
            (new int[] { -50, -13, -2, -1, 0, 0, 1, 1, 2, 3, 19, 20 }, new int[]{ 0, 0, 1, 1, 1, 4, 4, 9, 169, 361, 400, 2500 }),
            (new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[]{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }),
            (new int[] { -1, -1, 2, 3, 3, 3, 4 }, new int[]{ 1, 1, 4, 9, 9, 9, 16 }),
            (new int[] { -3, -2, -1 }, new int[]{ 1, 4, 9 }),
        };

        [Test]
        [TestCaseSource("TypeCases")]
        public void SortedSquaredArraySolutionOne((int[] input, int[] expected) test)
        {
            int[] actual = SortedSquareArray.SortedSquaredArraySolutionOne(test.input);
            for (int i = 0; i < test.expected.Length; i++)
            {
                Assert.True(test.expected[i] == actual[i]);
            }
        }

        [Test]
        [TestCaseSource("TypeCases")]
        public void SortedSquaredArraySolutionTwo((int[] input, int[] expected) test)
        {
            int[] actual = SortedSquareArray.SortedSquaredArraySolutionTwo(test.input);
            for (int i = 0; i < test.expected.Length; i++)
            {
                Assert.True(test.expected[i] == actual[i]);
            }
        }

        [Test]
        [TestCaseSource("TypeCases")]
        public void SortedSquaredArraySolutionThree((int[] input, int[] expected) test)
        {
            int[] actual = SortedSquareArray.SortedSquaredArraySolutionThree(test.input);
            for (int i = 0; i < test.expected.Length; i++)
            {
                Assert.True(test.expected[i] == actual[i]);
            }
        }
    }
}
