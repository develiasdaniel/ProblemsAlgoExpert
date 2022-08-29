using NUnit.Framework;
using System.Collections.Generic;
using ProblemsAlgoExpert.Arrays;

namespace TestsAlgoExpert.Arrays
{
    public class NonConstructibleChangeTest
    {
        public static readonly (int[] input, int expected)[] TypeCases =
        {
            (
                new int[]{ 5, 7, 1, 1, 2, 3, 22 },
                20
            ),
            (
                new int[]{ 1, 1, 1, 1, 1 },
                6
            ),
            (
                new int[]{ 1, 5, 1, 1, 1, 10, 15, 20, 100 },
                55
            ),
            (
                new int[]{ 6, 4, 5, 1, 1, 8, 9 },
                3
            ),
            (
                new int[]{},
                1
            ),
            (
                new int[]{ 87 },
                1
            ),
            (
                new int[]{ 5, 6, 1, 1, 2, 3, 4, 9 },
                32
            ),
            (
                new int[]{ 5, 6, 1, 1, 2, 3, 43 },
                19
            ),
            (
                new int[]{ 1, 1 },
                3
            ),
            (
                new int[]{ 2 },
                1
            ),
            (
                new int[]{ 1 },
                2
            ),
            (
                new int[]{ 109, 2000, 8765, 19, 18, 17, 16, 8, 1, 1, 2, 4 },
                87
            ),
            (
                new int[]{ 1, 2, 3, 4, 5, 6, 7 },
                29
            )
        };

        [Test]
        [TestCaseSource("TypeCases")]
        public void NonConstructibleChangeSol1((int[] input, int expected) test)
        {
            int output = NonConstructibleChange.NonConstructibleChangeSol1(test.input);
            Assert.True(output == test.expected);
        }
    }
}
