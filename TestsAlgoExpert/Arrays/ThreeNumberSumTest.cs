namespace TestsAlgoExpert.Arrays
{
    using NUnit.Framework;
    using ProblemsAlgoExpert.Arrays;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ThreeNumberSumTest
    {
        /// <summary>
        /// TypeCases.
        /// </summary>
        private static readonly (List<int[]> expected, int[] array, int targetSum)[] TypeCases =
        {
            (new List<int[]>
            {
                new int[]{-8, 2, 6},
                new int[]{-8, 3, 5},
                new int[]{ -6, 1, 5 }
            },
            new int[]{ 12, 3, 1, 2, -6, 5, -8, 6 },
            0),
            (new List<int[]>
            {
                new int[]{1, 2, 3},
            },
            new int[]{ 1, 2, 3 },
            6),
            (new List<int[]>
            {
            },
            new int[]{ 1, 2, 3 },
            7),
            (new List<int[]>
            {
                new int[]{ -2, 10, 49 },
            },
            new int[]{ 8, 10, -2, 49, 14 },
            57),
            (new List<int[]>
            {
                new int[]{ -8, 3, 5 },
                new int[]{ -6, 1, 5 },
                new int[]{ -1, 0, 1 },
            },
            new int[]{ 12, 3, 1, 2, -6, 5, 0, -8, -1 },
            0),
            (new List<int[]>
            {
                new int[]{ -8, 2, 6 },
                new int[]{ -8, 3, 5 },
                new int[]{ -6, 0, 6 },
                new int[]{ -6, 1, 5 },
                new int[]{ -1, 0, 1 },
            },
            new int[]{ 12, 3, 1, 2, -6, 5, 0, -8, -1, 6 },
            0),
            (new List<int[]>
            {
                new int[]{ -8, 2, 6 },
                new int[]{ -8, 3, 5},
                new int[]{ -6, 0, 6 },
                new int[]{ -6, 1, 5 },
                new int[]{ -5, -1, 6 },
                new int[]{ -5, 0, 5 },
                new int[]{ -5, 2, 3 },
                new int[]{ -1, 0, 1 },
            },
            new int[]{ 12, 3, 1, 2, -6, 5, 0, -8, -1, 6, -5 },
            0),
            (new List<int[]>
            {
                new int[]{ 1, 2, 15 },
                new int[]{ 1, 8, 9 },
                new int[]{ 2, 7, 9 },
                new int[]{ 3, 6, 9 },
                new int[]{ 3, 7, 8 },
                new int[]{ 4, 5, 9 },
                new int[]{ 4, 6, 8 },
                new int[]{ 5, 6, 7 },
            },
            new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 },
            18),
            (new List<int[]>
            {
                new int[]{ 8, 9, 15 },
            },
            new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 },
            32),
            (new List<int[]>
            {
            },
            new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 },
            33),
            (new List<int[]>
            {
            },
            new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 },
            5),
        };

        [Test]
        [TestCaseSource("TypeCases")]
        public void ThreeNumberSumSol1((List<int[]> expected, int[] array, int targetSum) test)
        {
            List<int[]> output = ThreeNumberSum.ThreeNumberSumSol1(test.array, test.targetSum);
            Assert.True(this.compare(output, test.expected));
        }

        [Test]
        [TestCaseSource("TypeCases")]
        public void ThreeNumberSumSol2((List<int[]> expected, int[] array, int targetSum) test)
        {
            List<int[]> output = ThreeNumberSum.ThreeNumberSumSol2(test.array, test.targetSum);
            Assert.True(this.compare(output, test.expected));
        }

        private bool compare(List<int[]> triplets1, List<int[]> triplets2)
        {
            if (triplets1.Count != triplets2.Count) return false;
            for (int i = 0; i < triplets1.Count; i++)
            {
                if (!Enumerable.SequenceEqual(triplets1[i], triplets2[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
